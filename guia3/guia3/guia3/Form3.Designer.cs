namespace guia3
{
    partial class Form3
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
            lstPalabras = new ListBox();
            txtsignificado = new TextBox();
            lblpalabra = new Label();
            btnsalir = new Button();
            SuspendLayout();
            // 
            // lstPalabras
            // 
            lstPalabras.FormattingEnabled = true;
            lstPalabras.ItemHeight = 15;
            lstPalabras.Location = new Point(330, 59);
            lstPalabras.Name = "lstPalabras";
            lstPalabras.Size = new Size(120, 289);
            lstPalabras.TabIndex = 0;
            lstPalabras.SelectedIndexChanged += lstPalabras_SelectedIndexChanged;
            // 
            // txtsignificado
            // 
            txtsignificado.Location = new Point(483, 150);
            txtsignificado.Multiline = true;
            txtsignificado.Name = "txtsignificado";
            txtsignificado.Size = new Size(205, 198);
            txtsignificado.TabIndex = 1;
            txtsignificado.TextChanged += textBox1_TextChanged;
            // 
            // lblpalabra
            // 
            lblpalabra.AutoSize = true;
            lblpalabra.Location = new Point(518, 59);
            lblpalabra.Name = "lblpalabra";
            lblpalabra.Size = new Size(46, 15);
            lblpalabra.TabIndex = 2;
            lblpalabra.Text = "Palabra";
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(370, 382);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(207, 23);
            btnsalir.TabIndex = 3;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(btnsalir);
            Controls.Add(lblpalabra);
            Controls.Add(txtsignificado);
            Controls.Add(lstPalabras);
            Name = "Form3";
            Text = "Formulario";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstPalabras;
        private TextBox txtsignificado;
        private Label lblpalabra;
        private Button btnsalir;
    }
}