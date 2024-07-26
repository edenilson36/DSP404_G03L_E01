namespace Ejemplos
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
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.cbtipoinfo = new System.Windows.Forms.ComboBox();
            this.lbedad = new System.Windows.Forms.Label();
            this.Lbdig_info = new System.Windows.Forms.Label();
            this.Lbtipo_info = new System.Windows.Forms.Label();
            this.gbMatriz = new System.Windows.Forms.GroupBox();
            this.dgdatos = new System.Windows.Forms.DataGridView();
            this.gbMantenimiento = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btPromedio = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.gbInformacion.SuspendLayout();
            this.gbMatriz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).BeginInit();
            this.gbMantenimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInformacion
            // 
            this.gbInformacion.Controls.Add(this.txtEdad);
            this.gbInformacion.Controls.Add(this.txtInfo);
            this.gbInformacion.Controls.Add(this.cbtipoinfo);
            this.gbInformacion.Controls.Add(this.lbedad);
            this.gbInformacion.Controls.Add(this.Lbdig_info);
            this.gbInformacion.Controls.Add(this.Lbtipo_info);
            this.gbInformacion.Location = new System.Drawing.Point(47, 45);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(259, 130);
            this.gbInformacion.TabIndex = 0;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Informacion";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(131, 84);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(64, 20);
            this.txtEdad.TabIndex = 5;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(131, 51);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(100, 20);
            this.txtInfo.TabIndex = 4;
            this.txtInfo.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // cbtipoinfo
            // 
            this.cbtipoinfo.FormattingEnabled = true;
            this.cbtipoinfo.Items.AddRange(new object[] {
            "Nombre",
            "Apellido"});
            this.cbtipoinfo.Location = new System.Drawing.Point(131, 26);
            this.cbtipoinfo.Name = "cbtipoinfo";
            this.cbtipoinfo.Size = new System.Drawing.Size(121, 21);
            this.cbtipoinfo.TabIndex = 3;
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Location = new System.Drawing.Point(23, 87);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(32, 13);
            this.lbedad.TabIndex = 2;
            this.lbedad.Text = "Edad";
            // 
            // Lbdig_info
            // 
            this.Lbdig_info.AutoSize = true;
            this.Lbdig_info.Location = new System.Drawing.Point(23, 53);
            this.Lbdig_info.Name = "Lbdig_info";
            this.Lbdig_info.Size = new System.Drawing.Size(102, 13);
            this.Lbdig_info.TabIndex = 1;
            this.Lbdig_info.Text = "Digite la información";
            // 
            // Lbtipo_info
            // 
            this.Lbtipo_info.AutoSize = true;
            this.Lbtipo_info.Location = new System.Drawing.Point(23, 26);
            this.Lbtipo_info.Name = "Lbtipo_info";
            this.Lbtipo_info.Size = new System.Drawing.Size(101, 13);
            this.Lbtipo_info.TabIndex = 0;
            this.Lbtipo_info.Text = "Tipo de Información";
            // 
            // gbMatriz
            // 
            this.gbMatriz.Controls.Add(this.dgdatos);
            this.gbMatriz.Location = new System.Drawing.Point(47, 214);
            this.gbMatriz.Name = "gbMatriz";
            this.gbMatriz.Size = new System.Drawing.Size(552, 200);
            this.gbMatriz.TabIndex = 1;
            this.gbMatriz.TabStop = false;
            this.gbMatriz.Text = "Matriz";
            // 
            // dgdatos
            // 
            this.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdatos.Location = new System.Drawing.Point(26, 31);
            this.dgdatos.Name = "dgdatos";
            this.dgdatos.Size = new System.Drawing.Size(513, 148);
            this.dgdatos.TabIndex = 0;
            // 
            // gbMantenimiento
            // 
            this.gbMantenimiento.Controls.Add(this.button5);
            this.gbMantenimiento.Controls.Add(this.btPromedio);
            this.gbMantenimiento.Controls.Add(this.btLimpiar);
            this.gbMantenimiento.Controls.Add(this.btMostrar);
            this.gbMantenimiento.Controls.Add(this.btAgregar);
            this.gbMantenimiento.Location = new System.Drawing.Point(369, 45);
            this.gbMantenimiento.Name = "gbMantenimiento";
            this.gbMantenimiento.Size = new System.Drawing.Size(248, 130);
            this.gbMantenimiento.TabIndex = 2;
            this.gbMantenimiento.TabStop = false;
            this.gbMantenimiento.Text = "Mantenimientos";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightPink;
            this.button5.Location = new System.Drawing.Point(16, 87);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btPromedio
            // 
            this.btPromedio.BackColor = System.Drawing.Color.Moccasin;
            this.btPromedio.Location = new System.Drawing.Point(133, 51);
            this.btPromedio.Name = "btPromedio";
            this.btPromedio.Size = new System.Drawing.Size(75, 23);
            this.btPromedio.TabIndex = 3;
            this.btPromedio.Text = "Promedio";
            this.btPromedio.UseVisualStyleBackColor = false;
            this.btPromedio.Click += new System.EventHandler(this.btPromedio_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.Color.LightSalmon;
            this.btLimpiar.Location = new System.Drawing.Point(16, 53);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(87, 23);
            this.btLimpiar.TabIndex = 2;
            this.btLimpiar.Text = "Limpíar Matriz";
            this.btLimpiar.UseVisualStyleBackColor = false;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btMostrar
            // 
            this.btMostrar.BackColor = System.Drawing.Color.PaleGreen;
            this.btMostrar.Location = new System.Drawing.Point(133, 21);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(91, 23);
            this.btMostrar.TabIndex = 1;
            this.btMostrar.Text = "Mostrar Matriz";
            this.btMostrar.UseVisualStyleBackColor = false;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.Tomato;
            this.btAgregar.Location = new System.Drawing.Point(16, 19);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "&Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.gbMantenimiento);
            this.Controls.Add(this.gbMatriz);
            this.Controls.Add(this.gbInformacion);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            this.gbMatriz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).EndInit();
            this.gbMantenimiento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.GroupBox gbMatriz;
        private System.Windows.Forms.GroupBox gbMantenimiento;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.ComboBox cbtipoinfo;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.Label Lbdig_info;
        private System.Windows.Forms.Label Lbtipo_info;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btPromedio;
        private System.Windows.Forms.DataGridView dgdatos;
    }
}