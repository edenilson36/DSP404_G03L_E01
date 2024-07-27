namespace practica3DSP
{
    public partial class Form1 : Form
    {
        int[] matriz = new int[5];

        public Form1()
        {
            InitializeComponent();
            int[] matriz = new int[5];


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] matriz = new int[5];
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {

            if (int <= 5)
            {
                //Gregamos los numeros en cada posicion del arreglo

                matriz[i] = Convert.ToInt32(txtNum.Text);
                listBox1.Items.Add(matriz[i]);  //agregamos los numeros a la lista
                int += 1;
                txtNum.Clear();  //Limpiar txtnum
                txtNum.Select();  //colocar cursos en txtnum
            }
            else
            {
                MessageBox.Show("No se puede ingresar mas datos", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            int j, k, count;
            double valor;
            int Tam = 5;

            //---ordenamos el arreglo por el metodo de la burbuja

            for (j = 0; j < Tam; j++)
            {
                for (k = 0; k < (Tam - 1); k++)
                {
                    if (matriz[k] > matriz[k + 1])
                    {
                        valor = matriz[k];
                        matriz[k] = matriz[k + 1];
                        matriz[k + 1] = Convert.ToInt16(valor);
                    }
                }

                //recorremos el arreglo e ingresamos los valores a la lista

                listBox1.Items.clear();
                for (count = 0; count < Tam; count++)
                {
                    listBox1.Items.Add(matriz[count]);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
