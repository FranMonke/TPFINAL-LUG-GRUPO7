using BLL;
using DAL;

namespace UI
{
    public partial class Prestamos : Form
    {
        private PrestamoBusiness prestamoBusiness = new PrestamoBusiness();
        public Prestamos()
        {
            InitializeComponent();
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void ActualizarCampos()
        {
            ActualizarDgv();
            //actualizar combobox
        }

        private void ActualizarDgv()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = prestamoBusiness.ObtenerPrestamos();
        }


        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
