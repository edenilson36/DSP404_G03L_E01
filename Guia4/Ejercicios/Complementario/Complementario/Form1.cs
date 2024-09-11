using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complementario
{
    public partial class Form1 : Form
    {

        private int[] lista; // Simulamos la lista con un array
        private int tamaño; // Tamaño del array dinámico

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearLista_Click(object sender, EventArgs e)
        {
            lista = new int[0]; // Inicializamos el array vacío
            tamaño = 0;
            MessageBox.Show("Lista vacía creada.");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int nuevoValor = Convert.ToInt32(txtNuevoElemento.Text);
            Array.Resize(ref lista, tamaño + 1);
            lista[tamaño] = nuevoValor; // Añadimos el nuevo elemento
            tamaño++;
            MessageBox.Show("Elemento insertado.");
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (tamaño > 0)
            {
                for (int i = 0; i < tamaño - 1; i++)
                {
                    lista[i] = lista[i + 1];
                }
                Array.Resize(ref lista, tamaño - 1);
                tamaño--;
                MessageBox.Show("Primer elemento removido.");
            }
            else
            {
                MessageBox.Show("La lista está vacía.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstElementos.Items.Clear();
            foreach (int elemento in lista)
            {
                lstElementos.Items.Add(elemento);
            }
        }
    }
}
