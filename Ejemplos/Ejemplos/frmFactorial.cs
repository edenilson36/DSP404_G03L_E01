using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplos
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            long factorial = 1;
            int i;
            //con la funcion IsNumeric verificamos que el TxtNumero contenga un dato numerico
            if (IsNumeric(txtNumero.Text))
            {
                //ser realizar un for desde el numero ingresado hasta llegar a uno

                for (i = Convert.ToInt32(txtNumero.Text); i >= 1; i--)
                {
                    //se multiplica el factorial por todos los numero menores
                    //factorial = factorial*i;
                    factorial *= i;
                }
                txtFactorial.Text = factorial.ToString();
            }
            else
            {
                txtNumero.BackColor = Color.Red;
                MessageBox.Show("Debe ingresar un número!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero.Clear();
                txtFactorial.Clear();
                txtNumero.Focus();
            }
        }

        private void lblNumero_Click(object sender, EventArgs e)
        {
            txtNumero.BackColor = Color.White;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtFactorial.Clear();
        }
    }
}
