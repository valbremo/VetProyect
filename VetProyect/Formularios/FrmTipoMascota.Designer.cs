namespace VetProyect.Formularios
{
    partial class FrmTipoMascota
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
            this.GbDatosTipoMascota = new System.Windows.Forms.GroupBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtIdTipoMascota = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColIdTipoMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvListaTipoMascota = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.CIdTipoMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbDatosTipoMascota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaTipoMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // GbDatosTipoMascota
            // 
            this.GbDatosTipoMascota.Controls.Add(this.TxtNombre);
            this.GbDatosTipoMascota.Controls.Add(this.TxtIdTipoMascota);
            this.GbDatosTipoMascota.Controls.Add(this.dataGridView1);
            this.GbDatosTipoMascota.Controls.Add(this.label2);
            this.GbDatosTipoMascota.Controls.Add(this.label1);
            this.GbDatosTipoMascota.Location = new System.Drawing.Point(50, 31);
            this.GbDatosTipoMascota.Name = "GbDatosTipoMascota";
            this.GbDatosTipoMascota.Size = new System.Drawing.Size(298, 175);
            this.GbDatosTipoMascota.TabIndex = 0;
            this.GbDatosTipoMascota.TabStop = false;
            this.GbDatosTipoMascota.Text = "Datos Tipo de Mascota";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(126, 128);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(148, 26);
            this.TxtNombre.TabIndex = 4;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtIdTipoMascota
            // 
            this.TxtIdTipoMascota.Location = new System.Drawing.Point(131, 81);
            this.TxtIdTipoMascota.Name = "TxtIdTipoMascota";
            this.TxtIdTipoMascota.ReadOnly = true;
            this.TxtIdTipoMascota.Size = new System.Drawing.Size(144, 26);
            this.TxtIdTipoMascota.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdTipoMascota,
            this.ColNombre});
            this.dataGridView1.Location = new System.Drawing.Point(361, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(549, 202);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColIdTipoMascota
            // 
            this.ColIdTipoMascota.DataPropertyName = "IdTipoMascota";
            this.ColIdTipoMascota.HeaderText = "Código";
            this.ColIdTipoMascota.MinimumWidth = 8;
            this.ColIdTipoMascota.Name = "ColIdTipoMascota";
            this.ColIdTipoMascota.ReadOnly = true;
            this.ColIdTipoMascota.Width = 150;
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
            this.label1.Location = new System.Drawing.Point(20, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // DgvListaTipoMascota
            // 
            this.DgvListaTipoMascota.AllowUserToAddRows = false;
            this.DgvListaTipoMascota.AllowUserToDeleteRows = false;
            this.DgvListaTipoMascota.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.DgvListaTipoMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaTipoMascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdTipoMascota,
            this.CNombre});
            this.DgvListaTipoMascota.Location = new System.Drawing.Point(12, 223);
            this.DgvListaTipoMascota.Name = "DgvListaTipoMascota";
            this.DgvListaTipoMascota.ReadOnly = true;
            this.DgvListaTipoMascota.RowHeadersWidth = 62;
            this.DgvListaTipoMascota.RowTemplate.Height = 28;
            this.DgvListaTipoMascota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaTipoMascota.Size = new System.Drawing.Size(524, 344);
            this.DgvListaTipoMascota.TabIndex = 1;
            this.DgvListaTipoMascota.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaTipoMascota_CellClick);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnAgregar.Location = new System.Drawing.Point(614, 106);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(125, 44);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnModificar.Location = new System.Drawing.Point(614, 204);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(125, 48);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnEliminar.Location = new System.Drawing.Point(614, 321);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(125, 52);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnSalir.Location = new System.Drawing.Point(614, 445);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(125, 52);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // CIdTipoMascota
            // 
            this.CIdTipoMascota.DataPropertyName = "IdTipoMascota";
            this.CIdTipoMascota.HeaderText = "Código";
            this.CIdTipoMascota.MinimumWidth = 8;
            this.CIdTipoMascota.Name = "CIdTipoMascota";
            this.CIdTipoMascota.ReadOnly = true;
            this.CIdTipoMascota.Width = 150;
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
            // FrmTipoMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 579);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.DgvListaTipoMascota);
            this.Controls.Add(this.GbDatosTipoMascota);
            this.Name = "FrmTipoMascota";
            this.Text = "Gestión de Tipo de Mascotas";
            this.Load += new System.EventHandler(this.FrmTipoMascota_Load);
            this.GbDatosTipoMascota.ResumeLayout(false);
            this.GbDatosTipoMascota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaTipoMascota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbDatosTipoMascota;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdTipoMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridView DgvListaTipoMascota;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtIdTipoMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdTipoMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
    }
}