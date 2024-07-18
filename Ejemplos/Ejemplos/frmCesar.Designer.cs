namespace Ejemplos
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lbltexto = new System.Windows.Forms.Label();
            this.lblllave = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtLlave = new System.Windows.Forms.TextBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.grOpcion = new System.Windows.Forms.GroupBox();
            this.rdbEncriptar = new System.Windows.Forms.RadioButton();
            this.rdbDesencriptar = new System.Windows.Forms.RadioButton();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(211, 20);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(159, 13);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Encriptamiento por código cesar";
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Location = new System.Drawing.Point(25, 90);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(198, 13);
            this.lbltexto.TabIndex = 1;
            this.lbltexto.Text = "Ingrese el texto a Encriptar/Desencriptar";
            // 
            // lblllave
            // 
            this.lblllave.AutoSize = true;
            this.lblllave.Location = new System.Drawing.Point(355, 90);
            this.lblllave.Name = "lblllave";
            this.lblllave.Size = new System.Drawing.Size(155, 13);
            this.lblllave.TabIndex = 2;
            this.lblllave.Text = "Llave (Digite un número entero)";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(52, 360);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 3;
            this.lblresultado.Text = "Resultado";
            // 
            // txtLlave
            // 
            this.txtLlave.Location = new System.Drawing.Point(523, 83);
            this.txtLlave.Name = "txtLlave";
            this.txtLlave.Size = new System.Drawing.Size(100, 20);
            this.txtLlave.TabIndex = 4;
            this.txtLlave.TextChanged += new System.EventHandler(this.txtLlave_TextChanged);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(37, 109);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(575, 117);
            this.txtTexto.TabIndex = 5;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(35, 376);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(575, 117);
            this.txtResultado.TabIndex = 6;
            // 
            // grOpcion
            // 
            this.grOpcion.Controls.Add(this.rdbDesencriptar);
            this.grOpcion.Controls.Add(this.rdbEncriptar);
            this.grOpcion.Location = new System.Drawing.Point(55, 247);
            this.grOpcion.Name = "grOpcion";
            this.grOpcion.Size = new System.Drawing.Size(341, 100);
            this.grOpcion.TabIndex = 7;
            this.grOpcion.TabStop = false;
            this.grOpcion.Text = "Seleccione una opcion";
            // 
            // rdbEncriptar
            // 
            this.rdbEncriptar.AutoSize = true;
            this.rdbEncriptar.Checked = true;
            this.rdbEncriptar.Location = new System.Drawing.Point(22, 47);
            this.rdbEncriptar.Name = "rdbEncriptar";
            this.rdbEncriptar.Size = new System.Drawing.Size(67, 17);
            this.rdbEncriptar.TabIndex = 0;
            this.rdbEncriptar.TabStop = true;
            this.rdbEncriptar.Text = "Encriptar";
            this.rdbEncriptar.UseVisualStyleBackColor = true;
            this.rdbEncriptar.CheckedChanged += new System.EventHandler(this.rdbEncriptar_CheckedChanged);
            // 
            // rdbDesencriptar
            // 
            this.rdbDesencriptar.AutoSize = true;
            this.rdbDesencriptar.Location = new System.Drawing.Point(194, 47);
            this.rdbDesencriptar.Name = "rdbDesencriptar";
            this.rdbDesencriptar.Size = new System.Drawing.Size(85, 17);
            this.rdbDesencriptar.TabIndex = 1;
            this.rdbDesencriptar.Text = "Desencriptar";
            this.rdbDesencriptar.UseVisualStyleBackColor = true;
            this.rdbDesencriptar.CheckedChanged += new System.EventHandler(this.rdbDesencriptar_CheckedChanged);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(523, 247);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(75, 23);
            this.btnEncriptar.TabIndex = 8;
            this.btnEncriptar.Text = "&Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(523, 288);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(523, 324);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.grOpcion);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.txtLlave);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblllave);
            this.Controls.Add(this.lbltexto);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form2";
            this.Text = "Encriptador / Desencriptador de Código de César";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grOpcion.ResumeLayout(false);
            this.grOpcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lbltexto;
        private System.Windows.Forms.Label lblllave;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtLlave;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.GroupBox grOpcion;
        private System.Windows.Forms.RadioButton rdbEncriptar;
        private System.Windows.Forms.RadioButton rdbDesencriptar;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}