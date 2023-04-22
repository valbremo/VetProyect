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
    public partial class FrmEspecialidad : Form
    {

        private VLogica.Especialidad MiEspecialidadLocal { get; set; }

        public DataTable ListaEspecialidadNormal { get; set; }

        public int IdEspecialidad { get; set; }

        public FrmEspecialidad()
        {
            InitializeComponent();

            MiEspecialidadLocal = new VLogica.Especialidad();
            ListaEspecialidadNormal = new DataTable();
        }


        private void LimpiarFormulario()
        {
            TxtIdEspecialidad.Clear();

            TxtNombre.Clear();
        }

        //Llena la lista con los datos de la Especialidad
        private void LlenarListaEspecialidad()
        {
            // se llama la clase Especialidad para manipular los datos.
            VLogica.Especialidad MiEspecialidad = new VLogica.Especialidad();
            try
            {
                ListaEspecialidadNormal = MiEspecialidad.ListarTodos();

                DgvListaEspecialidad.DataSource = ListaEspecialidadNormal;

                DgvListaEspecialidad.ClearSelection();
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

        //Método que agrega la Especialidad al datagridview
        //Valida los campos de texto
        //Se emplea el método de agregar de la clase Especialidad
        //Al agregar la especialidad, se limpia el formulario,
        //se activan el botón agregar y
        //se llena el datagrid con los datos de la Especialidad.

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {

                DialogResult Respuesta = MessageBox.Show("¿Esta seguro de agregar la nueva especialidad?", "Confirmacion requerida", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {

                    VLogica.Especialidad MiEspecialidad = new VLogica.Especialidad();

                    MiEspecialidad.Nombre = TxtNombre.Text.Trim();
   

                    bool NombreExiste = MiEspecialidad.ConsultarPorNombre();



                    if (!NombreExiste)
                    {
                        //No existe un usuario con la cédula y el correo proporcionado 

                        // en la llamada a funciones anteriores usé una var bool para 
                        //almacenar el retorno de la función. Acá evaluaremos el 
                        //retorno de la función de forma directa. 

                        if (MiEspecialidad.Agregar())
                        {

                            //todo salió bien al realizaer el Insert 
                            //se muestra un mensaje de éxito al usuario 

                            MessageBox.Show("Especialidad agregada correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            LimpiarFormulario();
                            LlenarListaEspecialidad();
                            //ActivarBtnAgregar();

                        }


                    }
                    else
                    {
                        //Se validan los textbox de nombre en caso
                        //de que ya existan estos datos registrados.
                        if (NombreExiste)
                        {
                            MessageBox.Show("El nombre ya esta en uso", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtNombre.Focus();
                            TxtNombre.SelectAll();

                        }

                    }

                }
            }

        }

        private void FrmEspecialidad_Load(object sender, EventArgs e)
        {
            LlenarListaEspecialidad();
            LimpiarFormulario();
        }

        private void DgvListaEspecialidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //valida si se ha seleccionado una fila en el DataGridview
            if (DgvListaEspecialidad.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                DataGridViewRow MiFila = DgvListaEspecialidad.SelectedRows[0];

                int IdEspecialidad = Convert.ToInt32(MiFila.Cells["CIdEspecialidad"].Value);

                MiEspecialidadLocal = new VLogica.Especialidad();

                MiEspecialidadLocal = MiEspecialidadLocal.Consultar(IdEspecialidad);

                TxtNombre.Text = MiEspecialidadLocal.Nombre;
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //valida los datos existentes y los modifica.
                if (ValidarDatosRequeridos())
                {
                    VLogica.Especialidad MiEspecialidad = new VLogica.Especialidad();

                    DataGridViewRow MiFila = DgvListaEspecialidad.SelectedRows[0];

                    MiEspecialidad.IdEspecialidad = Convert.ToInt32(MiFila.Cells["CIdEspecialidad"].Value);


                    MiEspecialidad.Nombre = TxtNombre.Text.Trim();

                    if (MiEspecialidad.ConsultarPorId())
                    {
                        //Se emplea el método editar de la clase.
                        if (MiEspecialidad.Modificar())
                        {
                            MessageBox.Show("Especialidad modificado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            LimpiarFormulario();
                            LlenarListaEspecialidad();
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
            VLogica.Especialidad MiEspecialidad = new VLogica.Especialidad();

            DataGridViewRow MiFila = DgvListaEspecialidad.SelectedRows[0];

            MiEspecialidad.IdEspecialidad = Convert.ToInt32(MiFila.Cells["CIdEspecialidad"].Value);


            try
            {

                if (MiEspecialidad.ConsultarPorId())
                {
                    //Se emplea el método de eliminar de la clase.
                    if (MiEspecialidad.Desactivar())
                    {
                        MessageBox.Show("Especialidad eliminada correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LimpiarFormulario();
                        //ActivarBtnAgregar();
                        LlenarListaEspecialidad();
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
