namespace Ejercicios
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
            this.textNumero1 = new System.Windows.Forms.TextBox();
            this.textNumero2 = new System.Windows.Forms.TextBox();
            this.textNumero3 = new System.Windows.Forms.TextBox();
            this.textNumero4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textPromedio = new System.Windows.Forms.TextBox();
            this.textDesviacion = new System.Windows.Forms.TextBox();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNumero1
            // 
            this.textNumero1.Location = new System.Drawing.Point(102, 52);
            this.textNumero1.Name = "textNumero1";
            this.textNumero1.Size = new System.Drawing.Size(100, 20);
            this.textNumero1.TabIndex = 0;
            // 
            // textNumero2
            // 
            this.textNumero2.Location = new System.Drawing.Point(102, 96);
            this.textNumero2.Name = "textNumero2";
            this.textNumero2.Size = new System.Drawing.Size(100, 20);
            this.textNumero2.TabIndex = 1;
            // 
            // textNumero3
            // 
            this.textNumero3.Location = new System.Drawing.Point(102, 140);
            this.textNumero3.Name = "textNumero3";
            this.textNumero3.Size = new System.Drawing.Size(100, 20);
            this.textNumero3.TabIndex = 2;
            // 
            // textNumero4
            // 
            this.textNumero4.Location = new System.Drawing.Point(102, 186);
            this.textNumero4.Name = "textNumero4";
            this.textNumero4.Size = new System.Drawing.Size(100, 20);
            this.textNumero4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número 4:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Promedio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Desviacíon Típica:";
            // 
            // textPromedio
            // 
            this.textPromedio.Enabled = false;
            this.textPromedio.Location = new System.Drawing.Point(102, 294);
            this.textPromedio.Name = "textPromedio";
            this.textPromedio.Size = new System.Drawing.Size(100, 20);
            this.textPromedio.TabIndex = 10;
            // 
            // textDesviacion
            // 
            this.textDesviacion.Enabled = false;
            this.textDesviacion.Location = new System.Drawing.Point(362, 294);
            this.textDesviacion.Name = "textDesviacion";
            this.textDesviacion.Size = new System.Drawing.Size(100, 20);
            this.textDesviacion.TabIndex = 11;
            // 
            // botonCalcular
            // 
            this.botonCalcular.Location = new System.Drawing.Point(43, 360);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(75, 23);
            this.botonCalcular.TabIndex = 12;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(214, 360);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 13;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(387, 360);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 14;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.textDesviacion);
            this.Controls.Add(this.textPromedio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNumero4);
            this.Controls.Add(this.textNumero3);
            this.Controls.Add(this.textNumero2);
            this.Controls.Add(this.textNumero1);
            this.Name = "Form2";
            this.Text = "Desviacion Típica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumero1;
        private System.Windows.Forms.TextBox textNumero2;
        private System.Windows.Forms.TextBox textNumero3;
        private System.Windows.Forms.TextBox textNumero4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPromedio;
        private System.Windows.Forms.TextBox textDesviacion;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonSalir;
    }
}