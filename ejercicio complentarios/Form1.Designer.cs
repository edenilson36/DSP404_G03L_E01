namespace ejercicio_complentarios
{
    partial class FibonacciApp
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
            textBoxInput = new TextBox();
            buttonGenerate = new Button();
            lstLista = new ListBox();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 71);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(133, 71);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(100, 23);
            textBoxInput.TabIndex = 1;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(89, 144);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(75, 23);
            buttonGenerate.TabIndex = 2;
            buttonGenerate.Text = "enviar ";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += button1_Click;
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.ItemHeight = 15;
            lstLista.Location = new Point(342, 193);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(120, 94);
            lstLista.TabIndex = 3;
            lstLista.SelectedIndexChanged += listBoxFibonacci_SelectedIndexChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(89, 208);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(89, 264);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FibonacciApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(lstLista);
            Controls.Add(buttonGenerate);
            Controls.Add(textBoxInput);
            Controls.Add(label1);
            Name = "FibonacciApp";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxInput;
        private Button buttonGenerate;
        private ListBox lstLista;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
