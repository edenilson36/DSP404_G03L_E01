namespace guia4
{
    partial class frmGuia04ejerc4
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
            groupBox1 = new GroupBox();
            txtpwd = new TextBox();
            txtusuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtpwd);
            groupBox1.Controls.Add(txtusuario);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(285, 269);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 128);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Private";
            // 
            // txtpwd
            // 
            txtpwd.Location = new Point(151, 61);
            txtpwd.Name = "txtpwd";
            txtpwd.Size = new Size(100, 23);
            txtpwd.TabIndex = 3;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(151, 28);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(100, 23);
            txtusuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 69);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 29);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2024_09_08_215504;
            pictureBox1.Location = new Point(389, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 106);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(421, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmGuia04ejerc4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "frmGuia04ejerc4";
            Text = "Login";
            Load += Form6_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtpwd;
        private TextBox txtusuario;
        private Button button1;
    }
}