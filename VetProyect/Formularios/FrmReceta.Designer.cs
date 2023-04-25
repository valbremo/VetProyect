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
            this.TxtIdReceta = new System.Windows.Forms.TextBox();
            this.CboxUsuario = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CboxHistorial = new System.Windows.Forms.ComboBox();
            this.TxtFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvListaRecetas = new System.Windows.Forms.DataGridView();
            this.CIdReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIdHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SintomasHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GbDatosCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaRecetas)).BeginInit();
            this.SuspendLayout();
            // 
            // GbDatosCita
            // 
            this.GbDatosCita.Controls.Add(this.TxtPrecio);
            this.GbDatosCita.Controls.Add(this.TxtTratamiento);
            this.GbDatosCita.Controls.Add(this.TxtIdReceta);
            this.GbDatosCita.Controls.Add(this.CboxUsuario);
            this.GbDatosCita.Controls.Add(this.label7);
            this.GbDatosCita.Controls.Add(this.label6);
            this.GbDatosCita.Controls.Add(this.CboxHistorial);
            this.GbDatosCita.Controls.Add(this.TxtFecha);
            this.GbDatosCita.Controls.Add(this.label5);
            this.GbDatosCita.Controls.Add(this.label4);
            this.GbDatosCita.Controls.Add(this.label3);
            this.GbDatosCita.Controls.Add(this.label2);
            this.GbDatosCita.Location = new System.Drawing.Point(158, 458);
            this.GbDatosCita.Name = "GbDatosCita";
            this.GbDatosCita.Size = new System.Drawing.Size(961, 322);
            this.GbDatosCita.TabIndex = 26;
            this.GbDatosCita.TabStop = false;
            this.GbDatosCita.Text = "Datos de la Receta";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(527, 184);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(208, 26);
            this.TxtPrecio.TabIndex = 12;
            // 
            // TxtTratamiento
            // 
            this.TxtTratamiento.Location = new System.Drawing.Point(527, 42);
            this.TxtTratamiento.Multiline = true;
            this.TxtTratamiento.Name = "TxtTratamiento";
            this.TxtTratamiento.Size = new System.Drawing.Size(419, 85);
            this.TxtTratamiento.TabIndex = 11;
            // 
            // TxtIdReceta
            // 
            this.TxtIdReceta.Location = new System.Drawing.Point(168, 45);
            this.TxtIdReceta.Name = "TxtIdReceta";
            this.TxtIdReceta.ReadOnly = true;
            this.TxtIdReceta.Size = new System.Drawing.Size(151, 26);
            this.TxtIdReceta.TabIndex = 10;
            // 
            // CboxUsuario
            // 
            this.CboxUsuario.FormattingEnabled = true;
            this.CboxUsuario.Location = new System.Drawing.Point(527, 269);
            this.CboxUsuario.Name = "CboxUsuario";
            this.CboxUsuario.Size = new System.Drawing.Size(194, 28);
            this.CboxUsuario.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Historial";
            // 
            // CboxHistorial
            // 
            this.CboxHistorial.FormattingEnabled = true;
            this.CboxHistorial.Location = new System.Drawing.Point(149, 269);
            this.CboxHistorial.Name = "CboxHistorial";
            this.CboxHistorial.Size = new System.Drawing.Size(198, 28);
            this.CboxHistorial.TabIndex = 6;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(149, 178);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(226, 26);
            this.TxtFecha.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tratamiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 178);
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
            // DgvListaRecetas
            // 
            this.DgvListaRecetas.AllowUserToAddRows = false;
            this.DgvListaRecetas.AllowUserToDeleteRows = false;
            this.DgvListaRecetas.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.DgvListaRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaRecetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdReceta,
            this.CTratamiento,
            this.CFecha,
            this.CPrecio,
            this.CIdHistorial,
            this.CIdUsuario,
            this.SintomasHistorial,
            this.NombreUsuario});
            this.DgvListaRecetas.Location = new System.Drawing.Point(12, 87);
            this.DgvListaRecetas.Name = "DgvListaRecetas";
            this.DgvListaRecetas.ReadOnly = true;
            this.DgvListaRecetas.RowHeadersWidth = 62;
            this.DgvListaRecetas.RowTemplate.Height = 28;
            this.DgvListaRecetas.Size = new System.Drawing.Size(1232, 353);
            this.DgvListaRecetas.TabIndex = 24;
            this.DgvListaRecetas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaRecetas_CellClick);
            // 
            // CIdReceta
            // 
            this.CIdReceta.DataPropertyName = "IdReceta";
            this.CIdReceta.HeaderText = "Código";
            this.CIdReceta.MinimumWidth = 8;
            this.CIdReceta.Name = "CIdReceta";
            this.CIdReceta.ReadOnly = true;
            this.CIdReceta.Width = 150;
            // 
            // CTratamiento
            // 
            this.CTratamiento.DataPropertyName = "Tratamiento";
            this.CTratamiento.HeaderText = "Tratamiento";
            this.CTratamiento.MinimumWidth = 8;
            this.CTratamiento.Name = "CTratamiento";
            this.CTratamiento.ReadOnly = true;
            this.CTratamiento.Width = 150;
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
            // CPrecio
            // 
            this.CPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CPrecio.DataPropertyName = "Precio";
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.MinimumWidth = 8;
            this.CPrecio.Name = "CPrecio";
            this.CPrecio.ReadOnly = true;
            this.CPrecio.Width = 75;
            // 
            // CIdHistorial
            // 
            this.CIdHistorial.DataPropertyName = "IdHistorial";
            this.CIdHistorial.HeaderText = "Historial";
            this.CIdHistorial.MinimumWidth = 8;
            this.CIdHistorial.Name = "CIdHistorial";
            this.CIdHistorial.ReadOnly = true;
            this.CIdHistorial.Visible = false;
            this.CIdHistorial.Width = 150;
            // 
            // CIdUsuario
            // 
            this.CIdUsuario.DataPropertyName = "IdUsuario";
            this.CIdUsuario.HeaderText = "Usuario";
            this.CIdUsuario.MinimumWidth = 8;
            this.CIdUsuario.Name = "CIdUsuario";
            this.CIdUsuario.ReadOnly = true;
            this.CIdUsuario.Visible = false;
            this.CIdUsuario.Width = 150;
            // 
            // SintomasHistorial
            // 
            this.SintomasHistorial.DataPropertyName = "Sintomas";
            this.SintomasHistorial.HeaderText = "Síntomas presentados";
            this.SintomasHistorial.MinimumWidth = 8;
            this.SintomasHistorial.Name = "SintomasHistorial";
            this.SintomasHistorial.ReadOnly = true;
            this.SintomasHistorial.Width = 150;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.DataPropertyName = "NombreCompleto";
            this.NombreUsuario.HeaderText = "Doctora";
            this.NombreUsuario.MinimumWidth = 8;
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            this.NombreUsuario.Width = 150;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnEliminar.Location = new System.Drawing.Point(637, 790);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(156, 42);
            this.BtnEliminar.TabIndex = 23;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnModificar.Location = new System.Drawing.Point(414, 790);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(129, 42);
            this.BtnModificar.TabIndex = 22;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnAgregar.Location = new System.Drawing.Point(226, 786);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(130, 43);
            this.BtnAgregar.TabIndex = 21;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnSalir.Location = new System.Drawing.Point(882, 790);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(161, 42);
            this.BtnSalir.TabIndex = 27;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(634, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 48);
            this.label1.TabIndex = 28;
            this.label1.Text = "Control de registro de recetas";
            // 
            // FrmReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 855);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.GbDatosCita);
            this.Controls.Add(this.DgvListaRecetas);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Name = "FrmReceta";
            this.Text = "Gestión de Receta";
            this.Load += new System.EventHandler(this.FrmReceta_Load);
            this.GbDatosCita.ResumeLayout(false);
            this.GbDatosCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaRecetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbDatosCita;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtTratamiento;
        private System.Windows.Forms.TextBox TxtIdReceta;
        private System.Windows.Forms.ComboBox CboxUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboxHistorial;
        private System.Windows.Forms.DateTimePicker TxtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvListaRecetas;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SintomasHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.Label label1;
    }
}