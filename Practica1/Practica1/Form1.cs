using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {

        private string mensa;
        static int conta;
        //Evento se ejecuta al iniciar ejecucion de form1
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mensa = "Aun no ha presionado boton contar";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(mensa);
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            //t conta = 0;

            //Acumulador, total veces que presiona boton

            conta = conta + 1;
            //Conta+=1; en forma de operador abreviado

            mensa = "Presiono boton contar, un total de " + Convert.ToString(conta) + " veces";  //Convert me pasa mi variable conta de int a string
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            //Restaura conteo clic realizado a button1 
            conta =0; 
            mensa = "Presiono boton Contar, un total de" + Convert.ToString(conta) + " veces"; 
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
