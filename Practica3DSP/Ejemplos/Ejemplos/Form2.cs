using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplos
{
    public partial class Form2 : Form
    {
        // Declaración de matriz
        string[,] matriz = new string[3, 3];
        // Variables para movernos dentro de las posiciones de la matriz
        public int fila1, colum1, fila2, colum2, fila3, colum3, countergen, i;

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar cada posición de la matriz
            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    matriz[fila, col] = string.Empty;
                }
            }

            // Inicializar las variables filas y columnas a cero
            fila1 = colum1 = fila2 = colum2 = fila3 = colum3 = countergen = i = 0;

            // Limpiar la grilla
            dgdatos.Rows.Clear();
        }

        private void btPromedio_Click(object sender, EventArgs e)
        {
            // Variables para calcular el promedio
            int suma = 0;
            int contador = 0;

            // Recorrer la columna de edades (columna 2)
            for (int fila = 0; fila < 3; fila++)
            {
                if (IsNumeric(matriz[fila, 2]))
                {
                    suma += int.Parse(matriz[fila, 2]);
                    contador++;
                }
            }

            if (contador > 0)
            {
                double promedio = (double)suma / contador;
                MessageBox.Show($"El promedio de las edades es: {promedio:F2}");
            }
            else
            {
                MessageBox.Show("No hay datos de edades para calcular el promedio.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            // Limpiar grilla
            dgdatos.Columns.Clear();

            // Crear columnas
            dgdatos.ColumnCount = 3;
            dgdatos.Columns[0].Name = "Nombre";
            dgdatos.Columns[1].Name = "Apellido";
            dgdatos.Columns[2].Name = "Edad";

            // Agregar filas
            dgdatos.Rows.Add(3);

            // Agregar datos a la grilla
            for (int fila = 0; fila < 3; fila++)
            {
                dgdatos.Rows[fila].Cells[0].Value = matriz[fila, 0];
                dgdatos.Rows[fila].Cells[1].Value = matriz[fila, 1];
                dgdatos.Rows[fila].Cells[2].Value = matriz[fila, 2];
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            // Posiciones de la columna de la matriz
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
                        // Agregar el dato en la posición [fila1, colum1] de la matriz
                        matriz[fila1, colum1] = txtInfo.Text;
                        // Pasar a la siguiente fila de la matriz
                        fila1++;
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
                        // Agregar el dato en la posición [fila2, colum2] de la matriz
                        matriz[fila2, colum2] = txtInfo.Text;
                        // Pasar a la siguiente fila de la matriz
                        fila2++;
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
                    // Agregar el dato en la posición [fila3, colum3] de la matriz
                    matriz[fila3, colum3] = txtEdad.Text;
                    // Pasar a la siguiente fila de la matriz
                    fila3++;
                    MessageBox.Show("Edad ingresada exitosamente");
                    txtEdad.Clear();
                    countergen++;
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

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            // Validación solo números
            if (!IsNumeric(txtEdad.Text))
            {
                MessageBox.Show("Solo se permiten Números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEdad.Text = string.Empty;
            }
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {
            // Validación solo letras
            if (txtInfo.Text.Any(c => !char.IsLetter(c) && c != ' '))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtInfo.Text = string.Empty;
            }
        }

        public static bool IsNumeric(string valor)
        {
            // Determina si el parámetro valor puede convertirse a entero
            int result;
            return int.TryParse(valor, out result);
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
