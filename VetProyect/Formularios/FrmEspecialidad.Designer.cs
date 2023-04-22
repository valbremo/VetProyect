namespace VetProyect.Formularios
{
    partial class FrmEspecialidad
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.GbDatosTipoMascota = new System.Windows.Forms.GroupBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtIdEspecialidad = new System.Windows.Forms.TextBox();
            this.DgvListaEspecialidad = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CIdEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbDatosTipoMascota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaEspecialidad)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnAgregar.Location = new System.Drawing.Point(776, 55);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(151, 56);
            this.BtnAgregar.TabIndex = 9;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnSalir.Location = new System.Drawing.Point(776, 295);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(151, 57);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnEliminar.Location = new System.Drawing.Point(776, 209);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(151, 61);
            this.BtnEliminar.TabIndex = 10;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnModificar.Location = new System.Drawing.Point(776, 132);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(151, 59);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // GbDatosTipoMascota
            // 
            this.GbDatosTipoMascota.Controls.Add(this.TxtNombre);
            this.GbDatosTipoMascota.Controls.Add(this.TxtIdEspecialidad);
            this.GbDatosTipoMascota.Controls.Add(this.DgvListaEspecialidad);
            this.GbDatosTipoMascota.Controls.Add(this.label2);
            this.GbDatosTipoMascota.Controls.Add(this.label1);
            this.GbDatosTipoMascota.Location = new System.Drawing.Point(59, 37);
            this.GbDatosTipoMascota.Name = "GbDatosTipoMascota";
            this.GbDatosTipoMascota.Size = new System.Drawing.Size(674, 390);
            this.GbDatosTipoMascota.TabIndex = 6;
            this.GbDatosTipoMascota.TabStop = false;
            this.GbDatosTipoMascota.Text = "Datos de Especialidad";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(126, 128);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(202, 26);
            this.TxtNombre.TabIndex = 4;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtIdEspecialidad
            // 
            this.TxtIdEspecialidad.Location = new System.Drawing.Point(131, 81);
            this.TxtIdEspecialidad.Name = "TxtIdEspecialidad";
            this.TxtIdEspecialidad.ReadOnly = true;
            this.TxtIdEspecialidad.Size = new System.Drawing.Size(144, 26);
            this.TxtIdEspecialidad.TabIndex = 3;
            // 
            // DgvListaEspecialidad
            // 
            this.DgvListaEspecialidad.AllowUserToAddRows = false;
            this.DgvListaEspecialidad.AllowUserToDeleteRows = false;
            this.DgvListaEspecialidad.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.DgvListaEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaEspecialidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdEspecialidad,
            this.CNombre});
            this.DgvListaEspecialidad.Location = new System.Drawing.Point(23, 200);
            this.DgvListaEspecialidad.Name = "DgvListaEspecialidad";
            this.DgvListaEspecialidad.ReadOnly = true;
            this.DgvListaEspecialidad.RowHeadersWidth = 62;
            this.DgvListaEspecialidad.RowTemplate.Height = 28;
            this.DgvListaEspecialidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaEspecialidad.Size = new System.Drawing.Size(604, 190);
            this.DgvListaEspecialidad.TabIndex = 2;
            this.DgvListaEspecialidad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaEspecialidad_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // CIdEspecialidad
            // 
            this.CIdEspecialidad.DataPropertyName = "IdEspecialidad";
            this.CIdEspecialidad.HeaderText = "Código";
            this.CIdEspecialidad.MinimumWidth = 8;
            this.CIdEspecialidad.Name = "CIdEspecialidad";
            this.CIdEspecialidad.ReadOnly = true;
            this.CIdEspecialidad.Width = 150;
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
            // FrmEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 475);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.GbDatosTipoMascota);
            this.Name = "FrmEspecialidad";
            this.Text = "Gestión de Especialidad";
            this.Load += new System.EventHandler(this.FrmEspecialidad_Load);
            this.GbDatosTipoMascota.ResumeLayout(false);
            this.GbDatosTipoMascota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaEspecialidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.GroupBox GbDatosTipoMascota;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtIdEspecialidad;
        private System.Windows.Forms.DataGridView DgvListaEspecialidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
    }
}