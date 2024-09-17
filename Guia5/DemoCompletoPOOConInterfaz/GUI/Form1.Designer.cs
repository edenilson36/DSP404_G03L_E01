namespace GUI
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
            label1 = new Label();
            ClienteTextbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            IDTextBox = new TextBox();
            DescripcionTextBox1 = new TextBox();
            PrecioTextBox = new TextBox();
            CantidadTextBox = new TextBox();
            label5 = new Label();
            AgregarButton = new Button();
            detalleDataGridView = new DataGridView();
            PagarButton = new Button();
            label4 = new Label();
            AsignarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)detalleDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // ClienteTextbox
            // 
            ClienteTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ClienteTextbox.Location = new Point(65, 12);
            ClienteTextbox.Name = "ClienteTextbox";
            ClienteTextbox.Size = new Size(583, 23);
            ClienteTextbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 2;
            label2.Text = "ID:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 73);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 3;
            label3.Text = "Descripcion:";
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(65, 69);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(160, 23);
            IDTextBox.TabIndex = 4;
            // 
            // DescripcionTextBox1
            // 
            DescripcionTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescripcionTextBox1.Location = new Point(337, 69);
            DescripcionTextBox1.Name = "DescripcionTextBox1";
            DescripcionTextBox1.Size = new Size(439, 23);
            DescripcionTextBox1.TabIndex = 5;
            // 
            // PrecioTextBox
            // 
            PrecioTextBox.Location = new Point(65, 126);
            PrecioTextBox.Name = "PrecioTextBox";
            PrecioTextBox.Size = new Size(160, 23);
            PrecioTextBox.TabIndex = 7;
            PrecioTextBox.TextChanged += textBox1_TextChanged;
            // 
            // CantidadTextBox
            // 
            CantidadTextBox.Location = new Point(332, 126);
            CantidadTextBox.Name = "CantidadTextBox";
            CantidadTextBox.Size = new Size(160, 23);
            CantidadTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 130);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 8;
            label5.Text = "Cantidad:";
            // 
            // AgregarButton
            // 
            AgregarButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AgregarButton.Location = new Point(518, 126);
            AgregarButton.Name = "AgregarButton";
            AgregarButton.Size = new Size(75, 23);
            AgregarButton.TabIndex = 10;
            AgregarButton.Text = "Agregar";
            AgregarButton.UseVisualStyleBackColor = true;
            AgregarButton.Click += AgregarButton_Click;
            // 
            // detalleDataGridView
            // 
            detalleDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            detalleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            detalleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detalleDataGridView.Location = new Point(12, 168);
            detalleDataGridView.Name = "detalleDataGridView";
            detalleDataGridView.Size = new Size(765, 247);
            detalleDataGridView.TabIndex = 11;
            detalleDataGridView.CellContentClick += detalleDataGridView_CellContentClick;
            // 
            // PagarButton
            // 
            PagarButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PagarButton.Location = new Point(631, 126);
            PagarButton.Name = "PagarButton";
            PagarButton.Size = new Size(75, 23);
            PagarButton.TabIndex = 12;
            PagarButton.Text = "Pagar";
            PagarButton.UseVisualStyleBackColor = true;
            PagarButton.Click += PagarButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 130);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 13;
            label4.Text = "Precio:";
            // 
            // AsignarButton
            // 
            AsignarButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AsignarButton.Location = new Point(701, 16);
            AsignarButton.Name = "AsignarButton";
            AsignarButton.Size = new Size(75, 23);
            AsignarButton.TabIndex = 14;
            AsignarButton.Text = "Asignar";
            AsignarButton.UseVisualStyleBackColor = true;
            AsignarButton.Click += AsignarButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AsignarButton);
            Controls.Add(label4);
            Controls.Add(PagarButton);
            Controls.Add(detalleDataGridView);
            Controls.Add(AgregarButton);
            Controls.Add(CantidadTextBox);
            Controls.Add(label5);
            Controls.Add(PrecioTextBox);
            Controls.Add(DescripcionTextBox1);
            Controls.Add(IDTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ClienteTextbox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ventas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)detalleDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ClienteTextbox;
        private Label label2;
        private Label label3;
        private TextBox IDTextBox;
        private TextBox DescripcionTextBox1;
        private TextBox PrecioTextBox;
        private TextBox CantidadTextBox;
        private Label label5;
        private Button AgregarButton;
        private DataGridView detalleDataGridView;
        private Button PagarButton;
        private Label label4;
        private Button AsignarButton;
    }
}
