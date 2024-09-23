using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guia4
{
    public partial class frmGuia04ejerc2 : Form
    {
        public frmGuia04ejerc2()
        {
            InitializeComponent();
            int contaventas;
        }
        public void inicializarControles()
        {
            // Código para inicializar controles si es necesario
        }


        private int contadorVentas = 0;


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmGuia04ejerc2_Load(object sender, EventArgs e)
        {
            // Configura los controles iniciales del formulario
            tabControl1.TabPages[0].Text = "Ventas efectuadas";
            tabControl1.TabPages[1].Text = "Estadísticas de venta";
            tabControl1.SelectedIndex = 0;

            // Configura el DataGridView
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns.Add("numeventa", "#");
            dataGridView1.Columns.Add("montoventa", "Monto ($)");
            dataGridView1.Columns.Add("fechaventa", "Fecha Venta");
            dataGridView1.Columns.Add("Trime", "Trimestre (1-4)");

            // Configura el rango del DateTimePicker
            dateTimePicker1.MaxDate = new DateTime(2010, 12, 31);
            dateTimePicker1.MinDate = new DateTime(2010, 1, 1);
            dateTimePicker1.Value = new DateTime(2010, 1, 1);

            // Enfocar en el MaskedTextBox
            maskedTextBox1.Focus();
        }
        public void RegistrarVenta(decimal monto, DateTime fecha)
        {
            int trimestre = ObtenerTrimestre(fecha.Month);

            // Agregar una nueva fila al DataGridView
            dataGridView1.Rows.Add(contadorVentas + 1, monto, fecha.ToShortDateString(), trimestre);
            contadorVentas++;
        }
        private int ObtenerTrimestre(int mes)
        {
            // Determina el trimestre basado en el mes
            if (mes <= 3) return 1;   // Enero, Febrero, Marzo (1er trimestre)
            if (mes <= 6) return 2;   // Abril, Mayo, Junio (2do trimestre)
            if (mes <= 9) return 3;   // Julio, Agosto, Septiembre (3er trimestre)
            return 4;                 // Octubre, Noviembre, Diciembre (4to trimestre)
        }
        public void EvaluacionTrimestral()
        {
            decimal[] totalesTrimestre = new decimal[5]; // Array para almacenar totales de cada trimestre
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int trimestre = Convert.ToInt32(dataGridView1.Rows[i].Cells["Trime"].Value);
                decimal monto = Convert.ToDecimal(dataGridView1.Rows[i].Cells["montoventa"].Value);
                totalesTrimestre[trimestre] += monto; // Acumula el monto en el trimestre correspondiente
            }

           
        }
        private void ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                MessageBox.Show("Por favor, ingrese un monto válido.");
                maskedTextBox1.Focus();
                return;
            }

            decimal monto = Convert.ToDecimal(maskedTextBox1.Text);
            DateTime fecha = dateTimePicker1.Value;

            // Registrar la venta
            RegistrarVenta(monto, fecha);

            // Limpiar el campo para una nueva venta
            maskedTextBox1.Clear();
            maskedTextBox1.Focus();
        }


        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void btnVerResumen_Click(object sender, EventArgs e)
        {
            EvaluacionTrimestral();
            tabControl1.SelectedIndex = 1; // Cambia a la pestaña de estadísticas
            groupBox1.Enabled = false; // Deshabilitar los controles de venta
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
