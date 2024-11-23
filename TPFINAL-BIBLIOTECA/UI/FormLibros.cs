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
                Libro libro = GetLibroFromForm();
                bussinesLibro.CargarLibro(libro);
                MessageBox.Show("Libro Cargado Correctamente.");
                ActualizarDGV();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnAgregarAListaLibro_Click(object sender, EventArgs e)
        {
            Libro libroborr = GetLibroFromForm();
            borradorLibros.Add(libroborr);
        }

        private void btnConfirmarCambiosLibro_Click(object sender, EventArgs e)
        {
            try
            {
                bussinesLibro.GuardarListaLibros(borradorLibros);
                ActualizarDGV();
                MessageBox.Show("Libros Agregados Correctamente");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnBajaLibro_Click(object sender, EventArgs e)
        {
            try
            {
                bussinesLibro.EliminarLibro(Convert.ToInt32(txtBajaIdLibro.Text));
                ActualizarDGV();
                MessageBox.Show("Se dio de baja el libro seleccionado");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnModificarStockLibro_Click(object sender, EventArgs e)
        {
            try
            {
                Libro libro = GetLibroFromForm();
                if (rbAumentar.Checked == true)
                {
                    bussinesLibro.AumentarStock(Convert.ToInt32(txtModificarIdLibro.Text), Convert.ToInt32(txtModificarCantidadLibro.Text));
                    ActualizarDGV();
                    MessageBox.Show("Cantidad Actualizada Correctamente.");
                }
                if (rbDisminuir.Checked == true)
                {
                    bussinesLibro.DisminuirStock(Convert.ToInt32(txtModificarIdLibro.Text), Convert.ToInt32(txtModificarCantidadLibro.Text));
                    ActualizarDGV();
                    MessageBox.Show("Cantidad Actualizada Correctamente.");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
