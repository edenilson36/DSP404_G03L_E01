namespace ejercicio2
{
    public partial class Form1 : Form
    {
        private List<double> numbers = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            {
                if (txtEntrada.Text.EndsWith("\r\n"))
                {
                    string input = txtEntrada.Text.Trim();
                    if (double.TryParse(input, out double number))
                    {
                        numbers.Add(number);
                        lstNumeros.Items.Add(number);
                        txtEntrada.Clear();
                        if (numbers.Count == 4)
                        {
                            btnCalcular.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un número válido.");
                    }
                    txtEntrada.Clear();
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (numbers.Count == 4)
            {
                double average = CalculateAverage(numbers);
                double stdDev = CalculateStandardDeviation(numbers, average);
                lblResultado.Text = $"Promedio: {average:F3}\nDesviación típica: {stdDev:F3}";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese 4 números antes de calcular.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            lstNumeros.Items.Clear();
            lblResultado.Text = "";
            txtEntrada.Clear();
            btnCalcular.Enabled = false;
        }
        private double CalculateAverage(List<double> numbers)
        {
            double sum = numbers.Sum();
            return sum / numbers.Count;
        }
        private double CalculateStandardDeviation(List<double> numbers, double average)
        {
            double sumOfSquares = numbers.Sum(num => Math.Pow(num - average, 2));
            return Math.Sqrt(sumOfSquares / numbers.Count);
        }

        private void lblInstrucciones_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
