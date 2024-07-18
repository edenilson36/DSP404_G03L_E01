using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplos
{
    public partial class FrmReves : Form
    {
        public FrmReves()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (IsNumeric(txtNumero.Text) && (long.Parse(txtNumero.Text) > 0))
            {
                long numero = long.Parse(txtNumero.Text);
                /*Para poner al revés un numero hay que ir dividiendo el número
                 * *para sacer al digito mas significativo y colocarlo en el nuevo
                 * *numero osea en el digito menos significativo y asi sucesivamente*/
                long r, div, reves = 0, multi = 1;

                txtNumero.Text = numero.ToString();

                if (numero >= 100000 & numero <= 99999)
                {
                    div = 100000;
                }
                else if (numero >= 1000 & numero <= 9999)
                {
                    div = 1000;
                }
                else if (numero >= 100 & numero <= 999)
                {
                    div = 100;
                }
                else if (numero >= 10 & numero <= 99)
                {
                    div = 10;
                }
                else
                {
                    MessageBox.Show("Número fuera de rango(1-999999)", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtNumero.Clear();
                    txtNumero.BackColor = Color.Red;
                    return;
                }
                do
                {
                    //capturamos el digito mas significativo
                    r = numero / div;
                    //restamos ese digito al numero
                    numero = numero - r * div;
                    //calculamos el siguiente divisor
                    div = div / 10;
                    //multiplicamosd el digito segun su peso y lo sumamos al nuevo numero
                    reves = reves + (r * multi);
                    //calculamos el siguiente multiplicador
                    multi = multi * 10;
                    //el proceso se repite hasta el numero es igual a 0
                } while (numero != 0);
                txtReves.Text = reves.ToString();
            }
            else
            {
                MessageBox.Show("El dato que ingreso no es un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Clear();
                txtNumero.BackColor = Color.Red;
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.BackColor = Color.White;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtReves.Clear();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
