namespace Ejercicios
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMayorNegativo = new System.Windows.Forms.TextBox();
            this.textCantidadPositivos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPromedioNegativos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPositivos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNegativos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textCeros = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un número: ";
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(176, 40);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(100, 20);
            this.textNumero.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mayor Negativo:";
            // 
            // textMayorNegativo
            // 
            this.textMayorNegativo.Enabled = false;
            this.textMayorNegativo.Location = new System.Drawing.Point(152, 112);
            this.textMayorNegativo.Name = "textMayorNegativo";
            this.textMayorNegativo.Size = new System.Drawing.Size(100, 20);
            this.textMayorNegativo.TabIndex = 3;
            // 
            // textCantidadPositivos
            // 
            this.textCantidadPositivos.Enabled = false;
            this.textCantidadPositivos.Location = new System.Drawing.Point(224, 144);
            this.textCantidadPositivos.Name = "textCantidadPositivos";
            this.textCantidadPositivos.Size = new System.Drawing.Size(100, 20);
            this.textCantidadPositivos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad de Números Positivos:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textPromedioNegativos
            // 
            this.textPromedioNegativos.Enabled = false;
            this.textPromedioNegativos.Location = new System.Drawing.Point(172, 178);
            this.textPromedioNegativos.Name = "textPromedioNegativos";
            this.textPromedioNegativos.Size = new System.Drawing.Size(100, 20);
            this.textPromedioNegativos.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Promedio Negativos:";
            // 
            // textPositivos
            // 
            this.textPositivos.Enabled = false;
            this.textPositivos.Location = new System.Drawing.Point(114, 283);
            this.textPositivos.Name = "textPositivos";
            this.textPositivos.Size = new System.Drawing.Size(100, 20);
            this.textPositivos.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Positivos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textNegativos
            // 
            this.textNegativos.Enabled = false;
            this.textNegativos.Location = new System.Drawing.Point(118, 320);
            this.textNegativos.Name = "textNegativos";
            this.textNegativos.Size = new System.Drawing.Size(100, 20);
            this.textNegativos.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Negativos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Porcentajes";
            // 
            // textCeros
            // 
            this.textCeros.Enabled = false;
            this.textCeros.Location = new System.Drawing.Point(118, 356);
            this.textCeros.Name = "textCeros";
            this.textCeros.Size = new System.Drawing.Size(100, 20);
            this.textCeros.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ceros";
            // 
            // botonCalcular
            // 
            this.botonCalcular.Location = new System.Drawing.Point(37, 406);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(75, 23);
            this.botonCalcular.TabIndex = 15;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(177, 406);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 16;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(319, 406);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 17;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 464);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.textCeros);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textNegativos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPositivos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textPromedioNegativos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCantidadPositivos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textMayorNegativo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMayorNegativo;
        private System.Windows.Forms.TextBox textCantidadPositivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPromedioNegativos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPositivos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNegativos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCeros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonSalir;
    }
}