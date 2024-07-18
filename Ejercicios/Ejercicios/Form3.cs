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
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {

            // Variables para las estadistica
            int mayorNegativo = int.MinValue;
            int cantidadPositivos = 0;
            int sumaNegativos = 0;
            int cantidadNumeros = 0;
            double promedioNegativos = 0;
            double porcentajePositivos = 0;
            double porcentajeNegativos = 0;
            double porcentajeCeros = 0;

            if (int.TryParse(textNumero.Text, out int numero))
            {
                if (numero >= -40 && numero <= 45)
                {
                    // Cuenta numeros positivos y acumula suma de negativos
                    if (numero > 0)
                    {
                        cantidadPositivos++;
                    }
                    else if (numero < 0)
                    {
                        // Actualizar el mayor número negativo
                        if (numero > mayorNegativo)
                        {
                            mayorNegativo = numero;
                        }
                        sumaNegativos += numero;
                    }

                    cantidadNumeros++;

                    // Calcula promedio de los negativos
                    if (cantidadNumeros > 0)
                    {
                        promedioNegativos = (double)sumaNegativos / cantidadNumeros;
                    }

                    // Calcula porcentajes
                    if (cantidadNumeros > 0)
                    {
                        porcentajePositivos = (double)cantidadPositivos / cantidadNumeros * 100;
                        porcentajeNegativos = (double)(cantidadNumeros - cantidadPositivos) / cantidadNumeros * 100;
                        porcentajeCeros = (double)(cantidadNumeros - cantidadPositivos - cantidadNumeros) / cantidadNumeros * 100;
                    }

                    // Muestra los resultados en TextBoxes
                    textMayorNegativo.Text = mayorNegativo.ToString();
                    textCantidadPositivos.Text = cantidadPositivos.ToString();
                    textPromedioNegativos.Text = promedioNegativos.ToString("F2");
                    textPositivos.Text = porcentajePositivos.ToString("F2");
                    textNegativos.Text = porcentajeNegativos.ToString("F2");
                    textCeros.Text = porcentajeCeros.ToString("F2");
                }
                else
                {
                    MessageBox.Show("El número debe estar en el rango de -40 a 45.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textNumero.Clear();
                    textNumero.BackColor = Color.Red;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textNumero.Clear();
                textNumero.BackColor = Color.Red;
                return;
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            textNumero.Clear();
            textMayorNegativo.Clear();
            textCantidadPositivos.Clear();
            textPromedioNegativos.Clear();
            textPositivos.Clear();
            textNegativos.Clear();
            textCeros.Clear();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
