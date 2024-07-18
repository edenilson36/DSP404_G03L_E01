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
                    MessageBox.Show("Por favor, introduce un n�mero v�lido.");
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
            int a = 0; // Primer n�mero de la serie
            int b = 1; // Segundo n�mero de la serie
            int next;  // Variable para almacenar el siguiente n�mero de la serie

            // Agregar los dos primeros n�meros de la serie al ListBox
            lstLista.Items.Add(a);
            if (maxNumber == 0) return;
            lstLista.Items.Add(b);

            // Generar y agregar los siguientes n�meros de la serie hasta que el siguiente n�mero exceda el m�ximo
            while (true)
            {
                next = a + b; // Calcular el siguiente n�mero de la serie
                if (next > maxNumber) break; // Salir del bucle si el siguiente n�mero excede el m�ximo

                lstLista.Items.Add(next); // Agregar el siguiente n�mero al ListBox
                a = b; // Actualizar a y b para los siguientes c�lculos
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


