using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa
{
    public class Liga
    {
        private int id;
        private string nombre;
        private string equipo;
        private int puntos;
        //Nombre de las variables (elementos identificados en la BD)
        public Liga()
        {

        }

        public Liga(int id, string nombre, string equipo, int puntos)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Equipo = equipo;
            this.Puntos = puntos;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Equipo { get => equipo; set => equipo = value; }
        public int Puntos { get => puntos; set => puntos = value; }
    }
}
