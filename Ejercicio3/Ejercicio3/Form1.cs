using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            string nombreTarea = txtNombreTarea.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreTara))
            {
                MessageBox.Show("Por favor ingrese un nombre para la tarea.");
                return;
            }

            if (char.IsDigit(nombreTarea[0]))
            {
                MessageBox.Show("El nombre de la tarea no puede comenzar con un número.");
            }
        }
    }
}
