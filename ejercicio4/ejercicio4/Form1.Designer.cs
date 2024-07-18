namespace ejercicio4
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
            txtAmount = new TextBox();
            cmbFromCurrency = new ComboBox();
            lblResult = new Label();
            btnConvert = new Button();
            cmbToCurrency = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(225, 93);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 0;
            // 
            // cmbFromCurrency
            // 
            cmbFromCurrency.FormattingEnabled = true;
            cmbFromCurrency.Location = new Point(225, 204);
            cmbFromCurrency.Name = "cmbFromCurrency";
            cmbFromCurrency.Size = new Size(121, 23);
            cmbFromCurrency.TabIndex = 1;
            cmbFromCurrency.SelectedIndexChanged += cmbFromCurrency_SelectedIndexChanged;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(225, 339);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(59, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "Resultado";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(93, 198);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "enviar ";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += button1_Click;
            // 
            // cmbToCurrency
            // 
            cmbToCurrency.FormattingEnabled = true;
            cmbToCurrency.Location = new Point(225, 275);
            cmbToCurrency.Name = "cmbToCurrency";
            cmbToCurrency.Size = new Size(121, 23);
            cmbToCurrency.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 101);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 5;
            label1.Text = "ingrese su valor ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cmbToCurrency);
            Controls.Add(btnConvert);
            Controls.Add(lblResult);
            Controls.Add(cmbFromCurrency);
            Controls.Add(txtAmount);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAmount;
        private ComboBox cmbFromCurrency;
        private Label lblResult;
        private Button btnConvert;
        private ComboBox cmbToCurrency;
        private Label label1;
    }
}
