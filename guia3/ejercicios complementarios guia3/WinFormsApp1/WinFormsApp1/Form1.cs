namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            // Añadir nombre a la lista
            string nombre = txtNombre.Text.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                lstNombres.Items.Add(nombre);
                txtNombre.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Borrar nombre seleccionado de la lista
            if (lstNombres.SelectedItem != null)
            {
                lstNombres.Items.Remove(lstNombres.SelectedItem);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un nombre para borrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Modificar nombre seleccionado
            if (lstNombres.SelectedItem != null)
            {
                string nuevoNombre = txtNombre.Text.Trim();
                if (!string.IsNullOrEmpty(nuevoNombre))
                {
                    int selectedIndex = lstNombres.SelectedIndex;
                    lstNombres.Items[selectedIndex] = nuevoNombre;
                    txtNombre.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un nuevo nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un nombre para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Salir de la aplicación
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
