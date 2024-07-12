using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {

        private string mensa;
        private static int conta;

        public Form1()
        {
            InitializeComponent();

            mensa = "Aun no ha presionado boton contar";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = mensa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            //Acumulador, Total veces que presiona boton
            conta = conta + 1;
            //conta+= //En forma de operador abreviado
            mensa = "Presiono botón Contar, un total de " + Convert.ToString(conta) + " veces";
            label1.Text = mensa;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void botonReinicio_Click(object sender, EventArgs e)
        {
            //Restaura conteo clic realizado a button1
            conta = 0;
            mensa = "Presionó botón Contar, un total de " + Convert.ToString(conta) + " veces";
            label1.Text = mensa;
        }

        private void botonfin_Click(object sender, EventArgs e)
        {
            Close(); //finalizacion aplicacion
        }
    }
}
