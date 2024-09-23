namespace guia4
{
    partial class Form11
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
            txtNotas = new TextBox();
            label1 = new Label();
            btnProcesarNotas = new Button();
            lstResultados = new ListBox();
            SuspendLayout();
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(59, 107);
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(100, 23);
            txtNotas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 78);
            label1.Name = "label1";
            label1.Size = new Size(208, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese las notas separadas por comas";
            // 
            // btnProcesarNotas
            // 
            btnProcesarNotas.Location = new Point(59, 172);
            btnProcesarNotas.Name = "btnProcesarNotas";
            btnProcesarNotas.Size = new Size(100, 23);
            btnProcesarNotas.TabIndex = 2;
            btnProcesarNotas.Text = "Procesar Notas";
            btnProcesarNotas.UseVisualStyleBackColor = true;
            btnProcesarNotas.Click += btnProcesarNotas_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.ItemHeight = 15;
            lstResultados.Location = new Point(415, 90);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(120, 244);
            lstResultados.TabIndex = 3;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstResultados);
            Controls.Add(btnProcesarNotas);
            Controls.Add(label1);
            Controls.Add(txtNotas);
            Name = "Form11";
            Text = "Form11";
            Load += Form11_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNotas;
        private Label label1;
        private Button btnProcesarNotas;
        private ListBox lstResultados;
    }
}