namespace VetProyect.Formularios
{
    partial class Mascota
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtRaza = new System.Windows.Forms.TextBox();
            this.TxtObservacion = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.TxtIdTipoMascota = new System.Windows.Forms.ComboBox();
            this.TxtIdCliente = new System.Windows.Forms.ComboBox();
            this.CbVerId = new System.Windows.Forms.CheckBox();
            this.CbVerNombre = new System.Windows.Forms.CheckBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.ColIdMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRaza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdTipoMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.GbBuscar = new System.Windows.Forms.GroupBox();
            this.GbDatosMascota = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.GbBuscar.SuspendLayout();
            this.GbDatosMascota.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(633, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Mascotas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Raza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Observación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo de Mascota";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dueño";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(120, 60);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(186, 26);
            this.TxtId.TabIndex = 8;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(123, 105);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(203, 26);
            this.TxtNombre.TabIndex = 9;
            // 
            // TxtRaza
            // 
            this.TxtRaza.Location = new System.Drawing.Point(113, 207);
            this.TxtRaza.Name = "TxtRaza";
            this.TxtRaza.Size = new System.Drawing.Size(171, 26);
            this.TxtRaza.TabIndex = 11;
            // 
            // TxtObservacion
            // 
            this.TxtObservacion.Location = new System.Drawing.Point(135, 250);
            this.TxtObservacion.Name = "TxtObservacion";
            this.TxtObservacion.Size = new System.Drawing.Size(190, 26);
            this.TxtObservacion.TabIndex = 12;
            // 
            // TxtIdTipoMascota
            // 
            this.TxtIdTipoMascota.FormattingEnabled = true;
            this.TxtIdTipoMascota.Location = new System.Drawing.Point(154, 298);
            this.TxtIdTipoMascota.Name = "TxtIdTipoMascota";
            this.TxtIdTipoMascota.Size = new System.Drawing.Size(215, 28);
            this.TxtIdTipoMascota.TabIndex = 13;
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.FormattingEnabled = true;
            this.TxtIdCliente.Location = new System.Drawing.Point(154, 343);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(188, 28);
            this.TxtIdCliente.TabIndex = 14;
            // 
            // CbVerId
            // 
            this.CbVerId.AutoSize = true;
            this.CbVerId.Location = new System.Drawing.Point(18, 56);
            this.CbVerId.Name = "CbVerId";
            this.CbVerId.Size = new System.Drawing.Size(85, 24);
            this.CbVerId.TabIndex = 15;
            this.CbVerId.Text = "Código";
            this.CbVerId.UseVisualStyleBackColor = true;
            // 
            // CbVerNombre
            // 
            this.CbVerNombre.AutoSize = true;
            this.CbVerNombre.Location = new System.Drawing.Point(201, 56);
            this.CbVerNombre.Name = "CbVerNombre";
            this.CbVerNombre.Size = new System.Drawing.Size(91, 24);
            this.CbVerNombre.TabIndex = 16;
            this.CbVerNombre.Text = "Nombre";
            this.CbVerNombre.UseVisualStyleBackColor = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(314, 44);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(317, 26);
            this.TxtBuscar.TabIndex = 17;
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.Location = new System.Drawing.Point(182, 158);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(186, 26);
            this.dateTimeFecha.TabIndex = 18;
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdMascota,
            this.ColNombre,
            this.ColFechaNacimiento,
            this.ColRaza,
            this.ColObservacion,
            this.ColIdTipoMascota,
            this.ColIdCliente});
            this.DgvLista.Location = new System.Drawing.Point(522, 199);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersWidth = 62;
            this.DgvLista.RowTemplate.Height = 28;
            this.DgvLista.Size = new System.Drawing.Size(1113, 265);
            this.DgvLista.TabIndex = 19;
            // 
            // ColIdMascota
            // 
            this.ColIdMascota.DataPropertyName = "IdMascota";
            this.ColIdMascota.HeaderText = "Código";
            this.ColIdMascota.MinimumWidth = 8;
            this.ColIdMascota.Name = "ColIdMascota";
            this.ColIdMascota.ReadOnly = true;
            this.ColIdMascota.Width = 150;
            // 
            // ColNombre
            // 
            this.ColNombre.DataPropertyName = "Nombre";
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 8;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 150;
            // 
            // ColFechaNacimiento
            // 
            this.ColFechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.ColFechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.ColFechaNacimiento.MinimumWidth = 8;
            this.ColFechaNacimiento.Name = "ColFechaNacimiento";
            this.ColFechaNacimiento.ReadOnly = true;
            this.ColFechaNacimiento.Width = 150;
            // 
            // ColRaza
            // 
            this.ColRaza.DataPropertyName = "Raza";
            this.ColRaza.HeaderText = "Raza";
            this.ColRaza.MinimumWidth = 8;
            this.ColRaza.Name = "ColRaza";
            this.ColRaza.ReadOnly = true;
            this.ColRaza.Width = 150;
            // 
            // ColObservacion
            // 
            this.ColObservacion.DataPropertyName = "Observacion";
            this.ColObservacion.HeaderText = "Observación";
            this.ColObservacion.MinimumWidth = 8;
            this.ColObservacion.Name = "ColObservacion";
            this.ColObservacion.ReadOnly = true;
            this.ColObservacion.Width = 150;
            // 
            // ColIdTipoMascota
            // 
            this.ColIdTipoMascota.DataPropertyName = "IdTipoMascota";
            this.ColIdTipoMascota.HeaderText = "Tipo de Mascota";
            this.ColIdTipoMascota.MinimumWidth = 8;
            this.ColIdTipoMascota.Name = "ColIdTipoMascota";
            this.ColIdTipoMascota.ReadOnly = true;
            this.ColIdTipoMascota.Width = 150;
            // 
            // ColIdCliente
            // 
            this.ColIdCliente.DataPropertyName = "IdCliente";
            this.ColIdCliente.HeaderText = "Dueño";
            this.ColIdCliente.MinimumWidth = 8;
            this.ColIdCliente.Name = "ColIdCliente";
            this.ColIdCliente.ReadOnly = true;
            this.ColIdCliente.Width = 150;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(493, 538);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(203, 72);
            this.BtnAgregar.TabIndex = 20;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(753, 535);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(200, 73);
            this.BtnModificar.TabIndex = 21;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(1016, 538);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(270, 70);
            this.BtnEliminar.TabIndex = 22;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(1345, 535);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(237, 73);
            this.BtnSalir.TabIndex = 23;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // GbBuscar
            // 
            this.GbBuscar.Controls.Add(this.TxtBuscar);
            this.GbBuscar.Controls.Add(this.CbVerNombre);
            this.GbBuscar.Controls.Add(this.CbVerId);
            this.GbBuscar.Location = new System.Drawing.Point(552, 76);
            this.GbBuscar.Name = "GbBuscar";
            this.GbBuscar.Size = new System.Drawing.Size(950, 109);
            this.GbBuscar.TabIndex = 24;
            this.GbBuscar.TabStop = false;
            this.GbBuscar.Text = "Buscar Mascota";
            // 
            // GbDatosMascota
            // 
            this.GbDatosMascota.Controls.Add(this.dateTimeFecha);
            this.GbDatosMascota.Controls.Add(this.TxtIdCliente);
            this.GbDatosMascota.Controls.Add(this.TxtIdTipoMascota);
            this.GbDatosMascota.Controls.Add(this.TxtObservacion);
            this.GbDatosMascota.Controls.Add(this.TxtRaza);
            this.GbDatosMascota.Controls.Add(this.TxtNombre);
            this.GbDatosMascota.Controls.Add(this.TxtId);
            this.GbDatosMascota.Controls.Add(this.label8);
            this.GbDatosMascota.Controls.Add(this.label7);
            this.GbDatosMascota.Controls.Add(this.label6);
            this.GbDatosMascota.Controls.Add(this.label5);
            this.GbDatosMascota.Controls.Add(this.label4);
            this.GbDatosMascota.Controls.Add(this.label3);
            this.GbDatosMascota.Controls.Add(this.label2);
            this.GbDatosMascota.Location = new System.Drawing.Point(44, 62);
            this.GbDatosMascota.Name = "GbDatosMascota";
            this.GbDatosMascota.Size = new System.Drawing.Size(425, 476);
            this.GbDatosMascota.TabIndex = 25;
            this.GbDatosMascota.TabStop = false;
            this.GbDatosMascota.Text = "Datos de la Mascota";
            // 
            // Mascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 633);
            this.Controls.Add(this.GbDatosMascota);
            this.Controls.Add(this.GbBuscar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.label1);
            this.Name = "Mascota";
            this.Text = "Mascota";
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.GbBuscar.ResumeLayout(false);
            this.GbBuscar.PerformLayout();
            this.GbDatosMascota.ResumeLayout(false);
            this.GbDatosMascota.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtRaza;
        private System.Windows.Forms.TextBox TxtObservacion;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox TxtIdTipoMascota;
        private System.Windows.Forms.ComboBox TxtIdCliente;
        private System.Windows.Forms.CheckBox CbVerId;
        private System.Windows.Forms.CheckBox CbVerNombre;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColObservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdTipoMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdCliente;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox GbBuscar;
        private System.Windows.Forms.GroupBox GbDatosMascota;
    }
}