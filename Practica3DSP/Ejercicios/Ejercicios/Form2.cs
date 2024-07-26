using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form2 : Form
    {
        private int[,] matriz;
        private int dimension;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Inicialización si es necesario
        }


        private void MostrarMatriz(int[,] matriz, ListBox listBox)
        {
            listBox.Items.Clear();

            // Mostrar la matriz en el ListBox
            for (int i = 0; i < dimension; i++)
            {
                string fila = "";
                for (int j = 0; j < dimension; j++)
                {
                    fila += matriz[i, j] + "\t";
                }
                listBox.Items.Add(fila);
            }
        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            // Obtener la dimensión de la matriz del TextBox
            if (int.TryParse(txtDimension.Text, out dimension) && dimension > 0)
            {
                matriz = new int[dimension, dimension];
                Random random = new Random();

                // Llenar la matriz con valores aleatorios
                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        matriz[i, j] = random.Next(1, 101); // Valores aleatorios entre 1 y 100
                    }
                }

                MostrarMatriz(matriz, lstOriginal);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una dimensión válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTransponer_Click_1(object sender, EventArgs e)
        {
            if (matriz != null)
            {
                int[,] matrizTranspuesta = new int[dimension, dimension];

                // Calcular la matriz transpuesta
                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        matrizTranspuesta[i, j] = matriz[j, i];
                    }
                }

                MostrarMatriz(matrizTranspuesta, lstTranspuesta);
            }
            else
            {
                MessageBox.Show("Primero genere una matriz.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
