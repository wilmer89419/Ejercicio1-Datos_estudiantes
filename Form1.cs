namespace Datos_estudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        private void lblCarrera_Click(object sender, EventArgs e)
        {

        }

        private void lblMatricula_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            String Nombre, Apellido, Carrera;
            int Edad, Matricula;

            Nombre = txtNombre.Text;
            Apellido = txtApellido.Text;
            Carrera = txtCarrera.Text;

            Matricula = int.Parse(txtMatricula.Text);
            Edad = int.Parse(txtEdad.Text);

            lblDatos_Nombre.Text = Nombre;
            lblDatos_Apellido.Text = Apellido;
            lblDatos_Carrera.Text = Carrera;
            lblDatos_Edad.Text = Edad.ToString();
            lblDatos_Matricula.Text = Matricula.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCarrera.Clear();
            txtMatricula.Clear();
            txtEdad.Clear();
            lblDatos_Nombre.Text = string.Empty;
            lblDatos_Apellido.Text = string.Empty;
            lblDatos_Edad.Text = string.Empty;
            lblDatos_Carrera.Text = string.Empty;
            lblDatos_Matricula.Text = string.Empty;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}