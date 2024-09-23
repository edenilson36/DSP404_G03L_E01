namespace guia4
{
    partial class Form8
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtnombre = new TextBox();
            txtdias = new TextBox();
            txtmontoh = new TextBox();
            txtmontos = new TextBox();
            txtmontot = new TextBox();
            txtinteres = new TextBox();
            nUDpagar = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nUDpagar).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 47);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Apellidos y Nombres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 92);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 1;
            label2.Text = "Días de hospedaje";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 271);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 2;
            label3.Text = "Monto de Hospedaje:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 313);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 3;
            label4.Text = "Monto de Servicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 359);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 4;
            label5.Text = "Monto Total:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(461, 271);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(461, 313);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(212, 39);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 7;
            // 
            // txtdias
            // 
            txtdias.Location = new Point(197, 92);
            txtdias.Name = "txtdias";
            txtdias.Size = new Size(100, 23);
            txtdias.TabIndex = 8;
            // 
            // txtmontoh
            // 
            txtmontoh.Location = new Point(209, 263);
            txtmontoh.Name = "txtmontoh";
            txtmontoh.Size = new Size(100, 23);
            txtmontoh.TabIndex = 9;
            // 
            // txtmontos
            // 
            txtmontos.Location = new Point(209, 305);
            txtmontos.Name = "txtmontos";
            txtmontos.Size = new Size(100, 23);
            txtmontos.TabIndex = 10;
            // 
            // txtmontot
            // 
            txtmontot.Location = new Point(212, 351);
            txtmontot.Name = "txtmontot";
            txtmontot.Size = new Size(100, 23);
            txtmontot.TabIndex = 11;
            // 
            // txtinteres
            // 
            txtinteres.Location = new Point(525, 268);
            txtinteres.Name = "txtinteres";
            txtinteres.Size = new Size(100, 23);
            txtinteres.TabIndex = 12;
            // 
            // nUDpagar
            // 
            nUDpagar.DecimalPlaces = 2;
            nUDpagar.Location = new Point(525, 311);
            nUDpagar.Name = "nUDpagar";
            nUDpagar.Size = new Size(120, 23);
            nUDpagar.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(679, 52);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(679, 81);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "Nuevo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(679, 110);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 16;
            button3.Text = "Acerca…";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(679, 139);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 17;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(103, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(21, 66);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Delegado";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(21, 28);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Turista";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(373, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 112);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Servicios";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(14, 70);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(69, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Bar libre";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(15, 45);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(94, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Teléfono/Fax";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(14, 20);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(56, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Cable";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(nUDpagar);
            Controls.Add(txtinteres);
            Controls.Add(txtmontot);
            Controls.Add(txtmontos);
            Controls.Add(txtmontoh);
            Controls.Add(txtdias);
            Controls.Add(txtnombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)nUDpagar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtnombre;
        private TextBox txtdias;
        private TextBox txtmontoh;
        private TextBox txtmontos;
        private TextBox txtmontot;
        private TextBox txtinteres;
        private NumericUpDown nUDpagar;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}