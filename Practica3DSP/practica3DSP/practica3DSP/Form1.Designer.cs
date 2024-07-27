namespace practica3DSP
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Location = new Point(43, 41);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(123, 20);
            lblnumero.TabIndex = 0;
            lblnumero.Text = "Ingresar Numero:";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(203, 41);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(286, 27);
            txtNum.TabIndex = 1;
            // 
            // btAgregar
            // 
            btAgregar.BackColor = Color.Lime;
            btAgregar.Location = new Point(622, 41);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(94, 29);
            btAgregar.TabIndex = 2;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = false;
            btAgregar.Click += btAgregar_Click;
            // 
            // btOrdenar
            // 
            btOrdenar.BackColor = Color.Yellow;
            btOrdenar.Location = new Point(622, 137);
            btOrdenar.Name = "btOrdenar";
            btOrdenar.Size = new Size(94, 29);
            btOrdenar.TabIndex = 3;
            btOrdenar.Text = "Ordenar";
            btOrdenar.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(43, 218);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(209, 204);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(452, 218);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(209, 204);
            listBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
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
        private ListBox listBox1;
        private ListBox listBox2;
    }
}
