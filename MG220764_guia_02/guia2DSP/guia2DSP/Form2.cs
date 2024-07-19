using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guia2
{
    public partial class frmCesar : Form
    {
        public frmCesar()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblllave_Click(object sender, EventArgs e)
        {
            txtLlave.BackColor = Color.White;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            if (IsNumeric(txtLlave.Text) && (Convert.ToInt16(txtLlave.Text) > 0))
            {
                txtResultado.Clear();
                int ascii;
                foreach (char c in txtTexto.Text) 
                {
                    if (rdbEncriptar.Checked)
                    {
                        ascii = (int)c + Convert.ToInt16(txtLlave.Text);
                    }
                    else
                    {
                        ascii = (int)c - Convert.ToInt16(txtLlave.Text);
                    }
                    txtResultado.Text += (char)ascii;
                }
                lblresultado.Text = rdbEncriptar.Checked ? "Texto encriptado:" : "Texto desencriptado:";
            }
            else
            {
                MessageBox.Show("El dato introducido en la llave es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLlave.Focus();
                txtLlave.Clear();
                txtLlave.BackColor = Color.Red;
            }
        }

        private void rdbEncriptar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEncriptar.Checked)
            {
                btnEncriptar.Text = "Encriptar";
            }
        }

        private void rdbDesencriptar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDesencriptar.Checked)
            {
                btnEncriptar.Text = "Desencriptar";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
    }
}
