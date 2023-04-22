namespace VetProyect.Formularios
{
    partial class FrmMascota
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtIdMascota = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtRaza = new System.Windows.Forms.TextBox();
            this.TxtObservacion = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.CboxTipoMascota = new System.Windows.Forms.ComboBox();
            this.CboxCliente = new System.Windows.Forms.ComboBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.DgvListaMascotas = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.GbBuscar = new System.Windows.Forms.GroupBox();
            this.GbDatosMascota = new System.Windows.Forms.GroupBox();
            this.CIdMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRaza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIdTipoMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaMascotas)).BeginInit();
            this.GbBuscar.SuspendLayout();
            this.GbDatosMascota.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Raza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Observación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(553, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo de Mascota";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dueño";
            // 
            // TxtIdMascota
            // 
            this.TxtIdMascota.Location = new System.Drawing.Point(202, 57);
            this.TxtIdMascota.Name = "TxtIdMascota";
            this.TxtIdMascota.ReadOnly = true;
            this.TxtIdMascota.Size = new System.Drawing.Size(186, 26);
            this.TxtIdMascota.TabIndex = 8;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(697, 54);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(231, 26);
            this.TxtNombre.TabIndex = 9;
            // 
            // TxtRaza
            // 
            this.TxtRaza.Location = new System.Drawing.Point(697, 118);
            this.TxtRaza.Name = "TxtRaza";
            this.TxtRaza.Size = new System.Drawing.Size(171, 26);
            this.TxtRaza.TabIndex = 11;
            // 
            // TxtObservacion
            // 
            this.TxtObservacion.Location = new System.Drawing.Point(202, 258);
            this.TxtObservacion.Multiline = true;
            this.TxtObservacion.Name = "TxtObservacion";
            this.TxtObservacion.Size = new System.Drawing.Size(283, 82);
            this.TxtObservacion.TabIndex = 12;
            // 
            // CboxTipoMascota
            // 
            this.CboxTipoMascota.FormattingEnabled = true;
            this.CboxTipoMascota.Location = new System.Drawing.Point(697, 195);
            this.CboxTipoMascota.Name = "CboxTipoMascota";
            this.CboxTipoMascota.Size = new System.Drawing.Size(215, 28);
            this.CboxTipoMascota.TabIndex = 13;
            // 
            // CboxCliente
            // 
            this.CboxCliente.FormattingEnabled = true;
            this.CboxCliente.Location = new System.Drawing.Point(202, 192);
            this.CboxCliente.Name = "CboxCliente";
            this.CboxCliente.Size = new System.Drawing.Size(188, 28);
            this.CboxCliente.TabIndex = 14;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(314, 44);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(317, 26);
            this.TxtBuscar.TabIndex = 17;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(202, 121);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(293, 26);
            this.DtpFecha.TabIndex = 18;
            // 
            // DgvListaMascotas
            // 
            this.DgvListaMascotas.AllowUserToAddRows = false;
            this.DgvListaMascotas.AllowUserToDeleteRows = false;
            this.DgvListaMascotas.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.DgvListaMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaMascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdMascota,
            this.CNombre,
            this.CFechaNacimiento,
            this.CRaza,
            this.CObservacion,
            this.CIdTipoMascota,
            this.CIdCliente});
            this.DgvListaMascotas.Location = new System.Drawing.Point(12, 153);
            this.DgvListaMascotas.Name = "DgvListaMascotas";
            this.DgvListaMascotas.ReadOnly = true;
            this.DgvListaMascotas.RowHeadersWidth = 62;
            this.DgvListaMascotas.RowTemplate.Height = 28;
            this.DgvListaMascotas.Size = new System.Drawing.Size(1113, 265);
            this.DgvListaMascotas.TabIndex = 19;
            this.DgvListaMascotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaMascotas_CellClick);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnAgregar.Location = new System.Drawing.Point(98, 841);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(165, 45);
            this.BtnAgregar.TabIndex = 20;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnModificar.Location = new System.Drawing.Point(355, 841);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(165, 45);
            this.BtnModificar.TabIndex = 21;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnEliminar.Location = new System.Drawing.Point(618, 841);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(165, 45);
            this.BtnEliminar.TabIndex = 22;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnSalir.Location = new System.Drawing.Point(881, 841);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(165, 45);
            this.BtnSalir.TabIndex = 23;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // GbBuscar
            // 
            this.GbBuscar.Controls.Add(this.TxtBuscar);
            this.GbBuscar.Location = new System.Drawing.Point(80, 22);
            this.GbBuscar.Name = "GbBuscar";
            this.GbBuscar.Size = new System.Drawing.Size(950, 109);
            this.GbBuscar.TabIndex = 24;
            this.GbBuscar.TabStop = false;
            this.GbBuscar.Text = "Buscar Mascota";
            // 
            // GbDatosMascota
            // 
            this.GbDatosMascota.Controls.Add(this.DtpFecha);
            this.GbDatosMascota.Controls.Add(this.CboxCliente);
            this.GbDatosMascota.Controls.Add(this.CboxTipoMascota);
            this.GbDatosMascota.Controls.Add(this.TxtObservacion);
            this.GbDatosMascota.Controls.Add(this.TxtRaza);
            this.GbDatosMascota.Controls.Add(this.TxtNombre);
            this.GbDatosMascota.Controls.Add(this.TxtIdMascota);
            this.GbDatosMascota.Controls.Add(this.label8);
            this.GbDatosMascota.Controls.Add(this.label7);
            this.GbDatosMascota.Controls.Add(this.label6);
            this.GbDatosMascota.Controls.Add(this.label5);
            this.GbDatosMascota.Controls.Add(this.label4);
            this.GbDatosMascota.Controls.Add(this.label3);
            this.GbDatosMascota.Controls.Add(this.label2);
            this.GbDatosMascota.Location = new System.Drawing.Point(50, 447);
            this.GbDatosMascota.Name = "GbDatosMascota";
            this.GbDatosMascota.Size = new System.Drawing.Size(1019, 350);
            this.GbDatosMascota.TabIndex = 25;
            this.GbDatosMascota.TabStop = false;
            this.GbDatosMascota.Text = "Datos de la Mascota";
            // 
            // CIdMascota
            // 
            this.CIdMascota.DataPropertyName = "IdMascota";
            this.CIdMascota.HeaderText = "Código";
            this.CIdMascota.MinimumWidth = 8;
            this.CIdMascota.Name = "CIdMascota";
            this.CIdMascota.ReadOnly = true;
            this.CIdMascota.Width = 150;
            // 
            // CNombre
            // 
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.MinimumWidth = 8;
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            this.CNombre.Width = 150;
            // 
            // CFechaNacimiento
            // 
            this.CFechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.CFechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.CFechaNacimiento.MinimumWidth = 8;
            this.CFechaNacimiento.Name = "CFechaNacimiento";
            this.CFechaNacimiento.ReadOnly = true;
            this.CFechaNacimiento.Width = 150;
            // 
            // CRaza
            // 
            this.CRaza.DataPropertyName = "Raza";
            this.CRaza.HeaderText = "Raza";
            this.CRaza.MinimumWidth = 8;
            this.CRaza.Name = "CRaza";
            this.CRaza.ReadOnly = true;
            this.CRaza.Width = 150;
            // 
            // CObservacion
            // 
            this.CObservacion.DataPropertyName = "Observacion";
            this.CObservacion.HeaderText = "Observación";
            this.CObservacion.MinimumWidth = 8;
            this.CObservacion.Name = "CObservacion";
            this.CObservacion.ReadOnly = true;
            this.CObservacion.Width = 150;
            // 
            // CIdTipoMascota
            // 
            this.CIdTipoMascota.DataPropertyName = "IdTipoMascota";
            this.CIdTipoMascota.HeaderText = "Tipo de Mascota";
            this.CIdTipoMascota.MinimumWidth = 8;
            this.CIdTipoMascota.Name = "CIdTipoMascota";
            this.CIdTipoMascota.ReadOnly = true;
            this.CIdTipoMascota.Width = 150;
            // 
            // CIdCliente
            // 
            this.CIdCliente.DataPropertyName = "IdCliente";
            this.CIdCliente.HeaderText = "Dueño";
            this.CIdCliente.MinimumWidth = 8;
            this.CIdCliente.Name = "CIdCliente";
            this.CIdCliente.ReadOnly = true;
            this.CIdCliente.Width = 150;
            // 
            // FrmMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 898);
            this.Controls.Add(this.GbDatosMascota);
            this.Controls.Add(this.GbBuscar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.DgvListaMascotas);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Name = "FrmMascota";
            this.Text = "Gestión de Mascota";
            this.Load += new System.EventHandler(this.FrmMascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaMascotas)).EndInit();
            this.GbBuscar.ResumeLayout(false);
            this.GbBuscar.PerformLayout();
            this.GbDatosMascota.ResumeLayout(false);
            this.GbDatosMascota.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtIdMascota;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtRaza;
        private System.Windows.Forms.TextBox TxtObservacion;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox CboxTipoMascota;
        private System.Windows.Forms.ComboBox CboxCliente;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.DataGridView DgvListaMascotas;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox GbBuscar;
        private System.Windows.Forms.GroupBox GbDatosMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn CObservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdTipoMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdCliente;
    }
}