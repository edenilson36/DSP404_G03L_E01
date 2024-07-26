namespace Complementarios
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
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.labelPositivos = new System.Windows.Forms.Label();
            this.labelNegativos = new System.Windows.Forms.Label();
            this.listBoxPositivos = new System.Windows.Forms.ListBox();
            this.listBoxNegativos = new System.Windows.Forms.ListBox();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.labelMenorNegativo = new System.Windows.Forms.Label();
            this.labelPromedioPositivos = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(45, 12);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(87, 20);
            this.textBoxNumero.TabIndex = 0;
            this.textBoxNumero.TextChanged += new System.EventHandler(this.textBoxNumero_TextChanged);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(48, 56);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // labelPositivos
            // 
            this.labelPositivos.AutoSize = true;
            this.labelPositivos.Location = new System.Drawing.Point(74, 149);
            this.labelPositivos.Name = "labelPositivos";
            this.labelPositivos.Size = new System.Drawing.Size(49, 13);
            this.labelPositivos.TabIndex = 2;
            this.labelPositivos.Text = "Positivos";
            // 
            // labelNegativos
            // 
            this.labelNegativos.AutoSize = true;
            this.labelNegativos.Location = new System.Drawing.Point(365, 149);
            this.labelNegativos.Name = "labelNegativos";
            this.labelNegativos.Size = new System.Drawing.Size(55, 13);
            this.labelNegativos.TabIndex = 3;
            this.labelNegativos.Text = "Negativos";
            // 
            // listBoxPositivos
            // 
            this.listBoxPositivos.FormattingEnabled = true;
            this.listBoxPositivos.Location = new System.Drawing.Point(45, 179);
            this.listBoxPositivos.Name = "listBoxPositivos";
            this.listBoxPositivos.Size = new System.Drawing.Size(120, 95);
            this.listBoxPositivos.TabIndex = 4;
            // 
            // listBoxNegativos
            // 
            this.listBoxNegativos.FormattingEnabled = true;
            this.listBoxNegativos.Location = new System.Drawing.Point(333, 179);
            this.listBoxNegativos.Name = "listBoxNegativos";
            this.listBoxNegativos.Size = new System.Drawing.Size(120, 95);
            this.listBoxNegativos.TabIndex = 5;
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Location = new System.Drawing.Point(213, 290);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(75, 23);
            this.buttonFinalizar.TabIndex = 6;
            this.buttonFinalizar.Text = "Finalizar";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // labelMenorNegativo
            // 
            this.labelMenorNegativo.AutoSize = true;
            this.labelMenorNegativo.Location = new System.Drawing.Point(63, 348);
            this.labelMenorNegativo.Name = "labelMenorNegativo";
            this.labelMenorNegativo.Size = new System.Drawing.Size(35, 13);
            this.labelMenorNegativo.TabIndex = 7;
            this.labelMenorNegativo.Text = "label1";
            // 
            // labelPromedioPositivos
            // 
            this.labelPromedioPositivos.AutoSize = true;
            this.labelPromedioPositivos.Location = new System.Drawing.Point(63, 390);
            this.labelPromedioPositivos.Name = "labelPromedioPositivos";
            this.labelPromedioPositivos.Size = new System.Drawing.Size(35, 13);
            this.labelPromedioPositivos.TabIndex = 8;
            this.labelPromedioPositivos.Text = "label1";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(333, 380);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 9;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(444, 380);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 10;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.labelPromedioPositivos);
            this.Controls.Add(this.labelMenorNegativo);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.listBoxNegativos);
            this.Controls.Add(this.listBoxPositivos);
            this.Controls.Add(this.labelNegativos);
            this.Controls.Add(this.labelPositivos);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.textBoxNumero);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label labelPositivos;
        private System.Windows.Forms.Label labelNegativos;
        private System.Windows.Forms.ListBox listBoxPositivos;
        private System.Windows.Forms.ListBox listBoxNegativos;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.Label labelMenorNegativo;
        private System.Windows.Forms.Label labelPromedioPositivos;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonSalir;
    }
}