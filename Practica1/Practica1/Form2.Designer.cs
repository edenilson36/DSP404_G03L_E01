﻿namespace Practica1
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
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTasaInter = new System.Windows.Forms.Label();
            this.rdbInteres1 = new System.Windows.Forms.RadioButton();
            this.rdbInteres2 = new System.Windows.Forms.RadioButton();
            this.rdbInteres3 = new System.Windows.Forms.RadioButton();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtTasaInterEX = new System.Windows.Forms.TextBox();
            this.lstResul = new System.Windows.Forms.ListBox();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(34, 30);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(135, 16);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Nombre de empresa:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(34, 73);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(119, 16);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto prestamo($)";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(446, 73);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(92, 16);
            this.lblTiempo.TabIndex = 2;
            this.lblTiempo.Text = "Tiempo(años)";
            // 
            // lblTasaInter
            // 
            this.lblTasaInter.AutoSize = true;
            this.lblTasaInter.Location = new System.Drawing.Point(34, 127);
            this.lblTasaInter.Name = "lblTasaInter";
            this.lblTasaInter.Size = new System.Drawing.Size(85, 16);
            this.lblTasaInter.TabIndex = 3;
            this.lblTasaInter.Text = "Tasa Interes:";
            // 
            // rdbInteres1
            // 
            this.rdbInteres1.AutoSize = true;
            this.rdbInteres1.Checked = true;
            this.rdbInteres1.Location = new System.Drawing.Point(37, 199);
            this.rdbInteres1.Name = "rdbInteres1";
            this.rdbInteres1.Size = new System.Drawing.Size(58, 20);
            this.rdbInteres1.TabIndex = 4;
            this.rdbInteres1.TabStop = true;
            this.rdbInteres1.Text = "r12%";
            this.rdbInteres1.UseVisualStyleBackColor = true;
            this.rdbInteres1.CheckedChanged += new System.EventHandler(this.rdbInteres1_CheckedChanged);
            // 
            // rdbInteres2
            // 
            this.rdbInteres2.AutoSize = true;
            this.rdbInteres2.Location = new System.Drawing.Point(190, 199);
            this.rdbInteres2.Name = "rdbInteres2";
            this.rdbInteres2.Size = new System.Drawing.Size(64, 20);
            this.rdbInteres2.TabIndex = 5;
            this.rdbInteres2.Text = "23.5%";
            this.rdbInteres2.UseVisualStyleBackColor = true;
            this.rdbInteres2.CheckedChanged += new System.EventHandler(this.rdbInteres2_CheckedChanged);
            // 
            // rdbInteres3
            // 
            this.rdbInteres3.AutoSize = true;
            this.rdbInteres3.Location = new System.Drawing.Point(368, 199);
            this.rdbInteres3.Name = "rdbInteres3";
            this.rdbInteres3.Size = new System.Drawing.Size(106, 20);
            this.rdbInteres3.TabIndex = 6;
            this.rdbInteres3.Text = "Otro, indique:";
            this.rdbInteres3.UseVisualStyleBackColor = true;
            this.rdbInteres3.CheckedChanged += new System.EventHandler(this.rdbInteres3_CheckedChanged);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(190, 24);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(576, 22);
            this.txtEmpresa.TabIndex = 7;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(190, 67);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(215, 22);
            this.txtMonto.TabIndex = 8;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(558, 70);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(208, 22);
            this.txtTiempo.TabIndex = 9;
            this.txtTiempo.Text = "2";
            // 
            // txtTasaInterEX
            // 
            this.txtTasaInterEX.Location = new System.Drawing.Point(538, 197);
            this.txtTasaInterEX.Name = "txtTasaInterEX";
            this.txtTasaInterEX.Size = new System.Drawing.Size(228, 22);
            this.txtTasaInterEX.TabIndex = 10;
            this.txtTasaInterEX.Text = "0";
            // 
            // lstResul
            // 
            this.lstResul.FormattingEnabled = true;
            this.lstResul.ItemHeight = 16;
            this.lstResul.Location = new System.Drawing.Point(37, 248);
            this.lstResul.Name = "lstResul";
            this.lstResul.Size = new System.Drawing.Size(729, 100);
            this.lstResul.TabIndex = 11;
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Location = new System.Drawing.Point(118, 389);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(159, 23);
            this.btnAnalisis.TabIndex = 12;
            this.btnAnalisis.Text = "Analisis financiero";
            this.btnAnalisis.UseVisualStyleBackColor = true;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(449, 389);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(159, 23);
            this.btnFin.TabIndex = 13;
            this.btnFin.Text = "Salir del programa";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnAnalisis);
            this.Controls.Add(this.lstResul);
            this.Controls.Add(this.txtTasaInterEX);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.rdbInteres3);
            this.Controls.Add(this.rdbInteres2);
            this.Controls.Add(this.rdbInteres1);
            this.Controls.Add(this.lblTasaInter);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblEmpresa);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblTasaInter;
        private System.Windows.Forms.RadioButton rdbInteres1;
        private System.Windows.Forms.RadioButton rdbInteres2;
        private System.Windows.Forms.RadioButton rdbInteres3;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtTasaInterEX;
        private System.Windows.Forms.ListBox lstResul;
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.Button btnFin;
    }
}