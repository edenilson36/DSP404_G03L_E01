namespace guia3
{
    public partial class Form1 : Form
    {
        int[] matriz  = new int[5];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (i <= 5)
            {

                matriz[i] = Convert.ToInt16(txtNum.Text);
                lstdesorden.Items.Add(matriz[i]);//agregamos los numeros a la lista
                i += 1;
                txtNum.Clear();//limpiar txtnum
                txtNum.Select();//colocar cursos en txtnum
            }
            else
            {
                MessageBox.Show("No se puede ingresar mas datos", "Advertencia", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }


        }

        private void btOrdenar_Click(object sender, EventArgs e)
        {
            int j, k, count;
            double valor;
            int Tam = 5;
            //---ordenamos el arreglo por le metodo de la burbuja
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
            }
            //recorremos el arreglo e ingresamos los valores a la lista
            lstOrdenada.Items.Clear();
            for (count = 0; count < Tam; count++)
            {
                lstOrdenada.Items.Add(matriz[count]);
            }
        }
    }
}
