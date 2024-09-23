namespace guia6
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
            cmbTipoAnimal = new ComboBox();
            txtNombreComun = new TextBox();
            dataGridViewAnimales = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtNombreCientifico = new TextBox();
            txtFamilia = new TextBox();
            txtHabitat = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAgregarAnimal = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimales).BeginInit();
            SuspendLayout();
            // 
            // cmbTipoAnimal
            // 
            cmbTipoAnimal.FormattingEnabled = true;
            cmbTipoAnimal.Location = new Point(12, 41);
            cmbTipoAnimal.Name = "cmbTipoAnimal";
            cmbTipoAnimal.Size = new Size(121, 23);
            cmbTipoAnimal.TabIndex = 0;
            // 
            // txtNombreComun
            // 
            txtNombreComun.Location = new Point(183, 41);
            txtNombreComun.Name = "txtNombreComun";
            txtNombreComun.Size = new Size(100, 23);
            txtNombreComun.TabIndex = 1;
            // 
            // dataGridViewAnimales
            // 
            dataGridViewAnimales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnimales.Location = new Point(12, 288);
            dataGridViewAnimales.Name = "dataGridViewAnimales";
            dataGridViewAnimales.Size = new Size(757, 150);
            dataGridViewAnimales.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 4;
            label1.Text = "Seleccione su especie    ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 9);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 5;
            label2.Text = " ingresar el nombre común";
            // 
            // txtNombreCientifico
            // 
            txtNombreCientifico.Location = new Point(16, 126);
            txtNombreCientifico.Name = "txtNombreCientifico";
            txtNombreCientifico.Size = new Size(100, 23);
            txtNombreCientifico.TabIndex = 6;
            // 
            // txtFamilia
            // 
            txtFamilia.Location = new Point(183, 126);
            txtFamilia.Name = "txtFamilia";
            txtFamilia.Size = new Size(100, 23);
            txtFamilia.TabIndex = 7;
            // 
            // txtHabitat
            // 
            txtHabitat.Location = new Point(371, 41);
            txtHabitat.Name = "txtHabitat";
            txtHabitat.Size = new Size(100, 23);
            txtHabitat.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 9);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 9;
            label3.Text = "nombre científico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 85);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 10;
            label4.Text = " familia del animal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(183, 85);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 11;
            label5.Text = "hábitat del animal";
            // 
            // btnAgregarAnimal
            // 
            btnAgregarAnimal.Location = new Point(329, 236);
            btnAgregarAnimal.Name = "btnAgregarAnimal";
            btnAgregarAnimal.Size = new Size(101, 23);
            btnAgregarAnimal.TabIndex = 12;
            btnAgregarAnimal.Text = "Agregar Animal";
            btnAgregarAnimal.UseVisualStyleBackColor = true;
            btnAgregarAnimal.Click += btnAgregarAnimal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregarAnimal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtHabitat);
            Controls.Add(txtFamilia);
            Controls.Add(txtNombreCientifico);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewAnimales);
            Controls.Add(txtNombreComun);
            Controls.Add(cmbTipoAnimal);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoAnimal;
        private TextBox txtNombreComun;
        private DataGridView dataGridViewAnimales;
        private Label label1;
        private Label label2;
        private TextBox txtNombreCientifico;
        private TextBox txtFamilia;
        private TextBox txtHabitat;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAgregarAnimal;
    }
}
