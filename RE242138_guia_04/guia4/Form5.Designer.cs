namespace guia4
{
    partial class frmGuia04ejerc3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblResul = new Label();
            nudN1 = new NumericUpDown();
            nudN2 = new NumericUpDown();
            cmbOperaciones = new ComboBox();
            btnCalcular = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)nudN1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudN2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 60);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero Uno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 114);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero Dos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(528, 60);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // lblResul
            // 
            lblResul.AutoSize = true;
            lblResul.Location = new Point(182, 306);
            lblResul.Name = "lblResul";
            lblResul.Size = new Size(38, 15);
            lblResul.TabIndex = 3;
            lblResul.Text = "label4";
            // 
            // nudN1
            // 
            nudN1.Location = new Point(158, 58);
            nudN1.Name = "nudN1";
            nudN1.Size = new Size(120, 23);
            nudN1.TabIndex = 4;
            // 
            // nudN2
            // 
            nudN2.Location = new Point(158, 123);
            nudN2.Name = "nudN2";
            nudN2.Size = new Size(120, 23);
            nudN2.TabIndex = 5;
            // 
            // cmbOperaciones
            // 
            cmbOperaciones.FormattingEnabled = true;
            cmbOperaciones.Location = new Point(528, 106);
            cmbOperaciones.Name = "cmbOperaciones";
            cmbOperaciones.Size = new Size(121, 23);
            cmbOperaciones.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(398, 225);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "button1";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(528, 225);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "button2";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmGuia04ejerc3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(cmbOperaciones);
            Controls.Add(nudN2);
            Controls.Add(nudN1);
            Controls.Add(lblResul);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmGuia04ejerc3";
            Text = "Form5";
            Load += frmGuia04ejerc3_Load;
            ((System.ComponentModel.ISupportInitialize)nudN1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudN2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResul;
        private NumericUpDown nudN1;
        private NumericUpDown nudN2;
        private ComboBox cmbOperaciones;
        private Button btnCalcular;
        private Button btnSalir;
    }
}