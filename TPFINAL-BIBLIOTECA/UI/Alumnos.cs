using BLL;
using Entity;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace UI
{
    public partial class Alumnos : Form
    {
        AlumnosBLL alumnosBLL = new AlumnosBLL();
        private List<Alumnoss> borradorAlumnoss = new List<Alumnoss>();
        public Alumnos()
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
            Alumnoss alumnos = LECTURA();

            try
            {
                alumnosBLL.CargarAlumnos(alumnos);
                ActualizarDgv();
                MessageBox.Show("Alumno cargado correctamente");
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

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarAListaAluumno_Click(object sender, EventArgs e)
        {
            Alumnoss alumnoss = LECTURA();
            borradorAlumnoss.Add(alumnoss);
        }

        private void btnConfirmarCambiosAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                alumnosBLL.CargarAlumnosMultiples(borradorAlumnoss);
                ActualizarDgv();
                MessageBox.Show("Alumnos cargados correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBajaAlumno_Click(object sender, EventArgs e)
        {
            try
            {
               alumnosBLL.DeleteById(Convert.ToInt32(txtDniBajaAlumno.Text));
                ActualizarDgv();
                MessageBox.Show("Alumno eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
