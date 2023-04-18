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
    public partial class FrmCliente : Form
    {

        private VLogica.Cliente MiClienteLocal { get; set; }

        public DataTable ListaClientesNormal { get; set; }

        public int IdCliente { get; set; }

        public FrmCliente()
        {
            InitializeComponent();

            MiClienteLocal = new VLogica.Cliente();
            ListaClientesNormal = new DataTable();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        //Método que permite limpiar los campos del formulario.
        private void LimpiarFormulario()
        {
            TxtIdCliente.Clear();

            TxtNombre.Clear();
            TxtCedula.Clear();
            TxtTelefono.Clear();
            TxtCorreoElectronico.Clear();
            TxtDireccion.Clear();
        }

        //Llena la lista con los datos del cliente.
        private void LlenarListaClientes()
        {
            //se llama la clase empleado para manipular los datos.
            VLogica.Cliente MiCliente = new VLogica.Cliente();
            try
            {
                ListaClientesNormal = MiCliente.ListarTodos();

                DgvListaClientes.DataSource = ListaClientesNormal;

                DgvListaClientes.ClearSelection();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Activa el botón de agregar
        //Desactiva los botones de eliminar
        //y editar.
        private void ActivarBtnAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            
        }

        private void ActivarBtnModificarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;

        }


        //Método que agrega el cliente al datagridview
        //Valida los campos de texto
        //Se emplea el método de agregar de la clase Cliente
        //Al agregar el cliente, se limpia el formulario,
        //se activan el botón agregar y
        //se llena el datagrid con los datos del cliente.
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
           
            if (ValidarDatosRequeridos())
            {

                DialogResult Respuesta = MessageBox.Show("¿Esta seguro de agregar el nuevo cliente?", "Confirmacion requerida", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {

                    VLogica.Cliente MiCliente = new VLogica.Cliente();

                    MiCliente.NombreCompleto = TxtNombre.Text.Trim();
                    MiCliente.Cedula = TxtCedula.Text.Trim();
                    MiCliente.Telefono = TxtTelefono.Text.Trim();
                    MiCliente.CorreoElectronico = TxtCorreoElectronico.Text.Trim();
                    MiCliente.Direccion = TxtDireccion.Text.Trim();

                    bool CedulaExiste = MiCliente.ConsultarPorCedula();



                    if (!CedulaExiste)
                    {
                        //No existe un usuario con la cédula y el correo proporcionado 

                        // en la llamada a funciones anteriores usé una var bool para 
                        //almacenar el retorno de la función. Acá evaluaremos el 
                        //retorno de la función de forma directa. 

                        if (MiCliente.Agregar())
                        {

                            //todo salió bien al realizaer el Insert 
                            //se muestra un mensaje de éxito al usuario 

                            MessageBox.Show("Cliente agregado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            LimpiarFormulario();
                            LlenarListaClientes();
                            //ActivarBtnAgregar();

                        }


                    }
                    else
                    {
                        //Se validan los textbox de nombre en caso
                        //de que ya existan estos datos registrados.
                        if (CedulaExiste)
                        {
                            MessageBox.Show("La cédula ya esta en uso", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtCedula.Focus();
                            TxtCedula.SelectAll();

                        }

                    }

                }
            }

        }


        //Método que valida los campos del formulario.
        private bool ValidarDatosRequeridos()
        {
            bool R = false;
            try
            {
                //Valida  los campos no estén vacíos o
                //que no contengan un dato menor al ingresado.

                if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCorreoElectronico.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtDireccion.Text.Trim()))
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                //valida los datos existentes y los modifica.
                if (ValidarDatosRequeridos())
                {
                   VLogica.Cliente MiCliente = new VLogica.Cliente();

                    DataGridViewRow MiFila = DgvListaClientes.SelectedRows[0];

                    MiCliente.IdCliente = Convert.ToInt32(MiFila.Cells["IdCliente"].Value);


                    MiCliente.NombreCompleto = TxtNombre.Text.Trim();
                    MiCliente.Cedula = TxtCedula.Text.Trim();
                    MiCliente.Telefono = TxtTelefono.Text.Trim();
                    MiCliente.CorreoElectronico = TxtCorreoElectronico.Text.Trim();
                    MiCliente.Direccion = TxtDireccion.Text.Trim();

                    if (MiCliente.ConsultarPorId())
                    {
                        //Se emplea el método editar de la clase.
                        if (MiCliente.Modificar())
                        {
                            MessageBox.Show("Cliente modificado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            LimpiarFormulario();
                            LlenarListaClientes();
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

            VLogica.Cliente MiCliente = new VLogica.Cliente();

            DataGridViewRow MiFila = DgvListaClientes.SelectedRows[0];

            MiCliente.IdCliente = Convert.ToInt32(MiFila.Cells["Id"].Value);


            try
             {

                if (MiCliente.ConsultarPorId())
                {
            //Se emplea el método de eliminar de la clase.
                   if (MiCliente.Desactivar())
                    {
                         MessageBox.Show("Cliente eliminado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LimpiarFormulario();
                        //ActivarBtnAgregar();
                        LlenarListaClientes();
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

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void DgvListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                //valida si se ha seleccionado una fila en el datagridview
                if (DgvListaClientes.SelectedRows.Count == 1)
                {
                    LimpiarFormulario();

                    DataGridViewRow MiFila = DgvListaClientes.SelectedRows[0];


                    int IdCliente = Convert.ToInt32(MiFila.Cells["Id"].Value);

                    MiClienteLocal = new VLogica.Cliente();

                    MiClienteLocal = MiClienteLocal.Consultar(IdCliente);

                    TxtNombre.Text = MiClienteLocal.NombreCompleto;
                    TxtCedula.Text = MiClienteLocal.Cedula;
                    TxtTelefono.Text = MiClienteLocal.Telefono;
                    TxtCorreoElectronico.Text = MiClienteLocal.CorreoElectronico;
                    TxtDireccion.Text = MiClienteLocal.Direccion;

                    //ActivarBtnModificarYEliminar();
                }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
           

            LlenarListaClientes();

            LimpiarFormulario();

            //ActivarBtnAgregar();

        }

        //Método que permite solo letras 
        //en el textbox de nombre.
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs pE)
        {
            Herramientas.CaracteresTexto(pE);

        }

        //Método que permite solo letras y números
        //en el textbox de cedula.
        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e);

        }

        //Método que permite solo números 
        //en el textbox de teléfono.
        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresNumeros(e);
        }

        //Método que permite solo letras y números
        //en el textbox de correo.
        private void TxtCorreoElectronico_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, false, true);

        }

        //Método que permite solo letras y números
        //en el textbox de direccion.
        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Herramientas.CaracteresTexto(e, true);

        }

        private void TxtBuscar_Click(object sender, EventArgs e)
        {
            TxtBuscar.Focus();
            TxtBuscar.SelectAll();
        }

        private void TxtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }

}
