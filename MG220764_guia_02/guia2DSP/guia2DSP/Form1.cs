namespace guia2
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            long factorial = 1;
            int i;
            if (IsNumeric(txtNumero.Text))
            {
                for (i = Convert.ToInt32(txtNumero.Text); i >= 1; i--)
                {
                    
                    factorial *= i;
                }
                txtFactorial.Text = factorial.ToString();
            }
            else
            {
                txtNumero.BackColor = Color.Red;
                MessageBox.Show("Debe ingresar un número!", "Informacion", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                txtNumero.Clear();
                txtFactorial.Clear();
                txtNumero.Focus();
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.BackColor = Color.White;
        }

        private void frmFactorial_Load(object sender, EventArgs e)
        {

        }

        
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
