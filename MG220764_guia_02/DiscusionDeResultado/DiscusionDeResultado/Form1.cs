namespace DiscusionDeResultado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtLimite.Text, out int vall))
            {
                String listBoxFibonacci;
                String txtLimite;

                List<int> fibonacciNumbers = generateFibonacciNumbers(limite);

                foreach(int num in fibonacciNumbers)
                {
                    listBoxFibonacci.Items.Add(num);
                }
            }
            else
            {
                MessageBox.Show("Ingrese el numero: ");
            }
        }
        private List<int>GenerateFibonacciNumbers(int limite)
        {
            List<int> fibonacciNumbers = new List<int>();

            if(limite >= 1)
            {
                fibonacciNumbers.Add(0);
            }if(limite >= 2)
            {
                fibonacciNumbers.Add(1);
            }
            int a = 0, b = 1, c;
            for(int i = 1; i< limite; i++)
            {
                c = a + b;
                if (c > limite)
                    break;
                fibonacciNumbers.Add(c);
                a = b;
                b = c;
            }
            return fibonacciNumbers;
        }
    }
}
