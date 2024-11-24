namespace UI
{
    public partial class Main : Form
    {
        private bool bienvenidaMostrada = false;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!bienvenidaMostrada)
            {
                // Invocaci�n a la bienvenida
                FormBienvenida bienvenida = new FormBienvenida();

                bienvenida.ShowDialog();

                bienvenidaMostrada = true;
            }
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            // Invoaci�n al gestor de alumnos
            FormAlumnos alumnos = new FormAlumnos();

            this.Hide();
            alumnos.ShowDialog();
            this.Show();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            // Invoacic�n al gestor de libros
            FormLibros libros = new FormLibros();

            this.Hide();
            libros.ShowDialog();
            this.Show();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            //Invocaci�n al gestor de pr�stamos
            Prestamos prestamos = new Prestamos();

            this.Hide();
            prestamos.ShowDialog();
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
