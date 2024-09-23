namespace guia4
{
    partial class frmGuia04ejerc2
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
            dataGridView1 = new DataGridView();
            maskedTextBox1 = new MaskedTextBox();
            groupBox1 = new GroupBox();
            btnSalir = new Button();
            dateTimePicker1 = new DateTimePicker();
            btnRegistrar = new Button();
            label2 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnVerResumen = new Button();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(695, 150);
            dataGridView1.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(118, 27);
            maskedTextBox1.Mask = "00000.00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(251, 23);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(51, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(714, 199);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de Venta";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(628, 143);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(105, 78);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(284, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(620, 30);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 84);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha Venta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Monto Venta ($)";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(33, 217);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(737, 237);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnVerResumen);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(729, 209);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btnVerResumen
            // 
            btnVerResumen.Location = new Point(246, 174);
            btnVerResumen.Name = "btnVerResumen";
            btnVerResumen.Size = new Size(209, 23);
            btnVerResumen.TabIndex = 3;
            btnVerResumen.Text = "Ver Resumen Ventas";
            btnVerResumen.UseVisualStyleBackColor = true;
            btnVerResumen.Click += btnVerResumen_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(729, 209);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmGuia04ejerc2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Name = "frmGuia04ejerc2";
            Text = "Form3";
            Load += frmGuia04ejerc2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Button btnRegistrar;
        private Label label2;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnVerResumen;
        private TabPage tabPage2;
        private Button btnSalir;
    }
}