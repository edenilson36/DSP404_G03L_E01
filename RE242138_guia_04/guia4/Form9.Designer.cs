namespace guia4
{
    partial class Form9
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
            lstLista = new ListBox();
            txtNuevoElemento = new TextBox();
            label1 = new Label();
            btnCrearLista = new Button();
            btnInsertarElemento = new Button();
            btnRemoverElemento = new Button();
            SuspendLayout();
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.ItemHeight = 15;
            lstLista.Location = new Point(149, 31);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(131, 274);
            lstLista.TabIndex = 0;
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(33, 67);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(100, 23);
            txtNuevoElemento.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese valor";
            // 
            // btnCrearLista
            // 
            btnCrearLista.Location = new Point(149, 321);
            btnCrearLista.Name = "btnCrearLista";
            btnCrearLista.Size = new Size(131, 23);
            btnCrearLista.TabIndex = 3;
            btnCrearLista.Text = "Crear Lista Vacía";
            btnCrearLista.UseVisualStyleBackColor = true;
            btnCrearLista.Click += btnCrearLista_Click;
            // 
            // btnInsertarElemento
            // 
            btnInsertarElemento.Location = new Point(22, 118);
            btnInsertarElemento.Name = "btnInsertarElemento";
            btnInsertarElemento.Size = new Size(121, 23);
            btnInsertarElemento.TabIndex = 4;
            btnInsertarElemento.Text = "Insertar Elemento";
            btnInsertarElemento.UseVisualStyleBackColor = true;
            btnInsertarElemento.Click += btnInsertarElemento_Click;
            // 
            // btnRemoverElemento
            // 
            btnRemoverElemento.Location = new Point(149, 359);
            btnRemoverElemento.Name = "btnRemoverElemento";
            btnRemoverElemento.Size = new Size(131, 23);
            btnRemoverElemento.TabIndex = 5;
            btnRemoverElemento.Text = "Remover Primer Elemento";
            btnRemoverElemento.UseVisualStyleBackColor = true;
            btnRemoverElemento.Click += btnRemoverElemento_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemoverElemento);
            Controls.Add(btnInsertarElemento);
            Controls.Add(btnCrearLista);
            Controls.Add(label1);
            Controls.Add(txtNuevoElemento);
            Controls.Add(lstLista);
            Name = "Form9";
            Text = "Form9";
            Load += Form9_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLista;
        private TextBox txtNuevoElemento;
        private Label label1;
        private Button btnCrearLista;
        private Button btnInsertarElemento;
        private Button btnRemoverElemento;
    }
}