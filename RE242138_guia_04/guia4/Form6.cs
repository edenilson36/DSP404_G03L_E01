using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace guia4
{
    public partial class frmGuia04ejerc4 : Form
    {
        public frmGuia04ejerc4()
        {
            InitializeComponent();
        }

       

        private void Form6_Load(object sender, EventArgs e)
        {
            txtusuario.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar(txtusuario.Text, txtpwd.Text))
            {
                // Ocultamos el Form1 si las credenciales son correctas
                this.Hide();
            }
            else
            {
                // Si las credenciales no son correctas, no se hace nada (el mensaje de error ya se mostró en validar())
            }
        }

        private Boolean validar(string nombre, string pwd)
        {
            string clave = "usuario"; // Nombre de usuario correcto
            string pasword = "contraseña123"; // Contraseña correcta

            // Validar si los campos están vacíos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(pwd))
            {
                MessageBox.Show("Por favor, ingrese ambos campos (usuario y contraseña).", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            DialogResult respuesta; // Variable para capturar la respuesta del MessageBox

            if (nombre == clave && pwd == pasword)
            {
                // Credenciales correctas
                respuesta = MessageBox.Show("Bienvenido " + nombre, "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (respuesta == DialogResult.OK)
                {
                    // Mostrar el Form5
                    frmGuia04ejerc4 formulario2 = new frmGuia04ejerc4(); // Instanciamos Form5
                    formulario2.Show(); // Mostramos el Form5
                    return true;
                }
            }
            else
            {
                // Credenciales incorrectas
                MessageBox.Show("Contraseña incorrecta.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpwd.Focus(); // Enfocamos el campo de la contraseña para que el usuario ingrese nuevamente
            }
            return false;
        }

        // Evento Load del Form1
        private void Form1_Load(object sender, EventArgs e)
        {
            txtusuario.Focus(); // Enfocar en el campo de usuario al cargar el formulario
        }

        // Evento Click del botón Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar(txtusuario.Text, txtpwd.Text))
            {
                // Ocultamos el Form1 si las credenciales son correctas
                this.Hide();
            }
            else
            {
                // Si las credenciales no son correctas, no se hace nada (el mensaje de error ya se mostró en validar())
            }
        }
    }
}
