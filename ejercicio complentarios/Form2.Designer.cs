namespace ejercicio_complentarios
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
            txtEntrada = new TextBox();
            lblResultado = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lstNumeros = new ListBox();
            lblInstrucciones = new Label();
            SuspendLayout();
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(362, 53);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(326, 23);
            txtEntrada.TabIndex = 0;
            txtEntrada.TextChanged += txtEntrada_TextChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 61);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(344, 15);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Mostrará el resultado del cálculo (promedio y desviación típica).";
            lblResultado.Click += lblResultado_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(31, 133);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(141, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "calculará el promedio";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(31, 174);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 284);
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
            lstNumeros.Location = new Point(6, 313);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(795, 139);
            lstNumeros.TabIndex = 5;
            lstNumeros.SelectedIndexChanged += lstNumeros_SelectedIndexChanged;
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.Location = new Point(12, 90);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(104, 15);
            lblInstrucciones.TabIndex = 6;
            lblInstrucciones.Text = "Ingrese 4 números";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInstrucciones);
            Controls.Add(lstNumeros);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            Controls.Add(txtEntrada);
            Name = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEntrada;
        private Label lblResultado;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private ListBox lstNumeros;
        private Label lblInstrucciones;
    }
}