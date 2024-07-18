namespace Ejercicios
{
    partial class Form4
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
            this.textConvertir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboInicial = new System.Windows.Forms.ComboBox();
            this.comboFinal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor a Convertir";
            // 
            // textConvertir
            // 
            this.textConvertir.Location = new System.Drawing.Point(245, 85);
            this.textConvertir.Name = "textConvertir";
            this.textConvertir.Size = new System.Drawing.Size(100, 20);
            this.textConvertir.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Divisa Inicial";
            // 
            // comboInicial
            // 
            this.comboInicial.FormattingEnabled = true;
            this.comboInicial.Location = new System.Drawing.Point(245, 141);
            this.comboInicial.Name = "comboInicial";
            this.comboInicial.Size = new System.Drawing.Size(121, 21);
            this.comboInicial.TabIndex = 3;
            // 
            // comboFinal
            // 
            this.comboFinal.FormattingEnabled = true;
            this.comboFinal.Location = new System.Drawing.Point(245, 185);
            this.comboFinal.Name = "comboFinal";
            this.comboFinal.Size = new System.Drawing.Size(121, 21);
            this.comboFinal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Divisa Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resultado:";
            // 
            // textResultado
            // 
            this.textResultado.Enabled = false;
            this.textResultado.Location = new System.Drawing.Point(227, 253);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(100, 20);
            this.textResultado.TabIndex = 7;
            // 
            // botonCalcular
            // 
            this.botonCalcular.Location = new System.Drawing.Point(135, 354);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(75, 23);
            this.botonCalcular.TabIndex = 8;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(260, 354);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 9;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(385, 354);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 10;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboFinal);
            this.Controls.Add(this.comboInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textConvertir);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Conversor de Divisas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textConvertir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboInicial;
        private System.Windows.Forms.ComboBox comboFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonSalir;
    }
}