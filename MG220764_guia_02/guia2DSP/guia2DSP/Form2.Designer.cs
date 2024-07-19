namespace guia2
{
    partial class frmCesar
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
            lbltitulo = new Label();
            lbltexto = new Label();
            lblllave = new Label();
            txtTexto = new TextBox();
            grOpcion = new GroupBox();
            rdbDesencriptar = new RadioButton();
            rdbEncriptar = new RadioButton();
            txtResultado = new TextBox();
            lblresultado = new Label();
            btnEncriptar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtLlave = new TextBox();
            grOpcion.SuspendLayout();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Location = new Point(355, 34);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(181, 15);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Encriptamiento por código César";
            lbltitulo.Click += label1_Click;
            // 
            // lbltexto
            // 
            lbltexto.AutoSize = true;
            lbltexto.Location = new Point(56, 84);
            lbltexto.Name = "lbltexto";
            lbltexto.Size = new Size(96, 15);
            lbltexto.TabIndex = 1;
            lbltexto.Text = "Ingrese el texto a";
            lbltexto.Click += label2_Click;
            // 
            // lblllave
            // 
            lblllave.AutoSize = true;
            lblllave.Location = new Point(488, 69);
            lblllave.Name = "lblllave";
            lblllave.Size = new Size(175, 15);
            lblllave.TabIndex = 2;
            lblllave.Text = "Llave (Digite un número entero)";
            lblllave.Click += lblllave_Click;
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(52, 102);
            txtTexto.Multiline = true;
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(717, 66);
            txtTexto.TabIndex = 3;
            // 
            // grOpcion
            // 
            grOpcion.Controls.Add(rdbDesencriptar);
            grOpcion.Controls.Add(rdbEncriptar);
            grOpcion.Location = new Point(52, 174);
            grOpcion.Name = "grOpcion";
            grOpcion.Size = new Size(389, 66);
            grOpcion.TabIndex = 4;
            grOpcion.TabStop = false;
            grOpcion.Text = "Seleccione una opción ";
            grOpcion.Enter += groupBox1_Enter;
            // 
            // rdbDesencriptar
            // 
            rdbDesencriptar.AutoSize = true;
            rdbDesencriptar.Location = new Point(277, 31);
            rdbDesencriptar.Name = "rdbDesencriptar";
            rdbDesencriptar.Size = new Size(91, 19);
            rdbDesencriptar.TabIndex = 1;
            rdbDesencriptar.TabStop = true;
            rdbDesencriptar.Text = "Desencriptar";
            rdbDesencriptar.UseVisualStyleBackColor = true;
            rdbDesencriptar.CheckedChanged += rdbDesencriptar_CheckedChanged;
            // 
            // rdbEncriptar
            // 
            rdbEncriptar.AutoSize = true;
            rdbEncriptar.Checked = true;
            rdbEncriptar.Location = new Point(6, 31);
            rdbEncriptar.Name = "rdbEncriptar";
            rdbEncriptar.Size = new Size(72, 19);
            rdbEncriptar.TabIndex = 0;
            rdbEncriptar.TabStop = true;
            rdbEncriptar.Text = "Encriptar";
            rdbEncriptar.UseVisualStyleBackColor = true;
            rdbEncriptar.CheckedChanged += rdbEncriptar_CheckedChanged;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(34, 322);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(692, 116);
            txtResultado.TabIndex = 5;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(188, 295);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(38, 15);
            lblresultado.TabIndex = 6;
            lblresultado.Text = "label4";
            lblresultado.Click += label4_Click;
            // 
            // btnEncriptar
            // 
            btnEncriptar.Location = new Point(518, 174);
            btnEncriptar.Name = "btnEncriptar";
            btnEncriptar.Size = new Size(75, 23);
            btnEncriptar.TabIndex = 7;
            btnEncriptar.Text = "&Encriptar";
            btnEncriptar.UseVisualStyleBackColor = true;
            btnEncriptar.Click += btnEncriptar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(518, 217);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(518, 257);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtLlave
            // 
            txtLlave.Location = new Point(669, 61);
            txtLlave.Name = "txtLlave";
            txtLlave.Size = new Size(100, 23);
            txtLlave.TabIndex = 10;
            txtLlave.TextChanged += textBox3_TextChanged;
            // 
            // frmCesar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(txtLlave);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEncriptar);
            Controls.Add(lblresultado);
            Controls.Add(txtResultado);
            Controls.Add(grOpcion);
            Controls.Add(txtTexto);
            Controls.Add(lblllave);
            Controls.Add(lbltexto);
            Controls.Add(lbltitulo);
            Name = "frmCesar";
            Text = "Encriptador/Desencriptador de Código";
            Load += Form2_Load;
            grOpcion.ResumeLayout(false);
            grOpcion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private Label lbltexto;
        private Label lblllave;
        private TextBox txtTexto;
        private GroupBox grOpcion;
        private TextBox txtResultado;
        private Label lblresultado;
        private Button btnEncriptar;
        private Button btnLimpiar;
        private Button btnSalir;
        private TextBox txtLlave;
        private RadioButton rdbDesencriptar;
        private RadioButton rdbEncriptar;
    }
}