namespace Ejercicios
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
            this.IngreseNumero = new System.Windows.Forms.Label();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IngreseNumero
            // 
            this.IngreseNumero.AutoSize = true;
            this.IngreseNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngreseNumero.Location = new System.Drawing.Point(78, 65);
            this.IngreseNumero.Name = "IngreseNumero";
            this.IngreseNumero.Size = new System.Drawing.Size(103, 13);
            this.IngreseNumero.TabIndex = 0;
            this.IngreseNumero.Text = "Ingrese un Número: ";
            this.IngreseNumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(216, 62);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(100, 20);
            this.textNumero.TabIndex = 1;
            // 
            // botonCalcular
            // 
            this.botonCalcular.Location = new System.Drawing.Point(81, 130);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(75, 23);
            this.botonCalcular.TabIndex = 2;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(80, 177);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 3;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(80, 221);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 4;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(216, 121);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(120, 121);
            this.Lista.TabIndex = 5;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.Lista_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 338);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.IngreseNumero);
            this.Name = "Form1";
            this.Text = "Serie Fibonacci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IngreseNumero;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.ListBox Lista;
    }
}

