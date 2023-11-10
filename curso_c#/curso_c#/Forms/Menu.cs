using curso_c_.Forms;

namespace curso_c_
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionClientes ventanaGestionClientes = new GestionClientes();
            ventanaGestionClientes.ShowDialog();


            //string textoEdad = txtPeso.Text;
            //int edad = Int32.Parse(textoEdad);
            //bool esMayorDeEdad = edad >= 18;

            //if (esMayorDeEdad)
            //{
            //    Peso.Text = "Es mayor de edad";
            //}
            //else
            //{
            //    Peso.Text = "Es menor de edad";
            //}
            //double numeroConCOmas = 1234.56;
            //string prueba = "=";
            //string prueba2 = "prueba de variable " + prueba + numeroConCOmas;

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}