namespace RE242138_desafio_01
{
    public partial class frmBienvenida : Form

    {
        private int counter = 15; // Contador inicial de 15 segundos
        public frmBienvenida()
        {
            InitializeComponent();
            this.Load += frmBienvenida_Load_1;
        }

        private void frmBienvenida_Load_1(object sender, EventArgs e)
        {
            this.timerCountdown.Tick += new EventHandler(timerCountdown_Tick);
            timerCountdown.Start();
        }
            
        


        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            counter--; // Reducir el contador en 1
            lblCounter.Text = counter.ToString(); // Actualizar el Label con el valor del contador

            if (counter == 0)
            {
                timerCountdown.Stop(); // Detener el Timer cuando llega a 0

              
                // Crear una nueva instancia de frmLogin
                frmLogin frmLogin = new frmLogin();

                // Mostrar frmLogin
                frmLogin.Show();

                // Cerrar frmBienvenida
                this.Hide();
            }
        }
    }
}




