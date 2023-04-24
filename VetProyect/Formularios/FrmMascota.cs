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
    public partial class FrmMascota : Form
    {
        private VLogica.Mascota MiMascota { get; set; }

        public DataTable ListaMascotasNormal { get; set; }

        public int IdMascota { get; set; }

        public FrmMascota()
        {
            InitializeComponent();

            MiMascota = new VLogica.Mascota();
            ListaMascotasNormal = new DataTable();
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

        private void CargarDatosTipoMascota()
        {
            VLogica.TipoMascota MiTipoMascota = new VLogica.TipoMascota();

            DataTable Datos = new DataTable();

            Datos = MiTipoMascota.Listar();

            CboxTipoMascota.ValueMember = "IdTipoMascota";
            CboxTipoMascota.DisplayMember = "Nombre";

            CboxTipoMascota.DataSource = Datos;
            CboxTipoMascota.SelectedIndex = -1;
        }

        private void LlenarListaMascotas()
        {
            //se llama la clase mascota para manipular los datos.
            VLogica.Mascota MiMascota = new VLogica.Mascota();
            try
            {
                ListaMascotasNormal = MiMascota.ListarTodos();

                DgvListaMascotas.DataSource = ListaMascotasNormal;

                DgvListaMascotas.ClearSelection();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            TxtIdMascota.Clear();
            TxtNombre.Clear();
            TxtFecha.Value = DateTime.Now.Date;
            TxtRaza.Clear();
            TxtObservacion.Clear();
            CboxTipoMascota.SelectedIndex = -1;
            CboxCliente.SelectedIndex = -1;  

        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;
            try
            {
                //Valida  los campos no estén vacíos o
                //que no contengan un dato menor al ingresado.
                if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                    !string.IsNullOrEmpty(TxtRaza.Text.Trim()) &&
                    !string.IsNullOrEmpty(TxtObservacion.Text.Trim()) &&
                    //DgvListaMascotas.Rows.Count > 1 &&
                    CboxTipoMascota.SelectedIndex > -1 &&
                    CboxCliente.SelectedIndex > -1)
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (ValidarDatosRequeridos())
            {

                DialogResult Respuesta = MessageBox.Show("¿Esta seguro de agregar una nueva mascota?", "Confirmacion requerida", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {

                    VLogica.Mascota MiMascota = new VLogica.Mascota();

                    MiMascota.Nombre = TxtNombre.Text.Trim();
                    MiMascota.FechaNacimiento = Convert.ToDateTime(TxtFecha.Text.Trim());
                    MiMascota.Raza = TxtRaza.Text.Trim();
                    MiMascota.Observacion = TxtObservacion.Text.Trim();
                    MiMascota.MiTipoMascota.IdTipoMascota = Convert.ToInt32(CboxTipoMascota.SelectedValue);
                    MiMascota.MiCliente.IdCliente = Convert.ToInt32(CboxCliente.SelectedValue);

                    bool IdExiste = MiMascota.ConsultarPorId();



                    if (!IdExiste)
                    {
                        //No existe un usuario con la cédula y el correo proporcionado 

                        // en la llamada a funciones anteriores usé una var bool para 
                        //almacenar el retorno de la función. Acá evaluaremos el 
                        //retorno de la función de forma directa. 

                        if (MiMascota.Agregar())
                        {

                            //todo salió bien al realizaer el Insert 
                            //se muestra un mensaje de éxito al usuario 

                            MessageBox.Show("Mascota agregado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            LimpiarFormulario();
                            LlenarListaMascotas();
                            

                        }


                    }
                    else
                    {
                        //Se validan los textbox de nombre en caso
                        //de que ya existan estos datos registrados.
                        if (IdExiste)
                        {
                            MessageBox.Show("El Id ya esta en uso", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtIdMascota.Focus();
                            TxtIdMascota.SelectAll();

                        }

                    }

                }
            }
        }

        private void FrmMascota_Load(object sender, EventArgs e)
        {

            CargarDatosTipoMascota();

            CargarDatosCliente();

            LlenarListaMascotas();

            LimpiarFormulario();
        }

        private void DgvListaMascotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Valida que la fila este seleccionada.
                if (DgvListaMascotas.SelectedRows.Count == 1)
                {

                    DataGridViewRow MiFila = DgvListaMascotas.SelectedRows[0];


                    TxtIdMascota.Text = Convert.ToString(MiFila.Cells["CIdMascota"].Value);
                    TxtNombre.Text = Convert.ToString(MiFila.Cells["CNombre"].Value);
                    TxtFecha.Text = Convert.ToString(MiFila.Cells["CFechaNacimiento"].Value);
                    TxtRaza.Text = Convert.ToString(MiFila.Cells["CRaza"].Value);
                    TxtObservacion.Text = Convert.ToString(MiFila.Cells["CObservacion"].Value);
                    

                  
                     CboxTipoMascota.SelectedValue = Convert.ToInt32(MiFila.Cells["CIdTipoMascota"].Value);

                     CboxCliente.SelectedValue = Convert.ToInt32(MiFila.Cells["CIdCliente"].Value);
                   

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
                    VLogica.Mascota MiMascota = new VLogica.Mascota();


                    DataGridViewRow MiFila = DgvListaMascotas.SelectedRows[0];

                    MiMascota.IdMascota = Convert.ToInt32(MiFila.Cells["CIdMascota"].Value);

                    MiMascota.Nombre = TxtNombre.Text.Trim();
                    MiMascota.FechaNacimiento = Convert.ToDateTime(TxtFecha.Text.Trim());
                    MiMascota.Raza = TxtRaza.Text.Trim();
                    MiMascota.Observacion = TxtObservacion.Text.Trim();
                    MiMascota.MiTipoMascota.IdTipoMascota = Convert.ToInt32(CboxTipoMascota.SelectedValue);
                    MiMascota.MiCliente.IdCliente = Convert.ToInt32(CboxCliente.SelectedValue);

                    if (MiMascota.ConsultarPorId())
                    {
                        //Se emplea el método editar de la clase.
                        if (MiMascota.Modificar())
                        {
                            MessageBox.Show("Mascota modificada correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            LimpiarFormulario();
                            LlenarListaMascotas();
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
            VLogica.Mascota MiMascota = new VLogica.Mascota();

            DataGridViewRow MiFila = DgvListaMascotas.SelectedRows[0];

            MiMascota.IdMascota = Convert.ToInt32(MiFila.Cells["CIdMascota"].Value);

            try
            {
                if (MiMascota.ConsultarPorId())
                {
                    //Se emplea el método de eliminar de la clase.
                    if (MiMascota.Desactivar())
                    {
                        MessageBox.Show("Mascota eliminada correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LimpiarFormulario();
                        LlenarListaMascotas();
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
