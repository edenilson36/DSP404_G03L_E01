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
    public partial class Form3 : Form
    {

        private List<double> notas;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            notas = new List<double> { 3.5, 5.0, 7.5, 6.0, 8.0 }; // Ejemplo de notas

            int deficientes = notas.Count(n => n < 5.0);
            int aprobados = notas.Count(n => n >= 6.0);
            double notaMaxima = notas.Max();
            double notaMinima = notas.Min();
            double promedio = notas.Average();

            lstNotas.Items.Clear();
            lstNotas.Items.Add($"Porcentaje de deficientes: {((double)deficientes / notas.Count) * 100}%");
            lstNotas.Items.Add($"Número de aprobados: {aprobados}");
            lstNotas.Items.Add($"Nota más alta: {notaMaxima}");
            lstNotas.Items.Add($"Nota más baja: {notaMinima}");
            lstNotas.Items.Add($"Promedio: {promedio}");
        }
    }
}
