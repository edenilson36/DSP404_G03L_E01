using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {

        private int[] cuentas = { 1000001, 1000002, 1000004 };
        private double[] saldos = { 400, 200, 500 };
        private int cuentaActual = 0;
        public Form1()
        {
            InitializeComponent();
            comboMenu.Items.Add("Consulta de saldo");
            comboMenu.Items.Add("Retiro de fondos");
            comboMenu.Items.Add("Consignaciones");
            comboMenu.Items.Add("Transferencias");
            comboMenu.Items.Add("Salir");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int cuentaIngresada;

            try
            {
                cuentaIngresada = Convert.ToInt32(txtNumero.Text);

                int indiceCuenta = Array.IndexOf(cuentas, cuentaIngresada);

                if (indiceCuenta != -1)
                {
                    cuentaActual = indiceCuenta;
                    lblSaludo.Text = "Bienvenido, su número de cuenta es " + cuentaIngresada;
                    comboMenu.Enabled = true;
                    btnEjecutar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Número de cuenta no válido, vuelva a intentarlo");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Número de cuenta no válido, vuelva a intentarlo");
            }
        }


    private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if(cuentaActual == -1)
            {
                MessageBox.Show("Ingrese un numero de cuenta primero");
                return;
            }

            string opcionSeleccionada = comboMenu.SelectedItem.ToString();
            switch (opcionSeleccionada)
            {
                case "Consulta de saldo":
                    MessageBox.Show("El saldo actual de cuenta " + cuentas[cuentaActual]+" es de $"+saldos[cuentaActual].ToString("0.00"));
                    break;

                case "Retiro de fondos":
                    double cantidadRetiro;
                    if(double.TryParse(InputBox("Ingrese la cantidad a retirar: "),out cantidadRetiro))
                    {
                        if (cantidadRetiro > saldos[cuentaActual])
                        {
                            MessageBox.Show("Saldo insuficiente");
                        }
                        else
                        {
                            saldos[cuentaActual] -= cantidadRetiro;
                            MessageBox.Show("Retiro exitoso. El saldo actual de la cuenta " + cuentas[cuentaActual] + " es de $" + saldos[cuentaActual].ToString("0.00"));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cantidad no valida");
                    }
                    break;

                case "Consignaciones":
                    double cantidadConsignacion;
                    if(double.TryParse(InputBox("Ingrese la cantidad a consignar: "),out cantidadConsignacion))
                    {
                        saldos[cuentaActual] += cantidadConsignacion;
                        MessageBox.Show("Consignación exitosa. El saldo actual de la cuenta " + cuentas[cuentaActual] + " es de $" + saldos[cuentaActual].ToString("0.00"));
                    }

                    else
                    {
                        MessageBox.Show("Cantidad no válida");
                    }
                    break;

                case "Transferencias":
                    int cuentaDestino;
                    if (int.TryParse(InputBox("Ingrese cuenta destino:"), out cuentaDestino))
                    {
                        int cuentaDestino2 = Array.IndexOf(cuentas, cuentaDestino);
                        if (cuentaDestino2 != -1)
                        {
                            double cantidadTransferencia;
                            if (double.TryParse(InputBox("Ingrese la cantidad a transferir:"), out cantidadTransferencia))
                            {
                                if(cantidadTransferencia > saldos[cuentaActual])
                                {
                                    MessageBox.Show("Saldo insuficiente");
                                }
                                else
                                {
                                    saldos[cuentaActual] -= cantidadTransferencia;
                                    saldos[cuentaDestino2] += cantidadTransferencia;
                                    MessageBox.Show("Transferencia exitosa. El saldo actual de la cuenta " + cuentas[cuentaActual] + " es de $" + saldos[cuentaActual].ToString("0.00"));
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cantidad no válida");
                            }
                        }
                        else
                        {
                            MessageBox.Show("numero de destino no valido");
                        }
                      
                     }break;

                        case "Salir":
                            Application.Exit();
                            break;

                        default:
                            MessageBox.Show("Opcion no valida");
                    break;
             }
        }
        private string InputBox(string prompt)
        {

            using (Form form = new Form())
            {
                form.Text = prompt;
                form.Width = 300;
                form.Height = 150;
                form.StartPosition = FormStartPosition.CenterScreen;

                Label label = new Label { Left = 20, Top = 20, Text = prompt };
                form.Controls.Add(label);

                TextBox textBox = new TextBox { Left = 20, Top = 50, Width = 250 };
                form.Controls.Add(textBox);

                Button button = new Button { Text = "OK", Left = 200, Top = 70, DialogResult = DialogResult.OK };
                form.Controls.Add(button);
                form.AcceptButton = button;

                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return textBox.Text;
                }
                else
                {
                    return "";
                }
            }
        }


        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
