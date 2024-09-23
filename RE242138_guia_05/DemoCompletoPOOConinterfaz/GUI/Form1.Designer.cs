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
            clienteTexbox = new TextBox();
            label2 = new Label();
            IDTexbox = new TextBox();
            DescripcionTextBox = new TextBox();
            label3 = new Label();
            PrecioTextBox = new TextBox();
            label4 = new Label();
            CantidadTextBox = new TextBox();
            label5 = new Label();
            agregarButton = new Button();
            detalleDataGridView = new DataGridView();
            PagarButton = new Button();
            AsignarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)detalleDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 38);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // clienteTexbox
            // 
            clienteTexbox.Location = new Point(124, 30);
            clienteTexbox.Name = "clienteTexbox";
            clienteTexbox.Size = new Size(569, 23);
            clienteTexbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 72);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // IDTexbox
            // 
            IDTexbox.Location = new Point(124, 64);
            IDTexbox.Name = "IDTexbox";
            IDTexbox.Size = new Size(100, 23);
            IDTexbox.TabIndex = 3;
            // 
            // DescripcionTextBox
            // 
            DescripcionTextBox.Location = new Point(343, 69);
            DescripcionTextBox.Name = "DescripcionTextBox";
            DescripcionTextBox.Size = new Size(350, 23);
            DescripcionTextBox.TabIndex = 5;
            DescripcionTextBox.TextChanged += DescripcionTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 72);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Descripcion ";
            // 
            // PrecioTextBox
            // 
            PrecioTextBox.Location = new Point(124, 132);
            PrecioTextBox.Name = "PrecioTextBox";
            PrecioTextBox.Size = new Size(100, 23);
            PrecioTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 140);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Precio";
            // 
            // CantidadTextBox
            // 
            CantidadTextBox.Location = new Point(343, 132);
            CantidadTextBox.Name = "CantidadTextBox";
            CantidadTextBox.Size = new Size(100, 23);
            CantidadTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 140);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 8;
            label5.Text = "Cantidad";
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(519, 132);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(75, 23);
            agregarButton.TabIndex = 10;
            agregarButton.Text = "agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // detalleDataGridView
            // 
            detalleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detalleDataGridView.Location = new Point(12, 183);
            detalleDataGridView.Name = "detalleDataGridView";
            detalleDataGridView.Size = new Size(794, 273);
            detalleDataGridView.TabIndex = 11;
            // 
            // PagarButton
            // 
            PagarButton.Location = new Point(618, 132);
            PagarButton.Name = "PagarButton";
            PagarButton.Size = new Size(75, 23);
            PagarButton.TabIndex = 12;
            PagarButton.Text = "Pagar";
            PagarButton.UseVisualStyleBackColor = true;
            PagarButton.Click += PagarButton_Click;
            // 
            // AsignarButton
            // 
            AsignarButton.Location = new Point(713, 29);
            AsignarButton.Name = "AsignarButton";
            AsignarButton.Size = new Size(75, 23);
            AsignarButton.TabIndex = 13;
            AsignarButton.Text = "asignar";
            AsignarButton.UseVisualStyleBackColor = true;
            AsignarButton.Click += AsignarButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 482);
            Controls.Add(AsignarButton);
            Controls.Add(PagarButton);
            Controls.Add(detalleDataGridView);
            Controls.Add(agregarButton);
            Controls.Add(CantidadTextBox);
            Controls.Add(label5);
            Controls.Add(PrecioTextBox);
            Controls.Add(label4);
            Controls.Add(DescripcionTextBox);
            Controls.Add(label3);
            Controls.Add(IDTexbox);
            Controls.Add(label2);
            Controls.Add(clienteTexbox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)detalleDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox clienteTexbox;
        private Label label2;
        private TextBox IDTexbox;
        private TextBox DescripcionTextBox;
        private Label label3;
        private TextBox PrecioTextBox;
        private Label label4;
        private TextBox CantidadTextBox;
        private Label label5;
        private Button agregarButton;
        private DataGridView detalleDataGridView;
        private Button PagarButton;
        private Button AsignarButton;
    }
}
