using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia6Ejercicio1

    
{
    public partial class Form1 : Form


    {
        // Declarar a nivel de clase
        List<clsDoctor> doctores = new List<clsDoctor>();
        List<clsVendedor> vendedores = new List<clsVendedor>();

        // Cuadro de diálogo para seleccionar archivos (fotos)
        OpenFileDialog cuadroSeleccion = new OpenFileDialog();


        public Form1() //constructor de clase Form1
        {


           

            InitializeComponent();

            
        }
        private void llenarcombobox()
        {
            int c; // Contador

            // Llenar los ComboBox de día
            for (c = 1; c <= 31; c++)
                cmbDia.Items.Add(c);
            cmbDia.Text = DateTime.Now.Day.ToString();

            // Llenar los ComboBox de mes
            for (c = 1; c <= 12; c++)
                cmbMes.Items.Add(c);
            cmbMes.Text = DateTime.Now.Month.ToString();

            // Llenar los ComboBox de año
            for (c = 1950; c <= DateTime.Now.Year; c++)
                cmbAnno.Items.Add(c);
            cmbAnno.Text = DateTime.Now.Year.ToString();
        }

        private void PrepararNuevoDoctor()
        {
            // Reiniciar los controles del formulario para el ingreso de un nuevo doctor
            txtNom.Clear();
            picFotoDoc.ImageLocation = Application.StartupPath + "\\Desconocido.jpg";
            cmbDia.SelectedIndex = 0;
            cmbMes.SelectedIndex = 0;
            cmbAnno.SelectedIndex = 0;
            nudSueldo.Value = 1.00M;
            mtbCodDoctor.Clear();
            txtNom.Focus();
        }

        private void PrepararNuevoVendedor()
        {
            // Reiniciar los controles del formulario para el ingreso de un nuevo vendedor
            txtNomV.Clear();
            picFotoVen.ImageLocation = Application.StartupPath + "\\Desconocido.jpg";
            dtpFechaNac.Value = DateTime.Now;
            dtpFechaC.Value = DateTime.Now;
            txtNomV.Focus();
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarDoc_Click(object sender, EventArgs e)
        {
            clsDoctor doctor = new clsDoctor(); // Crear un nuevo objeto Doctor

            // Asignar los valores de los controles al objeto Doctor
            doctor.nombreempleado = txtNom.Text;
            doctor.asignarfechanac(cmbAnno.Text, cmbMes.Text, cmbDia.Text);
            doctor.sueldobase = Convert.ToSingle(nudSueldo.Value);
            doctor.codigodoctor = mtbCodDoctor.Text;

            // Asignar la URL de la foto seleccionada
            doctor.URLfoto = picFotoDoc.ImageLocation;

            // Verificar si los datos del doctor son correctos
            if (doctor.DatossonCorrectos())
            {
                doctores.Add(doctor); // Agregar el doctor a la lista
                MessageBox.Show("Doctor " + doctor.nombreempleado + " agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PrepararNuevoDoctor(); // Preparar los controles para un nuevo doctor
            }
            else
            {
                MessageBox.Show("Datos incompletos");
            }
        }

        private void btnAgregarVen_Click(object sender, EventArgs e)
        {
            clsVendedor vendedor = new clsVendedor(); // Crear un nuevo objeto Vendedor

            // Asignar los valores de los controles al objeto Vendedor
            vendedor.nombreempleado = txtNomV.Text;
            vendedor.sueldobase = 2000; // Sueldo fijo de 2000 para vendedores
            vendedor.asignarfechanac(dtpFechaNac.Value);
            vendedor.FechaContrato = dtpFechaC.Value;

            // Asignar la URL de la foto seleccionada
            vendedor.URLfoto = picFotoVen.ImageLocation;

            // Agregar el vendedor a la lista
            vendedores.Add(vendedor);

            // Preparar los controles para un nuevo vendedor
            PrepararNuevoVendedor();
        }

        private void MostrarLista_Doctores()
        {
            int cm = 0;
            dataGridView1.Rows.Clear(); // Limpiar la tabla
            dataGridView1.Columns[4].HeaderText = "Código Médico"; // Ajustar el encabezado

            // Recorrer la lista de doctores y agregarlos al DataGridView
            foreach (clsDoctor doctor in doctores)
            {
                dataGridView1.Rows.Add(++cm, doctor.nombreempleado, doctor.URLfoto, doctor.fecha_nacimiento, doctor.codigodoctor);
            }
        }
        private void MostrarLista_Vendedores()
        {
            int cm = 0;
            dataGridView1.Rows.Clear(); // Limpiar la tabla
            dataGridView1.Columns[4].HeaderText = "Fecha Contratación"; // Ajustar el encabezado

            // Recorrer la lista de vendedores y agregarlos al DataGridView
            foreach (clsVendedor vendedor in vendedores)
            {
                dataGridView1.Rows.Add(++cm, vendedor.nombreempleado, vendedor.URLfoto, vendedor.fecha_nacimiento, vendedor.FechaContrato);
            }
        }

        private void rbDoctores_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDoctores.Checked)
                MostrarLista_Doctores(); // Mostrar la lista de doctores
        }

        private void rbVendedores_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVendedores.Checked)
                MostrarLista_Vendedores(); // Mostrar la lista de vendedores
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarcombobox(); // Llenar los combos de fecha
            doctores = new List<clsDoctor>();
            vendedores = new List<clsVendedor>();

            cuadroSeleccion.Filter = "Imágenes JPG|*.jpg"; // Configurar el cuadro de selección de archivos

            PrepararNuevoDoctor(); // Preparar los controles para ingresar un nuevo doctor
            PrepararNuevoVendedor(); // Preparar los controles para ingresar un nuevo vendedor
        }
    }
}
