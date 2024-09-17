namespace GUI
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            dtpFechaNac = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            nudISSS = new NumericUpDown();
            label7 = new Label();
            nudRenta = new NumericUpDown();
            txtSueldoini = new TextBox();
            dtpFechaContrato = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnNuevo = new Button();
            btnAceptar = new Button();
            btnAbrirPlanilla = new Button();
            btnGenerarPlanilla = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudISSS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(dtpFechaNac);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos personales de empleados";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(127, 34);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(211, 23);
            txtNombres.TabIndex = 5;
            txtNombres.KeyPress += txtNombres_KeyPress;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(127, 66);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(211, 23);
            txtApellidos.TabIndex = 4;
            txtApellidos.KeyPress += txtApellidos_KeyPress;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(127, 106);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(211, 23);
            dtpFechaNac.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 110);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha Nacimiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 74);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 37);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nudISSS);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(nudRenta);
            groupBox2.Controls.Add(txtSueldoini);
            groupBox2.Controls.Add(dtpFechaContrato);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(464, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(353, 150);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos laborales:";
            // 
            // nudISSS
            // 
            nudISSS.DecimalPlaces = 1;
            nudISSS.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudISSS.Location = new Point(271, 110);
            nudISSS.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudISSS.Name = "nudISSS";
            nudISSS.Size = new Size(63, 23);
            nudISSS.TabIndex = 7;
            nudISSS.KeyPress += nudISSS_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(198, 118);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 6;
            label7.Text = "Tasa ISSS:";
            // 
            // nudRenta
            // 
            nudRenta.DecimalPlaces = 1;
            nudRenta.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudRenta.Location = new Point(117, 110);
            nudRenta.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudRenta.Name = "nudRenta";
            nudRenta.Size = new Size(63, 23);
            nudRenta.TabIndex = 5;
            nudRenta.KeyPress += nudRenta_KeyPress;
            // 
            // txtSueldoini
            // 
            txtSueldoini.Location = new Point(127, 63);
            txtSueldoini.Name = "txtSueldoini";
            txtSueldoini.Size = new Size(87, 23);
            txtSueldoini.TabIndex = 4;
            txtSueldoini.KeyPress += txtSueldoini_KeyPress;
            // 
            // dtpFechaContrato
            // 
            dtpFechaContrato.Location = new Point(127, 28);
            dtpFechaContrato.Name = "dtpFechaContrato";
            dtpFechaContrato.Size = new Size(211, 23);
            dtpFechaContrato.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 34);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 2;
            label4.Text = "Fecha contrato:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 74);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 1;
            label5.Text = "Sueldo Base:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 118);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 0;
            label6.Text = "Tasa Renta:";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(28, 192);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(106, 23);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo Empleado";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(177, 192);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(131, 23);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Proximo Empleado";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnAbrirPlanilla
            // 
            btnAbrirPlanilla.Location = new Point(509, 192);
            btnAbrirPlanilla.Name = "btnAbrirPlanilla";
            btnAbrirPlanilla.Size = new Size(102, 23);
            btnAbrirPlanilla.TabIndex = 9;
            btnAbrirPlanilla.Text = "Abrir Planilla";
            btnAbrirPlanilla.UseVisualStyleBackColor = true;
            btnAbrirPlanilla.Click += btnAbrirPlanilla_Click;
            // 
            // btnGenerarPlanilla
            // 
            btnGenerarPlanilla.Location = new Point(672, 192);
            btnGenerarPlanilla.Name = "btnGenerarPlanilla";
            btnGenerarPlanilla.Size = new Size(108, 23);
            btnGenerarPlanilla.TabIndex = 10;
            btnGenerarPlanilla.Text = "Generar Planilla";
            btnGenerarPlanilla.UseVisualStyleBackColor = true;
            btnGenerarPlanilla.Click += btnGenerarPlanilla_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(804, 207);
            dataGridView1.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnGenerarPlanilla);
            Controls.Add(btnAbrirPlanilla);
            Controls.Add(btnAceptar);
            Controls.Add(btnNuevo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Registro inicial de empleados";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudISSS).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private DateTimePicker dtpFechaNac;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtSueldoini;
        private DateTimePicker dtpFechaContrato;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown nudRenta;
        private NumericUpDown nudISSS;
        private Label label7;
        private Button btnNuevo;
        private Button btnAceptar;
        private Button btnAbrirPlanilla;
        private Button btnGenerarPlanilla;
        private DataGridView dataGridView1;
    }
}