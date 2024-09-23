using BL;
using System.Data;

namespace GUI
{
    public partial class Form1 : Form
    {
        private Venta Venta;




        public Form1()
        {

            InitializeComponent();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            if (Venta == null)
            {
                MessageBox.Show("debe asignar un cliente ");
                clienteTexbox.Focus();
                return;
            }
            if (IDTexbox.Text == string.Empty)
            {
                MessageBox.Show("debe ingresar un ID ");
                IDTexbox.Focus();
                return;
            }

            int id = 0;
            if (!int.TryParse(IDTexbox.Text, out id))
            {
                MessageBox.Show("debe ingresar un ID numero entero ");
                IDTexbox.Focus();
                return;
            }

            if (id <= 0)
            {
                MessageBox.Show("debe ingresar un ID Mayor a 0 ");
                IDTexbox.Focus();
                return;
            }

            if (DescripcionTextBox.Text == string.Empty)
            {
                MessageBox.Show("debe ingresar una Descripcion ");
                DescripcionTextBox.Focus();
                return;
            }

            if (PrecioTextBox.Text == string.Empty)
            {

                MessageBox.Show("debe ingresar una Descripcion ");
                PrecioTextBox.Focus();
                return;
            }
            decimal precio = 0;
            if (!decimal.TryParse(PrecioTextBox.Text, out precio))
            {
                MessageBox.Show("debe ingresar un precio numerico ");
                PrecioTextBox.Focus();
                return;
            }
            if (precio <= 0)
            {
                MessageBox.Show("debe ingresar un precio mayor a 0 ");
                PrecioTextBox.Focus();
                return;
            }

            if (DescripcionTextBox.Text == string.Empty)
            {
                MessageBox.Show("debe ingresar una Descripcion ");
                DescripcionTextBox.Focus();
                return;
            }

            if (CantidadTextBox.Text == string.Empty)
            {

                MessageBox.Show("debe ingresar una cantidad ");
                CantidadTextBox.Focus();
                return;
            }
            float cantidad = 0;
            if (!float.TryParse(CantidadTextBox.Text, out cantidad))
            {
                MessageBox.Show("debe ingresar una cantidad numerica  ");
                CantidadTextBox.Focus();
                return;
            }
            if (cantidad <= 0)
            {
                MessageBox.Show("debe ingresar una cantidad mayor a 0 ");
                CantidadTextBox.Focus();
                return;
            }


            Producto producto = new Producto();
            producto.ID = id;
            producto.Descripocion = DescripcionTextBox.Text;
            producto.Precio = precio;
            producto.Cantidad = cantidad;
            Venta.agregarProducto(producto);
            detalleDataGridView.DataSource = null;
            detalleDataGridView.DataSource = Venta.Productos;
            DescripcionTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
            CantidadTextBox.Text = string.Empty;
            IDTexbox.Focus();
        }

        private void AsignarButton_Click(object sender, EventArgs e)
        {
            if (clienteTexbox.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un cliente");

                clienteTexbox.Focus();
                return;

            }
            Venta = new Venta(clienteTexbox.Text);
            detalleDataGridView.DataSource = Venta.Productos;
        }

        private void DescripcionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PagarButton_Click(object sender, EventArgs e)
        {
            if (Venta == null || Venta.Productos.Count == 0)
            {
                MessageBox.Show("No hay productos agregados a la venta.");
                return;
            }

            DialogResult rta = MessageBox.Show(this, string.Format("Su cuenta es: {0:C2}\n"
                 + "¿Desea pagar?",
                  Venta.Total()), "Pagar",
                   MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (rta == DialogResult.No)
            {
                return;
            }

            Venta = null;
            clienteTexbox.Text = string.Empty;
           clienteTexbox.Focus();
            detalleDataGridView.DataSource = null;

        }
    }
}
