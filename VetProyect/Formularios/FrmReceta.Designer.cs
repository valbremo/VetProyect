namespace VetProyect.Formularios
{
    partial class FrmReceta
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
            this.GbDatosCita = new System.Windows.Forms.GroupBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtTratamiento = new System.Windows.Forms.TextBox();
            this.TxtIdRecetaa = new System.Windows.Forms.TextBox();
            this.CbIdUsuario = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbIdHistorial = new System.Windows.Forms.ComboBox();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GbBuscarCita = new System.Windows.Forms.GroupBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbVerID = new System.Windows.Forms.CheckBox();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.ColIdReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbDatosCita.SuspendLayout();
            this.GbBuscarCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // GbDatosCita
            // 
            this.GbDatosCita.Controls.Add(this.TxtPrecio);
            this.GbDatosCita.Controls.Add(this.TxtTratamiento);
            this.GbDatosCita.Controls.Add(this.TxtIdRecetaa);
            this.GbDatosCita.Controls.Add(this.CbIdUsuario);
            this.GbDatosCita.Controls.Add(this.label7);
            this.GbDatosCita.Controls.Add(this.label6);
            this.GbDatosCita.Controls.Add(this.CbIdHistorial);
            this.GbDatosCita.Controls.Add(this.dateTimeFecha);
            this.GbDatosCita.Controls.Add(this.label5);
            this.GbDatosCita.Controls.Add(this.label4);
            this.GbDatosCita.Controls.Add(this.label3);
            this.GbDatosCita.Controls.Add(this.label2);
            this.GbDatosCita.Location = new System.Drawing.Point(18, 49);
            this.GbDatosCita.Name = "GbDatosCita";
            this.GbDatosCita.Size = new System.Drawing.Size(483, 430);
            this.GbDatosCita.TabIndex = 26;
            this.GbDatosCita.TabStop = false;
            this.GbDatosCita.Text = "Datos de la Receta";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(217, 219);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(195, 26);
            this.TxtPrecio.TabIndex = 12;
            // 
            // TxtTratamiento
            // 
            this.TxtTratamiento.Location = new System.Drawing.Point(211, 120);
            this.TxtTratamiento.Name = "TxtTratamiento";
            this.TxtTratamiento.Size = new System.Drawing.Size(202, 26);
            this.TxtTratamiento.TabIndex = 11;
            // 
            // TxtIdRecetaa
            // 
            this.TxtIdRecetaa.Location = new System.Drawing.Point(215, 40);
            this.TxtIdRecetaa.Name = "TxtIdRecetaa";
            this.TxtIdRecetaa.ReadOnly = true;
            this.TxtIdRecetaa.Size = new System.Drawing.Size(151, 26);
            this.TxtIdRecetaa.TabIndex = 10;
            // 
            // CbIdUsuario
            // 
            this.CbIdUsuario.FormattingEnabled = true;
            this.CbIdUsuario.Location = new System.Drawing.Point(218, 333);
            this.CbIdUsuario.Name = "CbIdUsuario";
            this.CbIdUsuario.Size = new System.Drawing.Size(194, 28);
            this.CbIdUsuario.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Historial";
            // 
            // CbIdHistorial
            // 
            this.CbIdHistorial.FormattingEnabled = true;
            this.CbIdHistorial.Location = new System.Drawing.Point(215, 289);
            this.CbIdHistorial.Name = "CbIdHistorial";
            this.CbIdHistorial.Size = new System.Drawing.Size(198, 28);
            this.CbIdHistorial.TabIndex = 6;
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.Location = new System.Drawing.Point(211, 173);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(226, 26);
            this.dateTimeFecha.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tratamiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // GbBuscarCita
            // 
            this.GbBuscarCita.Controls.Add(this.TxtBuscar);
            this.GbBuscarCita.Controls.Add(this.CbVerID);
            this.GbBuscarCita.Location = new System.Drawing.Point(557, 49);
            this.GbBuscarCita.Name = "GbBuscarCita";
            this.GbBuscarCita.Size = new System.Drawing.Size(982, 101);
            this.GbBuscarCita.TabIndex = 25;
            this.GbBuscarCita.TabStop = false;
            this.GbBuscarCita.Text = "Buscar Receta";
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
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdReceta,
            this.ColTratamiento,
            this.ColFecha,
            this.ColPrecio,
            this.ColHistorial,
            this.ColIdUsuario});
            this.DgvLista.Location = new System.Drawing.Point(566, 172);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersWidth = 62;
            this.DgvLista.RowTemplate.Height = 28;
            this.DgvLista.Size = new System.Drawing.Size(974, 353);
            this.DgvLista.TabIndex = 24;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(973, 563);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(212, 58);
            this.BtnEliminar.TabIndex = 23;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(763, 567);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(180, 50);
            this.BtnModificar.TabIndex = 22;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(575, 563);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(171, 51);
            this.BtnAgregar.TabIndex = 21;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Control de registro de Recetas";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(1209, 570);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(212, 43);
            this.BtnSalir.TabIndex = 27;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // ColIdReceta
            // 
            this.ColIdReceta.DataPropertyName = "IdReceta";
            this.ColIdReceta.HeaderText = "Código";
            this.ColIdReceta.MinimumWidth = 8;
            this.ColIdReceta.Name = "ColIdReceta";
            this.ColIdReceta.ReadOnly = true;
            this.ColIdReceta.Width = 150;
            // 
            // ColTratamiento
            // 
            this.ColTratamiento.DataPropertyName = "Tratamiento";
            this.ColTratamiento.HeaderText = "Tratamiento";
            this.ColTratamiento.MinimumWidth = 8;
            this.ColTratamiento.Name = "ColTratamiento";
            this.ColTratamiento.ReadOnly = true;
            this.ColTratamiento.Width = 150;
            // 
            // ColFecha
            // 
            this.ColFecha.DataPropertyName = "Fecha";
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.MinimumWidth = 8;
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            this.ColFecha.Width = 150;
            // 
            // ColPrecio
            // 
            this.ColPrecio.DataPropertyName = "Precio";
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.MinimumWidth = 8;
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 150;
            // 
            // ColHistorial
            // 
            this.ColHistorial.DataPropertyName = "IdHistorial";
            this.ColHistorial.HeaderText = "Historial";
            this.ColHistorial.MinimumWidth = 8;
            this.ColHistorial.Name = "ColHistorial";
            this.ColHistorial.ReadOnly = true;
            this.ColHistorial.Width = 150;
            // 
            // ColIdUsuario
            // 
            this.ColIdUsuario.DataPropertyName = "IdUsuario";
            this.ColIdUsuario.HeaderText = "Usuario";
            this.ColIdUsuario.MinimumWidth = 8;
            this.ColIdUsuario.Name = "ColIdUsuario";
            this.ColIdUsuario.ReadOnly = true;
            this.ColIdUsuario.Width = 150;
            // 
            // FrmReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 638);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.GbDatosCita);
            this.Controls.Add(this.GbBuscarCita);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label1);
            this.Name = "FrmReceta";
            this.Text = "FrmReceta";
            this.GbDatosCita.ResumeLayout(false);
            this.GbDatosCita.PerformLayout();
            this.GbBuscarCita.ResumeLayout(false);
            this.GbBuscarCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbDatosCita;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtTratamiento;
        private System.Windows.Forms.TextBox TxtIdRecetaa;
        private System.Windows.Forms.ComboBox CbIdUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbIdHistorial;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GbBuscarCita;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.CheckBox CbVerID;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdUsuario;
        private System.Windows.Forms.Button BtnSalir;
    }
}