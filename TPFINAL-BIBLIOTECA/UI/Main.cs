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
                Bienvenida bienvenida = new Bienvenida();

                bienvenida.ShowDialog();

                bienvenidaMostrada = true;
            }
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            // Invoación al gestor de alumnos
            Alumnos alumnos = new Alumnos();

            this.Hide();
            alumnos.ShowDialog();
            this.Show();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            // Invoacicón al gestor de libros
            Libros libros = new Libros();

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
