using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complementarios
{
    public partial class Form2 : Form
    {

        private List<decimal> numerosPositivos = new List<decimal>();
        private List<decimal> numerosNegativos = new List<decimal>();
        private int contador = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void textBoxNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (contador < 10)
            {
                if (decimal.TryParse(textBoxNumero.Text, out decimal numero))
                {
                    if (numero >= 0)
                    {
                        numerosPositivos.Add(numero);
                        listBoxPositivos.Items.Add(numero);
                    }
                    else
                    {
                        numerosNegativos.Add(numero);
                        listBoxNegativos.Items.Add(numero);
                    }
                    contador++;
                    textBoxNumero.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número decimal válido.");
                }
            }
            else
            {
                MessageBox.Show("Ya se han ingresado 10 números.");
            }
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            if (numerosNegativos.Any())
            {
                decimal menorNegativo = numerosNegativos.Min();
                labelMenorNegativo.Text = "Menor de los negativos: " + menorNegativo.ToString();
            }
            else
            {
                labelMenorNegativo.Text = "No hay números negativos.";
            }

            if (numerosPositivos.Any())
            {
                decimal promedioPositivos = numerosPositivos.Average();
                labelPromedioPositivos.Text = "Promedio de los positivos: " + promedioPositivos.ToString();
            }
            else
            {
                labelPromedioPositivos.Text = "No hay números positivos.";
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
