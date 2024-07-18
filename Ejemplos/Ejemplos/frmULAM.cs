using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplos
{
    public partial class frmULAM : Form
    {
        public frmULAM()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result );
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Verifico que en txtNumero tenga un dato numerico y que sea positivo
            if (IsNumeric(txtNumero.Text) && (long.Parse(txtNumero.Text) > 0))
            {
                long numero = long.Parse(txtNumero.Text);


                //Muestra el numero inicial
                lstLista.Items.Add(numero.ToString());

                //aplicacion la sucesion de ulam utilizando un ciclo while
                while (numero !=1)
                {
                    if (numero % 2 == 0)
                    {
                        numero = numero / 2;
                    }
                    else
                    {
                        numero = 3 * numero + 1;
                    }

                    //Muestra el numero actual en cada interaccion 
                    lstLista.Items.Add(numero.ToString());
                }

            }
            else
            {
                MessageBox.Show("Ingrese un número y positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Clear();
                txtNumero.BackColor = Color.Red;
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstLista.Items.Clear();
            txtNumero.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
