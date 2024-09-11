using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complementario
{
    public partial class Form2 : Form
    {

        private int[,] matriz;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int limiteInferior = Convert.ToInt32(txtLimiteInferior.Text);
            int limiteSuperior = Convert.ToInt32(txtLimiteSuperior.Text);

            Random random = new Random();
            matriz = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = random.Next(limiteInferior, limiteSuperior + 1);
                }
            }

            MostrarMatriz();
        }

        private void MostrarMatriz()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 5;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView1[j, i].Value = matriz[i, j];
                }
            }
        }
    }
}
