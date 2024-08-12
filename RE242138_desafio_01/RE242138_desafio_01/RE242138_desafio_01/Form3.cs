

using System.Windows.Forms.DataVisualization.Charting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace RE242138_desafio_01
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void rtbSinopsisGoT_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblGeneroHP_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Limpiar series anteriores, si las hay
            chart1.Series.Clear();

            // Crear una nueva serie de columnas
            var series = new Series
            {
                Name = "Estadísticas",
                Color = System.Drawing.Color.SkyBlue,
                ChartType = SeriesChartType.Column // Tipo de gráfico: Columnas
            };

            // Añadir datos a la serie
            series.Points.Add(new DataPoint(0, 10) { AxisLabel = "Programas de Televisión" });
            series.Points.Add(new DataPoint(1, 15) { AxisLabel = "Libros de Lectura" });
            series.Points.Add(new DataPoint(2, 8) { AxisLabel = "Lenguajes de Programación" });

            // Agregar la serie al gráfico
            chart1.Series.Add(series);

            // Configurar los ejes
            chart1.ChartAreas[0].AxisX.Title = "Categorías";
            chart1.ChartAreas[0].AxisY.Title = "Cantidad";

            // Configurar el título del gráfico
            chart1.Titles.Clear();
            chart1.Titles.Add("Estadísticas de Contenidos");
        }

        private void plotView1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
