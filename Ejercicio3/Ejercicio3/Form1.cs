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
        private List<string> todasLasTareasCompletadas = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class Tareas
        {
            public List<string> Pendientes { get; set; } = new List<string>();
            public List<string> Completadas { get; set; } = new List<string>();

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

        private void btnMarcarCompletada_Click(object sender, EventArgs e)
        {
            if (lbTareasPendientes.SelectedIndex != -1)
            {
                string tarea = lbTareasPendientes.SelectedItem.ToString();
                lbTareasPendientes.Items.Remove(tarea);
                todasLasTareasPendientes.Remove(tarea);
                lbTareasCompletadas.Items.Add(tarea);
                todasLasTareasCompletadas.Add(tarea);
            }
            else
            {
                MessageBox.Show("Seleccione una tarea para marcar como completada.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files|*.xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Tareas todasTareas = new Tareas
                    {
                        Pendientes = lbTareasPendientes.Items.Cast<string>().ToList(),
                        Completadas = lbTareasCompletadas.Items.Cast<string>().ToList()
                    };

                    System.Xml.Serialization.XmlSerializer writer = 
                        new System.Xml.Serialization.XmlSerializer(typeof(Tareas));
                    using (System.IO.FileStream file = System.IO.File.Create(saveFileDialog.FileName))
                    {
                        writer.Serialize(file, todasTareas);
                    }

                    MessageBox.Show("Tareas guardadas correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al guardar las tareas: {ex.Message}");
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.Xml.Serialization.XmlSerializer reader =
                        new System.Xml.Serialization.XmlSerializer(typeof(Tareas));
                    using (System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog.FileName))
                    {
                        Tareas todasTareas = (Tareas)reader.Deserialize(file);
                        lbTareasPendientes.Items.Clear();
                        lbTareasCompletadas.Items.Clear();
                        lbTareasPendientes.Items.AddRange(todasTareas.Pendientes.ToArray());
                        lbTareasCompletadas.Items.AddRange(todasTareas.Completadas.ToArray());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrio un error al cargar las tareaa: {ex.Message}");
                }
            }

        }

        private void btnFiltrarTareas_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            DateTime fechaLimite = hoy.AddDays(7); //7 dias

            var tareasFiltradas = todasLasTareasPendientes
                .Where(t => DateTime.Parse(t.Split(new[] { "(Límite: " }, StringSplitOptions.None)[1].Replace(")", "")) <= fechaLimite)
                .ToList();

            lbTareasPendientes.Items.Clear();
            lbTareasPendientes.Items.AddRange(tareasFiltradas.ToArray());
        }

        private void btnOrdenarPorNombre_Click(object sender, EventArgs e)
        {
            var tareasOrdenadas = lbTareasPendientes.Items.Cast<string>()
            .OrderBy(t => t.Split(new[] { " (Límite: " }, StringSplitOptions.None)[0])
            .ToList();

            lbTareasPendientes.Items.Clear();
            lbTareasPendientes.Items.AddRange(tareasOrdenadas.ToArray());
        }


        // Este es "Ordenar por Fecha Limite" (se me olvidó ponerle nombre al boton)
        private void button1_Click(object sender, EventArgs e)
        {
            var tareasOrdenadas = lbTareasPendientes.Items.Cast<string>()
            .OrderBy(t => DateTime.Parse(t.Split(new[] { "(Límite: " }, StringSplitOptions.None)[1].Replace(")", "")))
            .ToList();

            lbTareasPendientes.Items.Clear();
            lbTareasPendientes.Items.AddRange(tareasOrdenadas.ToArray());
        }
    }
}
