namespace Ejemplo1
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
            this.botoncontar = new System.Windows.Forms.Button();
            this.botonReinicio = new System.Windows.Forms.Button();
            this.botonfin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botoncontar
            // 
            this.botoncontar.Location = new System.Drawing.Point(86, 61);
            this.botoncontar.Name = "botoncontar";
            this.botoncontar.Size = new System.Drawing.Size(75, 23);
            this.botoncontar.TabIndex = 0;
            this.botoncontar.Text = "Contar";
            this.botoncontar.UseVisualStyleBackColor = true;
            this.botoncontar.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonReinicio
            // 
            this.botonReinicio.Location = new System.Drawing.Point(432, 61);
            this.botonReinicio.Name = "botonReinicio";
            this.botonReinicio.Size = new System.Drawing.Size(75, 23);
            this.botonReinicio.TabIndex = 1;
            this.botonReinicio.Text = "Reiniciar conteo";
            this.botonReinicio.UseVisualStyleBackColor = true;
            this.botonReinicio.Click += new System.EventHandler(this.botonReinicio_Click);
            // 
            // botonfin
            // 
            this.botonfin.Location = new System.Drawing.Point(432, 247);
            this.botonfin.Name = "botonfin";
            this.botonfin.Size = new System.Drawing.Size(75, 23);
            this.botonfin.TabIndex = 2;
            this.botonfin.Text = "Salir programa";
            this.botonfin.UseVisualStyleBackColor = true;
            this.botonfin.Click += new System.EventHandler(this.botonfin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonfin);
            this.Controls.Add(this.botonReinicio);
            this.Controls.Add(this.botoncontar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botoncontar;
        private System.Windows.Forms.Button botonReinicio;
        private System.Windows.Forms.Button botonfin;
        private System.Windows.Forms.Label label1;
    }
}

