namespace Ejercicio3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreTarea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.btnFiltrarTareas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMarcarCompletada = new System.Windows.Forms.Button();
            this.btnEditarTarea = new System.Windows.Forms.Button();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOrdenarPorNombre = new System.Windows.Forms.Button();
            this.lbTareasCompletadas = new System.Windows.Forms.ListBox();
            this.lbTareasPendientes = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMostrarTodasTareas = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la Tarea:";
            // 
            // txtNombreTarea
            // 
            this.txtNombreTarea.Location = new System.Drawing.Point(176, 61);
            this.txtNombreTarea.Name = "txtNombreTarea";
            this.txtNombreTarea.Size = new System.Drawing.Size(100, 20);
            this.txtNombreTarea.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Límite:";
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.Location = new System.Drawing.Point(176, 95);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaLimite.TabIndex = 3;
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.Location = new System.Drawing.Point(56, 165);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(101, 23);
            this.btnAgregarTarea.TabIndex = 4;
            this.btnAgregarTarea.Text = "Agregar Tarea";
            this.btnAgregarTarea.UseVisualStyleBackColor = true;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // btnFiltrarTareas
            // 
            this.btnFiltrarTareas.Location = new System.Drawing.Point(371, 165);
            this.btnFiltrarTareas.Name = "btnFiltrarTareas";
            this.btnFiltrarTareas.Size = new System.Drawing.Size(138, 23);
            this.btnFiltrarTareas.TabIndex = 5;
            this.btnFiltrarTareas.Text = "Filtrar Tareas por Fecha";
            this.btnFiltrarTareas.UseVisualStyleBackColor = true;
            this.btnFiltrarTareas.Click += new System.EventHandler(this.btnFiltrarTareas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnMarcarCompletada);
            this.groupBox1.Controls.Add(this.btnEditarTarea);
            this.groupBox1.Controls.Add(this.btnEliminarTarea);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnOrdenarPorNombre);
            this.groupBox1.Controls.Add(this.lbTareasCompletadas);
            this.groupBox1.Controls.Add(this.lbTareasPendientes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(56, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 325);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnMarcarCompletada
            // 
            this.btnMarcarCompletada.Location = new System.Drawing.Point(315, 263);
            this.btnMarcarCompletada.Name = "btnMarcarCompletada";
            this.btnMarcarCompletada.Size = new System.Drawing.Size(110, 23);
            this.btnMarcarCompletada.TabIndex = 8;
            this.btnMarcarCompletada.Text = "Marcar Completada";
            this.btnMarcarCompletada.UseVisualStyleBackColor = true;
            this.btnMarcarCompletada.Click += new System.EventHandler(this.btnMarcarCompletada_Click);
            // 
            // btnEditarTarea
            // 
            this.btnEditarTarea.Location = new System.Drawing.Point(182, 263);
            this.btnEditarTarea.Name = "btnEditarTarea";
            this.btnEditarTarea.Size = new System.Drawing.Size(93, 23);
            this.btnEditarTarea.TabIndex = 7;
            this.btnEditarTarea.Text = "Editar Tarea";
            this.btnEditarTarea.UseVisualStyleBackColor = true;
            this.btnEditarTarea.Click += new System.EventHandler(this.btnEditarTarea_Click);
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.Location = new System.Drawing.Point(24, 263);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(93, 23);
            this.btnEliminarTarea.TabIndex = 6;
            this.btnEliminarTarea.Text = "Eliminar Tarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = true;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ordenar Por Fecha Límite";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOrdenarPorNombre
            // 
            this.btnOrdenarPorNombre.Location = new System.Drawing.Point(24, 204);
            this.btnOrdenarPorNombre.Name = "btnOrdenarPorNombre";
            this.btnOrdenarPorNombre.Size = new System.Drawing.Size(113, 23);
            this.btnOrdenarPorNombre.TabIndex = 4;
            this.btnOrdenarPorNombre.Text = "Ordenar Por Nombre";
            this.btnOrdenarPorNombre.UseVisualStyleBackColor = true;
            this.btnOrdenarPorNombre.Click += new System.EventHandler(this.btnOrdenarPorNombre_Click);
            // 
            // lbTareasCompletadas
            // 
            this.lbTareasCompletadas.FormattingEnabled = true;
            this.lbTareasCompletadas.Location = new System.Drawing.Point(253, 60);
            this.lbTareasCompletadas.Name = "lbTareasCompletadas";
            this.lbTareasCompletadas.Size = new System.Drawing.Size(175, 121);
            this.lbTareasCompletadas.TabIndex = 3;
            // 
            // lbTareasPendientes
            // 
            this.lbTareasPendientes.FormattingEnabled = true;
            this.lbTareasPendientes.Location = new System.Drawing.Point(24, 60);
            this.lbTareasPendientes.Name = "lbTareasPendientes";
            this.lbTareasPendientes.Size = new System.Drawing.Size(175, 121);
            this.lbTareasPendientes.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tareas Completadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tareas Pendientes";
            // 
            // btnMostrarTodasTareas
            // 
            this.btnMostrarTodasTareas.Location = new System.Drawing.Point(213, 543);
            this.btnMostrarTodasTareas.Name = "btnMostrarTodasTareas";
            this.btnMostrarTodasTareas.Size = new System.Drawing.Size(153, 23);
            this.btnMostrarTodasTareas.TabIndex = 7;
            this.btnMostrarTodasTareas.Text = "Mostrar Todas las Tareas";
            this.btnMostrarTodasTareas.UseVisualStyleBackColor = true;
            this.btnMostrarTodasTareas.Click += new System.EventHandler(this.btnMostrarTodasTareas_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(80, 598);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(409, 598);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 9;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(577, 656);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnMostrarTodasTareas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFiltrarTareas);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.dtpFechaLimite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreTarea);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreTarea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.Button btnFiltrarTareas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOrdenarPorNombre;
        private System.Windows.Forms.ListBox lbTareasCompletadas;
        private System.Windows.Forms.ListBox lbTareasPendientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMarcarCompletada;
        private System.Windows.Forms.Button btnEditarTarea;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMostrarTodasTareas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
    }
}

