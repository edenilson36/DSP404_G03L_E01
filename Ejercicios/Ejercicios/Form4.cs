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
    public partial class Form4 : Form
    {
        // Definición de las variables para monedas y tasas de conversión
        private string[] monedas = { "USD", "EUR", "GBP", "JPY", "CAD" };
        private double[,] tasasConversion = {
            { 1.0, 0.85, 0.75, 110.0, 1.25 },
            { 1.18, 1.0, 0.88, 129.0, 1.46 },
            { 1.33, 1.14, 1.0, 146.0, 1.65 },
            { 0.0091, 0.0078, 0.0068, 1.0, 0.011 },
            { 0.8, 0.68, 0.61, 89.0, 1.0 }
        };

        public Form4()
        {
            InitializeComponent();

            // Inicialización de ComboBox con las monedas
            comboInicial.Items.AddRange(monedas);
            comboFinal.Items.AddRange(monedas);
        }

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            // Verifica que en textConvertir tenga un dato numérico
            if (IsNumeric(textConvertir.Text))
            {
                double valor = double.Parse(textConvertir.Text);

                // Verifica que se haya seleccionado una divisa inicial y final
                if (comboInicial.SelectedItem != null && comboFinal.SelectedItem != null)
                {
                    string divisaInicial = comboInicial.SelectedItem.ToString();
                    string divisaFinal = comboFinal.SelectedItem.ToString();

                    // Convierta las divisas a indices
                    int indexInicial = Array.IndexOf(monedas, divisaInicial);
                    int indexFinal = Array.IndexOf(monedas, divisaFinal);

                    // Calcula el resultado de la conversión utilizando las tasas de conversion
                    double tasaConversion = tasasConversion[indexInicial, indexFinal];
                    double resultado = valor * tasaConversion;

                    // Muestra los resultado en textResultado
                    textResultado.Text = resultado.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione las divisas inicial y final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textConvertir.Clear();
                    textConvertir.BackColor = Color.Red;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textConvertir.Clear();
                textConvertir.BackColor = Color.Red;
                return;
            }

        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        { 
            textConvertir.Clear();
     
            textResultado.Clear();
        }
    }
}
