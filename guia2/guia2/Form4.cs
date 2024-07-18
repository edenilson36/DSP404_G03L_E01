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
    public partial class frmULAM : Form
    {
        public frmULAM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lstLista.Items.Clear();

            // Get the number from the textbox
            int numero;
            if (int.TryParse(txtnumero.Text, out numero) && numero > 0)
            {
                // Start the ULAM sequence with the given number
                int current = numero;
                lstLista.Items.Add(current.ToString());

                // Calculate the ULAM sequence
                while (current != 1)
                {
                    if (current % 2 == 0)
                    {
                        current /= 2; // If current is even, divide by 2
                    }
                    else
                    {
                        current = 3 * current + 1; // If current is odd, multiply by 3 and add 1
                    }
                    lstLista.Items.Add(current.ToString());
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número positivo válido.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            lstLista.Items.Clear();
        }
    }
}
