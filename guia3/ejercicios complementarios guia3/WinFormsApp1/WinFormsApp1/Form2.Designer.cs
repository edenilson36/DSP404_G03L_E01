namespace WinFormsApp1
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
            txtDimension = new TextBox();
            btnGenerar = new Button();
            dgvMatrizOriginal = new DataGridView();
            btnSalir = new Button();
            dgvMatrizTraspuesta = new DataGridView();
            btnCalcularTraspuesta = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMatrizOriginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMatrizTraspuesta).BeginInit();
            SuspendLayout();
            // 
            // txtDimension
            // 
            txtDimension.Location = new Point(111, 48);
            txtDimension.Multiline = true;
            txtDimension.Name = "txtDimension";
            txtDimension.Size = new Size(190, 152);
            txtDimension.TabIndex = 0;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(162, 206);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(117, 23);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar Matriz";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dgvMatrizOriginal
            // 
            dgvMatrizOriginal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatrizOriginal.Location = new Point(162, 280);
            dgvMatrizOriginal.Name = "dgvMatrizOriginal";
            dgvMatrizOriginal.Size = new Size(240, 150);
            dgvMatrizOriginal.TabIndex = 2;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(64, 395);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvMatrizTraspuesta
            // 
            dgvMatrizTraspuesta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatrizTraspuesta.Location = new Point(493, 280);
            dgvMatrizTraspuesta.Name = "dgvMatrizTraspuesta";
            dgvMatrizTraspuesta.Size = new Size(240, 150);
            dgvMatrizTraspuesta.TabIndex = 6;
            dgvMatrizTraspuesta.CellContentClick += dgvMatrizTraspuesta_CellContentClick;
            // 
            // btnCalcularTraspuesta
            // 
            btnCalcularTraspuesta.Location = new Point(493, 206);
            btnCalcularTraspuesta.Name = "btnCalcularTraspuesta";
            btnCalcularTraspuesta.Size = new Size(136, 23);
            btnCalcularTraspuesta.TabIndex = 7;
            btnCalcularTraspuesta.Text = "Calcular Traspuesta";
            btnCalcularTraspuesta.UseVisualStyleBackColor = true;
            btnCalcularTraspuesta.Click += btnCalcularTraspuesta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 15);
            label1.TabIndex = 8;
            label1.Text = " ingresar la dimensión de la matriz ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnCalcularTraspuesta);
            Controls.Add(dgvMatrizTraspuesta);
            Controls.Add(btnSalir);
            Controls.Add(dgvMatrizOriginal);
            Controls.Add(btnGenerar);
            Controls.Add(txtDimension);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvMatrizOriginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMatrizTraspuesta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDimension;
        private Button btnGenerar;
        private DataGridView dgvMatrizOriginal;
        private Button btnSalir;
        private DataGridView dgvMatrizTraspuesta;
        private Button btnCalcularTraspuesta;
        private Label label1;
    }
}