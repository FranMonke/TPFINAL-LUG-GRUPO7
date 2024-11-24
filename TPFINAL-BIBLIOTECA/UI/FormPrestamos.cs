using BLL;
using DAL;
using Entity;

namespace UI
{
    public partial class Prestamos : Form
    {
        private PrestamoBusiness prestamoBusiness = new PrestamoBusiness();
        private LibroBusiness libroBusiness = new LibroBusiness();
        public Prestamos()
        {
            InitializeComponent();
            ActualizarCampos();
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {

        }

        private void ActualizarCampos()
        {
            ActualizarDgv();
            ActualizarComboBox();
        }

        private void ActualizarDgv()
        {
            dgvPrestamos.AutoGenerateColumns = true;
            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = prestamoBusiness.ObtenerPrestamos();
        }

        private void ActualizarComboBox()
        {
            comboLibroPrestamo.ValueMember = "IdLibro";
            comboLibroPrestamo.DisplayMember = "TituloLibro";
            comboLibroPrestamo.DataSource = libroBusiness.GetLibrosAll();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAlumnoPrestamo.Text))
            {
                MessageBox.Show("El campo ''DNI Alumno'' no puede estar vacío.");
                return;
            }

            if (!int.TryParse(txtAlumnoPrestamo.Text, out int dniAlumno))
            {
                MessageBox.Show("DNI inválido.");
                return;
            }

            Prestamo prestamo = GetPrestamoFromForm();

            try
            {
                prestamoBusiness.CargarPrestamo(prestamo);
                ActualizarDgv();
                MessageBox.Show("Préstamo cargado con éxito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrestamoDevolucion.Text))
            {
                MessageBox.Show("El campo ''ID Préstamo'' no puede estar vacío.");
                return;
            }
            if (!int.TryParse(txtPrestamoDevolucion.Text, out int idPrestamo))
            {
                MessageBox.Show("ID de préstamo inválido.");
                return;
            }
            Prestamo prestamo = GetDevolucionFromForm();
            try
            {
                prestamoBusiness.CargarDevolucion(prestamo);
                ActualizarDgv();
                MessageBox.Show("Devolución cargada con éxito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Prestamo GetPrestamoFromForm()
        {
            Prestamo prestamo = new Prestamo();
            prestamo.IdLibro = Convert.ToInt32(comboLibroPrestamo.SelectedValue.ToString());
            prestamo.DniAlumno = Convert.ToInt32(txtAlumnoPrestamo.Text);
            prestamo.FechaPrestamo = DateTime.Now;
            return prestamo;
        }
        private Prestamo GetDevolucionFromForm()
        {
            Prestamo prestamo = new Prestamo();
            prestamo.IdPrestamo = Convert.ToInt32(txtPrestamoDevolucion.Text);
            prestamo.FechaPrestamo = DateTime.Now;
            return prestamo;
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            try
            {
                string dniTexto = txtDniDevolucion.Text.Trim();

                if (int.TryParse(dniTexto, out int dni))
                {
                    List<Prestamo> prestamosFiltrados = prestamoBusiness.ObtenerPrestamos()
                        .Where(p => p.DniAlumno == dni)
                        .ToList();

                    dgvPrestamos.DataSource = null;
                    dgvPrestamos.DataSource = prestamosFiltrados;

                    if (prestamosFiltrados.Count == 0)
                    {
                        MessageBox.Show("No se encontraron préstamos para el DNI ingresado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al filtrar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {

                txtDniDevolucion.Text = "";
                dgvPrestamos.DataSource = null; 
                dgvPrestamos.DataSource = prestamoBusiness.ObtenerPrestamos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al restaurar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
