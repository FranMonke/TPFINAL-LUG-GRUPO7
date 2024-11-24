using BLL;
using Entity;

namespace UI
{
    public partial class FormLibros : Form
    {
        public List<Libro> borradorLibros = new List<Libro>();
        private LibroBusiness bussinesLibro = new LibroBusiness();

        public FormLibros()
        {
            InitializeComponent();
            ActualizarDGV();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ActualizarDGV()
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = bussinesLibro.GetLibrosAll();
        }
        private Libro GetLibroFromForm()
        {
            Libro libro = new Libro();
            libro.TituloLibro = txtTitulo.Text;
            libro.AutorLibro = txtAutor.Text;
            libro.GeneroLibro = txtGenero.Text;
            libro.StockLibro = Convert.ToInt32(txtCantidad.Text);
            return libro;
        }

        private void btnCargarUnLibro_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacionentradascompletas())
                {
                    Libro libro = GetLibroFromForm();
                    bussinesLibro.CargarLibro(libro);
                    MessageBox.Show("Libro Cargado Correctamente.");
                    LimpiarCampos();
                    ActualizarDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarAListaLibro_Click(object sender, EventArgs e)
        {
            if (validacionentradascompletas())
            {
                Libro libroborr = GetLibroFromForm();
                borradorLibros.Add(libroborr);
            }
        }

        private void btnConfirmarCambiosLibro_Click(object sender, EventArgs e)
        {
            try
            {
                bussinesLibro.GuardarListaLibros(borradorLibros);
                ActualizarDGV();
                MessageBox.Show("Libros Agregados Correctamente");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                borradorLibros.Clear();
            }
        }

        private void btnBajaLibro_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtBajaIdLibro.Text))
                {
                    bussinesLibro.EliminarLibro(Convert.ToInt32(txtBajaIdLibro.Text));
                    ActualizarDGV();
                    MessageBox.Show("Se dio de baja el libro seleccionado");
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarStockLibro_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtModificarIdLibro.Text))
                {
                    if (rbAumentar.Checked == true)
                    {
                        bussinesLibro.AumentarStock(Convert.ToInt32(txtModificarIdLibro.Text), Convert.ToInt32(txtModificarCantidadLibro.Text));
                        ActualizarDGV();
                        MessageBox.Show("Cantidad Actualizada Correctamente.");
                        LimpiarCampos();
                    }
                    if (rbDisminuir.Checked == true)
                    {
                        bussinesLibro.DisminuirStock(Convert.ToInt32(txtModificarIdLibro.Text), Convert.ToInt32(txtModificarCantidadLibro.Text));
                        ActualizarDGV();
                        MessageBox.Show("Cantidad Actualizada Correctamente.");
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtGenero.Clear();
            txtCantidad.Clear();
            txtBajaIdLibro.Clear();
            txtModificarIdLibro.Clear();
            txtModificarCantidadLibro.Clear();
        }

        private bool validacionentradascompletas()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("El campo Titulo no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("El campo Autor no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            if (string.IsNullOrWhiteSpace(txtGenero.Text))
            {
                MessageBox.Show("El campo Genero no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("El campo Cantidad no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            return true;
        }
    }
}
