using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace practica3_DSP
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> palabras = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //agregamos datos al diccionario
            palabras.Add("Manzana", "Fruta pomácea comestible, fruto\n del manzano doméstico (Malus domestica)\n, otros manzanos(especies del género\n Malus).");

            palabras.Add("Pera", "Fruta comestible que procede del Pyrus communis, un árbol que se conoce coloquialmente como peral común.Existen, de todas maneras, muchas clases de peras, que son producidas por otros árboles del género Pyrus.");

            palabras.Add("Pera", "Fruta comestible que procede del Pyrus communis, un árbol que se conoce coloquialmente como peral común.Existen, de todas maneras, muchas clases de peras, que son producidas por otros árboles del género Pyrus.");

            //recorre el diccionario para llenar la lista con la llave

            foreach (var item in palabras.Keys)
            {
                lstPalabras.Items.Add(item);
            }
        }

        private void lstPalabras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = lstPalabras.Text;
            //buscamos dato de la lista dentro del diccionario
            for (int i = 0; i < palabras.Count; i++)
            {
                var item = palabras.ElementAt(i);
                if (buscar == item.Key)
                {
                    lblPalabra.Text = item.Key;
                    txtsignificado.Text = item.Value;
                    break;
                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
