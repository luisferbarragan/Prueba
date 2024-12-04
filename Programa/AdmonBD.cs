using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Intrinsics.Arm;
using Mysqlx.Crud;
using Microsoft.VisualBasic;
using Programa;

namespace WinFormsPruebaBD
{

    public class AdmonBD
    {

        private MySqlConnection connection;

        public AdmonBD()
        {
            this.Connect();
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public List<Liga> consulta()
        {
            List<Liga> data = new List<Liga>();
            Liga item;
            int id;
            string nombre;
            string equipo;
            int puntos;
            try
            {
                string query = "SELECT * FROM jugadores";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    nombre = Convert.ToString(reader["nombre"]) ?? "";
                    equipo = Convert.ToString(reader["equipo"]) ?? "";
                    puntos = Convert.ToInt32(reader["puntos"]);

                    item = new Liga(id, nombre, equipo, puntos);
                    data.Add(item);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return data;
        }

        public void insertar(int idp, string nom, string eqpo,  int pts)
        {
            string query="";
            try
            {

                /* Esta forma de insertar es la menos segura en cuanto ataques por mysql pero la mas sencilla por lo pronto*/
                   query = "INSERT INTO jugadores (id,nombre,equipo,puntos) VALUES ("
                  + "'"+idp + "',"
                  + "'" + nom + "',"
                  + "'" + eqpo + "', "
                  + "'" + pts + "')";

               

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query+"\nRegistro Agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(query +  "\nClave duplicada"+ex.Message);
                this.Disconnect();
            }


        }

    public Liga consultaUnRegistro(int idp)
        {
           
            Liga item=null;
            int id;
            string nombre;
            string equipo;
            int puntos;
            try
            {
                string query = "SELECT * FROM jugadores where id="+idp+";";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    
                    id = Convert.ToInt32(reader["id"]);
                    nombre = Convert.ToString(reader["nombre"]) ?? "";
                    equipo = Convert.ToString(reader["equipo"]) ?? "";
                    puntos = Convert.ToInt32(reader["puntos"]);

                    item = new Liga(id, nombre, equipo, puntos);
                    

                }
                reader.Close();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return item;
        }


    public void eliminar(int idp)
        {
            string query = "";
            try
            {

                /* Esta forma de insertar es la menos segura en cuanto ataques por mysql pero la mas sencilla por lo pronto*/

                query="DELETE FROM jugadores WHERE id="+idp+";";
             
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query + "\nRegistro Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nError " + ex.Message);
                this.Disconnect();
            }
        }


        public void actualizar(int idp, string nom, string eqpo, int pts)
        {
            try
            {
                string query = "UPDATE jugadores SET id=" + "'"+idp+"'" + ",nombre=" + "'" + nom + "'"+ ",equipo=" +"'"+ eqpo + "'"+",puntos="+ "'"+pts+"'"+ "where id=" + idp + ";";
                MessageBox.Show(query);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show(query + "\nRegistro Actualizado");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la actualizacion: " + ex.Message);
                this.Disconnect();
            }
        }

    public void Connect()
        {
            string cadena = "Server=localhost;Port=33065;Database=liga;User=root;Password=;SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
                MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
