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
    public partial class FrmReceta : Form
    {

        private VLogica.Receta MiReceta { get; set; }

        public DataTable ListaRecetasNormal { get; set; }

        public int IdReceta { get; set; }

        public FrmReceta()
        {
            InitializeComponent();

            MiReceta = new VLogica.Receta();
            ListaRecetasNormal = new DataTable();
        }

        private void CargarDatosHistorial()
        {
            VLogica.Historial MiHistorial = new VLogica.Historial();

            DataTable Datos = new DataTable();

            Datos = MiHistorial.ListarRHi();



            CboxHistorial.ValueMember = "IdHistorial";
            CboxHistorial.DisplayMember = "Sintomas";

            CboxHistorial.DataSource = Datos;
            CboxHistorial.SelectedIndex = -1;
        }

        private void CargarDatosUsuario()
        {
            VLogica.Usuario MiUsuario = new VLogica.Usuario();

            DataTable Datos = new DataTable();

            Datos = MiUsuario.ListarRU();

            CboxUsuario.ValueMember = "IdUsuario";
            CboxUsuario.DisplayMember = "NombreCompleto";

            CboxUsuario.DataSource = Datos;
            CboxUsuario.SelectedIndex = -1;
        }

        private void LlenarListaRecetas()
        {
            //se llama la clase mascota para manipular los datos.
            VLogica.Receta MiReceta = new VLogica.Receta();
            try
            {
                ListaRecetasNormal = MiReceta.ListarTodos();

                DgvListaRecetas.DataSource = ListaRecetasNormal;

                DgvListaRecetas.ClearSelection();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            TxtIdReceta.Clear();
            TxtTratamiento.Clear();
            TxtFecha.Value = DateTime.Now.Date;
            TxtPrecio.Clear();
            CboxHistorial.SelectedIndex = -1;
            CboxUsuario.SelectedIndex = -1;

        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;
            try
            {
                //Valida  los campos no estén vacíos o
                //que no contengan un dato menor al ingresado.
                if (!string.IsNullOrEmpty(TxtTratamiento.Text.Trim()) &&
                    !string.IsNullOrEmpty(TxtPrecio.Text.Trim()) &&
                    //DgvListaMascotas.Rows.Count > 1 &&
                    CboxHistorial.SelectedIndex > -1 &&
                    CboxUsuario.SelectedIndex > -1)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (ValidarDatosRequeridos())
            {

                DialogResult Respuesta = MessageBox.Show("¿Esta seguro de agregar una nueva receta?", "Confirmacion requerida", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {

                    VLogica.Receta MiReceta = new VLogica.Receta();

                    MiReceta.Tratamiento = TxtTratamiento.Text.Trim();
                    MiReceta.Fecha = Convert.ToDateTime(TxtFecha.Text.Trim());
                    MiReceta.Precio = Convert.ToDecimal(TxtPrecio.Text.Trim());
                    MiReceta.MiHistorial.IdHistorial = Convert.ToInt32(CboxHistorial.SelectedValue);
                    MiReceta.MiUsuario.IdUsuario = Convert.ToInt32(CboxUsuario.SelectedValue);

                    bool IdExiste = MiReceta.ConsultarPorId();



                    if (!IdExiste)
                    {
                        //No existe un receta con la cédula 

                        // en la llamada a funciones anteriores usé una var bool para 
                        //almacenar el retorno de la función. Acá evaluaremos el 
                        //retorno de la función de forma directa. 

                        if (MiReceta.Agregar())
                        {

                            //todo salió bien al realizaer el Insert 
                            //se muestra un mensaje de éxito al usuario 

                            MessageBox.Show("Receta agregado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            LimpiarFormulario();
                            LlenarListaRecetas();


                        }


                    }
                    else
                    {
                        //Se validan los textbox de nombre en caso
                        //de que ya existan estos datos registrados.
                        if (IdExiste)
                        {
                            MessageBox.Show("El Id ya esta en uso", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtIdReceta.Focus();
                            TxtIdReceta.SelectAll();

                        }

                    }

                }
            }

        }

        private void FrmReceta_Load(object sender, EventArgs e)
        {
            CargarDatosHistorial();

            CargarDatosUsuario();

            LlenarListaRecetas();

            LimpiarFormulario();
        }

        private void DgvListaRecetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Valida que la fila este seleccionada.
                if (DgvListaRecetas.SelectedRows.Count == 1)
                {

                    DataGridViewRow MiFila = DgvListaRecetas.SelectedRows[0];


                    TxtIdReceta.Text = Convert.ToString(MiFila.Cells["CIdReceta"].Value);
                    TxtTratamiento.Text = Convert.ToString(MiFila.Cells["CTratamiento"].Value);
                    TxtFecha.Text = Convert.ToString(MiFila.Cells["CFecha"].Value);
                    TxtPrecio.Text = Convert.ToString(MiFila.Cells["CPrecio"].Value);



                    CboxHistorial.SelectedValue = Convert.ToInt32(MiFila.Cells["CIdHistorial"].Value);

                    CboxUsuario.SelectedValue = Convert.ToInt32(MiFila.Cells["CIdUsuario"].Value);


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
                    VLogica.Receta MiReceta = new VLogica.Receta();


                    DataGridViewRow MiFila = DgvListaRecetas.SelectedRows[0];

                    MiReceta.IdReceta = Convert.ToInt32(MiFila.Cells["CIdReceta"].Value);

                    MiReceta.Tratamiento = TxtTratamiento.Text.Trim();
                    MiReceta.Fecha = Convert.ToDateTime(TxtFecha.Text.Trim());
                    MiReceta.Precio = Convert.ToDecimal(TxtPrecio.Text.Trim());
                    MiReceta.MiHistorial.IdHistorial = Convert.ToInt32(CboxHistorial.SelectedValue);
                    MiReceta.MiUsuario.IdUsuario = Convert.ToInt32(CboxUsuario.SelectedValue);

                    if (MiReceta.ConsultarPorId())
                    {
                        //Se emplea el método editar de la clase.
                        if (MiReceta.Modificar())
                        {
                            MessageBox.Show("Receta modificada correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            LimpiarFormulario();
                            LlenarListaRecetas();
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
            VLogica.Receta MiReceta = new VLogica.Receta();

            DataGridViewRow MiFila = DgvListaRecetas.SelectedRows[0];

            MiReceta.IdReceta = Convert.ToInt32(MiFila.Cells["CIdReceta"].Value);

            try
            {
                if (MiReceta.ConsultarPorId())
                {
                    //Se emplea el método de eliminar de la clase.
                    if (MiReceta.Desactivar())
                    {
                        MessageBox.Show("Receta eliminada correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LimpiarFormulario();
                        LlenarListaRecetas();
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
