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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GbDatosHistorial = new System.Windows.Forms.GroupBox();
            this.TxtIdHistorial = new System.Windows.Forms.TextBox();
            this.TxtSintomas = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtDiagnostico = new System.Windows.Forms.TextBox();
            this.CbIdMascota = new System.Windows.Forms.ComboBox();
            this.CbIdEspecialidad = new System.Windows.Forms.ComboBox();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.ColIdHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSintomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbBuscarHistorial = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.GbDatosHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.GbBuscarHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Historial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Síntomas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Diagnostico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mascota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Especialidad";
            // 
            // GbDatosHistorial
            // 
            this.GbDatosHistorial.Controls.Add(this.CbIdEspecialidad);
            this.GbDatosHistorial.Controls.Add(this.CbIdMascota);
            this.GbDatosHistorial.Controls.Add(this.TxtDiagnostico);
            this.GbDatosHistorial.Controls.Add(this.dateTimeFecha);
            this.GbDatosHistorial.Controls.Add(this.TxtSintomas);
            this.GbDatosHistorial.Controls.Add(this.TxtIdHistorial);
            this.GbDatosHistorial.Controls.Add(this.label7);
            this.GbDatosHistorial.Controls.Add(this.label6);
            this.GbDatosHistorial.Controls.Add(this.label5);
            this.GbDatosHistorial.Controls.Add(this.label4);
            this.GbDatosHistorial.Controls.Add(this.label3);
            this.GbDatosHistorial.Controls.Add(this.label2);
            this.GbDatosHistorial.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDatosHistorial.Location = new System.Drawing.Point(12, 105);
            this.GbDatosHistorial.Name = "GbDatosHistorial";
            this.GbDatosHistorial.Size = new System.Drawing.Size(384, 416);
            this.GbDatosHistorial.TabIndex = 7;
            this.GbDatosHistorial.TabStop = false;
            this.GbDatosHistorial.Text = "Datos del Historial";
            this.GbDatosHistorial.Enter += new System.EventHandler(this.GbDatosHistorial_Enter);
            // 
            // TxtIdHistorial
            // 
            this.TxtIdHistorial.Location = new System.Drawing.Point(132, 60);
            this.TxtIdHistorial.Name = "TxtIdHistorial";
            this.TxtIdHistorial.Size = new System.Drawing.Size(190, 30);
            this.TxtIdHistorial.TabIndex = 7;
            // 
            // TxtSintomas
            // 
            this.TxtSintomas.Location = new System.Drawing.Point(135, 113);
            this.TxtSintomas.Name = "TxtSintomas";
            this.TxtSintomas.Size = new System.Drawing.Size(186, 30);
            this.TxtSintomas.TabIndex = 8;
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.Location = new System.Drawing.Point(145, 157);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(175, 30);
            this.dateTimeFecha.TabIndex = 9;
            // 
            // TxtDiagnostico
            // 
            this.TxtDiagnostico.Location = new System.Drawing.Point(148, 199);
            this.TxtDiagnostico.Name = "TxtDiagnostico";
            this.TxtDiagnostico.Size = new System.Drawing.Size(173, 30);
            this.TxtDiagnostico.TabIndex = 10;
            // 
            // CbIdMascota
            // 
            this.CbIdMascota.FormattingEnabled = true;
            this.CbIdMascota.Location = new System.Drawing.Point(146, 250);
            this.CbIdMascota.Name = "CbIdMascota";
            this.CbIdMascota.Size = new System.Drawing.Size(176, 30);
            this.CbIdMascota.TabIndex = 11;
            // 
            // CbIdEspecialidad
            // 
            this.CbIdEspecialidad.FormattingEnabled = true;
            this.CbIdEspecialidad.Location = new System.Drawing.Point(147, 297);
            this.CbIdEspecialidad.Name = "CbIdEspecialidad";
            this.CbIdEspecialidad.Size = new System.Drawing.Size(172, 30);
            this.CbIdEspecialidad.TabIndex = 12;
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdHistorial,
            this.ColSintomas,
            this.ColFecha,
            this.ColDiagnostico,
            this.ColIdMascota,
            this.ColEspecialidad});
            this.DgvLista.Location = new System.Drawing.Point(417, 165);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersWidth = 62;
            this.DgvLista.RowTemplate.Height = 28;
            this.DgvLista.Size = new System.Drawing.Size(973, 292);
            this.DgvLista.TabIndex = 8;
            // 
            // ColIdHistorial
            // 
            this.ColIdHistorial.DataPropertyName = "IdHistorial";
            this.ColIdHistorial.HeaderText = "Código";
            this.ColIdHistorial.MinimumWidth = 8;
            this.ColIdHistorial.Name = "ColIdHistorial";
            this.ColIdHistorial.ReadOnly = true;
            this.ColIdHistorial.Width = 150;
            // 
            // ColSintomas
            // 
            this.ColSintomas.DataPropertyName = "Sintomas";
            this.ColSintomas.HeaderText = "Sintomas";
            this.ColSintomas.MinimumWidth = 8;
            this.ColSintomas.Name = "ColSintomas";
            this.ColSintomas.ReadOnly = true;
            this.ColSintomas.Width = 150;
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
            // ColDiagnostico
            // 
            this.ColDiagnostico.DataPropertyName = "Diagnostico";
            this.ColDiagnostico.HeaderText = "Diagnostico";
            this.ColDiagnostico.MinimumWidth = 8;
            this.ColDiagnostico.Name = "ColDiagnostico";
            this.ColDiagnostico.ReadOnly = true;
            this.ColDiagnostico.Width = 150;
            // 
            // ColIdMascota
            // 
            this.ColIdMascota.DataPropertyName = "IdMascota";
            this.ColIdMascota.HeaderText = "Mascota";
            this.ColIdMascota.MinimumWidth = 8;
            this.ColIdMascota.Name = "ColIdMascota";
            this.ColIdMascota.ReadOnly = true;
            this.ColIdMascota.Width = 150;
            // 
            // ColEspecialidad
            // 
            this.ColEspecialidad.DataPropertyName = "Especialidad";
            this.ColEspecialidad.HeaderText = "Especialidad";
            this.ColEspecialidad.MinimumWidth = 8;
            this.ColEspecialidad.Name = "ColEspecialidad";
            this.ColEspecialidad.ReadOnly = true;
            this.ColEspecialidad.Width = 150;
            // 
            // GbBuscarHistorial
            // 
            this.GbBuscarHistorial.Controls.Add(this.BtnBuscar);
            this.GbBuscarHistorial.Controls.Add(this.label9);
            this.GbBuscarHistorial.Controls.Add(this.label8);
            this.GbBuscarHistorial.Controls.Add(this.dateTimePicker3);
            this.GbBuscarHistorial.Controls.Add(this.dateTimePicker2);
            this.GbBuscarHistorial.Location = new System.Drawing.Point(417, 74);
            this.GbBuscarHistorial.Name = "GbBuscarHistorial";
            this.GbBuscarHistorial.Size = new System.Drawing.Size(973, 75);
            this.GbBuscarHistorial.TabIndex = 9;
            this.GbBuscarHistorial.TabStop = false;
            this.GbBuscarHistorial.Text = "Buscar Historial";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(77, 36);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(333, 26);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(494, 37);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(326, 26);
            this.dateTimePicker3.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "De";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Hasta";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(850, 35);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(93, 27);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 634);
            this.Controls.Add(this.GbBuscarHistorial);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.GbDatosHistorial);
            this.Controls.Add(this.label1);
            this.Name = "FrmHistorial";
            this.Text = "FrmHistorial";
            this.GbDatosHistorial.ResumeLayout(false);
            this.GbDatosHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.GbBuscarHistorial.ResumeLayout(false);
            this.GbBuscarHistorial.PerformLayout();
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
        private System.Windows.Forms.GroupBox GbDatosHistorial;
        private System.Windows.Forms.ComboBox CbIdEspecialidad;
        private System.Windows.Forms.ComboBox CbIdMascota;
        private System.Windows.Forms.TextBox TxtDiagnostico;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
        private System.Windows.Forms.TextBox TxtSintomas;
        private System.Windows.Forms.TextBox TxtIdHistorial;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSintomas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEspecialidad;
        private System.Windows.Forms.GroupBox GbBuscarHistorial;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}