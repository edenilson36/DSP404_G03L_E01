namespace guia3
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
            lblnumero = new Label();
            txtNum = new TextBox();
            btAgregar = new Button();
            btOrdenar = new Button();
            lstdesorden = new ListBox();
            lstOrdenada = new ListBox();
            SuspendLayout();
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Location = new Point(136, 62);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(156, 25);
            lblnumero.TabIndex = 0;
            lblnumero.Text = "Ingresar numeros ";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(342, 56);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(150, 31);
            txtNum.TabIndex = 1;
            // 
            // btAgregar
            // 
            btAgregar.BackColor = Color.DarkGreen;
            btAgregar.Location = new Point(797, 100);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(112, 34);
            btAgregar.TabIndex = 2;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = false;
            btAgregar.Click += btAgregar_Click;
            // 
            // btOrdenar
            // 
            btOrdenar.BackColor = Color.Yellow;
            btOrdenar.Location = new Point(797, 206);
            btOrdenar.Name = "btOrdenar";
            btOrdenar.Size = new Size(112, 34);
            btOrdenar.TabIndex = 3;
            btOrdenar.Text = "Ordenar";
            btOrdenar.UseVisualStyleBackColor = false;
            btOrdenar.Click += btOrdenar_Click;
            // 
            // lstdesorden
            // 
            lstdesorden.FormattingEnabled = true;
            lstdesorden.ItemHeight = 25;
            lstdesorden.Location = new Point(172, 289);
            lstdesorden.Name = "lstdesorden";
            lstdesorden.Size = new Size(180, 129);
            lstdesorden.TabIndex = 4;
            // 
            // lstOrdenada
            // 
            lstOrdenada.FormattingEnabled = true;
            lstOrdenada.ItemHeight = 25;
            lstOrdenada.Location = new Point(538, 302);
            lstOrdenada.Name = "lstOrdenada";
            lstOrdenada.Size = new Size(180, 129);
            lstOrdenada.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(996, 608);
            Controls.Add(lstOrdenada);
            Controls.Add(lstdesorden);
            Controls.Add(btOrdenar);
            Controls.Add(btAgregar);
            Controls.Add(txtNum);
            Controls.Add(lblnumero);
            Name = "Form1";
            Text = "Ordenar";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnumero;
        private TextBox txtNum;
        private Button btAgregar;
        private Button btOrdenar;
        private ListBox lstdesorden;
        private ListBox lstOrdenada;
    }
}
