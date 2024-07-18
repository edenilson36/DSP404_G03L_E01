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
    public partial class Form1 : Form
    {
        public Form1()
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
            int primero = 0, segundo = 1, tercero, i;

            //Verifico que en textNumero tenga un dato numerico y que sea positivo
            if (IsNumeric(textNumero.Text) && (long.Parse(textNumero.Text) > 0))
            {
                long numero = long.Parse(textNumero.Text);

                //Muestra el numero inicial
                if (primero <= numero)
                {
                    Lista.Items.Add(primero);
                }
                if (segundo <= numero)
                {
                    Lista.Items.Add(segundo);
                }

                tercero = primero + segundo;
                while (tercero <= numero)
                {
                    Lista.Items.Add(tercero);
                    primero = segundo;
                    segundo = tercero;
                    tercero = primero + segundo;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número y positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textNumero.Clear();
                textNumero.BackColor = Color.Red;
                return;
            }


        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
            textNumero.Clear();
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
