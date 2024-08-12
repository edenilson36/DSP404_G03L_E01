namespace RE242138_desafio_01
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            rtbSinopsisGoT = new RichTextBox();
            lblEpisodiosGoT = new Label();
            lblTemporadasGoT = new Label();
            lblPaisOrigenGoT = new Label();
            lblProtagonistasGoT = new Label();
            lblCreadorGoT = new Label();
            lblTituloEspanolGoT = new Label();
            lblTituloGoT = new Label();
            tabPage2 = new TabPage();
            rtbSinopsisHP = new RichTextBox();
            lblAntagonistasHP = new Label();
            lblProtagonistasHP = new Label();
            lblPaginasHP = new Label();
            lblSubgeneroHP = new Label();
            lblGeneroHP = new Label();
            lblAutorHP = new Label();
            lblTituloHP = new Label();
            tabPage3 = new TabPage();
            gbJava = new GroupBox();
            lblLicenciaJava = new Label();
            lblVersionJava = new Label();
            lblParadigmaJava = new Label();
            lblSOjava = new Label();
            lblAnoAparicionJava = new Label();
            lblExtensionesJava = new Label();
            lblDesarrolladoresJava = new Label();
            lblNombreJava = new Label();
            lblLicenciaPython = new Label();
            lblVersionPython = new Label();
            lblParadigmaPython = new Label();
            lblSOpython = new Label();
            lblAnoAparicionPython = new Label();
            lblExtensionesPython = new Label();
            lblDesarrolladoresPython = new Label();
            lblNombrePython = new Label();
            tabPage4 = new TabPage();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            gbJava.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(3, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(785, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(rtbSinopsisGoT);
            tabPage1.Controls.Add(lblEpisodiosGoT);
            tabPage1.Controls.Add(lblTemporadasGoT);
            tabPage1.Controls.Add(lblPaisOrigenGoT);
            tabPage1.Controls.Add(lblProtagonistasGoT);
            tabPage1.Controls.Add(lblCreadorGoT);
            tabPage1.Controls.Add(lblTituloEspanolGoT);
            tabPage1.Controls.Add(lblTituloGoT);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(777, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Programas de Televisión";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtbSinopsisGoT
            // 
            rtbSinopsisGoT.Location = new Point(124, 278);
            rtbSinopsisGoT.Name = "rtbSinopsisGoT";
            rtbSinopsisGoT.Size = new Size(638, 114);
            rtbSinopsisGoT.TabIndex = 7;
            rtbSinopsisGoT.Text = resources.GetString("rtbSinopsisGoT.Text");
            rtbSinopsisGoT.TextChanged += rtbSinopsisGoT_TextChanged;
            // 
            // lblEpisodiosGoT
            // 
            lblEpisodiosGoT.AutoSize = true;
            lblEpisodiosGoT.Location = new Point(19, 340);
            lblEpisodiosGoT.Name = "lblEpisodiosGoT";
            lblEpisodiosGoT.Size = new Size(75, 15);
            lblEpisodiosGoT.TabIndex = 6;
            lblEpisodiosGoT.Text = "Episodios: 73";
            // 
            // lblTemporadasGoT
            // 
            lblTemporadasGoT.AutoSize = true;
            lblTemporadasGoT.Location = new Point(22, 298);
            lblTemporadasGoT.Name = "lblTemporadasGoT";
            lblTemporadasGoT.Size = new Size(83, 15);
            lblTemporadasGoT.TabIndex = 5;
            lblTemporadasGoT.Text = "Temporadas: 8";
            // 
            // lblPaisOrigenGoT
            // 
            lblPaisOrigenGoT.AutoSize = true;
            lblPaisOrigenGoT.Location = new Point(22, 250);
            lblPaisOrigenGoT.Name = "lblPaisOrigenGoT";
            lblPaisOrigenGoT.Size = new Size(167, 15);
            lblPaisOrigenGoT.TabIndex = 4;
            lblPaisOrigenGoT.Text = "País de origen: Estados Unidos";
            // 
            // lblProtagonistasGoT
            // 
            lblProtagonistasGoT.AutoSize = true;
            lblProtagonistasGoT.Location = new Point(12, 200);
            lblProtagonistasGoT.Name = "lblProtagonistasGoT";
            lblProtagonistasGoT.Size = new Size(445, 15);
            lblProtagonistasGoT.TabIndex = 3;
            lblProtagonistasGoT.Text = "Protagonistas: Sean Bean, Nikolaj Coster-Waldau, Peter Dinklage, Emilia Clarke, etc.";
            // 
            // lblCreadorGoT
            // 
            lblCreadorGoT.AutoSize = true;
            lblCreadorGoT.Location = new Point(12, 142);
            lblCreadorGoT.Name = "lblCreadorGoT";
            lblCreadorGoT.Size = new Size(206, 15);
            lblCreadorGoT.TabIndex = 2;
            lblCreadorGoT.Text = "Creado por: David Benioff, D. B. Weiss";
            // 
            // lblTituloEspanolGoT
            // 
            lblTituloEspanolGoT.AutoSize = true;
            lblTituloEspanolGoT.Location = new Point(12, 79);
            lblTituloEspanolGoT.Name = "lblTituloEspanolGoT";
            lblTituloEspanolGoT.Size = new Size(188, 15);
            lblTituloEspanolGoT.TabIndex = 1;
            lblTituloEspanolGoT.Text = "Título en español: Juego de Tronos";
            // 
            // lblTituloGoT
            // 
            lblTituloGoT.AutoSize = true;
            lblTituloGoT.Location = new Point(12, 30);
            lblTituloGoT.Name = "lblTituloGoT";
            lblTituloGoT.Size = new Size(97, 15);
            lblTituloGoT.TabIndex = 0;
            lblTituloGoT.Text = "Game of Thrones";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(rtbSinopsisHP);
            tabPage2.Controls.Add(lblAntagonistasHP);
            tabPage2.Controls.Add(lblProtagonistasHP);
            tabPage2.Controls.Add(lblPaginasHP);
            tabPage2.Controls.Add(lblSubgeneroHP);
            tabPage2.Controls.Add(lblGeneroHP);
            tabPage2.Controls.Add(lblAutorHP);
            tabPage2.Controls.Add(lblTituloHP);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(777, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Libros de Lectura";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtbSinopsisHP
            // 
            rtbSinopsisHP.Location = new Point(3, 253);
            rtbSinopsisHP.Name = "rtbSinopsisHP";
            rtbSinopsisHP.Size = new Size(768, 139);
            rtbSinopsisHP.TabIndex = 7;
            rtbSinopsisHP.Text = resources.GetString("rtbSinopsisHP.Text");
            // 
            // lblAntagonistasHP
            // 
            lblAntagonistasHP.AutoSize = true;
            lblAntagonistasHP.Location = new Point(16, 198);
            lblAntagonistasHP.Name = "lblAntagonistasHP";
            lblAntagonistasHP.Size = new Size(228, 15);
            lblAntagonistasHP.TabIndex = 6;
            lblAntagonistasHP.Text = "Antagonistas: Lord Voldemort, Mortífagos";
            // 
            // lblProtagonistasHP
            // 
            lblProtagonistasHP.AutoSize = true;
            lblProtagonistasHP.Location = new Point(16, 163);
            lblProtagonistasHP.Name = "lblProtagonistasHP";
            lblProtagonistasHP.Size = new Size(431, 15);
            lblProtagonistasHP.TabIndex = 5;
            lblProtagonistasHP.Text = "Protagonistas: Harry Potter, Ron Weasley, Hermione Granger, Ginny Weasley, etc";
            // 
            // lblPaginasHP
            // 
            lblPaginasHP.AutoSize = true;
            lblPaginasHP.Location = new Point(16, 124);
            lblPaginasHP.Name = "lblPaginasHP";
            lblPaginasHP.Size = new Size(235, 15);
            lblPaginasHP.TabIndex = 4;
            lblPaginasHP.Text = "Número de páginas: 3407 (ENG), 3665 (ESP)";
            // 
            // lblSubgeneroHP
            // 
            lblSubgeneroHP.AutoSize = true;
            lblSubgeneroHP.Location = new Point(16, 92);
            lblSubgeneroHP.Name = "lblSubgeneroHP";
            lblSubgeneroHP.Size = new Size(327, 15);
            lblSubgeneroHP.TabIndex = 3;
            lblSubgeneroHP.Text = "Subgénero: Literatura fantástica, juvenil, novela de desarrollo";
            // 
            // lblGeneroHP
            // 
            lblGeneroHP.AutoSize = true;
            lblGeneroHP.Location = new Point(16, 55);
            lblGeneroHP.Name = "lblGeneroHP";
            lblGeneroHP.Size = new Size(88, 15);
            lblGeneroHP.TabIndex = 2;
            lblGeneroHP.Text = "Género: Novela";
            lblGeneroHP.Click += lblGeneroHP_Click;
            // 
            // lblAutorHP
            // 
            lblAutorHP.AutoSize = true;
            lblAutorHP.Location = new Point(16, 28);
            lblAutorHP.Name = "lblAutorHP";
            lblAutorHP.Size = new Size(109, 15);
            lblAutorHP.TabIndex = 1;
            lblAutorHP.Text = "Autor: J. K. Rowling";
            // 
            // lblTituloHP
            // 
            lblTituloHP.AutoSize = true;
            lblTituloHP.Location = new Point(325, 12);
            lblTituloHP.Name = "lblTituloHP";
            lblTituloHP.Size = new Size(71, 15);
            lblTituloHP.TabIndex = 0;
            lblTituloHP.Text = "Harry Potter";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(gbJava);
            tabPage3.Controls.Add(lblLicenciaPython);
            tabPage3.Controls.Add(lblVersionPython);
            tabPage3.Controls.Add(lblParadigmaPython);
            tabPage3.Controls.Add(lblSOpython);
            tabPage3.Controls.Add(lblAnoAparicionPython);
            tabPage3.Controls.Add(lblExtensionesPython);
            tabPage3.Controls.Add(lblDesarrolladoresPython);
            tabPage3.Controls.Add(lblNombrePython);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(777, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Lenguajes de Programación";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbJava
            // 
            gbJava.Controls.Add(lblLicenciaJava);
            gbJava.Controls.Add(lblVersionJava);
            gbJava.Controls.Add(lblParadigmaJava);
            gbJava.Controls.Add(lblSOjava);
            gbJava.Controls.Add(lblAnoAparicionJava);
            gbJava.Controls.Add(lblExtensionesJava);
            gbJava.Controls.Add(lblDesarrolladoresJava);
            gbJava.Controls.Add(lblNombreJava);
            gbJava.Location = new Point(432, 0);
            gbJava.Name = "gbJava";
            gbJava.Size = new Size(339, 395);
            gbJava.TabIndex = 8;
            gbJava.TabStop = false;
            gbJava.Text = "java";
            // 
            // lblLicenciaJava
            // 
            lblLicenciaJava.AutoSize = true;
            lblLicenciaJava.Location = new Point(8, 257);
            lblLicenciaJava.Name = "lblLicenciaJava";
            lblLicenciaJava.Size = new Size(248, 15);
            lblLicenciaJava.TabIndex = 7;
            lblLicenciaJava.Text = "Licencia: GNU GPL / Java Community Process";
            // 
            // lblVersionJava
            // 
            lblVersionJava.AutoSize = true;
            lblVersionJava.Location = new Point(18, 228);
            lblVersionJava.Name = "lblVersionJava";
            lblVersionJava.Size = new Size(156, 15);
            lblVersionJava.TabIndex = 6;
            lblVersionJava.Text = "Última Versión Estable: 14.01";
            // 
            // lblParadigmaJava
            // 
            lblParadigmaJava.AutoSize = true;
            lblParadigmaJava.Location = new Point(13, 192);
            lblParadigmaJava.Name = "lblParadigmaJava";
            lblParadigmaJava.Size = new Size(237, 15);
            lblParadigmaJava.TabIndex = 5;
            lblParadigmaJava.Text = "Paradigma: Orientado a objetos, imperativo";
            // 
            // lblSOjava
            // 
            lblSOjava.AutoSize = true;
            lblSOjava.Location = new Point(10, 152);
            lblSOjava.Name = "lblSOjava";
            lblSOjava.Size = new Size(195, 15);
            lblSOjava.TabIndex = 4;
            lblSOjava.Text = "Sistema Operativo: Multiplataforma";
            // 
            // lblAnoAparicionJava
            // 
            lblAnoAparicionJava.AutoSize = true;
            lblAnoAparicionJava.Location = new Point(9, 124);
            lblAnoAparicionJava.Name = "lblAnoAparicionJava";
            lblAnoAparicionJava.Size = new Size(129, 15);
            lblAnoAparicionJava.TabIndex = 3;
            lblAnoAparicionJava.Text = "Año de Aparición: 1996";
            // 
            // lblExtensionesJava
            // 
            lblExtensionesJava.AutoSize = true;
            lblExtensionesJava.Location = new Point(16, 92);
            lblExtensionesJava.Name = "lblExtensionesJava";
            lblExtensionesJava.Size = new Size(277, 15);
            lblExtensionesJava.TabIndex = 2;
            lblExtensionesJava.Text = "Extensiones de Archivo: .java, .class, .jar, .jad, .jmod";
            // 
            // lblDesarrolladoresJava
            // 
            lblDesarrolladoresJava.AutoSize = true;
            lblDesarrolladoresJava.Location = new Point(11, 57);
            lblDesarrolladoresJava.Name = "lblDesarrolladoresJava";
            lblDesarrolladoresJava.Size = new Size(277, 15);
            lblDesarrolladoresJava.TabIndex = 1;
            lblDesarrolladoresJava.Text = "Desarrolladores: James Gosling y Sun Microsystems";
            // 
            // lblNombreJava
            // 
            lblNombreJava.AutoSize = true;
            lblNombreJava.Location = new Point(6, 19);
            lblNombreJava.Name = "lblNombreJava";
            lblNombreJava.Size = new Size(28, 15);
            lblNombreJava.TabIndex = 0;
            lblNombreJava.Text = "java";
            // 
            // lblLicenciaPython
            // 
            lblLicenciaPython.AutoSize = true;
            lblLicenciaPython.Location = new Point(6, 229);
            lblLicenciaPython.Name = "lblLicenciaPython";
            lblLicenciaPython.Size = new Size(249, 15);
            lblLicenciaPython.TabIndex = 7;
            lblLicenciaPython.Text = "Licencia: Python Software Foundation License";
            // 
            // lblVersionPython
            // 
            lblVersionPython.AutoSize = true;
            lblVersionPython.Location = new Point(6, 200);
            lblVersionPython.Name = "lblVersionPython";
            lblVersionPython.Size = new Size(153, 15);
            lblVersionPython.TabIndex = 6;
            lblVersionPython.Text = "Última Versión Estable: 3.8.3";
            // 
            // lblParadigmaPython
            // 
            lblParadigmaPython.AutoSize = true;
            lblParadigmaPython.Location = new Point(3, 168);
            lblParadigmaPython.Name = "lblParadigmaPython";
            lblParadigmaPython.Size = new Size(433, 15);
            lblParadigmaPython.TabIndex = 5;
            lblParadigmaPython.Text = "Paradigma: Multiparadigma: orientado a objetos, imperativo, funcional, reflexivo";
            // 
            // lblSOpython
            // 
            lblSOpython.AutoSize = true;
            lblSOpython.Location = new Point(6, 141);
            lblSOpython.Name = "lblSOpython";
            lblSOpython.Size = new Size(195, 15);
            lblSOpython.TabIndex = 4;
            lblSOpython.Text = "Sistema Operativo: Multiplataforma";
            // 
            // lblAnoAparicionPython
            // 
            lblAnoAparicionPython.AutoSize = true;
            lblAnoAparicionPython.Location = new Point(6, 116);
            lblAnoAparicionPython.Name = "lblAnoAparicionPython";
            lblAnoAparicionPython.Size = new Size(129, 15);
            lblAnoAparicionPython.TabIndex = 3;
            lblAnoAparicionPython.Text = "Año de Aparición: 1991";
            // 
            // lblExtensionesPython
            // 
            lblExtensionesPython.AutoSize = true;
            lblExtensionesPython.Location = new Point(6, 89);
            lblExtensionesPython.Name = "lblExtensionesPython";
            lblExtensionesPython.Size = new Size(295, 15);
            lblExtensionesPython.TabIndex = 2;
            lblExtensionesPython.Text = "Extensiones de Archivo: .py, .pyc, .pyd, .pyo, .pyw, .pyz";
            // 
            // lblDesarrolladoresPython
            // 
            lblDesarrolladoresPython.AutoSize = true;
            lblDesarrolladoresPython.Location = new Point(6, 49);
            lblDesarrolladoresPython.Name = "lblDesarrolladoresPython";
            lblDesarrolladoresPython.Size = new Size(245, 15);
            lblDesarrolladoresPython.TabIndex = 1;
            lblDesarrolladoresPython.Text = "Desarrolladores: Python Software Foundation";
            // 
            // lblNombrePython
            // 
            lblNombrePython.AutoSize = true;
            lblNombrePython.Location = new Point(6, 17);
            lblNombrePython.Name = "lblNombrePython";
            lblNombrePython.Size = new Size(45, 15);
            lblNombrePython.TabIndex = 0;
            lblNombrePython.Text = "Python";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(chart1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(777, 398);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Gráficos";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(269, 61);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(300, 300);
            chart1.TabIndex = 0;
            chart1.Click += chart1_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "frmPrincipal";
            Text = "Estadisticas";
            Load += frmPrincipal_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            gbJava.ResumeLayout(false);
            gbJava.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label lblTituloGoT;
        private Label lblProtagonistasGoT;
        private Label lblCreadorGoT;
        private Label lblTituloEspanolGoT;
        private RichTextBox rtbSinopsisGoT;
        private Label lblEpisodiosGoT;
        private Label lblTemporadasGoT;
        private Label lblPaisOrigenGoT;
        private RichTextBox rtbSinopsisHP;
        private Label lblAntagonistasHP;
        private Label lblProtagonistasHP;
        private Label lblPaginasHP;
        private Label lblSubgeneroHP;
        private Label lblGeneroHP;
        private Label lblAutorHP;
        private Label lblTituloHP;
        private Label lblDesarrolladoresPython;
        private Label lblNombrePython;
        private Label lblLicenciaPython;
        private Label lblVersionPython;
        private Label lblParadigmaPython;
        private Label lblSOpython;
        private Label lblAnoAparicionPython;
        private Label lblExtensionesPython;
        private GroupBox gbJava;
        private Label lblNombreJava;
        private Label lblAnoAparicionJava;
        private Label lblExtensionesJava;
        private Label lblDesarrolladoresJava;
        private Label lblLicenciaJava;
        private Label lblVersionJava;
        private Label lblParadigmaJava;
        private Label lblSOjava;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}