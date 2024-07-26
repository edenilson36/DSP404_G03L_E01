namespace Ejercicios
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
            this.lstOriginal = new System.Windows.Forms.ListBox();
            this.lstTranspuesta = new System.Windows.Forms.ListBox();
            this.txtDimension = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnTransponer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstOriginal
            // 
            this.lstOriginal.FormattingEnabled = true;
            this.lstOriginal.Location = new System.Drawing.Point(51, 149);
            this.lstOriginal.Name = "lstOriginal";
            this.lstOriginal.Size = new System.Drawing.Size(167, 121);
            this.lstOriginal.TabIndex = 0;
            // 
            // lstTranspuesta
            // 
            this.lstTranspuesta.FormattingEnabled = true;
            this.lstTranspuesta.Location = new System.Drawing.Point(262, 149);
            this.lstTranspuesta.Name = "lstTranspuesta";
            this.lstTranspuesta.Size = new System.Drawing.Size(162, 121);
            this.lstTranspuesta.TabIndex = 1;
            // 
            // txtDimension
            // 
            this.txtDimension.Location = new System.Drawing.Point(181, 77);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(100, 20);
            this.txtDimension.TabIndex = 2;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnGenerar.Location = new System.Drawing.Point(94, 329);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click_1);
            // 
            // btnTransponer
            // 
            this.btnTransponer.BackColor = System.Drawing.Color.Turquoise;
            this.btnTransponer.Location = new System.Drawing.Point(305, 329);
            this.btnTransponer.Name = "btnTransponer";
            this.btnTransponer.Size = new System.Drawing.Size(75, 23);
            this.btnTransponer.TabIndex = 4;
            this.btnTransponer.Text = "Transponer";
            this.btnTransponer.UseVisualStyleBackColor = false;
            this.btnTransponer.Click += new System.EventHandler(this.btnTransponer_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Introduzca un número";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(489, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTransponer);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtDimension);
            this.Controls.Add(this.lstTranspuesta);
            this.Controls.Add(this.lstOriginal);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOriginal;
        private System.Windows.Forms.ListBox lstTranspuesta;
        private System.Windows.Forms.TextBox txtDimension;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnTransponer;
        private System.Windows.Forms.Label label1;
    }
}