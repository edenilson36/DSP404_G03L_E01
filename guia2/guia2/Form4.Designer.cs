namespace guia2
{
    partial class frmULAM
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
            lblNumero = new Label();
            label2 = new Label();
            button1 = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lstLista = new ListBox();
            txtnumero = new TextBox();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(377, 128);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(109, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Sucesión de ULAM:";
            lblNumero.Click += lblNumero_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 77);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(101, 209);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "&Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(101, 281);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(101, 332);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.ItemHeight = 15;
            lstLista.Location = new Point(436, 174);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(120, 94);
            lstLista.TabIndex = 5;
            lstLista.SelectedIndexChanged += lstLista_SelectedIndexChanged;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(194, 69);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(180, 23);
            txtnumero.TabIndex = 6;
            txtnumero.TextChanged += txtnumero_TextChanged;
            // 
            // frmULAM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtnumero);
            Controls.Add(lstLista);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(lblNumero);
            Name = "frmULAM";
            Text = "Sucesión de ULAM";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label label2;
        private Button button1;
        private Button btnLimpiar;
        private Button btnSalir;
        private ListBox lstLista;
        private TextBox txtnumero;
    }
}