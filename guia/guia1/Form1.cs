using System;
using System.Windows.Forms;

namespace guia1
{
    public partial class Form1 : Form
    {
        private string mensa;
        private int conta = 0; // Variable para contar clics

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mensa = "Aun no ha presionado botón Contar";
            label1.Text = mensa;
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            // Acumulador, Total veces que presiona botón
            conta = conta + 1;
            // Forma abreviada: conta += 1;

            // Asignarle a mensa la siguiente cadena
            mensa = "Presionó botón Contar, un total de " + Convert.ToString(conta) + " veces";

            // Hacer que label1 muestre el contenido de mensa
            label1.Text = mensa;
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            // Restaura conteo clic realizado a button1
            conta = 0;
            mensa = "Presionó botón Contar, un total de " + Convert.ToString(conta) + " veces";

            // Hacer que label1 muestre el contenido de mensa
            label1.Text = mensa;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            // Finaliza la aplicación
            Close();
        }
    }
}
