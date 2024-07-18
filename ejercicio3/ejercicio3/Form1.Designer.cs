namespace ejercicio3
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
            txtNumber = new TextBox();
            btnAddNumber = new Button();
            lblMaxNegative = new Label();
            lblPositiveCount = new Label();
            lblNegativeAverage = new Label();
            lblPositivePercentage = new Label();
            lblNegativePercentage = new Label();
            lblZeroPercentage = new Label();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(262, 47);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 0;
            // 
            // btnAddNumber
            // 
            btnAddNumber.Location = new Point(135, 138);
            btnAddNumber.Name = "btnAddNumber";
            btnAddNumber.Size = new Size(75, 23);
            btnAddNumber.TabIndex = 1;
            btnAddNumber.Text = "calcular ";
            btnAddNumber.UseVisualStyleBackColor = true;
            btnAddNumber.Click += btnAddNumber_Click;
            // 
            // lblMaxNegative
            // 
            lblMaxNegative.AutoSize = true;
            lblMaxNegative.Location = new Point(12, 197);
            lblMaxNegative.Name = "lblMaxNegative";
            lblMaxNegative.Size = new Size(135, 15);
            lblMaxNegative.TabIndex = 2;
            lblMaxNegative.Text = "Mayor número negativo";
            // 
            // lblPositiveCount
            // 
            lblPositiveCount.AutoSize = true;
            lblPositiveCount.Location = new Point(12, 262);
            lblPositiveCount.Name = "lblPositiveCount";
            lblPositiveCount.Size = new Size(173, 15);
            lblPositiveCount.TabIndex = 3;
            lblPositiveCount.Text = "Cuantos números son positivos";
            // 
            // lblNegativeAverage
            // 
            lblNegativeAverage.AutoSize = true;
            lblNegativeAverage.Location = new Point(12, 335);
            lblNegativeAverage.Name = "lblNegativeAverage";
            lblNegativeAverage.Size = new Size(198, 15);
            lblNegativeAverage.TabIndex = 4;
            lblNegativeAverage.Text = "Promedio de los negativos recibidos";
            // 
            // lblPositivePercentage
            // 
            lblPositivePercentage.AutoSize = true;
            lblPositivePercentage.Location = new Point(262, 197);
            lblPositivePercentage.Name = "lblPositivePercentage";
            lblPositivePercentage.Size = new Size(129, 15);
            lblPositivePercentage.TabIndex = 5;
            lblPositivePercentage.Text = "Porcentaje de positivos";
            // 
            // lblNegativePercentage
            // 
            lblNegativePercentage.AutoSize = true;
            lblNegativePercentage.Location = new Point(262, 335);
            lblNegativePercentage.Name = "lblNegativePercentage";
            lblNegativePercentage.Size = new Size(133, 15);
            lblNegativePercentage.TabIndex = 6;
            lblNegativePercentage.Text = "Porcentaje de negativos";
            // 
            // lblZeroPercentage
            // 
            lblZeroPercentage.AutoSize = true;
            lblZeroPercentage.Location = new Point(461, 197);
            lblZeroPercentage.Name = "lblZeroPercentage";
            lblZeroPercentage.Size = new Size(110, 15);
            lblZeroPercentage.TabIndex = 7;
            lblZeroPercentage.Text = "Porcentaje de ceros";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(33, 55);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(98, 15);
            lblMessage.TabIndex = 8;
            lblMessage.Text = "ingrese numeros ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMessage);
            Controls.Add(lblZeroPercentage);
            Controls.Add(lblNegativePercentage);
            Controls.Add(lblPositivePercentage);
            Controls.Add(lblNegativeAverage);
            Controls.Add(lblPositiveCount);
            Controls.Add(lblMaxNegative);
            Controls.Add(btnAddNumber);
            Controls.Add(txtNumber);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber;
        private Button btnAddNumber;
        private Label lblMaxNegative;
        private Label lblPositiveCount;
        private Label lblNegativeAverage;
        private Label lblPositivePercentage;
        private Label lblNegativePercentage;
        private Label lblZeroPercentage;
        private Label lblMessage;
    }
}
