namespace guia4
{
    partial class frmGuia04ejerc1
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
            lbltema = new Label();
            btnCalculo = new Button();
            btnSalir = new Button();
            nupBase = new NumericUpDown();
            grbResult = new GroupBox();
            lstTabla2 = new ListBox();
            lstTabla1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nupBase).BeginInit();
            grbResult.SuspendLayout();
            SuspendLayout();
            // 
            // lbltema
            // 
            lbltema.AutoSize = true;
            lbltema.Location = new Point(69, 61);
            lbltema.Name = "lbltema";
            lbltema.Size = new Size(90, 15);
            lbltema.TabIndex = 0;
            lbltema.Text = "Ingrese número";
            // 
            // btnCalculo
            // 
            btnCalculo.Location = new Point(114, 141);
            btnCalculo.Name = "btnCalculo";
            btnCalculo.Size = new Size(176, 61);
            btnCalculo.TabIndex = 1;
            btnCalculo.Text = "Ver tablas";
            btnCalculo.UseVisualStyleBackColor = true;
            btnCalculo.Click += btnCalculo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(114, 222);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(176, 58);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Finalizar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // nupBase
            // 
            nupBase.DecimalPlaces = 1;
            nupBase.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nupBase.Location = new Point(69, 92);
            nupBase.Maximum = new decimal(new int[] { 69, 0, 0, 65536 });
            nupBase.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nupBase.Name = "nupBase";
            nupBase.Size = new Size(120, 23);
            nupBase.TabIndex = 3;
            nupBase.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // grbResult
            // 
            grbResult.Controls.Add(lstTabla2);
            grbResult.Controls.Add(lstTabla1);
            grbResult.Location = new Point(468, 24);
            grbResult.Name = "grbResult";
            grbResult.Size = new Size(292, 381);
            grbResult.TabIndex = 4;
            grbResult.TabStop = false;
            grbResult.Text = "Resultados";
            // 
            // lstTabla2
            // 
            lstTabla2.FormattingEnabled = true;
            lstTabla2.ItemHeight = 15;
            lstTabla2.Location = new Point(172, 42);
            lstTabla2.Name = "lstTabla2";
            lstTabla2.Size = new Size(120, 274);
            lstTabla2.TabIndex = 1;
            // 
            // lstTabla1
            // 
            lstTabla1.FormattingEnabled = true;
            lstTabla1.ItemHeight = 15;
            lstTabla1.Location = new Point(6, 42);
            lstTabla1.Name = "lstTabla1";
            lstTabla1.Size = new Size(120, 274);
            lstTabla1.TabIndex = 0;
            // 
            // frmGuia04ejerc1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbResult);
            Controls.Add(nupBase);
            Controls.Add(btnSalir);
            Controls.Add(btnCalculo);
            Controls.Add(lbltema);
            Name = "frmGuia04ejerc1";
            Text = "Form1";
            Load += frmGuia04ejerc1_Load;
            ((System.ComponentModel.ISupportInitialize)nupBase).EndInit();
            grbResult.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltema;
        private Button btnCalculo;
        private Button btnSalir;
        private NumericUpDown nupBase;
        private GroupBox grbResult;
        private ListBox lstTabla2;
        private ListBox lstTabla1;
    }
}
