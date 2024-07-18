namespace ejercicio4
{
    public partial class Form1 : Form
    {
        private Dictionary<string, double> exchangeRates;
        public Form1()




        {
            InitializeComponent();
            InitializeCurrencyData();

        }
        private void InitializeCurrencyData()
        {
            exchangeRates = new Dictionary<string, double>
            {
                { "USD", 1.0 },
                { "EUR", 0.85 },
                { "GBP", 0.75 },
                { "JPY", 110.0 },
                { "AUD", 1.35 }
            };

            cmbFromCurrency.Items.AddRange(new object[] { "USD", "EUR", "GBP", "JPY", "AUD" });
            cmbToCurrency.Items.AddRange(new object[] { "USD", "EUR", "GBP", "JPY", "AUD" });

            cmbFromCurrency.SelectedIndex = 0;
            cmbToCurrency.SelectedIndex = 1;
        }






        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amount;
            if (double.TryParse(txtAmount.Text, out amount))
            {
                string fromCurrency = cmbFromCurrency.SelectedItem.ToString();
                string toCurrency = cmbToCurrency.SelectedItem.ToString();

                double fromRate = exchangeRates[fromCurrency];
                double toRate = exchangeRates[toCurrency];

                double convertedAmount = (amount / fromRate) * toRate;

                lblResult.Text = $"{amount} {fromCurrency} = {convertedAmount:F2} {toCurrency}";
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        private void cmbFromCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
