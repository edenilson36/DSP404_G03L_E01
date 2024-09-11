using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Enfocamos el campo de usuario al cargar el formulario
            txtusuario.Focus();
        }

        // Método para validar las credenciales y los campos vacíos
        private Boolean validar(string nombre, string pwd)
        {
            string clave = "usuario";  // Nombre de usuario esperado
            string pasword = "usuario";  // Contraseña esperada
            DialogResult respuesta;

            // Validar si el campo de usuario está vacío
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El campo de usuario no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusuario.Focus();  // Enfocamos el campo de usuario
                return false;
            }

            // Validar si el campo de contraseña está vacío
            if (string.IsNullOrWhiteSpace(pwd))
            {
                MessageBox.Show("El campo de contraseña no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpwd.Focus();  // Enfocamos el campo de contraseña
                return false;
            }

            // Validamos si el usuario y la contraseña son correctos
            if (nombre == clave && pwd == pasword)
            {
                respuesta = MessageBox.Show("Bienvenido " + nombre, "Acceso",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                if (respuesta == DialogResult.OK)
                {
                    // Mostramos el nuevo Form (Form5)
                    Form5 formulario2 = new Form5(); // Instanciando el Form
                    formulario2.Show(); // Mostramos el Form5
                    return true;
                }
            }
            else
            {
                // Si la contraseña es incorrecta
                MessageBox.Show("Contraseña incorrecta", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpwd.Focus();  // Enfocamos el campo de contraseña para que el usuario lo intente nuevamente
            }
            return false;
        }

        // Evento del botón de Login donde se hacen las validaciones
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtusuario.Text;  // Nombre de usuario ingresado
            string pwd = txtpwd.Text;  // Contraseña ingresada

            // Llamar a la función de validación
            if (validar(nombre, pwd))
            {
                this.Hide();  // Ocultamos el formulario actual
            }
        }
    }
}
