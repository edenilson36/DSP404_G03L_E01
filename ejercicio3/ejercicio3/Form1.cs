namespace ejercicio3
{
    public partial class Form1 : Form
    {
        private List<int> numbers = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cualquier inicialización que necesites aquí
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtNumber.Text, out number) && number >= -40 && number <= 45)
            {
                numbers.Add(number);
                UpdateStatistics();
            }
            else
            {
                MessageBox.Show("Please enter a valid number between -40 and 45.");
            }
            txtNumber.Clear();
            txtNumber.Focus();
        }

        private void UpdateStatistics()
        {
            int maxNegative = numbers.Where(n => n < 0).DefaultIfEmpty(int.MinValue).Max();
            int positiveCount = numbers.Count(n => n > 0);
            double negativeAverage = numbers.Where(n => n < 0).DefaultIfEmpty().Average();
            int totalNumbers = numbers.Count;
            int zeroCount = numbers.Count(n => n == 0);

            double positivePercentage = (double)positiveCount / totalNumbers * 100;
            double negativePercentage = (double)(totalNumbers - positiveCount - zeroCount) / totalNumbers * 100;
            double zeroPercentage = (double)zeroCount / totalNumbers * 100;

            lblMaxNegative.Text = $"Mayor número negativo: {maxNegative}";
            lblMaxNegative.Text = $"Cantidad de números positivos: {positiveCount}";
            lblNegativeAverage.Text = $"Promedio de números negativos: {negativeAverage:F2}";
            lblPositivePercentage.Text = $"Porcentaje de positivos: {positivePercentage:F2}%";
            lblNegativePercentage.Text = $"Porcentaje de negativos: {negativePercentage:F2}%";
            lblZeroPercentage.Text = $"Porcentaje de ceros: {zeroPercentage:F2}%";
        }
    }
}
