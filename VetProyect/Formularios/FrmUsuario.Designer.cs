namespace VetProyect.Formularios
{
    partial class FrmUsuario
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
            this.CbActivo = new System.Windows.Forms.CheckBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtIdUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.ColIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbVerActivos = new System.Windows.Forms.CheckBox();
            this.GbDatosCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // GbDatosCita
            // 
            this.GbDatosCita.Controls.Add(this.CbActivo);
            this.GbDatosCita.Controls.Add(this.TxtContrasena);
            this.GbDatosCita.Controls.Add(this.TxtTelefono);
            this.GbDatosCita.Controls.Add(this.label6);
            this.GbDatosCita.Controls.Add(this.label3);
            this.GbDatosCita.Controls.Add(this.TxtCedula);
            this.GbDatosCita.Controls.Add(this.TxtNombre);
            this.GbDatosCita.Controls.Add(this.TxtIdUsuario);
            this.GbDatosCita.Controls.Add(this.label5);
            this.GbDatosCita.Controls.Add(this.label4);
            this.GbDatosCita.Controls.Add(this.label2);
            this.GbDatosCita.Location = new System.Drawing.Point(12, 461);
            this.GbDatosCita.Name = "GbDatosCita";
            this.GbDatosCita.Size = new System.Drawing.Size(757, 218);
            this.GbDatosCita.TabIndex = 26;
            this.GbDatosCita.TabStop = false;
            this.GbDatosCita.Text = "Datos del Usuario";
            // 
            // CbActivo
            // 
            this.CbActivo.AutoSize = true;
            this.CbActivo.Location = new System.Drawing.Point(457, 181);
            this.CbActivo.Name = "CbActivo";
            this.CbActivo.Size = new System.Drawing.Size(78, 24);
            this.CbActivo.TabIndex = 17;
            this.CbActivo.Text = "Activo";
            this.CbActivo.UseVisualStyleBackColor = true;
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(582, 121);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(168, 26);
            this.TxtContrasena.TabIndex = 16;
            this.TxtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContrasena_KeyPress);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(582, 52);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(168, 26);
            this.TxtTelefono.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Teléfono";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(137, 175);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(195, 26);
            this.TxtCedula.TabIndex = 12;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(137, 121);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(202, 26);
            this.TxtNombre.TabIndex = 11;
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.Location = new System.Drawing.Point(157, 46);
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.ReadOnly = true;
            this.TxtIdUsuario.Size = new System.Drawing.Size(151, 26);
            this.TxtIdUsuario.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cédula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // DgvListaUsuarios
            // 
            this.DgvListaUsuarios.AllowUserToAddRows = false;
            this.DgvListaUsuarios.AllowUserToDeleteRows = false;
            this.DgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdUsuario,
            this.ColNombreCompleto,
            this.ColCedula,
            this.ColTelefono});
            this.DgvListaUsuarios.Location = new System.Drawing.Point(123, 137);
            this.DgvListaUsuarios.Name = "DgvListaUsuarios";
            this.DgvListaUsuarios.ReadOnly = true;
            this.DgvListaUsuarios.RowHeadersVisible = false;
            this.DgvListaUsuarios.RowHeadersWidth = 62;
            this.DgvListaUsuarios.RowTemplate.Height = 28;
            this.DgvListaUsuarios.Size = new System.Drawing.Size(602, 301);
            this.DgvListaUsuarios.TabIndex = 24;
            this.DgvListaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaUsuarios_CellClick);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(410, 686);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(212, 52);
            this.BtnEliminar.TabIndex = 23;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(219, 686);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(180, 50);
            this.BtnModificar.TabIndex = 22;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(25, 685);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(171, 51);
            this.BtnAgregar.TabIndex = 21;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Control de registro de usuarios";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Buscar";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(219, 79);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(434, 26);
            this.TxtBuscar.TabIndex = 28;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(628, 688);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(181, 50);
            this.BtnSalir.TabIndex = 29;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // ColIdUsuario
            // 
            this.ColIdUsuario.DataPropertyName = "IdUsuario";
            this.ColIdUsuario.HeaderText = "Código";
            this.ColIdUsuario.MinimumWidth = 8;
            this.ColIdUsuario.Name = "ColIdUsuario";
            this.ColIdUsuario.ReadOnly = true;
            this.ColIdUsuario.Width = 150;
            // 
            // ColNombreCompleto
            // 
            this.ColNombreCompleto.DataPropertyName = "NombreCompleto";
            this.ColNombreCompleto.HeaderText = "Nombre";
            this.ColNombreCompleto.MinimumWidth = 8;
            this.ColNombreCompleto.Name = "ColNombreCompleto";
            this.ColNombreCompleto.ReadOnly = true;
            this.ColNombreCompleto.Width = 150;
            // 
            // ColCedula
            // 
            this.ColCedula.DataPropertyName = "Cedula";
            this.ColCedula.HeaderText = "Cédula";
            this.ColCedula.MinimumWidth = 8;
            this.ColCedula.Name = "ColCedula";
            this.ColCedula.ReadOnly = true;
            this.ColCedula.Width = 150;
            // 
            // ColTelefono
            // 
            this.ColTelefono.DataPropertyName = "Telefono";
            this.ColTelefono.HeaderText = "Teléfono";
            this.ColTelefono.MinimumWidth = 8;
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            this.ColTelefono.Width = 150;
            // 
            // CbVerActivos
            // 
            this.CbVerActivos.AutoSize = true;
            this.CbVerActivos.Checked = true;
            this.CbVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbVerActivos.Location = new System.Drawing.Point(656, 107);
            this.CbVerActivos.Name = "CbVerActivos";
            this.CbVerActivos.Size = new System.Drawing.Size(153, 24);
            this.CbVerActivos.TabIndex = 30;
            this.CbVerActivos.Text = "Usuarios Activos";
            this.CbVerActivos.UseVisualStyleBackColor = true;
            this.CbVerActivos.CheckedChanged += new System.EventHandler(this.CbVerActivos_CheckedChanged);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 741);
            this.Controls.Add(this.CbVerActivos);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GbDatosCita);
            this.Controls.Add(this.DgvListaUsuarios);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label1);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.GbDatosCita.ResumeLayout(false);
            this.GbDatosCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbDatosCita;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtIdUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvListaUsuarios;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.CheckBox CbActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.CheckBox CbVerActivos;
    }
}