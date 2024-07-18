namespace ejercicio_complentarios
{
    public partial class FibonacciApp : Form
    {
        public FibonacciApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                lstLista.Items.Clear();

                int maxNumber;
                if (int.TryParse(textBoxInput.Text, out maxNumber))
                {
                    GenerateFibonacciSeries(maxNumber);
                }
                else
                {
                    MessageBox.Show("Por favor, introduce un número válido.");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxFibonacci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void GenerateFibonacciSeries(int maxNumber)
        {
            int a = 0; // Primer número de la serie
            int b = 1; // Segundo número de la serie
            int next;  // Variable para almacenar el siguiente número de la serie

            // Agregar los dos primeros números de la serie al ListBox
            lstLista.Items.Add(a);
            if (maxNumber == 0) return;
            lstLista.Items.Add(b);

            // Generar y agregar los siguientes números de la serie hasta que el siguiente número exceda el máximo
            while (true)
            {
                next = a + b; // Calcular el siguiente número de la serie
                if (next > maxNumber) break; // Salir del bucle si el siguiente número excede el máximo

                lstLista.Items.Add(next); // Agregar el siguiente número al ListBox
                a = b; // Actualizar a y b para los siguientes cálculos
                b = next;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            lstLista.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


