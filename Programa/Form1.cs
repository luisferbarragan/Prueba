using WinFormsPruebaBD;

namespace Programa
{
    public partial class Form1 : Form
    {
        List<Liga> data;
        public Form1()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            MessageBox.Show("entre a limpiar");
            this.textBoxID.PlaceholderText = "ID";
            this.textBoxNombre.PlaceholderText = "Nombre";
            this.textBoxEquipo.PlaceholderText = "Equipo";
            this.textBoxPuntos.PlaceholderText = "Puntos";

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            AdmonBD obj = new AdmonBD();
            data = obj.consulta();
            this.richTextBox1.Clear();
            data.ForEach(p =>
            {
                this.richTextBox1.AppendText("-------------------------------------------\n" +
                    "ID: " + p.Id + "\nNombre: " + p.Nombre + "\nEquipo: " + p.Equipo + "\nPuntos: " + p.Puntos + "\n");
            });

            obj.Disconnect();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            int id;
            string nombre;
            string equipo;
            int puntos;
            id = Convert.ToInt32(this.textBoxID.Text);
            nombre = this.textBoxNombre.Text;
            equipo = this.textBoxEquipo.Text;
            puntos = Convert.ToInt32(this.textBoxPuntos.Text);

            AdmonBD obj = new AdmonBD();
            obj.insertar(id, nombre, equipo, puntos);
            limpiar();
            obj.Disconnect();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int id;
            string nombre;
            string equipo;
            int puntos;
            id = Convert.ToInt32(this.textBoxModId.Text);
            nombre = this.textBoxModNom.Text;
            equipo = this.textBoxModEqpo.Text;
            puntos = Convert.ToInt32(this.textBoxModPts.Text);

            AdmonBD obj = new AdmonBD();
            obj.actualizar(id, nombre, equipo, puntos);
            obj.Disconnect();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            AdmonBD obj = new AdmonBD();
            obj.eliminar(Convert.ToInt32(this.textBoxEliminar.Text));
            this.textBoxEliminar.PlaceholderText = "id eliminar";
            obj.Disconnect();
        }
    }

}
