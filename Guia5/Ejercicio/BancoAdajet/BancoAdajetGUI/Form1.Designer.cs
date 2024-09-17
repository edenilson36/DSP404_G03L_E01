namespace BancoAdajetGUI
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
            lblNumeroCuenta = new Label();
            label1 = new Label();
            txtDui = new TextBox();
            txtSaldoInicial = new TextBox();
            label2 = new Label();
            txtInteresAnual = new TextBox();
            label3 = new Label();
            lblSaldoActual = new Label();
            txtCantidad = new TextBox();
            label4 = new Label();
            btnCrearCuenta = new Button();
            btnIngresar = new Button();
            btnRetirar = new Button();
            btnActualizarSaldo = new Button();
            btnMostrarDatos = new Button();
            SuspendLayout();
            // 
            // lblNumeroCuenta
            // 
            lblNumeroCuenta.AutoSize = true;
            lblNumeroCuenta.Location = new Point(62, 41);
            lblNumeroCuenta.Name = "lblNumeroCuenta";
            lblNumeroCuenta.Size = new Size(111, 15);
            lblNumeroCuenta.TabIndex = 0;
            lblNumeroCuenta.Text = "Numero de Cuenta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 111);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "DUI del Cliente:";
            // 
            // txtDui
            // 
            txtDui.Location = new Point(162, 108);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(100, 23);
            txtDui.TabIndex = 2;
            // 
            // txtSaldoInicial
            // 
            txtSaldoInicial.Location = new Point(162, 161);
            txtSaldoInicial.Name = "txtSaldoInicial";
            txtSaldoInicial.Size = new Size(100, 23);
            txtSaldoInicial.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 164);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
            label2.Text = "Saldo Inicial:";
            // 
            // txtInteresAnual
            // 
            txtInteresAnual.Location = new Point(162, 209);
            txtInteresAnual.Name = "txtInteresAnual";
            txtInteresAnual.Size = new Size(100, 23);
            txtInteresAnual.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 212);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 5;
            label3.Text = "Interes Anual (%):";
            // 
            // lblSaldoActual
            // 
            lblSaldoActual.AutoSize = true;
            lblSaldoActual.Location = new Point(62, 288);
            lblSaldoActual.Name = "lblSaldoActual";
            lblSaldoActual.Size = new Size(111, 15);
            lblSaldoActual.TabIndex = 7;
            lblSaldoActual.Text = "Numero de Cuenta:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(171, 346);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 349);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 8;
            label4.Text = "Cantidad:";
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.Location = new Point(364, 104);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(99, 23);
            btnCrearCuenta.TabIndex = 10;
            btnCrearCuenta.Text = "Crear Cuenta";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(364, 133);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(99, 23);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "Ingresar Dinero";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(364, 164);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(99, 23);
            btnRetirar.TabIndex = 12;
            btnRetirar.Text = "Retirar Dinero";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // btnActualizarSaldo
            // 
            btnActualizarSaldo.Location = new Point(364, 193);
            btnActualizarSaldo.Name = "btnActualizarSaldo";
            btnActualizarSaldo.Size = new Size(99, 23);
            btnActualizarSaldo.TabIndex = 13;
            btnActualizarSaldo.Text = "Actualizar Saldo";
            btnActualizarSaldo.UseVisualStyleBackColor = true;
            btnActualizarSaldo.Click += btnActualizarSaldo_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(364, 222);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(99, 23);
            btnMostrarDatos.TabIndex = 14;
            btnMostrarDatos.Text = "Mostrar Datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnActualizarSaldo);
            Controls.Add(btnRetirar);
            Controls.Add(btnIngresar);
            Controls.Add(btnCrearCuenta);
            Controls.Add(txtCantidad);
            Controls.Add(label4);
            Controls.Add(lblSaldoActual);
            Controls.Add(txtInteresAnual);
            Controls.Add(label3);
            Controls.Add(txtSaldoInicial);
            Controls.Add(label2);
            Controls.Add(txtDui);
            Controls.Add(label1);
            Controls.Add(lblNumeroCuenta);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumeroCuenta;
        private Label label1;
        private TextBox txtDui;
        private TextBox txtSaldoInicial;
        private Label label2;
        private TextBox txtInteresAnual;
        private Label label3;
        private Label lblSaldoActual;
        private TextBox txtCantidad;
        private Label label4;
        private Button btnCrearCuenta;
        private Button btnIngresar;
        private Button btnRetirar;
        private Button btnActualizarSaldo;
        private Button btnMostrarDatos;
    }
}
