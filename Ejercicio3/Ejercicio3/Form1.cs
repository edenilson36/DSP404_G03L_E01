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
        private List<string> todasLasTareasPendientes = new List<string>();

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

            if (string.IsNullOrWhiteSpace(nombreTarea))
            {
                MessageBox.Show("Por favor ingrese un nombre para la tarea.");
                return;
            }

            if (char.IsDigit(nombreTarea[0]))
            {
                MessageBox.Show("El nombre de la tarea no puede comenzar con un número.");
                return;
            }

            string tarea = $"{nombreTarea} (Límite: {dtpFechaLimite.Value.ToShortDateString()})";
            lbTareasPendientes.Items.Add(tarea);
            todasLasTareasPendientes.Add(tarea); //almacena la tarea en la lista compelta

            txtNombreTarea.BackColor = SystemColors.Window;
            txtNombreTarea.Clear();
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (lbTareasPendientes.SelectedIndex != -1)
            {
                string tareaSeleccionada = lbTareasPendientes.SelectedItem.ToString();
                lbTareasPendientes.Items.Remove(tareaSeleccionada);
                todasLasTareasPendientes.Remove(tareaSeleccionada); //elimina lar tarea de la lista completa
            }
            else
            {
                MessageBox.Show("Seleccione una tarea para elimnar.");
            }
        }

        private void btnEditarTarea_Click(object sender, EventArgs e)
        {
            if (lbTareasPendientes.SelectedIndex != -1)
            {
                txtNombreTarea.BackColor = Color.Green;

                string selectedTask = lbTareasPendientes.SelectedItem.ToString();
                string[] parts = selectedTask.Split(new[] { " (Límite: " }, StringSplitOptions.None);
                txtNombreTarea.Text = parts[0];
                lbTareasPendientes.Items.Remove(selectedTask);
            }
            else
            {
                MessageBox.Show("Selccione una tarea para editar.");
            }
        }
    }
}
