using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VLogica;

namespace VetProyect.Formularios
{
    public partial class FrmTipoMascota : Form
    {

        private VLogica.TipoMascota MiTipoMascotaLocal { get; set; }    

        public DataTable ListaTipoMascotaNormal { get; set; }

        public int IdTipoMascota { get; set; }

        public FrmTipoMascota()
        {
            InitializeComponent();

            MiTipoMascotaLocal = new VLogica.TipoMascota();
            ListaTipoMascotaNormal = new DataTable();
        }

        private void LimpiarFormulario()
        {
            TxtIdTipoMascota.Clear();

            TxtNombre.Clear();
        }

        private void LlenarListaTipoMascota()
        {
            // se llama la clase Especialidad para manipular los datos.
            VLogica.TipoMascota MiTipoMascota = new VLogica.TipoMascota();
            try
            {
                ListaTipoMascotaNormal = MiTipoMascota.ListarTodos();

                DgvListaTipoMascota.DataSource = ListaTipoMascotaNormal;

                DgvListaTipoMascota.ClearSelection();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;
            try
            {
                //Valida  los campos no estén vacíos o
                //que no contengan un dato menor al ingresado.

                if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()))
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

                DialogResult Respuesta = MessageBox.Show("¿Esta seguro de agregar el nuevo tipo de mascota?", "Confirmacion requerida", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {

                    VLogica.TipoMascota MiTipoMascota = new VLogica.TipoMascota();

                    MiTipoMascota.Nombre = TxtNombre.Text.Trim();


                    bool IdExiste = MiTipoMascota.ConsultarPorId();



                    if (!IdExiste)
                    {
                        //No existe un usuario con la cédula y el correo proporcionado 

                        // en la llamada a funciones anteriores usé una var bool para 
                        //almacenar el retorno de la función. Acá evaluaremos el 
                        //retorno de la función de forma directa. 

                        if (MiTipoMascota.Agregar())
                        {

                            //todo salió bien al realizaer el Insert 
                            //se muestra un mensaje de éxito al usuario 

                            MessageBox.Show("Tipo de mascota agregada correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            LimpiarFormulario();
                            LlenarListaTipoMascota();
                           

                        }


                    }
                    else
                    {
                        //Se validan los textbox de nombre en caso
                        //de que ya existan estos datos registrados.
                        if (IdExiste)
                        {
                            MessageBox.Show("El nombre ya esta en uso", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtNombre.Focus();
                            TxtNombre.SelectAll();

                        }

                    }

                }
            }
        }

        private void FrmTipoMascota_Load(object sender, EventArgs e)
        {
            LlenarListaTipoMascota();
            LimpiarFormulario();
        }

        private void DgvListaTipoMascota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //valida si se ha seleccionado una fila en el DataGridview
            if (DgvListaTipoMascota.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                DataGridViewRow MiFila = DgvListaTipoMascota.SelectedRows[0];

                int IdTipoMascota = Convert.ToInt32(MiFila.Cells["CIdTipoMascota"].Value);

                MiTipoMascotaLocal = new VLogica.TipoMascota();

                MiTipoMascotaLocal = MiTipoMascotaLocal.Consultar(IdTipoMascota);

                TxtNombre.Text = MiTipoMascotaLocal.Nombre;
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //valida los datos existentes y los modifica.
                if (ValidarDatosRequeridos())
                {
                    VLogica.TipoMascota MiTipoMascota = new VLogica.TipoMascota();

                    DataGridViewRow MiFila = DgvListaTipoMascota.SelectedRows[0];

                    MiTipoMascota.IdTipoMascota = Convert.ToInt32(MiFila.Cells["CIdTipoMascota"].Value);


                    MiTipoMascota.Nombre = TxtNombre.Text.Trim();

                    if (MiTipoMascota.ConsultarPorId())
                    {
                        //Se emplea el método editar de la clase.
                        if (MiTipoMascota.Modificar())
                        {
                            MessageBox.Show("Tipo de mascota modificada correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            LimpiarFormulario();
                            LlenarListaTipoMascota();
                            //ActivarBtnAgregar();
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
            VLogica.TipoMascota MiTipoMascota = new VLogica.TipoMascota();

            DataGridViewRow MiFila = DgvListaTipoMascota.SelectedRows[0];

            MiTipoMascota.IdTipoMascota = Convert.ToInt32(MiFila.Cells["CIdTipoMascota"].Value);


            try
            {

                if (MiTipoMascota.ConsultarPorId())
                {
                    //Se emplea el método de eliminar de la clase.
                    if (MiTipoMascota.Desactivar())
                    {
                        MessageBox.Show("Tipo de mascota eliminado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LimpiarFormulario();
                        //ActivarBtnAgregar();
                        LlenarListaTipoMascota();
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


        //Método que permite solo letras 
        //en el textbox de nombre.
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs pE)
        {
            Herramientas.CaracteresTexto(pE);
        }
    }
}
