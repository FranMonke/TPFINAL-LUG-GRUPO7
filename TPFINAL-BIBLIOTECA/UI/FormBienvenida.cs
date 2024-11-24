namespace UI
{
    public partial class FormBienvenida : Form
    {
        private System.Windows.Forms.Timer timer;
        public FormBienvenida()
        {
            InitializeComponent();

            // Configuración del temporizador
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000; // Tiempo en milisegundos (3000 ms = 3 segundos)
            timer.Tick += Timer_Tick; // Evento cuando el temporizador finaliza
            timer.Start(); // Iniciar el temporizador
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            timer.Stop(); // Detener el temporizador
            this.Close(); // Cerrar el formulario
        }
    }
}
