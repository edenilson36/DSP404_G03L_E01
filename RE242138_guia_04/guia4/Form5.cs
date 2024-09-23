using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace guia4
{
    public partial class frmGuia04ejerc3 : Form
    {
        public frmGuia04ejerc3()
        {
            InitializeComponent();
        }

        private void frmGuia04ejerc3_Load(object sender, EventArgs e)
        {
            // Configura el ComboBox con las operaciones
            cmbOperaciones.Items.Add("Suma");
            cmbOperaciones.Items.Add("Resta");
            cmbOperaciones.Items.Add("Multiplicación");
            cmbOperaciones.Items.Add("División");
            cmbOperaciones.Items.Add("Potencia");

            cmbOperaciones.SelectedIndex = 0;
        }
        private void Sumar()
        {
            decimal resultado = nudN1.Value + nudN2.Value;
            lblResul.Text = "Resultado: " + resultado.ToString();
        }

        private void Restar()
        {
            decimal resultado = nudN1.Value - nudN2.Value;
            lblResul.Text = "Resultado: " + resultado.ToString();
        }

        private void Multiplicar()
        {
            decimal resultado = nudN1.Value * nudN2.Value;
            lblResul.Text = "Resultado: " + resultado.ToString();
        }
        private void Dividir()
        {
            if (nudN2.Value != 0) // Validar que el divisor no sea 0
            {
                decimal resultado = nudN1.Value / nudN2.Value;
                lblResul.Text = "Resultado: " + resultado.ToString();
            }
            else
            {
                MessageBox.Show("No se puede dividir entre 0");
            }
        }
        private decimal Potencia(decimal baseNum, int exponente)
        {
            decimal resultado = 1;
            for (int i = 1; i <= exponente; i++)
            {
                resultado *= baseNum;
            }
            return resultado;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            {
                string operacionSeleccionada = cmbOperaciones.SelectedItem.ToString();

                switch (operacionSeleccionada)
                {
                    case "Suma":
                        Sumar();
                        break;
                    case "Resta":
                        Restar();
                        break;
                    case "Multiplicación":
                        Multiplicar();
                        break;
                    case "División":
                        Dividir();
                        break;
                    case "Potencia":
                        // Para la potencia, convertimos el segundo número a entero porque es el exponente
                        int exponente = Convert.ToInt32(nudN2.Value);
                        decimal resultado = Potencia(nudN1.Value, exponente);
                        lblResul.Text = "Resultado: " + resultado.ToString();
                        break;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
