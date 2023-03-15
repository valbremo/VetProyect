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
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.CbIdCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CbIdMascota = new System.Windows.Forms.ComboBox();
            this.TxtIdCita = new System.Windows.Forms.TextBox();
            this.TxtEspecificacion = new System.Windows.Forms.TextBox();
            this.TxtDisponibilidad = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.ColIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEspecificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbBuscarCita = new System.Windows.Forms.GroupBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbVerID = new System.Windows.Forms.CheckBox();
            this.GbDatosCita = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.GbBuscarCita.SuspendLayout();
            this.GbDatosCita.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 32);
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
            this.label3.Location = new System.Drawing.Point(33, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Especificación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Disponiblilidad";
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.Location = new System.Drawing.Point(187, 100);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(226, 26);
            this.dateTimeFecha.TabIndex = 5;
            // 
            // CbIdCliente
            // 
            this.CbIdCliente.FormattingEnabled = true;
            this.CbIdCliente.Location = new System.Drawing.Point(215, 289);
            this.CbIdCliente.Name = "CbIdCliente";
            this.CbIdCliente.Size = new System.Drawing.Size(198, 28);
            this.CbIdCliente.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mascota";
            // 
            // CbIdMascota
            // 
            this.CbIdMascota.FormattingEnabled = true;
            this.CbIdMascota.Location = new System.Drawing.Point(218, 333);
            this.CbIdMascota.Name = "CbIdMascota";
            this.CbIdMascota.Size = new System.Drawing.Size(194, 28);
            this.CbIdMascota.TabIndex = 9;
            // 
            // TxtIdCita
            // 
            this.TxtIdCita.Location = new System.Drawing.Point(215, 40);
            this.TxtIdCita.Name = "TxtIdCita";
            this.TxtIdCita.ReadOnly = true;
            this.TxtIdCita.Size = new System.Drawing.Size(151, 26);
            this.TxtIdCita.TabIndex = 10;
            // 
            // TxtEspecificacion
            // 
            this.TxtEspecificacion.Location = new System.Drawing.Point(209, 160);
            this.TxtEspecificacion.Name = "TxtEspecificacion";
            this.TxtEspecificacion.Size = new System.Drawing.Size(202, 26);
            this.TxtEspecificacion.TabIndex = 11;
            // 
            // TxtDisponibilidad
            // 
            this.TxtDisponibilidad.Location = new System.Drawing.Point(217, 219);
            this.TxtDisponibilidad.Name = "TxtDisponibilidad";
            this.TxtDisponibilidad.Size = new System.Drawing.Size(195, 26);
            this.TxtDisponibilidad.TabIndex = 12;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(573, 583);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(171, 51);
            this.BtnAgregar.TabIndex = 13;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(761, 587);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(180, 50);
            this.BtnModificar.TabIndex = 14;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(971, 583);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(212, 58);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(1200, 593);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(181, 48);
            this.BtnSalir.TabIndex = 16;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdCliente,
            this.ColFecha,
            this.ColEspecificacion,
            this.ColDisponible,
            this.ColCliente,
            this.Mascota});
            this.DgvLista.Location = new System.Drawing.Point(564, 192);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersWidth = 62;
            this.DgvLista.RowTemplate.Height = 28;
            this.DgvLista.Size = new System.Drawing.Size(974, 353);
            this.DgvLista.TabIndex = 17;
            this.DgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColIdCliente
            // 
            this.ColIdCliente.DataPropertyName = "IdCita";
            this.ColIdCliente.HeaderText = "Código";
            this.ColIdCliente.MinimumWidth = 8;
            this.ColIdCliente.Name = "ColIdCliente";
            this.ColIdCliente.ReadOnly = true;
            this.ColIdCliente.Width = 150;
            // 
            // ColFecha
            // 
            this.ColFecha.DataPropertyName = "Fecha";
            this.ColFecha.HeaderText = "Fecha Agendada";
            this.ColFecha.MinimumWidth = 8;
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            this.ColFecha.Width = 150;
            // 
            // ColEspecificacion
            // 
            this.ColEspecificacion.DataPropertyName = "Especificacion";
            this.ColEspecificacion.HeaderText = "Propósito";
            this.ColEspecificacion.MinimumWidth = 8;
            this.ColEspecificacion.Name = "ColEspecificacion";
            this.ColEspecificacion.ReadOnly = true;
            this.ColEspecificacion.Width = 150;
            // 
            // ColDisponible
            // 
            this.ColDisponible.DataPropertyName = "Disponible";
            this.ColDisponible.HeaderText = "Disponibilidad";
            this.ColDisponible.MinimumWidth = 8;
            this.ColDisponible.Name = "ColDisponible";
            this.ColDisponible.ReadOnly = true;
            this.ColDisponible.Width = 150;
            // 
            // ColCliente
            // 
            this.ColCliente.DataPropertyName = "IdCliente";
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.MinimumWidth = 8;
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            this.ColCliente.Width = 150;
            // 
            // Mascota
            // 
            this.Mascota.DataPropertyName = "IdMascota";
            this.Mascota.HeaderText = "Mascota";
            this.Mascota.MinimumWidth = 8;
            this.Mascota.Name = "Mascota";
            this.Mascota.ReadOnly = true;
            this.Mascota.Width = 150;
            // 
            // GbBuscarCita
            // 
            this.GbBuscarCita.Controls.Add(this.TxtBuscar);
            this.GbBuscarCita.Controls.Add(this.CbVerID);
            this.GbBuscarCita.Location = new System.Drawing.Point(555, 69);
            this.GbBuscarCita.Name = "GbBuscarCita";
            this.GbBuscarCita.Size = new System.Drawing.Size(982, 101);
            this.GbBuscarCita.TabIndex = 18;
            this.GbBuscarCita.TabStop = false;
            this.GbBuscarCita.Text = "Buscar Cita";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(357, 40);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(523, 26);
            this.TxtBuscar.TabIndex = 1;
            // 
            // CbVerID
            // 
            this.CbVerID.AutoSize = true;
            this.CbVerID.Location = new System.Drawing.Point(206, 40);
            this.CbVerID.Name = "CbVerID";
            this.CbVerID.Size = new System.Drawing.Size(85, 24);
            this.CbVerID.TabIndex = 0;
            this.CbVerID.Text = "Código";
            this.CbVerID.UseVisualStyleBackColor = true;
            // 
            // GbDatosCita
            // 
            this.GbDatosCita.Controls.Add(this.TxtDisponibilidad);
            this.GbDatosCita.Controls.Add(this.TxtEspecificacion);
            this.GbDatosCita.Controls.Add(this.TxtIdCita);
            this.GbDatosCita.Controls.Add(this.CbIdMascota);
            this.GbDatosCita.Controls.Add(this.label7);
            this.GbDatosCita.Controls.Add(this.label6);
            this.GbDatosCita.Controls.Add(this.CbIdCliente);
            this.GbDatosCita.Controls.Add(this.dateTimeFecha);
            this.GbDatosCita.Controls.Add(this.label5);
            this.GbDatosCita.Controls.Add(this.label4);
            this.GbDatosCita.Controls.Add(this.label3);
            this.GbDatosCita.Controls.Add(this.label2);
            this.GbDatosCita.Location = new System.Drawing.Point(16, 69);
            this.GbDatosCita.Name = "GbDatosCita";
            this.GbDatosCita.Size = new System.Drawing.Size(483, 430);
            this.GbDatosCita.TabIndex = 19;
            this.GbDatosCita.TabStop = false;
            this.GbDatosCita.Text = "Datos de la Cita";
            // 
            // FrmCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 673);
            this.Controls.Add(this.GbDatosCita);
            this.Controls.Add(this.GbBuscarCita);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label1);
            this.Name = "FrmCita";
            this.Text = "Gestión de Citas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
        private System.Windows.Forms.ComboBox CbIdCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbIdMascota;
        private System.Windows.Forms.TextBox TxtIdCita;
        private System.Windows.Forms.TextBox TxtEspecificacion;
        private System.Windows.Forms.TextBox TxtDisponibilidad;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEspecificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mascota;
        private System.Windows.Forms.GroupBox GbBuscarCita;
        private System.Windows.Forms.CheckBox CbVerID;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.GroupBox GbDatosCita;
    }
}