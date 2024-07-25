using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private int[,] matriz = new int[1, 1];
        private int dimension;

        public Form2()
        {
            InitializeComponent();
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDimension.Text, out dimension) && dimension > 0)
            {
                matriz = new int[dimension, dimension];
                Random rand = new Random();

                // Generar matriz aleatoria
                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        matriz[i, j] = rand.Next(1, 100); // números aleatorios entre 1 y 100
                    }
                }

                // Mostrar matriz original
                MostrarMatriz(dgvMatrizOriginal, matriz);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una dimensión válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMatrizTraspuesta_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularTraspuesta_Click(object sender, EventArgs e)
        {
            if (matriz == null)
            {
                MessageBox.Show("Primero debe generar una matriz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int[,] traspuesta = new int[dimension, dimension];

            // Calcular la traspuesta
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    traspuesta[i, j] = matriz[j, i];
                }
            }

            // Mostrar matriz traspuesta
            MostrarMatriz(dgvMatrizTraspuesta, traspuesta);
        }

        private void MostrarMatriz(DataGridView dgv, int[,] matriz)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            int dimension = matriz.GetLength(0);

            for (int i = 0; i < dimension; i++)
            {
                dgv.Columns.Add(i.ToString(), i.ToString());
            }

            for (int i = 0; i < dimension; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgv);

                for (int j = 0; j < dimension; j++)
                {
                    row.Cells[j].Value = matriz[i, j];
                }

                dgv.Rows.Add(row);
            }
        }




        private void dgvMatrizTraspuesta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
