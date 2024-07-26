using System;
using System.Linq;
using System.Windows.Forms;

namespace Complementarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializarSelectoresDeFecha();
        }

        private void InicializarSelectoresDeFecha()
        {
            // Agrega opciones al ComboBox de Meses
            cbMes.Items.AddRange(new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });

            // Agrega años de 1970 a 2060
            for (int año = 1970; año <= 2060; año++)
            {
                cbAño.Items.Add(año);
            }
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDias();
        }

        private void cbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDias();
        }

        private void ActualizarDias()
        {
            if (cbMes.SelectedIndex == -1 || cbAño.SelectedIndex == -1)
            {
                return;
            }

            int mesSeleccionado = cbMes.SelectedIndex + 1;
            int añoSeleccionado = (int)cbAño.SelectedItem;
            int diasEnMes;

            switch (mesSeleccionado)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    diasEnMes = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    diasEnMes = 30;
                    break;
                case 2:
                    if (EsAñoBisiesto(añoSeleccionado))
                    {
                        diasEnMes = 29;
                    }
                    else
                    {
                        diasEnMes = 28;
                    }
                    break;
                default:
                    diasEnMes = 30;
                    break;
            }

            cbDia.Items.Clear();
            for (int dia = 1; dia <= diasEnMes; dia++)
            {
                cbDia.Items.Add(dia);
            }
        }

        private bool EsAñoBisiesto(int año)
        {
            return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
        }

        private void Confirmar_Click_1(object sender, EventArgs e)
        {
            if (cbMes.SelectedIndex != -1 && cbDia.SelectedIndex != -1 && cbAño.SelectedIndex != -1)
            {
                string fechaSeleccionada = $"{cbMes.SelectedItem}, {cbDia.SelectedItem}, {cbAño.SelectedItem}";
                txtFecha.Text = "Fecha seleccionada: " + fechaSeleccionada;
            }
            else
            {
                txtFecha.Text = "Por favor, seleccione mes, día y año.";
            }

        }
    }
}
