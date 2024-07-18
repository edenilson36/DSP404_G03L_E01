namespace ejercicio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResultado = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lstNumeros = new ListBox();
            lblInstrucciones = new Label();
            txtEntrada = new TextBox();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(23, 60);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(178, 15);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Mostrará el resultado del cálculo";
            lblResultado.Click += label1_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(23, 144);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(139, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "calculará el promedio";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(23, 200);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(23, 248);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.ItemHeight = 15;
            lstNumeros.Location = new Point(2, 343);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(786, 109);
            lstNumeros.TabIndex = 5;
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.Location = new Point(23, 89);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(104, 15);
            lblInstrucciones.TabIndex = 6;
            lblInstrucciones.Text = "Ingrese 4 números";
            lblInstrucciones.Click += lblInstrucciones_Click;
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(207, 60);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(317, 23);
            txtEntrada.TabIndex = 7;
            txtEntrada.TextChanged += txtEntrada_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEntrada);
            Controls.Add(lblInstrucciones);
            Controls.Add(lstNumeros);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblResultado;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private ListBox lstNumeros;
        private Label lblInstrucciones;
        private TextBox txtEntrada;
    }
}
