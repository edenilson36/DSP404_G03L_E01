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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        private void ProcesarNotas(double[] notas, ListBox listBox)
        {
            int numDeficientes = notas.Count(n => n < 5.0); // Cuenta notas menores de 5.0
            int numAprobados = notas.Count(n => n >= 6.0); // Cuenta notas mayores o iguales a 6.0
            double notaMinima = notas.Min(); // Nota más baja
            double notaMaxima = notas.Max(); // Nota más alta
            double notaMedia = notas.Average(); // Nota media

            // Mostrar los resultados en el ListBox
            listBox.Items.Clear();
            listBox.Items.Add($"Porcentaje de Deficientes: {(numDeficientes * 100.0) / notas.Length}%");
            listBox.Items.Add($"Número de Aprobados: {numAprobados}");
            listBox.Items.Add($"Nota más baja: {notaMinima}");
            listBox.Items.Add($"Nota más alta: {notaMaxima}");
            listBox.Items.Add($"Nota media: {notaMedia}");
        }





        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void btnProcesarNotas_Click(object sender, EventArgs e)
        {
            // Leer las notas desde el TextBox
            string[] notasStr = txtNotas.Text.Split(','); // Separar las notas por comas
            try
            {
                // Convertir las notas a números
                double[] notas = Array.ConvertAll(notasStr, Double.Parse);

                // Validar que todas las notas estén entre 0.0 y 10.0
                if (notas.All(n => n >= 0.0 && n <= 10.0))
                {
                    // Procesar las notas y mostrar los resultados
                    ProcesarNotas(notas, lstResultados);
                }
                else
                {
                    MessageBox.Show("Las notas deben estar entre 0.0 y 10.0.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese las notas en un formato válido, separadas por comas.");
            }
        }
    }
    }

