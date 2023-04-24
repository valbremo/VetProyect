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
    public partial class FrmHistorial : Form
    {

        private VLogica.Historial MiHistorial { get; set; }

        public DataTable ListaHistorialesNormal { get; set; }

        public int IdHistorial { get; set; }


        public FrmHistorial()
        {
            InitializeComponent();

            MiHistorial = new VLogica.Historial();
            ListaHistorialesNormal = new DataTable();
        }

        private void CargarDatosMascota()
        {
            VLogica.Mascota MiMascota = new VLogica.Mascota();

            DataTable Datos = new DataTable();

            Datos = MiMascota.ListarHM();



            CboxMascota.ValueMember = "IdMascota";
            CboxMascota.DisplayMember = "Nombre";

            CboxMascota.DataSource = Datos;
            CboxMascota.SelectedIndex = -1;
        }

        private void CargarDatosEspecialidad()
        {
            VLogica.Especialidad MiEspecialidad = new VLogica.Especialidad();

            DataTable Datos = new DataTable();

            Datos = MiEspecialidad.ListarHE();

            CboxEspecialidad.ValueMember = "IdEspecialidad";
            CboxEspecialidad.DisplayMember = "Nombre";

            CboxEspecialidad.DataSource = Datos;
            CboxEspecialidad.SelectedIndex = -1;
        }

        private void LlenarListaHistoriales()
        {
            //se llama la clase mascota para manipular los datos.
            VLogica.Historial MiHistorial = new VLogica.Historial();
            try
            {
                ListaHistorialesNormal = MiHistorial.ListarTodos();

                DgvListaHistoriales.DataSource = ListaHistorialesNormal;

                DgvListaHistoriales.ClearSelection();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            TxtIdHistorial.Clear();
            TxtSintomas.Clear();
            TxtFecha.Value = DateTime.Now.Date;
            TxtDiagnostico.Clear();
            CboxMascota.SelectedIndex = -1;
            CboxEspecialidad.SelectedIndex = -1;

        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;
            try
            {
                //Valida  los campos no estén vacíos o
                //que no contengan un dato menor al ingresado.
                if (!string.IsNullOrEmpty(TxtSintomas.Text.Trim()) &&
                    !string.IsNullOrEmpty(TxtDiagnostico.Text.Trim()) &&
                    //DgvListaMascotas.Rows.Count > 1 &&
                    CboxMascota.SelectedIndex > -1 &&
                    CboxEspecialidad.SelectedIndex > -1)
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

        private void GbDatosHistorial_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {

                DialogResult Respuesta = MessageBox.Show("¿Esta seguro de agregar un nuevo historial?", "Confirmacion requerida", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {

                    VLogica.Historial MiHistorial = new VLogica.Historial();

                    MiHistorial.Sintomas = TxtSintomas.Text.Trim();
                    MiHistorial.Fecha = Convert.ToDateTime(TxtFecha.Text.Trim());
                    MiHistorial.Diagnostico = TxtDiagnostico.Text.Trim();
                    MiHistorial.MiMascota.IdMascota = Convert.ToInt32(CboxMascota.SelectedValue);
                    MiHistorial.MiEspecialidad.IdEspecialidad = Convert.ToInt32(CboxEspecialidad.SelectedValue);

                    bool IdExiste = MiHistorial.ConsultarPorId();



                    if (!IdExiste)
                    {
                        //No existe un usuario con la cédula y el correo proporcionado 

                        // en la llamada a funciones anteriores usé una var bool para 
                        //almacenar el retorno de la función. Acá evaluaremos el 
                        //retorno de la función de forma directa. 

                        if (MiHistorial.Agregar())
                        {

                            //todo salió bien al realizaer el Insert 
                            //se muestra un mensaje de éxito al usuario 

                            MessageBox.Show("Historial agregado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            LimpiarFormulario();
                            LlenarListaHistoriales();


                        }


                    }
                    else
                    {
                        //Se validan los textbox de nombre en caso
                        //de que ya existan estos datos registrados.
                        if (IdExiste)
                        {
                            MessageBox.Show("El Id ya esta en uso", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtIdHistorial.Focus();
                            TxtIdHistorial.SelectAll();

                        }

                    }

                }
            }
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            CargarDatosMascota();

            CargarDatosEspecialidad();

            LlenarListaHistoriales();

            LimpiarFormulario();
        }

        private void DgvListaHistoriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Valida que la fila este seleccionada.
                if (DgvListaHistoriales.SelectedRows.Count == 1)
                {

                    DataGridViewRow MiFila = DgvListaHistoriales.SelectedRows[0];


                    TxtIdHistorial.Text = Convert.ToString(MiFila.Cells["CIdHistorial"].Value);
                    TxtSintomas.Text = Convert.ToString(MiFila.Cells["CSintomas"].Value);
                    TxtFecha.Text = Convert.ToString(MiFila.Cells["CFecha"].Value);
                    TxtDiagnostico.Text = Convert.ToString(MiFila.Cells["CDiagnostico"].Value);




                    CboxMascota.SelectedValue = Convert.ToInt32(MiFila.Cells["CIdMascota"].Value);

                    CboxEspecialidad.SelectedValue = Convert.ToInt32(MiFila.Cells["CIdEspecialidad"].Value);


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
                    VLogica.Historial MiHistorial = new VLogica.Historial();


                    DataGridViewRow MiFila = DgvListaHistoriales.SelectedRows[0];

                    MiHistorial.IdHistorial = Convert.ToInt32(MiFila.Cells["CIdHistorial"].Value);

                    MiHistorial.Sintomas = TxtSintomas.Text.Trim();
                    MiHistorial.Fecha = Convert.ToDateTime(TxtFecha.Text.Trim());
                    MiHistorial.Diagnostico = TxtDiagnostico.Text.Trim();
                    MiHistorial.MiMascota.IdMascota = Convert.ToInt32(CboxMascota.SelectedValue);
                    MiHistorial.MiEspecialidad.IdEspecialidad = Convert.ToInt32(CboxEspecialidad.SelectedValue);

                    if (MiHistorial.ConsultarPorId())
                    {
                        //Se emplea el método editar de la clase.
                        if (MiHistorial.Modificar())
                        {
                            MessageBox.Show("Historial modificado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            LimpiarFormulario();
                            LlenarListaHistoriales();
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
            VLogica.Historial MiHistorial = new VLogica.Historial();

            DataGridViewRow MiFila = DgvListaHistoriales.SelectedRows[0];

            MiHistorial.IdHistorial = Convert.ToInt32(MiFila.Cells["CIdHistorial"].Value);

            try
            {
                if (MiHistorial.ConsultarPorId())
                {
                    //Se emplea el método de eliminar de la clase.
                    if (MiHistorial.Desactivar())
                    {
                        MessageBox.Show("Historial eliminado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LimpiarFormulario();
                        LlenarListaHistoriales();
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

        private void TxtIdHistorial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
