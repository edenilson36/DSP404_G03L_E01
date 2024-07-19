namespace guia2
{
    partial class frmReves
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
            lblNumero = new Label();
            lblReves = new Label();
            txtNumero = new TextBox();
            txtReves = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(82, 81);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero:";
            // 
            // lblReves
            // 
            lblReves.AutoSize = true;
            lblReves.Location = new Point(82, 252);
            lblReves.Name = "lblReves";
            lblReves.Size = new Size(51, 15);
            lblReves.TabIndex = 1;
            lblReves.Text = "Al revés:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(82, 132);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(497, 23);
            txtNumero.TabIndex = 2;
            // 
            // txtReves
            // 
            txtReves.Enabled = false;
            txtReves.Location = new Point(82, 293);
            txtReves.Name = "txtReves";
            txtReves.Size = new Size(497, 23);
            txtReves.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(140, 378);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(446, 378);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frmReves
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtReves);
            Controls.Add(txtNumero);
            Controls.Add(lblReves);
            Controls.Add(lblNumero);
            Name = "frmReves";
            Text = "Mostrar un numero al reves ";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblReves;
        private TextBox txtNumero;
        private TextBox txtReves;
        private Button btnCalcular;
        private Button btnLimpiar;
    }
}