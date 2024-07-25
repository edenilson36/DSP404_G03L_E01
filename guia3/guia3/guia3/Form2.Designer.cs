namespace guia3
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
            Lbtipo_info = new Label();
            Lbdig_info = new Label();
            lbedad = new Label();
            gbInformacon = new GroupBox();
            txtEdad = new TextBox();
            txtInfo = new TextBox();
            cbtipoinfo = new ComboBox();
            gbMantenimiento = new GroupBox();
            dgdatos = new DataGridView();
            gbMatriz = new GroupBox();
            Button5 = new Button();
            btPromedio = new Button();
            btLimpiar = new Button();
            btMostrar = new Button();
            btAgregar = new Button();
            gbInformacon.SuspendLayout();
            gbMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgdatos).BeginInit();
            gbMatriz.SuspendLayout();
            SuspendLayout();
            // 
            // Lbtipo_info
            // 
            Lbtipo_info.AutoSize = true;
            Lbtipo_info.Location = new Point(4, 16);
            Lbtipo_info.Margin = new Padding(2, 0, 2, 0);
            Lbtipo_info.Name = "Lbtipo_info";
            Lbtipo_info.Size = new Size(114, 15);
            Lbtipo_info.TabIndex = 0;
            Lbtipo_info.Text = "Tipo de información";
            Lbtipo_info.Click += label1_Click;
            // 
            // Lbdig_info
            // 
            Lbdig_info.AutoSize = true;
            Lbdig_info.Location = new Point(4, 42);
            Lbdig_info.Margin = new Padding(2, 0, 2, 0);
            Lbdig_info.Name = "Lbdig_info";
            Lbdig_info.Size = new Size(118, 15);
            Lbdig_info.TabIndex = 1;
            Lbdig_info.Text = "Digite la información";
            // 
            // lbedad
            // 
            lbedad.AutoSize = true;
            lbedad.Location = new Point(37, 67);
            lbedad.Margin = new Padding(2, 0, 2, 0);
            lbedad.Name = "lbedad";
            lbedad.Size = new Size(33, 15);
            lbedad.TabIndex = 2;
            lbedad.Text = "Edad";
            // 
            // gbInformacon
            // 
            gbInformacon.Controls.Add(txtEdad);
            gbInformacon.Controls.Add(txtInfo);
            gbInformacon.Controls.Add(cbtipoinfo);
            gbInformacon.Controls.Add(Lbtipo_info);
            gbInformacon.Controls.Add(lbedad);
            gbInformacon.Controls.Add(Lbdig_info);
            gbInformacon.Location = new Point(43, 16);
            gbInformacon.Margin = new Padding(2);
            gbInformacon.Name = "gbInformacon";
            gbInformacon.Padding = new Padding(2);
            gbInformacon.Size = new Size(283, 90);
            gbInformacon.TabIndex = 3;
            gbInformacon.TabStop = false;
            gbInformacon.Text = "Informacion";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(122, 67);
            txtEdad.Margin = new Padding(2);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(106, 23);
            txtEdad.TabIndex = 5;
            txtEdad.TextChanged += txtEdad_TextChanged;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(122, 39);
            txtInfo.Margin = new Padding(2);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(106, 23);
            txtInfo.TabIndex = 4;
            // 
            // cbtipoinfo
            // 
            cbtipoinfo.FormattingEnabled = true;
            cbtipoinfo.Items.AddRange(new object[] { "Nombre ", "Apellido" });
            cbtipoinfo.Location = new Point(122, 13);
            cbtipoinfo.Margin = new Padding(2);
            cbtipoinfo.Name = "cbtipoinfo";
            cbtipoinfo.Size = new Size(129, 23);
            cbtipoinfo.TabIndex = 3;
            // 
            // gbMantenimiento
            // 
            gbMantenimiento.Controls.Add(dgdatos);
            gbMantenimiento.Location = new Point(43, 175);
            gbMantenimiento.Margin = new Padding(2);
            gbMantenimiento.Name = "gbMantenimiento";
            gbMantenimiento.Padding = new Padding(2);
            gbMantenimiento.Size = new Size(635, 236);
            gbMantenimiento.TabIndex = 4;
            gbMantenimiento.TabStop = false;
            gbMantenimiento.Text = "Mantenimientos";
            // 
            // dgdatos
            // 
            dgdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdatos.Location = new Point(25, 43);
            dgdatos.Name = "dgdatos";
            dgdatos.Size = new Size(584, 150);
            dgdatos.TabIndex = 0;
            // 
            // gbMatriz
            // 
            gbMatriz.Controls.Add(Button5);
            gbMatriz.Controls.Add(btPromedio);
            gbMatriz.Controls.Add(btLimpiar);
            gbMatriz.Controls.Add(btMostrar);
            gbMatriz.Controls.Add(btAgregar);
            gbMatriz.Location = new Point(330, 15);
            gbMatriz.Margin = new Padding(2);
            gbMatriz.Name = "gbMatriz";
            gbMatriz.Padding = new Padding(2);
            gbMatriz.Size = new Size(348, 135);
            gbMatriz.TabIndex = 5;
            gbMatriz.TabStop = false;
            gbMatriz.Text = "Matriz";
            // 
            // Button5
            // 
            Button5.BackColor = Color.Yellow;
            Button5.Location = new Point(167, 68);
            Button5.Name = "Button5";
            Button5.Size = new Size(75, 23);
            Button5.TabIndex = 4;
            Button5.Text = "Salir";
            Button5.UseVisualStyleBackColor = false;
            Button5.Click += Button5_Click;
            // 
            // btPromedio
            // 
            btPromedio.BackColor = Color.Lime;
            btPromedio.Location = new Point(164, 28);
            btPromedio.Margin = new Padding(2);
            btPromedio.Name = "btPromedio";
            btPromedio.Size = new Size(78, 20);
            btPromedio.TabIndex = 3;
            btPromedio.Text = "Promedio";
            btPromedio.UseVisualStyleBackColor = false;
            btPromedio.Click += btPromedio_Click;
            // 
            // btLimpiar
            // 
            btLimpiar.BackColor = Color.FromArgb(255, 192, 192);
            btLimpiar.Location = new Point(46, 105);
            btLimpiar.Margin = new Padding(2);
            btLimpiar.Name = "btLimpiar";
            btLimpiar.Size = new Size(78, 20);
            btLimpiar.TabIndex = 2;
            btLimpiar.Text = "Limpiar Matriz";
            btLimpiar.UseVisualStyleBackColor = false;
            btLimpiar.Click += btLimpiar_Click;
            // 
            // btMostrar
            // 
            btMostrar.BackColor = Color.FromArgb(255, 128, 0);
            btMostrar.Location = new Point(46, 68);
            btMostrar.Margin = new Padding(2);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(78, 20);
            btMostrar.TabIndex = 1;
            btMostrar.Text = "Mostrar Matriz";
            btMostrar.UseVisualStyleBackColor = false;
            btMostrar.Click += btMostrar_Click;
            // 
            // btAgregar
            // 
            btAgregar.BackColor = Color.Red;
            btAgregar.Location = new Point(46, 28);
            btAgregar.Margin = new Padding(2);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(78, 20);
            btAgregar.TabIndex = 0;
            btAgregar.Text = "&Agregar";
            btAgregar.UseVisualStyleBackColor = false;
            btAgregar.Click += btAgregar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(732, 449);
            Controls.Add(gbMatriz);
            Controls.Add(gbMantenimiento);
            Controls.Add(gbInformacon);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Formulario";
            Load += Form2_Load;
            gbInformacon.ResumeLayout(false);
            gbInformacon.PerformLayout();
            gbMantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgdatos).EndInit();
            gbMatriz.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label Lbtipo_info;
        private Label Lbdig_info;
        private Label lbedad;
        private GroupBox gbInformacon;
        private TextBox txtEdad;
        private TextBox txtInfo;
        private ComboBox cbtipoinfo;
        private GroupBox gbMantenimiento;
        private GroupBox gbMatriz;
        private Button btLimpiar;
        private Button btMostrar;
        private Button btAgregar;
        private Button btPromedio;
        private DataGridView dgdatos;
        private Button Button5;
    }
}