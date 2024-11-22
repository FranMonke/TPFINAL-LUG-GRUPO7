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
                // Invocación a la bienvenida
<<<<<<< HEAD
                Bienvenida bienvenida = new Bienvenida();
=======
                FormBienvenida bienvenida = new FormBienvenida();
>>>>>>> test

                bienvenida.ShowDialog();

                bienvenidaMostrada = true;
            }
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            // Invoación al gestor de alumnos
<<<<<<< HEAD
            Alumnos alumnos = new Alumnos();
=======
            FormAlumnos alumnos = new FormAlumnos();
>>>>>>> test

            this.Hide();
            alumnos.ShowDialog();
            this.Show();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            // Invoacicón al gestor de libros
<<<<<<< HEAD
            Libros libros = new Libros();
=======
            FormLibros libros = new FormLibros();
>>>>>>> test

            this.Hide();
            libros.ShowDialog();
            this.Show();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            //Invocación al gestor de préstamos
            Prestamos prestamos = new Prestamos();

            this.Hide();
            prestamos.ShowDialog();
            this.Show();
        }

<<<<<<< HEAD
        private void button1_Click(object sender, EventArgs e)
=======
        private void btnSalir_Click(object sender, EventArgs e)
>>>>>>> test
        {
            this.Close();
        }
    }
}
