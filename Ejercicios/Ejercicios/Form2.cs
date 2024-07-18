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
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            // Verificar que los TextBoxes contengan datos numéricos válidos
            if (IsNumeric(textNumero1.Text) && IsNumeric(textNumero2.Text) && IsNumeric(textNumero3.Text) && IsNumeric(textNumero4.Text))
            {
                // Obtener los números ingresados
                double numero1 = double.Parse(textNumero1.Text);
                double numero2 = double.Parse(textNumero2.Text);
                double numero3 = double.Parse(textNumero3.Text);
                double numero4 = double.Parse(textNumero4.Text);

                // Calcula el promedio
                double promedio = (numero1 + numero2 + numero3 + numero4) / 4;
                textPromedio.Text = promedio.ToString();

                // Calcula la desviación 
                double[] numeros = { numero1, numero2, numero3, numero4 };
                double media = numeros.Average();
                double sumatoriaCuadrados = numeros.Sum(num => Math.Pow(num - media, 2));
                double desviacion = Math.Sqrt(sumatoriaCuadrados / numeros.Length);
                textDesviacion.Text = desviacion.ToString("0.000"); // Muestra la desviación con tres decimales
            }
            else
            {
                MessageBox.Show("Ingrese un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textNumero1.Clear();
                textNumero1.BackColor = Color.Red;
                textNumero2.Clear();
                textNumero2.BackColor = Color.Red;
                textNumero3.Clear();
                textNumero3.BackColor = Color.Red;
                textNumero4.Clear();
                textNumero4.BackColor = Color.Red;
                return;
            }

        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textNumero1.Clear();
            textNumero2.Clear();
            textNumero3.Clear();
            textNumero4.Clear();
            textPromedio.Clear();
            textDesviacion.Clear();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
