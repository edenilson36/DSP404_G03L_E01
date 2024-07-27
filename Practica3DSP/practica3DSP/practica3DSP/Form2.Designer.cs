namespace practica3DSP
{
    partial class Form2
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
            gbInformacon = new GroupBox();
            txtEdad = new TextBox();
            cbtipoinfo = new ComboBox();
            txtinfo = new TextBox();
            lbedad = new Label();
            Lbding_info = new Label();
            Lptipo_info = new Label();
            gbMatriz = new GroupBox();
            dgdatos = new DataGridView();
            gbMantenimiento = new GroupBox();
            button5 = new Button();
            btPromedio = new Button();
            btLimpiar = new Button();
            btMostrar = new Button();
            btAgregar = new Button();
            gbInformacon.SuspendLayout();
            gbMatriz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgdatos).BeginInit();
            gbMantenimiento.SuspendLayout();
            SuspendLayout();
            // 
            // gbInformacon
            // 
            gbInformacon.Controls.Add(txtEdad);
            gbInformacon.Controls.Add(cbtipoinfo);
            gbInformacon.Controls.Add(txtinfo);
            gbInformacon.Controls.Add(lbedad);
            gbInformacon.Controls.Add(Lbding_info);
            gbInformacon.Controls.Add(Lptipo_info);
            gbInformacon.Location = new Point(40, 43);
            gbInformacon.Name = "gbInformacon";
            gbInformacon.Size = new Size(346, 156);
            gbInformacon.TabIndex = 0;
            gbInformacon.TabStop = false;
            gbInformacon.Text = "Informacion";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(175, 107);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(143, 27);
            txtEdad.TabIndex = 0;
            txtEdad.TextChanged += txtEdad_TextChanged;
            // 
            // cbtipoinfo
            // 
            cbtipoinfo.FormattingEnabled = true;
            cbtipoinfo.Items.AddRange(new object[] { "Nombre", "Apellido" });
            cbtipoinfo.Location = new Point(175, 29);
            cbtipoinfo.Name = "cbtipoinfo";
            cbtipoinfo.Size = new Size(143, 28);
            cbtipoinfo.TabIndex = 1;
            // 
            // txtinfo
            // 
            txtinfo.Location = new Point(175, 68);
            txtinfo.Name = "txtinfo";
            txtinfo.Size = new Size(143, 27);
            txtinfo.TabIndex = 0;
            txtinfo.TextChanged += txtinfo_TextChanged;
            // 
            // lbedad
            // 
            lbedad.AutoSize = true;
            lbedad.Location = new Point(25, 104);
            lbedad.Name = "lbedad";
            lbedad.Size = new Size(43, 20);
            lbedad.TabIndex = 0;
            lbedad.Text = "Edad";
            // 
            // Lbding_info
            // 
            Lbding_info.AutoSize = true;
            Lbding_info.Location = new Point(25, 68);
            Lbding_info.Name = "Lbding_info";
            Lbding_info.Size = new Size(150, 20);
            Lbding_info.TabIndex = 0;
            Lbding_info.Text = "Digite la informacion";
            Lbding_info.Click += label2_Click;
            // 
            // Lptipo_info
            // 
            Lptipo_info.AutoSize = true;
            Lptipo_info.Location = new Point(25, 32);
            Lptipo_info.Name = "Lptipo_info";
            Lptipo_info.Size = new Size(144, 20);
            Lptipo_info.TabIndex = 0;
            Lptipo_info.Text = "Tipo de informacion";
            // 
            // gbMatriz
            // 
            gbMatriz.Controls.Add(dgdatos);
            gbMatriz.ForeColor = SystemColors.ActiveCaptionText;
            gbMatriz.Location = new Point(40, 234);
            gbMatriz.Name = "gbMatriz";
            gbMatriz.Size = new Size(720, 181);
            gbMatriz.TabIndex = 1;
            gbMatriz.TabStop = false;
            gbMatriz.Text = "Matriz";
            // 
            // dgdatos
            // 
            dgdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdatos.Location = new Point(25, 26);
            dgdatos.Name = "dgdatos";
            dgdatos.RowHeadersWidth = 51;
            dgdatos.Size = new Size(672, 131);
            dgdatos.TabIndex = 0;
            // 
            // gbMantenimiento
            // 
            gbMantenimiento.Controls.Add(button5);
            gbMantenimiento.Controls.Add(btPromedio);
            gbMantenimiento.Controls.Add(btLimpiar);
            gbMantenimiento.Controls.Add(btMostrar);
            gbMantenimiento.Controls.Add(btAgregar);
            gbMantenimiento.Location = new Point(417, 43);
            gbMantenimiento.Name = "gbMantenimiento";
            gbMantenimiento.Size = new Size(343, 156);
            gbMantenimiento.TabIndex = 2;
            gbMantenimiento.TabStop = false;
            gbMantenimiento.Text = "Mantenimientos";
            // 
            // button5
            // 
            button5.BackColor = Color.MistyRose;
            button5.Location = new Point(26, 107);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 0;
            button5.Text = "Salir";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btPromedio
            // 
            btPromedio.BackColor = Color.Yellow;
            btPromedio.Location = new Point(171, 68);
            btPromedio.Name = "btPromedio";
            btPromedio.Size = new Size(94, 29);
            btPromedio.TabIndex = 3;
            btPromedio.Text = "Promedio";
            btPromedio.UseVisualStyleBackColor = false;
            btPromedio.Click += btPromedio_Click;
            // 
            // btLimpiar
            // 
            btLimpiar.BackColor = Color.Salmon;
            btLimpiar.Location = new Point(26, 68);
            btLimpiar.Name = "btLimpiar";
            btLimpiar.Size = new Size(94, 29);
            btLimpiar.TabIndex = 2;
            btLimpiar.Text = "Limpiar matriz";
            btLimpiar.UseVisualStyleBackColor = false;
            btLimpiar.Click += btLimpiar_Click;
            // 
            // btMostrar
            // 
            btMostrar.BackColor = Color.PaleGreen;
            btMostrar.Location = new Point(171, 32);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(94, 29);
            btMostrar.TabIndex = 1;
            btMostrar.Text = "Mostrar Matriz";
            btMostrar.UseVisualStyleBackColor = false;
            btMostrar.Click += btMostrar_Click;
            // 
            // btAgregar
            // 
            btAgregar.BackColor = Color.Red;
            btAgregar.ForeColor = Color.Black;
            btAgregar.Location = new Point(26, 32);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(94, 29);
            btAgregar.TabIndex = 0;
            btAgregar.Text = "&Agregar";
            btAgregar.UseVisualStyleBackColor = false;
            btAgregar.Click += btAgregar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(gbMantenimiento);
            Controls.Add(gbMatriz);
            Controls.Add(gbInformacon);
            Name = "Form2";
            Text = "Formulario";
            Load += Form2_Load;
            gbInformacon.ResumeLayout(false);
            gbInformacon.PerformLayout();
            gbMatriz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgdatos).EndInit();
            gbMantenimiento.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbInformacon;
        private GroupBox gbMatriz;
        private GroupBox gbMantenimiento;
        private Label lbedad;
        private Label Lbding_info;
        private Label Lptipo_info;
        private ComboBox cbtipoinfo;
        private TextBox txtinfo;
        private TextBox txtEdad;
        private Button button5;
        private Button btPromedio;
        private Button btLimpiar;
        private Button btMostrar;
        private Button btAgregar;
        private DataGridView dgdatos;
    }
}