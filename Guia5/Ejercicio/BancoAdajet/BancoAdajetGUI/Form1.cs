using BancoAdajet;
namespace BancoAdajetGUI
{
    public partial class Form1 : Form
    {
        private Cuenta cuentaActual;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSaldoActual.Text = "";
            lblNumeroCuenta.Text = "";
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                string dui = txtDui.Text;
                double saldoInicial = double.Parse(txtSaldoInicial.Text);
                double interesAnual = double.Parse(txtInteresAnual.Text);

                // Crear una nueva cuenta
                cuentaActual = new Cuenta(dui, saldoInicial, interesAnual);

                // Mostrar el número de cuenta y el saldo actual
                lblNumeroCuenta.Text = cuentaActual.NumeroCuenta;
                lblSaldoActual.Text = cuentaActual.SaldoActual.ToString("C");

                MessageBox.Show("Cuenta creada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                double cantidad = double.Parse(txtCantidad.Text);
                cuentaActual.Ingresar(cantidad);
                lblSaldoActual.Text = cuentaActual.SaldoActual.ToString("C");
                MessageBox.Show("Ingreso exitoso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                double cantidad = double.Parse(txtCantidad.Text);
                bool exito = cuentaActual.Retirar(cantidad);
                if (exito)
                {
                    lblSaldoActual.Text = cuentaActual.SaldoActual.ToString("C");
                    MessageBox.Show("Retiro exitoso.");
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizarSaldo_Click(object sender, EventArgs e)
        {
            try
            {
                cuentaActual.ActualizarSaldo();
                lblSaldoActual.Text = cuentaActual.SaldoActual.ToString("C");
                MessageBox.Show("Saldo actualizado con interés.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(cuentaActual.MostrarDatos());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
