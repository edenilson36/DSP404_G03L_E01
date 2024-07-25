using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guia3
{
    public partial class Form2 : Form
    {
        string[,] matriz = new string[3, 3];

        // Variables para movernos dentro de las posiciones de la matriz
        public int fila1, colum1, fila2, colum2, fila3, colum3, countergen, i;
        public Form2()
        {
            InitializeComponent();
        }
        public static bool IsNumeric(string valor)
        {
            // Determina si el parámetro valor puede convertirse a entero
            int result;
            return int.TryParse(valor, out result);
        }
        private void txtInfo_TextChanged(object sender, EventArgs e)
        {
            // Validación para solo letras
            foreach (char c in txtInfo.Text)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtInfo.Text = string.Empty;
                    return;
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            {
                // Validación para solo números
                if (!IsNumeric(txtEdad.Text))
                {
                    MessageBox.Show("Solo se permiten Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEdad.Text = string.Empty;
                }
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            // Posiciones de las columnas de la matriz
            colum1 = 0;
            colum2 = 1;
            colum3 = 2;

            // Verificar combobox1
            if (cbtipoinfo.SelectedIndex == 0)
            {
                if (string.IsNullOrWhiteSpace(txtInfo.Text))
                {
                    txtInfo.BackColor = Color.Bisque;
                }
                else
                {
                    if (fila1 < 3)
                    {
                        // Agregamos el dato en la posición [fila1, colum1] de la matriz
                        matriz[fila1, colum1] = txtInfo.Text;
                        // Pasamos a la siguiente fila de la matriz
                        fila1 += 1;
                        MessageBox.Show("Nombre ingresado exitosamente", "", MessageBoxButtons.OK);
                        txtInfo.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pueden agregar más nombres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (cbtipoinfo.SelectedIndex == 1)
            {
                if (string.IsNullOrWhiteSpace(txtInfo.Text))
                {
                    txtInfo.BackColor = Color.Bisque;
                }
                else
                {
                    if (fila2 < 3)
                    {
                        // Agregamos el dato en la posición [fila2, colum2] de la matriz
                        matriz[fila2, colum2] = txtInfo.Text;
                        // Pasamos a la siguiente fila de la matriz
                        fila2 += 1;
                        MessageBox.Show("Apellido ingresado exitosamente");
                        txtInfo.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pueden agregar más apellidos");
                    }
                }
            }

            if (IsNumeric(txtEdad.Text))
            {
                if (fila3 < 3)
                {
                    // Agregamos el dato en la posición [fila3, colum3] de la matriz
                    matriz[fila3, colum3] = txtEdad.Text;
                    // Pasamos a la siguiente fila de la matriz
                    fila3 += 1;
                    MessageBox.Show("Edad ingresada exitosamente");
                    txtEdad.Clear();
                    countergen += 1;
                }
                else
                {
                    MessageBox.Show("No se pueden agregar más edades");
                }
            }
            else
            {
                txtEdad.BackColor = Color.Beige;
            }
        }
        private void btMostrar_Click(object sender, EventArgs e)
        {
            // Limpiando la grilla
            dgdatos.Columns.Clear();

            // Creando columnas
            dgdatos.ColumnCount = 3;
            dgdatos.Columns[0].Name = "Nombre";
            dgdatos.Columns[1].Name = "Apellido";
            dgdatos.Columns[2].Name = "Edad";

            // Agregar filas
            dgdatos.Rows.Add();
            dgdatos.Rows.Add();
            dgdatos.Rows.Add();

            // Agregar datos a la grilla
            // Mostrar nombres
            dgdatos.Rows[0].Cells[0].Value = matriz[0, 0];
            dgdatos.Rows[0].Cells[1].Value = matriz[0, 1];
            dgdatos.Rows[0].Cells[2].Value = matriz[0, 2];

            // Mostrar apellidos
            dgdatos.Rows[1].Cells[0].Value = matriz[1, 0];
            dgdatos.Rows[1].Cells[1].Value = matriz[1, 1];
            dgdatos.Rows[1].Cells[2].Value = matriz[1, 2];

            // Mostrar edades
            dgdatos.Rows[2].Cells[0].Value = matriz[2, 0];
            dgdatos.Rows[2].Cells[1].Value = matriz[2, 1];
            dgdatos.Rows[2].Cells[2].Value = matriz[2, 2];
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar cada posición de la matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = string.Empty;
                }
            }

            // Inicializar las variables de filas y columnas a cero
            fila1 = colum1 = fila2 = colum2 = fila3 = colum3 = countergen = i = 0;

            // Limpiar la grilla
            dgdatos.Columns.Clear();
        }

        private void btPromedio_Click(object sender, EventArgs e)
        {
            // Calcular el promedio de las edades guardadas en la matriz y mostrarlo en un MessageBox
            int sum = 0, count = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (IsNumeric(matriz[i, 2]))
                {
                    sum += int.Parse(matriz[i, 2]);
                    count++;
                }
            }
            double average = (double)sum / count;
            MessageBox.Show("El promedio de las edades es: " + average);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            this.Close();
        }
    }
}
