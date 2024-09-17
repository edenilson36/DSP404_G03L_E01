using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        private Venta venta = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void AsignarButton_Click(object sender, EventArgs e)
        {
            if (ClienteTextbox.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un cliente");
                ClienteTextbox.Focus();
                return;
            }

            venta = new Venta(ClienteTextbox.Text);
            detalleDataGridView.DataSource = venta.Productos;
        }

        private void detalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (venta == null)
            {
                MessageBox.Show("Debe asignar un cliente");
                ClienteTextbox.Focus();
                return;
            }

            if (IDTextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un ID");
                IDTextBox.Focus();
                return;
            }

            int id = 0;
            if (!int.TryParse(IDTextBox.Text, out id))
            {
                MessageBox.Show("Debe ingresar un ID numérico entero");
                IDTextBox.Focus();
                return;
            }

            if (id <= 0)
            {
                MessageBox.Show("Debe ingresar un ID mayor a cero");
                IDTextBox.Focus();
                return;
            }

            if (DescripcionTextBox1.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una Descripción");
                DescripcionTextBox1.Focus();
                return;
            }

            if (PrecioTextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un precio");
                PrecioTextBox.Focus();
                return;
            }

            decimal precio = 0;
            if (!decimal.TryParse(PrecioTextBox.Text, out precio))
            {
                MessageBox.Show("Debe ingresar un precio numérico");
                PrecioTextBox.Focus();
                return;
            }

            if (id <= 0)
            {
                MessageBox.Show("Debe ingresar un precio mayor a cero");
                PrecioTextBox.Focus();
                return;
            }

            if (CantidadTextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una cantidad");
                CantidadTextBox.Focus();
                return;
            }

            float cantidad = 0;
            if (!float.TryParse(CantidadTextBox.Text, out cantidad))
            {
                MessageBox.Show("Debe ingresar una cantidad numérica");
                CantidadTextBox.Focus();
                return;
            }

            if (id <= 0)
            {
                MessageBox.Show("Debe ingresar una cantidad mayor a cero");
                CantidadTextBox.Focus();
                return;
            }

            Producto producto = new Producto();
            producto.ID = id;
            producto.Descripcion = DescripcionTextBox1.Text;
            producto.Precio = precio;
            producto.Cantidad = cantidad;

            venta.AgregarProducto(producto);
            detalleDataGridView.DataSource = null;
            detalleDataGridView.DataSource = venta.Productos;
            IDTextBox.Text = string.Empty;
            DescripcionTextBox1.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
            CantidadTextBox.Text = string.Empty;
            IDTextBox.Focus();

        }

        private void PagarButton_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(this, string.Format("Su cuenta es: {0:C2}\n"
                + "¿Desea pagar? ",
                venta.Total()), "Pagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rta == DialogResult.No)
            {
                return; 
            }
            venta = null;
            ClienteTextbox.Text = string.Empty;
            ClienteTextbox.Focus();
            detalleDataGridView.DataSource = null;


        }
    }
}
