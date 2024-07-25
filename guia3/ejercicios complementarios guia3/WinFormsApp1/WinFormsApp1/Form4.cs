using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        private int[,] notas = new int[6, 5];
        private double[] medias = new double[6];
        private Random rand = new Random();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            {
                // Configurar DataGridView
                dgvNotas.ColumnCount = 6;
                dgvNotas.Columns[0].Name = "Alumno";
                dgvNotas.Columns[1].Name = "Asignatura 1";
                dgvNotas.Columns[2].Name = "Asignatura 2";
                dgvNotas.Columns[3].Name = "Asignatura 3";
                dgvNotas.Columns[4].Name = "Asignatura 4";
                dgvNotas.Columns[5].Name = "Media";
            }

        }





        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarNotas();
            CalcularMedias();
            MostrarNotas();
        }

        private void GenerarNotas()
        {
            for (int i = 0; i < 6; i++)
            {
                int asignaturas = rand.Next(2, 6); // Número de asignaturas entre 2 y 5
                for (int j = 0; j < 5; j++)
                {
                    if (j < asignaturas)
                    {
                        notas[i, j] = rand.Next(0, 101); // Notas aleatorias entre 0 y 100
                    }
                    else
                    {
                        notas[i, j] = -1; // Indicador de que no hay nota
                    }
                }
            }
        }

        private void CalcularMedias()
        {
            for (int i = 0; i < 6; i++)
            {
                int sum = 0;
                int count = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (notas[i, j] != -1)
                    {
                        sum += notas[i, j];
                        count++;
                    }
                }
                medias[i] = count > 0 ? (double)sum / count : 0;
            }
        }
        private void MostrarNotas()
        {
            dgvNotas.Rows.Clear();
            for (int i = 0; i < 6; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvNotas);
                row.Cells[0].Value = $"Alumno {i + 1}";
                for (int j = 1; j <= 4; j++)
                {
                    row.Cells[j].Value = notas[i, j - 1] == -1 ? "N/A" : notas[i, j - 1].ToString();
                }
                row.Cells[5].Value = medias[i].ToString("F2");
                dgvNotas.Rows.Add(row);
            }
        }






        private void dgvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
