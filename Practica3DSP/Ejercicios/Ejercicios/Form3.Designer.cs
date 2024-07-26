namespace Ejercicios
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
            this.dgNotas = new System.Windows.Forms.DataGridView();
            this.btAgregarNota = new System.Windows.Forms.Button();
            this.btMostrarNotas = new System.Windows.Forms.Button();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.cbAlumnos = new System.Windows.Forms.ComboBox();
            this.cbAsignaturas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgNotas
            // 
            this.dgNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNotas.Location = new System.Drawing.Point(89, 284);
            this.dgNotas.Name = "dgNotas";
            this.dgNotas.Size = new System.Drawing.Size(514, 127);
            this.dgNotas.TabIndex = 0;
            // 
            // btAgregarNota
            // 
            this.btAgregarNota.Location = new System.Drawing.Point(371, 158);
            this.btAgregarNota.Name = "btAgregarNota";
            this.btAgregarNota.Size = new System.Drawing.Size(106, 23);
            this.btAgregarNota.TabIndex = 1;
            this.btAgregarNota.Text = "Agregar nota";
            this.btAgregarNota.UseVisualStyleBackColor = true;
            this.btAgregarNota.Click += new System.EventHandler(this.btAgregarNota_Click);
            // 
            // btMostrarNotas
            // 
            this.btMostrarNotas.Location = new System.Drawing.Point(506, 158);
            this.btMostrarNotas.Name = "btMostrarNotas";
            this.btMostrarNotas.Size = new System.Drawing.Size(75, 23);
            this.btMostrarNotas.TabIndex = 3;
            this.btMostrarNotas.Text = "Mostrar nota";
            this.btMostrarNotas.UseVisualStyleBackColor = true;
            this.btMostrarNotas.Click += new System.EventHandler(this.btMostrarNota_Click);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(145, 62);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 20);
            this.txtNota.TabIndex = 4;
            // 
            // cbAlumnos
            // 
            this.cbAlumnos.FormattingEnabled = true;
            this.cbAlumnos.Items.AddRange(new object[] {
            "Alumno 1",
            "Alumno 2",
            "Alumno 3",
            "Alumno 4",
            "Alumno 5",
            "Alumno 6"});
            this.cbAlumnos.Location = new System.Drawing.Point(144, 110);
            this.cbAlumnos.Name = "cbAlumnos";
            this.cbAlumnos.Size = new System.Drawing.Size(121, 21);
            this.cbAlumnos.TabIndex = 5;
            // 
            // cbAsignaturas
            // 
            this.cbAsignaturas.FormattingEnabled = true;
            this.cbAsignaturas.Items.AddRange(new object[] {
            "Asignatura 1",
            "Asignatura 2",
            "Asignatura 3",
            "Asignatura 4",
            "Asignatura 5"});
            this.cbAsignaturas.Location = new System.Drawing.Point(144, 160);
            this.cbAsignaturas.Name = "cbAsignaturas";
            this.cbAsignaturas.Size = new System.Drawing.Size(121, 21);
            this.cbAsignaturas.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Alumno";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Asignatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nota";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAsignaturas);
            this.Controls.Add(this.cbAlumnos);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.btMostrarNotas);
            this.Controls.Add(this.btAgregarNota);
            this.Controls.Add(this.dgNotas);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgNotas;
        private System.Windows.Forms.Button btAgregarNota;
        private System.Windows.Forms.Button btMostrarNotas;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.ComboBox cbAlumnos;
        private System.Windows.Forms.ComboBox cbAsignaturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}