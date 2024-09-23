using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guia4
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        private int[,] GenerarMatriz(int limiteInferior, int limiteSuperior)
        {
            Random rnd = new Random();
            int[,] matriz = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = rnd.Next(limiteInferior, limiteSuperior + 1); // Genera números aleatorios dentro del rango
                }
            }
            return matriz;
        }


        private void MostrarMatrizEnDataGridView(int[,] matriz, DataGridView dataGridView)
        {
            dataGridView.ColumnCount = 5;  // Establece 5 columnas
            dataGridView.RowCount = 5;     // Establece 5 filas
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = matriz[i, j]; // Asigna los valores a las celdas
                }
            }
        }





        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewMatriz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            // Validar que los límites ingresados sean correctos
            if (int.TryParse(txtLimiteInferior.Text, out int limiteInferior) && int.TryParse(txtLimiteSuperior.Text, out int limiteSuperior))
            {
                if (limiteInferior <= limiteSuperior)
                {
                    // Generar y mostrar la matriz
                    int[,] matriz = GenerarMatriz(limiteInferior, limiteSuperior);
                    MostrarMatrizEnDataGridView(matriz, dataGridViewMatriz);
                }
                else
                {
                    MessageBox.Show("El límite inferior debe ser menor o igual al límite superior.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese límites válidos.");
            }
        }
    }
}

