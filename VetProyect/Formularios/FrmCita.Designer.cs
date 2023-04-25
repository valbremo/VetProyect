namespace VetProyect.Formularios
{
    partial class FrmCita
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
            this.TxtFecha = new System.Windows.Forms.DateTimePicker();
            this.CboxCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CboxMascota = new System.Windows.Forms.ComboBox();
            this.TxtIdCita = new System.Windows.Forms.TextBox();
            this.TxtEspecificacion = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.DgvListaCitas = new System.Windows.Forms.DataGridView();
            this.CIdCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEspecificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIdMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbBuscarCita = new System.Windows.Forms.GroupBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.GbDatosCita = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCitas)).BeginInit();
            this.GbBuscarCita.SuspendLayout();
            this.GbDatosCita.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de registro de citas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Especificación";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(275, 74);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(304, 26);
            this.TxtFecha.TabIndex = 5;
            // 
            // CboxCliente
            // 
            this.CboxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxCliente.FormattingEnabled = true;
            this.CboxCliente.Location = new System.Drawing.Point(123, 136);
            this.CboxCliente.Name = "CboxCliente";
            this.CboxCliente.Size = new System.Drawing.Size(226, 28);
            this.CboxCliente.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mascota";
            // 
            // CboxMascota
            // 
            this.CboxMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxMascota.FormattingEnabled = true;
            this.CboxMascota.Location = new System.Drawing.Point(123, 210);
            this.CboxMascota.Name = "CboxMascota";
            this.CboxMascota.Size = new System.Drawing.Size(226, 28);
            this.CboxMascota.TabIndex = 9;
            // 
            // TxtIdCita
            // 
            this.TxtIdCita.Location = new System.Drawing.Point(37, 74);
            this.TxtIdCita.Name = "TxtIdCita";
            this.TxtIdCita.ReadOnly = true;
            this.TxtIdCita.Size = new System.Drawing.Size(118, 26);
            this.TxtIdCita.TabIndex = 10;
            // 
            // TxtEspecificacion
            // 
            this.TxtEspecificacion.Location = new System.Drawing.Point(618, 76);
            this.TxtEspecificacion.Name = "TxtEspecificacion";
            this.TxtEspecificacion.Size = new System.Drawing.Size(202, 26);
            this.TxtEspecificacion.TabIndex = 11;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnAgregar.Location = new System.Drawing.Point(34, 748);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(171, 51);
            this.BtnAgregar.TabIndex = 13;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnModificar.Location = new System.Drawing.Point(275, 748);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(180, 50);
            this.BtnModificar.TabIndex = 14;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnEliminar.Location = new System.Drawing.Point(530, 748);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(212, 51);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnSalir.Location = new System.Drawing.Point(807, 748);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(181, 51);
            this.BtnSalir.TabIndex = 16;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // DgvListaCitas
            // 
            this.DgvListaCitas.AllowUserToAddRows = false;
            this.DgvListaCitas.AllowUserToDeleteRows = false;
            this.DgvListaCitas.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.DgvListaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdCita,
            this.CFecha,
            this.CEspecificacion,
            this.CIdCliente,
            this.CIdMascota,
            this.NombreCliente,
            this.Mascota});
            this.DgvListaCitas.Location = new System.Drawing.Point(23, 356);
            this.DgvListaCitas.Name = "DgvListaCitas";
            this.DgvListaCitas.ReadOnly = true;
            this.DgvListaCitas.RowHeadersWidth = 62;
            this.DgvListaCitas.RowTemplate.Height = 28;
            this.DgvListaCitas.Size = new System.Drawing.Size(965, 353);
            this.DgvListaCitas.TabIndex = 17;
            this.DgvListaCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaCitas_CellClick);
            this.DgvListaCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CIdCita
            // 
            this.CIdCita.DataPropertyName = "IdCita";
            this.CIdCita.HeaderText = "Código";
            this.CIdCita.MinimumWidth = 8;
            this.CIdCita.Name = "CIdCita";
            this.CIdCita.ReadOnly = true;
            this.CIdCita.Width = 150;
            // 
            // CFecha
            // 
            this.CFecha.DataPropertyName = "Fecha";
            this.CFecha.HeaderText = "Fecha Agendada";
            this.CFecha.MinimumWidth = 8;
            this.CFecha.Name = "CFecha";
            this.CFecha.ReadOnly = true;
            this.CFecha.Width = 150;
            // 
            // CEspecificacion
            // 
            this.CEspecificacion.DataPropertyName = "Especificacion";
            this.CEspecificacion.HeaderText = "Propósito";
            this.CEspecificacion.MinimumWidth = 8;
            this.CEspecificacion.Name = "CEspecificacion";
            this.CEspecificacion.ReadOnly = true;
            this.CEspecificacion.Width = 150;
            // 
            // CIdCliente
            // 
            this.CIdCliente.DataPropertyName = "IdCliente";
            this.CIdCliente.HeaderText = "Dueño";
            this.CIdCliente.MinimumWidth = 8;
            this.CIdCliente.Name = "CIdCliente";
            this.CIdCliente.ReadOnly = true;
            this.CIdCliente.Visible = false;
            this.CIdCliente.Width = 150;
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
            // NombreCliente
            // 
            this.NombreCliente.DataPropertyName = "NombreCompleto";
            this.NombreCliente.HeaderText = "Nombre del dueño";
            this.NombreCliente.MinimumWidth = 8;
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 150;
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
            // GbBuscarCita
            // 
            this.GbBuscarCita.Controls.Add(this.TxtBuscar);
            this.GbBuscarCita.Location = new System.Drawing.Point(91, 407);
            this.GbBuscarCita.Name = "GbBuscarCita";
            this.GbBuscarCita.Size = new System.Drawing.Size(763, 59);
            this.GbBuscarCita.TabIndex = 18;
            this.GbBuscarCita.TabStop = false;
            this.GbBuscarCita.Text = "Buscar Cita";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(219, 39);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(523, 26);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // GbDatosCita
            // 
            this.GbDatosCita.Controls.Add(this.GbBuscarCita);
            this.GbDatosCita.Controls.Add(this.TxtEspecificacion);
            this.GbDatosCita.Controls.Add(this.TxtIdCita);
            this.GbDatosCita.Controls.Add(this.CboxMascota);
            this.GbDatosCita.Controls.Add(this.label7);
            this.GbDatosCita.Controls.Add(this.label6);
            this.GbDatosCita.Controls.Add(this.CboxCliente);
            this.GbDatosCita.Controls.Add(this.TxtFecha);
            this.GbDatosCita.Controls.Add(this.label4);
            this.GbDatosCita.Controls.Add(this.label3);
            this.GbDatosCita.Controls.Add(this.label2);
            this.GbDatosCita.Location = new System.Drawing.Point(62, 72);
            this.GbDatosCita.Name = "GbDatosCita";
            this.GbDatosCita.Size = new System.Drawing.Size(926, 266);
            this.GbDatosCita.TabIndex = 19;
            this.GbDatosCita.TabStop = false;
            this.GbDatosCita.Text = "Datos de la Cita";
            // 
            // FrmCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 821);
            this.Controls.Add(this.GbDatosCita);
            this.Controls.Add(this.DgvListaCitas);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label1);
            this.Name = "FrmCita";
            this.Text = "Gestión de Citas";
            this.Load += new System.EventHandler(this.FrmCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCitas)).EndInit();
            this.GbBuscarCita.ResumeLayout(false);
            this.GbBuscarCita.PerformLayout();
            this.GbDatosCita.ResumeLayout(false);
            this.GbDatosCita.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TxtFecha;
        private System.Windows.Forms.ComboBox CboxCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboxMascota;
        private System.Windows.Forms.TextBox TxtIdCita;
        private System.Windows.Forms.TextBox TxtEspecificacion;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView DgvListaCitas;
        private System.Windows.Forms.GroupBox GbBuscarCita;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.GroupBox GbDatosCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEspecificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mascota;
    }
}