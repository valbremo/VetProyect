namespace VetProyect.Formularios
{
    partial class FrmHistorial
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GbDatosHistorial = new System.Windows.Forms.GroupBox();
            this.CboxEspecialidad = new System.Windows.Forms.ComboBox();
            this.CboxMascota = new System.Windows.Forms.ComboBox();
            this.TxtDiagnostico = new System.Windows.Forms.TextBox();
            this.TxtFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtSintomas = new System.Windows.Forms.TextBox();
            this.TxtIdHistorial = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DgvListaHistoriales = new System.Windows.Forms.DataGridView();
            this.GbBuscarHistorial = new System.Windows.Forms.GroupBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CIdHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSintomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIdMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIdEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEspecificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbDatosHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaHistoriales)).BeginInit();
            this.GbBuscarHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Síntomas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Diagnostico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mascota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(429, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Especialidad";
            // 
            // GbDatosHistorial
            // 
            this.GbDatosHistorial.Controls.Add(this.CboxEspecialidad);
            this.GbDatosHistorial.Controls.Add(this.CboxMascota);
            this.GbDatosHistorial.Controls.Add(this.TxtDiagnostico);
            this.GbDatosHistorial.Controls.Add(this.TxtFecha);
            this.GbDatosHistorial.Controls.Add(this.TxtSintomas);
            this.GbDatosHistorial.Controls.Add(this.TxtIdHistorial);
            this.GbDatosHistorial.Controls.Add(this.label7);
            this.GbDatosHistorial.Controls.Add(this.label6);
            this.GbDatosHistorial.Controls.Add(this.label5);
            this.GbDatosHistorial.Controls.Add(this.label4);
            this.GbDatosHistorial.Controls.Add(this.label3);
            this.GbDatosHistorial.Controls.Add(this.label2);
            this.GbDatosHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDatosHistorial.Location = new System.Drawing.Point(197, 470);
            this.GbDatosHistorial.Name = "GbDatosHistorial";
            this.GbDatosHistorial.Size = new System.Drawing.Size(1144, 223);
            this.GbDatosHistorial.TabIndex = 7;
            this.GbDatosHistorial.TabStop = false;
            this.GbDatosHistorial.Text = "Datos del Historial";
            this.GbDatosHistorial.Enter += new System.EventHandler(this.GbDatosHistorial_Enter);
            // 
            // CboxEspecialidad
            // 
            this.CboxEspecialidad.FormattingEnabled = true;
            this.CboxEspecialidad.Location = new System.Drawing.Point(535, 175);
            this.CboxEspecialidad.Name = "CboxEspecialidad";
            this.CboxEspecialidad.Size = new System.Drawing.Size(204, 28);
            this.CboxEspecialidad.TabIndex = 12;
            // 
            // CboxMascota
            // 
            this.CboxMascota.FormattingEnabled = true;
            this.CboxMascota.Location = new System.Drawing.Point(90, 180);
            this.CboxMascota.Name = "CboxMascota";
            this.CboxMascota.Size = new System.Drawing.Size(204, 28);
            this.CboxMascota.TabIndex = 11;
            // 
            // TxtDiagnostico
            // 
            this.TxtDiagnostico.Location = new System.Drawing.Point(535, 118);
            this.TxtDiagnostico.Name = "TxtDiagnostico";
            this.TxtDiagnostico.Size = new System.Drawing.Size(377, 26);
            this.TxtDiagnostico.TabIndex = 10;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(90, 121);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(295, 26);
            this.TxtFecha.TabIndex = 9;
            // 
            // TxtSintomas
            // 
            this.TxtSintomas.Location = new System.Drawing.Point(534, 60);
            this.TxtSintomas.Name = "TxtSintomas";
            this.TxtSintomas.Size = new System.Drawing.Size(378, 26);
            this.TxtSintomas.TabIndex = 8;
            // 
            // TxtIdHistorial
            // 
            this.TxtIdHistorial.Location = new System.Drawing.Point(90, 61);
            this.TxtIdHistorial.Name = "TxtIdHistorial";
            this.TxtIdHistorial.ReadOnly = true;
            this.TxtIdHistorial.Size = new System.Drawing.Size(154, 26);
            this.TxtIdHistorial.TabIndex = 7;
            this.TxtIdHistorial.TextChanged += new System.EventHandler(this.TxtIdHistorial_TextChanged);
            // 
            // DgvListaHistoriales
            // 
            this.DgvListaHistoriales.AllowUserToAddRows = false;
            this.DgvListaHistoriales.AllowUserToDeleteRows = false;
            this.DgvListaHistoriales.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.DgvListaHistoriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaHistoriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdHistorial,
            this.CSintomas,
            this.CFecha,
            this.CDiagnostico,
            this.CIdMascota,
            this.CIdEspecialidad,
            this.Mascota,
            this.NombreEspecificacion});
            this.DgvListaHistoriales.Location = new System.Drawing.Point(12, 135);
            this.DgvListaHistoriales.Name = "DgvListaHistoriales";
            this.DgvListaHistoriales.ReadOnly = true;
            this.DgvListaHistoriales.RowHeadersWidth = 62;
            this.DgvListaHistoriales.RowTemplate.Height = 28;
            this.DgvListaHistoriales.Size = new System.Drawing.Size(1480, 318);
            this.DgvListaHistoriales.TabIndex = 8;
            this.DgvListaHistoriales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaHistoriales_CellClick);
            // 
            // GbBuscarHistorial
            // 
            this.GbBuscarHistorial.Controls.Add(this.TxtBuscar);
            this.GbBuscarHistorial.Location = new System.Drawing.Point(12, 30);
            this.GbBuscarHistorial.Name = "GbBuscarHistorial";
            this.GbBuscarHistorial.Size = new System.Drawing.Size(973, 75);
            this.GbBuscarHistorial.TabIndex = 9;
            this.GbBuscarHistorial.TabStop = false;
            this.GbBuscarHistorial.Text = "Buscar Historial";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnAgregar.Location = new System.Drawing.Point(301, 712);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(144, 48);
            this.BtnAgregar.TabIndex = 10;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnEliminar.Location = new System.Drawing.Point(778, 712);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(144, 48);
            this.BtnEliminar.TabIndex = 12;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnSalir.Location = new System.Drawing.Point(1015, 712);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(144, 48);
            this.BtnSalir.TabIndex = 13;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnModificar.Location = new System.Drawing.Point(537, 712);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(144, 48);
            this.BtnModificar.TabIndex = 13;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(241, 29);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(443, 26);
            this.TxtBuscar.TabIndex = 0;
            // 
            // CIdHistorial
            // 
            this.CIdHistorial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIdHistorial.DataPropertyName = "IdHistorial";
            this.CIdHistorial.HeaderText = "Código";
            this.CIdHistorial.MinimumWidth = 8;
            this.CIdHistorial.Name = "CIdHistorial";
            this.CIdHistorial.ReadOnly = true;
            this.CIdHistorial.Width = 150;
            // 
            // CSintomas
            // 
            this.CSintomas.DataPropertyName = "Sintomas";
            this.CSintomas.HeaderText = "Sintomas";
            this.CSintomas.MinimumWidth = 8;
            this.CSintomas.Name = "CSintomas";
            this.CSintomas.ReadOnly = true;
            this.CSintomas.Width = 150;
            // 
            // CFecha
            // 
            this.CFecha.DataPropertyName = "Fecha";
            this.CFecha.HeaderText = "Fecha";
            this.CFecha.MinimumWidth = 8;
            this.CFecha.Name = "CFecha";
            this.CFecha.ReadOnly = true;
            this.CFecha.Width = 150;
            // 
            // CDiagnostico
            // 
            this.CDiagnostico.DataPropertyName = "Diagnostico";
            this.CDiagnostico.HeaderText = "Diagnostico";
            this.CDiagnostico.MinimumWidth = 8;
            this.CDiagnostico.Name = "CDiagnostico";
            this.CDiagnostico.ReadOnly = true;
            this.CDiagnostico.Width = 150;
            // 
            // CIdMascota
            // 
            this.CIdMascota.DataPropertyName = "IdMascota";
            this.CIdMascota.HeaderText = "Mascota";
            this.CIdMascota.MinimumWidth = 8;
            this.CIdMascota.Name = "CIdMascota";
            this.CIdMascota.ReadOnly = true;
            this.CIdMascota.Visible = false;
            this.CIdMascota.Width = 150;
            // 
            // CIdEspecialidad
            // 
            this.CIdEspecialidad.DataPropertyName = "IdEspecialidad";
            this.CIdEspecialidad.HeaderText = "Especialidad";
            this.CIdEspecialidad.MinimumWidth = 8;
            this.CIdEspecialidad.Name = "CIdEspecialidad";
            this.CIdEspecialidad.ReadOnly = true;
            this.CIdEspecialidad.Visible = false;
            this.CIdEspecialidad.Width = 150;
            // 
            // Mascota
            // 
            this.Mascota.DataPropertyName = "Mascota";
            this.Mascota.HeaderText = "Nombre de la mascota";
            this.Mascota.MinimumWidth = 8;
            this.Mascota.Name = "Mascota";
            this.Mascota.ReadOnly = true;
            this.Mascota.Width = 150;
            // 
            // NombreEspecificacion
            // 
            this.NombreEspecificacion.DataPropertyName = "Nombre";
            this.NombreEspecificacion.HeaderText = "Procedimiento realizado";
            this.NombreEspecificacion.MinimumWidth = 8;
            this.NombreEspecificacion.Name = "NombreEspecificacion";
            this.NombreEspecificacion.ReadOnly = true;
            this.NombreEspecificacion.Width = 150;
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 775);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.GbBuscarHistorial);
            this.Controls.Add(this.DgvListaHistoriales);
            this.Controls.Add(this.GbDatosHistorial);
            this.Name = "FrmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Historial";
            this.Load += new System.EventHandler(this.FrmHistorial_Load);
            this.GbDatosHistorial.ResumeLayout(false);
            this.GbDatosHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaHistoriales)).EndInit();
            this.GbBuscarHistorial.ResumeLayout(false);
            this.GbBuscarHistorial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GbDatosHistorial;
        private System.Windows.Forms.ComboBox CboxEspecialidad;
        private System.Windows.Forms.ComboBox CboxMascota;
        private System.Windows.Forms.TextBox TxtDiagnostico;
        private System.Windows.Forms.DateTimePicker TxtFecha;
        private System.Windows.Forms.TextBox TxtSintomas;
        private System.Windows.Forms.TextBox TxtIdHistorial;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView DgvListaHistoriales;
        private System.Windows.Forms.GroupBox GbBuscarHistorial;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSintomas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEspecificacion;
    }
}