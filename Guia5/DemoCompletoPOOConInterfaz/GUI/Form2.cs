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
    public partial class Form2 : Form
    {

        clsPlanilla planillaEPSON = new clsPlanilla();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                // Establece las fechas mínimas y máximas
                DateTime fecha = DateTime.Now;
                dtpFechaNac.MinDate = fecha.AddYears(-70);
                dtpFechaNac.MaxDate = fecha.AddYears(15);

                // Habilita los controles al cargar el formulario
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                btnNuevo.Enabled = true;
                btnAceptar.Enabled = true;
                btnGenerarPlanilla.Enabled = true;
                btnNuevo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se prepara a registrar un nuevo empleado
                clsEmpleado trabajador = new clsEmpleado();

                // Definir datos personales
                trabajador.DefinirDatosPersonales(txtNombres.Text, txtApellidos.Text, dtpFechaNac.Value);

                // Definir datos laborales
                trabajador.DefinirDatosLaborales(dtpFechaContrato.Value, Convert.ToDecimal(txtSueldoini.Text));

                // Asignar descuentos
                trabajador.AsignarDescuentos(Convert.ToDecimal(nudISSS.Text), Convert.ToDecimal(nudRenta.Text));

                // Agregar el empleado a la planilla
                planillaEPSON.RecibirEmpleado(trabajador);

                // Deshabilitar los controles hasta registrar un nuevo empleado
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                btnNuevo.Enabled = true;
                btnAceptar.Enabled = false;
                btnNuevo.Focus();

                MessageBox.Show("Empleado registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbrirPlanilla_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnGenerarPlanilla.Enabled = true;
            //Activa planilla actual, para que se agreguen los N empleados
            planillaEPSON.AbrirPlanilla(DateTime.Now, "Epson Internacional");
        }

        private void btnGenerarPlanilla_Click(object sender, EventArgs e)
        {
            try
            {
                var empleados = planillaEPSON.ObtenerListadoEmpleados();
                dataGridView1.Rows.Clear();

                foreach (var empleado in empleados)
                {
                    dataGridView1.Rows.Add(empleado.Item1, empleado.Item2, empleado.Item3, empleado.Item4);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //deja controles en blanco para un proximo empleado
            txtNombres.Clear();
            txtApellidos.Clear();
            txtSueldoini.Clear();
            nudISSS.Value = 0;
            nudRenta.Value = 0;
            dtpFechaContrato.Value = DateTime.Now;
            dtpFechaNac.Value = DateTime.Now;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            btnNuevo.Enabled = false;
            btnAceptar.Enabled = true;
            txtNombres.Focus();
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Acepta solo letras y el caracter de retroceso (backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceptara solo letras
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nudRenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceptara solo dígitos/numeros
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nudISSS_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceptara solo dígitos/numeros
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSueldoini_KeyPress(object sender, KeyPressEventArgs e)
        {
            //aceptara solo dígitos/numeros
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
