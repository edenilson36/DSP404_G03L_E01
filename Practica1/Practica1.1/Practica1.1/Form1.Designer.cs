namespace Practica1._1
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
            this.lblApe1 = new System.Windows.Forms.Label();
            this.lblApe2 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCUM = new System.Windows.Forms.Label();
            this.txtApe1 = new System.Windows.Forms.TextBox();
            this.txtApe2 = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCUM = new System.Windows.Forms.TextBox();
            this.txtResul = new System.Windows.Forms.TextBox();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApe1
            // 
            this.lblApe1.AutoSize = true;
            this.lblApe1.Location = new System.Drawing.Point(36, 30);
            this.lblApe1.Name = "lblApe1";
            this.lblApe1.Size = new System.Drawing.Size(82, 16);
            this.lblApe1.TabIndex = 0;
            this.lblApe1.Text = "1er Apellido:";
            // 
            // lblApe2
            // 
            this.lblApe2.AutoSize = true;
            this.lblApe2.Location = new System.Drawing.Point(36, 71);
            this.lblApe2.Name = "lblApe2";
            this.lblApe2.Size = new System.Drawing.Size(86, 16);
            this.lblApe2.TabIndex = 1;
            this.lblApe2.Text = "2do Apellido:";
            this.lblApe2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(36, 118);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(63, 16);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nombres";
            // 
            // lblCUM
            // 
            this.lblCUM.AutoSize = true;
            this.lblCUM.Location = new System.Drawing.Point(36, 162);
            this.lblCUM.Name = "lblCUM";
            this.lblCUM.Size = new System.Drawing.Size(91, 16);
            this.lblCUM.TabIndex = 3;
            this.lblCUM.Text = "Valor de CUM";
            // 
            // txtApe1
            // 
            this.txtApe1.Location = new System.Drawing.Point(165, 24);
            this.txtApe1.Name = "txtApe1";
            this.txtApe1.Size = new System.Drawing.Size(597, 22);
            this.txtApe1.TabIndex = 4;
            // 
            // txtApe2
            // 
            this.txtApe2.Location = new System.Drawing.Point(165, 65);
            this.txtApe2.Name = "txtApe2";
            this.txtApe2.Size = new System.Drawing.Size(597, 22);
            this.txtApe2.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(165, 112);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(597, 22);
            this.txtNom.TabIndex = 6;
            // 
            // txtCUM
            // 
            this.txtCUM.Location = new System.Drawing.Point(165, 156);
            this.txtCUM.Name = "txtCUM";
            this.txtCUM.Size = new System.Drawing.Size(597, 22);
            this.txtCUM.TabIndex = 7;
            this.txtCUM.Text = "0.0";
            // 
            // txtResul
            // 
            this.txtResul.Location = new System.Drawing.Point(39, 211);
            this.txtResul.Name = "txtResul";
            this.txtResul.Size = new System.Drawing.Size(723, 22);
            this.txtResul.TabIndex = 8;
            this.txtResul.Text = "Resultado de evaluacion";
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Location = new System.Drawing.Point(165, 324);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(146, 23);
            this.btnAnalisis.TabIndex = 9;
            this.btnAnalisis.Text = "Calcular UV";
            this.btnAnalisis.UseVisualStyleBackColor = true;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(484, 324);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(146, 23);
            this.btnFin.TabIndex = 10;
            this.btnFin.Text = "Salir del programa";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnAnalisis);
            this.Controls.Add(this.txtResul);
            this.Controls.Add(this.txtCUM);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtApe2);
            this.Controls.Add(this.txtApe1);
            this.Controls.Add(this.lblCUM);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblApe2);
            this.Controls.Add(this.lblApe1);
            this.Name = "Form1";
            this.Text = "Calculo UV a cursar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApe1;
        private System.Windows.Forms.Label lblApe2;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCUM;
        private System.Windows.Forms.TextBox txtApe1;
        private System.Windows.Forms.TextBox txtApe2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCUM;
        private System.Windows.Forms.TextBox txtResul;
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.Button btnFin;
    }
}

