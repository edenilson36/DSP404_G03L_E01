using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guia4
{
    public partial class Form9 : Form

    {
        int[] lista;

        public Form9()
        {
            InitializeComponent();
        }
        private void CrearListaVacia(ref int[] lista)
        {
            lista = new int[0]; // Inicializa la lista como un arreglo vacío
        }

        private void MostrarLista(int[] lista, ListBox listBox)
        {
            listBox.Items.Clear(); // Limpia el ListBox antes de mostrar los elementos
            foreach (int item in lista)
            {
                listBox.Items.Add(item); // Agrega cada elemento del arreglo al ListBox
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearLista_Click(object sender, EventArgs e)
        {
            CrearListaVacia(ref lista); // Crear lista vacía
            MostrarLista(lista, lstLista); // Mostrar en ListBox
        }

        private void btnInsertarElemento_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNuevoElemento.Text, out int nuevoElemento))
            {
                InsertarElemento(ref lista, nuevoElemento); // Insertar nuevo elemento
                MostrarLista(lista, lstLista); // Actualizar ListBox
                txtNuevoElemento.Clear(); // Limpiar TextBox
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido.");
            }
        }

        private void btnRemoverElemento_Click(object sender, EventArgs e)
        {
            RemoverElemento(ref lista); // Eliminar primer elemento
            MostrarLista(lista, lstLista); // Actualizar ListBox
        }

        private void InsertarElemento(ref int[] lista, int valor)
        {
            Array.Resize(ref lista, lista.Length + 1); // Redimensiona el arreglo para agregar un nuevo valor
            lista[lista.Length - 1] = valor; // Agrega el nuevo valor al final del arreglo
        }

        private void RemoverElemento(ref int[] lista)
        {
            if (lista.Length > 0)
            {
                for (int i = 0; i < lista.Length - 1; i++)
                {
                    lista[i] = lista[i + 1]; // Desplaza los elementos a la izquierda
                }
                Array.Resize(ref lista, lista.Length - 1); // Reduce el tamaño del arreglo
            }
        }
    }
}
