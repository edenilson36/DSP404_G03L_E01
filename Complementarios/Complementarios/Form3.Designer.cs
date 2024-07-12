namespace Complementarios
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
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.labelIngreso = new System.Windows.Forms.Label();
            this.labelNumeros = new System.Windows.Forms.Label();
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.labelOpcion = new System.Windows.Forms.Label();
            this.radioButtonOpcionA = new System.Windows.Forms.RadioButton();
            this.radioButtonOpcionB = new System.Windows.Forms.RadioButton();
            this.buttonMostrarResultados = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(161, 44);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero.TabIndex = 0;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(303, 41);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelIngreso
            // 
            this.labelIngreso.AutoSize = true;
            this.labelIngreso.Location = new System.Drawing.Point(45, 47);
            this.labelIngreso.Name = "labelIngreso";
            this.labelIngreso.Size = new System.Drawing.Size(95, 13);
            this.labelIngreso.TabIndex = 2;
            this.labelIngreso.Text = "Ingrese un número";
            // 
            // labelNumeros
            // 
            this.labelNumeros.AutoSize = true;
            this.labelNumeros.Location = new System.Drawing.Point(45, 111);
            this.labelNumeros.Name = "labelNumeros";
            this.labelNumeros.Size = new System.Drawing.Size(104, 13);
            this.labelNumeros.TabIndex = 3;
            this.labelNumeros.Text = "Numeros Ingresados";
            // 
            // listBoxNumeros
            // 
            this.listBoxNumeros.FormattingEnabled = true;
            this.listBoxNumeros.Location = new System.Drawing.Point(123, 139);
            this.listBoxNumeros.Name = "listBoxNumeros";
            this.listBoxNumeros.Size = new System.Drawing.Size(120, 95);
            this.listBoxNumeros.TabIndex = 4;
            // 
            // labelOpcion
            // 
            this.labelOpcion.AutoSize = true;
            this.labelOpcion.Location = new System.Drawing.Point(45, 272);
            this.labelOpcion.Name = "labelOpcion";
            this.labelOpcion.Size = new System.Drawing.Size(116, 13);
            this.labelOpcion.TabIndex = 5;
            this.labelOpcion.Text = "Seleccione una opcion";
            // 
            // radioButtonOpcionA
            // 
            this.radioButtonOpcionA.AutoSize = true;
            this.radioButtonOpcionA.Location = new System.Drawing.Point(48, 300);
            this.radioButtonOpcionA.Name = "radioButtonOpcionA";
            this.radioButtonOpcionA.Size = new System.Drawing.Size(317, 17);
            this.radioButtonOpcionA.TabIndex = 6;
            this.radioButtonOpcionA.TabStop = true;
            this.radioButtonOpcionA.Text = "A: Menor y Mayor de los negativos y promedio de los positivos";
            this.radioButtonOpcionA.UseVisualStyleBackColor = true;
            this.radioButtonOpcionA.CheckedChanged += new System.EventHandler(this.radioButtonOpcionA_CheckedChanged);
            // 
            // radioButtonOpcionB
            // 
            this.radioButtonOpcionB.AutoSize = true;
            this.radioButtonOpcionB.Location = new System.Drawing.Point(48, 334);
            this.radioButtonOpcionB.Name = "radioButtonOpcionB";
            this.radioButtonOpcionB.Size = new System.Drawing.Size(142, 17);
            this.radioButtonOpcionB.TabIndex = 7;
            this.radioButtonOpcionB.TabStop = true;
            this.radioButtonOpcionB.Text = "B: Media de toda la serie";
            this.radioButtonOpcionB.UseVisualStyleBackColor = true;
            this.radioButtonOpcionB.CheckedChanged += new System.EventHandler(this.radioButtonOpcionB_CheckedChanged);
            // 
            // buttonMostrarResultados
            // 
            this.buttonMostrarResultados.Location = new System.Drawing.Point(123, 368);
            this.buttonMostrarResultados.Name = "buttonMostrarResultados";
            this.buttonMostrarResultados.Size = new System.Drawing.Size(120, 23);
            this.buttonMostrarResultados.TabIndex = 8;
            this.buttonMostrarResultados.Text = "Mostrar Resultado";
            this.buttonMostrarResultados.UseVisualStyleBackColor = true;
            this.buttonMostrarResultados.Click += new System.EventHandler(this.buttonMostrarResultados_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(54, 416);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(61, 13);
            this.labelResultado.TabIndex = 9;
            this.labelResultado.Text = "Resultado: ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 513);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonMostrarResultados);
            this.Controls.Add(this.radioButtonOpcionB);
            this.Controls.Add(this.radioButtonOpcionA);
            this.Controls.Add(this.labelOpcion);
            this.Controls.Add(this.listBoxNumeros);
            this.Controls.Add(this.labelNumeros);
            this.Controls.Add(this.labelIngreso);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.textBoxNumero);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label labelIngreso;
        private System.Windows.Forms.Label labelNumeros;
        private System.Windows.Forms.ListBox listBoxNumeros;
        private System.Windows.Forms.Label labelOpcion;
        private System.Windows.Forms.RadioButton radioButtonOpcionA;
        private System.Windows.Forms.RadioButton radioButtonOpcionB;
        private System.Windows.Forms.Button buttonMostrarResultados;
        private System.Windows.Forms.Label labelResultado;
    }
}