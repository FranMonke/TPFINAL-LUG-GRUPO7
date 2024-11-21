using BLL;
using Entity;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace UI
{
    public partial class FormAlumnos : Form
    {
        AlumnosBLL alumnosBLL = new AlumnosBLL();
        private List<Alumnoss> borradorAlumnoss = new List<Alumnoss>();
        public FormAlumnos()
        {
            InitializeComponent();
            ActualizarDgv();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ActualizarDgv()
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = alumnosBLL.GetAll();
        }

        private void btnCargarUnAlumno_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (validacionentradascompletas())
                {
                    Alumnoss alumnos = LECTURA();
                    alumnosBLL.CargarAlumnos(alumnos);
                    ActualizarDgv();
                    MessageBox.Show("Alumno cargado correctamente");
                    LimpiarTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private Alumnoss LECTURA()
        {
            Alumnoss alumnos = new Alumnoss();
            alumnos.Dni = Convert.ToInt32(txtDniAltaAlumno.Text);
            alumnos.NombreCompleto = txtNombreAlumno.Text;
            alumnos.Direccion = txtDireccionAlumno.Text;
            alumnos.Telefono = txtTelefonoAlumno.Text;
            alumnos.Email = txtEmailAlumno.Text;
            return alumnos;
        }

        private void btnAgregarAListaAluumno_Click(object sender, EventArgs e)
        {
            validacionentradascompletas();
            Alumnoss alumnoss = LECTURA();
            borradorAlumnoss.Add(alumnoss);
            LimpiarTextBoxes();
        }

        private void btnConfirmarCambiosAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (borradorAlumnoss == null || !borradorAlumnoss.Any())
                {
                    MessageBox.Show("La lista de alumnos está vacía. No se puede cargar.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                alumnosBLL.CargarAlumnosMultiples(borradorAlumnoss);
                ActualizarDgv();
                MessageBox.Show("Alumnos cargados correctamente");
                LimpiarTextBoxes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                borradorAlumnoss.Clear();
            }
        }

        private void btnBajaAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDniBajaAlumno.Text))
                {
                    MessageBox.Show("El campo DNI no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    alumnosBLL.DeleteById(Convert.ToInt32(txtDniBajaAlumno.Text));
                    ActualizarDgv();
                    MessageBox.Show("Alumno eliminado correctamente");
                    LimpiarTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool validacionentradascompletas()
        {
            if (string.IsNullOrWhiteSpace(txtDniAltaAlumno.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }

            if (string.IsNullOrWhiteSpace(txtNombreAlumno.Text))
            {
                MessageBox.Show("El campo Nombre Completo no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }

            if (string.IsNullOrWhiteSpace(txtDireccionAlumno.Text))
            {
                MessageBox.Show("El campo Direccion no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }

            if (string.IsNullOrWhiteSpace(txtTelefonoAlumno.Text))
            {
                MessageBox.Show("El campo Telefono no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }

            if (string.IsNullOrWhiteSpace(txtEmailAlumno.Text))
            {
                MessageBox.Show("El campo Email no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }

            return true;
        }
        private void LimpiarTextBoxes()
        {
            txtDniAltaAlumno.Clear();
            txtDniBajaAlumno.Clear();
            txtDireccionAlumno.Clear();
            txtEmailAlumno.Clear();
            txtNombreAlumno.Clear();
            txtTelefonoAlumno.Clear();
        }

    }
}
