namespace Complementarios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.cbAño = new System.Windows.Forms.ComboBox();
            this.Confirmar = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(95, 136);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(121, 21);
            this.cbMes.TabIndex = 0;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // cbDia
            // 
            this.cbDia.FormattingEnabled = true;
            this.cbDia.Location = new System.Drawing.Point(236, 136);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(121, 21);
            this.cbDia.TabIndex = 1;
            // 
            // cbAño
            // 
            this.cbAño.FormattingEnabled = true;
            this.cbAño.Location = new System.Drawing.Point(381, 136);
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(121, 21);
            this.cbAño.TabIndex = 2;
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(230, 303);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(75, 23);
            this.Confirmar.TabIndex = 4;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click_1);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(134, 235);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(298, 20);
            this.txtFecha.TabIndex = 5;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(112, 121);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 6;
            this.lblMes.Text = "Mes";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(278, 120);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(23, 13);
            this.lblDia.TabIndex = 7;
            this.lblDia.Text = "Dia";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(434, 120);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 8;
            this.lblAño.Text = "Año";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(548, 443);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.cbAño);
            this.Controls.Add(this.cbDia);
            this.Controls.Add(this.cbMes);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDos;
        private System.Windows.Forms.TextBox txtTres;
        private System.Windows.Forms.TextBox txtCuatro;
        private System.Windows.Forms.TextBox txtCinco;
        private System.Windows.Forms.TextBox txtSeis;
        private System.Windows.Forms.TextBox txtSiete;
        private System.Windows.Forms.TextBox txtOcho;
        private System.Windows.Forms.TextBox txtNueve;
        private System.Windows.Forms.TextBox txtDiez;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.ComboBox Resultado;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.ComboBox cbAño;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblAño;
    }
}

