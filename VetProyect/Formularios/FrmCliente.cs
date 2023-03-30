using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public FrmCliente()
        {
            InitializeComponent();

            MiClienteLocal = new Cliente();
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
            Cliente MiCliente = new Cliente();
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


        //Método que agrega el cliente al datagridview
        //Valida los campos de texto
        //Se emplea el método de agregar de la clase Cliente
        //Al agregar el cliente, se limpia el formulario,
        //se activan el botón agregar y
        //se llena el datagrid con los datos del cliente.
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se emplea este método para validar los campos
                //Se emplea un método para validar existencias
                //y así no existan datos repetidos
                //con los datos ingresados.
                if (ValidarDatosRequeridos())
                {

                    DialogResult Respuesta = MessageBox.Show("¿Esta seguro de agregar el nuevo cliente?", "Confirmacion requerida", MessageBoxButtons.YesNo);

                    if (Respuesta == DialogResult.Yes)
                    {

                        Cliente MiCliente = new Cliente();

                        MiCliente.NombreCompleto = TxtNombre.Text.Trim();
                        MiCliente.Cedula = TxtCedula.Text.Trim();
                        MiCliente.Telefono = TxtTelefono.Text.Trim();
                        MiCliente.CorreoElectronico = TxtCorreoElectronico.Text.Trim();
                        MiCliente.Direccion = TxtDireccion.Text.Trim();

                        bool NombreExiste = MiCliente.ConsultarPorCedula();


                        if (!NombreExiste)
                        {
                            //Se emplea el método agregar de la clase
                            //Se emplea el método de limpiar el formulario
                            //Se emplea el método para llenar la lista con los clientes
                            //Se emplea el método para activar el botón de agregar.
                            if (MiCliente.Agregar())
                            {
                                MessageBox.Show("Cliente agregado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                LimpiarFormulario();
                                LlenarListaClientes();
                                ActivarBtnAgregar();

                            }


                        }
                        else
                        {
                            //Se validan los textbox de nombre en caso
                            //de que ya existan estos datos registrados.
                            if (NombreExiste)
                            {
                                MessageBox.Show("La cedula ya esta en uso", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtCedula.Focus();
                                TxtCedula.SelectAll();

                            }

                        }

                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error denotado por:\n" + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                !string.IsNullOrEmpty(TxtCedula.Text.Trim()))
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
                    Cliente MiCliente = new Cliente();

                    DataGridViewRow MiFila = DgvListaClientes.SelectedRows[0];

                    MiCliente.IdCliente = Convert.ToInt32(MiFila.Cells["IDCliente"].Value);

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
                            ActivarBtnAgregar();
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

            Cliente MiCliente = new Cliente();

            DataGridViewRow MiFila = DgvListaClientes.SelectedRows[0];

            MiCliente.IdCliente = Convert.ToInt32(MiFila.Cells["IdCliente"].Value);

            try
            {
                if (MiCliente.ConsultarPorId())
                {
                    //Se emplea el método de eliminar de la clase.
                    if (MiCliente.Desactivar())
                    {
                        MessageBox.Show("Cliente eliminado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LimpiarFormulario();
                        ActivarBtnAgregar();
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
    }

 



}
