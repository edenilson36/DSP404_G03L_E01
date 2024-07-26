using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form1 : Form
    {
        // Definimos una matriz de tamaño fijo para almacenar nombres
        private string[,] matrizNombres = new string[10, 1];
        private int index = 0; // indice para rastrear la fila actual de la matriz

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                // Verificar si el nombre ya est en la matriz
                if (!NombreExiste(nombre))
                {
                    if (index < matrizNombres.GetLength(0))
                    {
                        matrizNombres[index, 0] = nombre;
                        index++;
                        ActualizarLista();
                        txtNombre.Clear();
                    }
                    else
                    {
                        MessageBox.Show("La matriz está llena, no se pueden añadir más nombres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("El nombre ya existe en la matriz.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("El campo de nombre no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lstNombres.SelectedIndex >= 0)
            {
                int selectedIndex = lstNombres.SelectedIndex;
                for (int i = selectedIndex; i < index - 1; i++)
                {
                    matrizNombres[i, 0] = matrizNombres[i + 1, 0];
                }
                matrizNombres[index - 1, 0] = null; // limpiar el ultimo elemento
                index--;
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Seleccione un nombre para borrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstNombres.SelectedIndex >= 0)
            {
                int selectedIndex = lstNombres.SelectedIndex;
                string nombre = txtNombre.Text.Trim();
                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    if (!NombreExiste(nombre))
                    {
                        matrizNombres[selectedIndex, 0] = nombre;
                        ActualizarLista();
                        txtNombre.Clear();
                    }
                    else
                    {
                        MessageBox.Show("El nombre ya existe en la matriz.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("El campo de nombre no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un nombre para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarLista()
        {
            lstNombres.Items.Clear();
            for (int i = 0; i < index; i++)
            {
                if (!string.IsNullOrWhiteSpace(matrizNombres[i, 0]))
                {
                    lstNombres.Items.Add(matrizNombres[i, 0]);
                }
            }
        }

        private bool NombreExiste(string nombre)
        {
            for (int i = 0; i < index; i++)
            {
                if (matrizNombres[i, 0].Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // Validacion solo letras y espacios
            string text = txtNombre.Text;
            foreach (char c in text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("Solo se permiten letras y espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Select(txtNombre.Text.Length, 0); // Coloca el cursor al final
                    break;
                }
            }
        }
    }
}