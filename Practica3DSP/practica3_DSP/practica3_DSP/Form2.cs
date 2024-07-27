using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica3_DSP
{
    public partial class Form2 : Form
    {

        DataTable tabla;
            Usuario dato=new Usuario();

        public string Nombre{get; set; }

        public Form2()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
            Iniciar();
            Limpiar();
            Consultar(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Iniciar()
        {
           tabla = new DataTable();
            tabla.Columns.Add("nombre");
            dataGridView1.DataSource = tabla;
        }

        private void Guardar()
        {
            Usuario usario = new Usuario()
            {
                Nombre = txtNombre.Text
            };
            dato.Guardar(usario);
        }

        private void Consultar()
        {
            foreach(var item in dato.Consultar())
            {
                datoRow fila = tabla.NewRow();
                fila["nombre"] = item.Nombre;
                tabla.Rows.Add(fila);
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class Usuario
    {
        List<Usuario> lista = new List<Usuario>();

        String name="uno";
        
        public void Guardar(Usuario uno)
        {
            lista.Add(uno);
        }
        public List<Usuario> Consultar(){
            return lista;
        }
    }


}
