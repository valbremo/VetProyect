using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VLogica;

namespace VetProyect.Formularios
{
    public partial class FrmCita : Form
    {

        private VLogica.Cita MiCita { get; set; }

        public DataTable ListaCitasNormal { get; set; }

        public int IdCita { get; set;}

        public FrmCita()
        {
            InitializeComponent();

            MiCita = new VLogica.Cita();
            ListaCitasNormal = new DataTable();
        }

        private void CargarDatosCliente()
        {
            VLogica.Cliente MiCliente = new VLogica.Cliente();

            DataTable Datos = new DataTable();

            Datos = MiCliente.Listar();



            CboxCliente.ValueMember = "IdCliente";
            CboxCliente.DisplayMember = "NombreCompleto";

            CboxCliente.DataSource = Datos;
            CboxCliente.SelectedIndex = -1;
        }


        private void CargarDatosMascota()
        {
            VLogica.Mascota MiMascota = new VLogica.Mascota();

            DataTable Datos = new DataTable();

            Datos = MiMascota.Listar();



            CboxMascota.ValueMember = "IdMascota";
            CboxMascota.DisplayMember = "Nombre";

            CboxMascota.DataSource = Datos;
            CboxMascota.SelectedIndex = -1;
        }

        private void LlenarListaCitas()
        {

            VLogica.Cita MiCita = new VLogica.Cita();
            try
            {
                ListaCitasNormal = MiCita.ListarTodos();

                DgvListaCitas.DataSource = ListaCitasNormal;

                DgvListaCitas.ClearSelection();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            TxtIdCita.Clear();
            TxtFecha.Value = DateTime.Now.Date;
            TxtEspecificacion.Clear();
            CboxCliente.SelectedIndex = -1;
            CboxMascota.SelectedIndex = -1;
        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;
            try
            {
                //Valida  los campos no estén vacíos o
                //que no contengan un dato menor al ingresado.
                if (!string.IsNullOrEmpty(TxtEspecificacion.Text.Trim()) &&

                    //DgvListaMascotas.Rows.Count > 1 &&
                    CboxCliente.SelectedIndex > -1 &&
                    CboxMascota.SelectedIndex > -1) 
                    
                {

                    R = true;

                }
                else
                {
                    MessageBox.Show("Hay campos vacíos", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return R;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                DialogResult Respuesta = MessageBox.Show("¿Esta seguro de agregar una nueva cita?", "Confirmacion requerida", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {

                    VLogica.Cita MiCita = new VLogica.Cita();

                    MiCita.Fecha = Convert.ToDateTime(TxtFecha.Text.Trim());
                    MiCita.Especificacion = TxtEspecificacion.Text.Trim();
                    MiCita.MiCliente.IdCliente = Convert.ToInt32(CboxCliente.SelectedValue);
                    MiCita.MiMascota.IdMascota = Convert.ToInt32(CboxMascota.SelectedValue);

                    bool IdExiste = MiCita.ConsultarPorId();


                    if (!IdExiste)
                    {
                        if (MiCita.Agregar())
                        {
                            MessageBox.Show("Cita agregada correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            LimpiarFormulario();
                            LlenarListaCitas();


                        }
                    }

                    else
                    {
                        //Se validan los textbox de nombre en caso
                        //de que ya existan estos datos registrados.
                        if (IdExiste)
                        {
                            MessageBox.Show("El Id ya esta en uso", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtIdCita.Focus();
                            TxtIdCita.SelectAll();

                        }

                    }
                }

            }

        }

        private void FrmCita_Load(object sender, EventArgs e)
        {
            CargarDatosCliente();

            CargarDatosMascota();

            LlenarListaCitas();

            LimpiarFormulario();
        }

        private void DgvListaCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Valida que la fila este seleccionada.
                if (DgvListaCitas.SelectedRows.Count == 1)
                {

                    DataGridViewRow MiFila = DgvListaCitas.SelectedRows[0];


                    TxtIdCita.Text = Convert.ToString(MiFila.Cells["CIdCita"].Value);
                    TxtFecha.Text = Convert.ToString(MiFila.Cells["CFecha"].Value);
                    TxtEspecificacion.Text = Convert.ToString(MiFila.Cells["CEspecificacion"].Value);


                    CboxCliente.SelectedValue = Convert.ToInt32(MiFila.Cells["CIdCliente"].Value);

                    CboxMascota.SelectedValue = Convert.ToInt32(MiFila.Cells["CIdMascota"].Value);

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //valida los datos existentes y los modifica.
                if (ValidarDatosRequeridos())
                {
                    VLogica.Cita MiCita = new VLogica.Cita();


                    DataGridViewRow MiFila = DgvListaCitas.SelectedRows[0];

                    MiCita.IdCita = Convert.ToInt32(MiFila.Cells["CIdCita"].Value);

                    MiCita.Fecha = Convert.ToDateTime(TxtFecha.Text.Trim());
                    MiCita.Especificacion = TxtEspecificacion.Text.Trim();

                    MiCita.MiMascota.IdMascota = Convert.ToInt32(CboxMascota.SelectedValue);
                    MiCita.MiCliente.IdCliente = Convert.ToInt32(CboxCliente.SelectedValue);

                    if (MiCita.ConsultarPorId())
                    {
                        //Se emplea el método editar de la clase.
                        if (MiCita.Modificar())
                        {
                            MessageBox.Show("Cita modificada correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            LimpiarFormulario();
                            LlenarListaCitas();
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            VLogica.Cita MiCita = new VLogica.Cita();

            DataGridViewRow MiFila = DgvListaCitas.SelectedRows[0];

            MiCita.IdCita = Convert.ToInt32(MiFila.Cells["CIdCita"].Value);

            try
            {
                if (MiCita.ConsultarPorId())
                {
                    //Se emplea el método de eliminar de la clase.
                    if (MiCita.Desactivar())
                    {
                        MessageBox.Show("Cita eliminada correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LimpiarFormulario();
                        LlenarListaCitas();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
