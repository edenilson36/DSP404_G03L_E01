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
    public partial class Form3 : Form
    {

        private double[,] notas = new double[6, 5];
        private int[] numAsignaturasAlumno = new int[6];

        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Inicializar las matrices con valores por defecto
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    notas[i, j] = -1; // Valor para indicar que no hay nota
                }
                numAsignaturasAlumno[i] = 0; // Inicialmente no hay asignaturas para cada alumno
            }
        }

        private void btAgregarNota_Click(object sender, EventArgs e)
        {
            if (cbAlumnos.SelectedIndex >= 0 && cbAsignaturas.SelectedIndex >= 0 && double.TryParse(txtNota.Text, out double nota))
            {
                int alumno = cbAlumnos.SelectedIndex;
                int asignatura = cbAsignaturas.SelectedIndex;

                if (nota < 0 || nota > 100)
                {
                    MessageBox.Show("La nota debe estar entre 0 y 100.");
                    return;
                }

                if (numAsignaturasAlumno[alumno] < 5)
                {
                    if (notas[alumno, asignatura] == -1)
                    {
                        notas[alumno, asignatura] = nota;
                        numAsignaturasAlumno[alumno]++;
                        MessageBox.Show("Nota agregada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Esta asignatura ya tiene una nota registrada.");
                    }
                }
                else
                {
                    MessageBox.Show("Este alumno ya tiene 5 notas registradas.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.");
            }
        }

        private void btMostrarNota_Click(object sender, EventArgs e)
        {
            dgNotas.Rows.Clear();
            dgNotas.Columns.Clear();

            dgNotas.ColumnCount = 7; // 6 para asignaturas y 1 para promedio
            dgNotas.Columns[0].Name = "Alumno";
            for (int i = 1; i <= 5; i++)
            {
                dgNotas.Columns[i].Name = "Asignatura " + i;
            }
            dgNotas.Columns[6].Name = "Promedio";

            for (int i = 0; i < 6; i++)
            {
                string[] row = new string[7];
                row[0] = "Alumno " + (i + 1);
                double suma = 0;
                int count = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (notas[i, j] != -1)
                    {
                        row[j + 1] = notas[i, j].ToString();
                        suma += notas[i, j];
                        count++;
                    }
                    else
                    {
                        row[j + 1] = "N/A";
                    }
                }
                double promedio = count > 0 ? suma / count : 0;
                row[6] = promedio.ToString("F2"); // Muestra el promedio con dos decimales
                dgNotas.Rows.Add(row);
            }
        }
    }
}
