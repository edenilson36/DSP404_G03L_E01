namespace guia4
{
    partial class Form10
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
            txtLimiteInferior = new TextBox();
            label1 = new Label();
            txtLimiteSuperior = new TextBox();
            label2 = new Label();
            btnGenerarMatriz = new Button();
            dataGridViewMatriz = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatriz).BeginInit();
            SuspendLayout();
            // 
            // txtLimiteInferior
            // 
            txtLimiteInferior.Location = new Point(61, 91);
            txtLimiteInferior.Name = "txtLimiteInferior";
            txtLimiteInferior.Size = new Size(100, 23);
            txtLimiteInferior.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 73);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "Límite Inferior";
            // 
            // txtLimiteSuperior
            // 
            txtLimiteSuperior.Location = new Point(61, 160);
            txtLimiteSuperior.Name = "txtLimiteSuperior";
            txtLimiteSuperior.Size = new Size(100, 23);
            txtLimiteSuperior.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 142);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 3;
            label2.Text = "Límite Superior";
            // 
            // btnGenerarMatriz
            // 
            btnGenerarMatriz.Location = new Point(216, 134);
            btnGenerarMatriz.Name = "btnGenerarMatriz";
            btnGenerarMatriz.Size = new Size(117, 23);
            btnGenerarMatriz.TabIndex = 4;
            btnGenerarMatriz.Text = "Generar Matriz";
            btnGenerarMatriz.UseVisualStyleBackColor = true;
            btnGenerarMatriz.Click += btnGenerarMatriz_Click;
            // 
            // dataGridViewMatriz
            // 
            dataGridViewMatriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatriz.Location = new Point(76, 240);
            dataGridViewMatriz.Name = "dataGridViewMatriz";
            dataGridViewMatriz.Size = new Size(624, 198);
            dataGridViewMatriz.TabIndex = 5;
            dataGridViewMatriz.CellContentClick += dataGridViewMatriz_CellContentClick;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewMatriz);
            Controls.Add(btnGenerarMatriz);
            Controls.Add(label2);
            Controls.Add(txtLimiteSuperior);
            Controls.Add(label1);
            Controls.Add(txtLimiteInferior);
            Name = "Form10";
            Text = "Form10";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatriz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLimiteInferior;
        private Label label1;
        private TextBox txtLimiteSuperior;
        private Label label2;
        private Button btnGenerarMatriz;
        private DataGridView dataGridViewMatriz;
    }
}