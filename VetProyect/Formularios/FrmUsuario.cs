﻿using System;
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
    public partial class FrmUsuario : Form
    {
        // Variables locales
        private VLogica.Usuario MiUsuarioLocal { get; set; }

        //usaremos una variable flag para capturar el valor boolean de 
        //si lo que queremos hacer es activar o desactivar un usuario 
        //NOTA. podríamos haber usado el valor de checked del checkbox también.
        private bool FlagActivar { get; set; }

        private bool FlagCambioContrasena { get; set; }


        //Si trabajos con dos versiones de listado que se presenta en el 
        //datagrid, es conveniente tenerlas por separado, para que la lista
        //normal no deba ser recargada cada que borramos el filtro del 
        //cuadro de búsqueda
        public DataTable ListaUsuariosNormal { get; set; }

        public DataTable ListaUsuariosConFiltro { get; set; }


        //Método que carga las variables locales en el constructor.
        public FrmUsuario()
        {
            InitializeComponent();

            MiUsuarioLocal = new VLogica.Usuario();
        }

        private void ActivarBotonAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
            TxtCedula.Enabled = true;
        }

        private void ActivarEditarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
            TxtCedula.Enabled = false;
        }





        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //primero debemos validar que hayan datos en los cuadros
            //de texto requisito (los que no permiten NULL a nivel 
            //de base de datos. 

            if (ValidarDatosRequeridos())
            {
                //hay data en cada campo requerido

                DialogResult RespuestaUsuario = MessageBox.Show("¿Está seguro de agregar el nuevo usuario?", "Confirmación requerida", MessageBoxButtons.YesNo);

                if (RespuestaUsuario == DialogResult.Yes)
                {

                    VLogica.Usuario MiUsuario = new VLogica.Usuario();

                    //Se asignan los datos de cada control del form 
                    //a los atribs del objeto usuario
                    MiUsuario.NombreCompleto = TxtNombre.Text.Trim();
                    MiUsuario.Cedula = TxtCedula.Text.Trim();
                    MiUsuario.Telefono = TxtTelefono.Text.Trim();
                    MiUsuario.Contrasena = TxtContrasena.Text.Trim();

                    
                    bool CedulaExiste = MiUsuario.ConsultarPorCedula();

                    
                    bool IdExiste = MiUsuario.ConsultarPorID();

                   
                    if (!CedulaExiste && !IdExiste)
                    {
                        //No existe un usuario con la cédula y el id proporcionado 

                        // en la llamada a funciones anteriores usé una var bool para 
                        //almacenar el retorno de la función. Acá evaluaremos el 
                        //retorno de la función de forma directa. 

                        if (MiUsuario.Agregar())
                        {
                            //todo salió bien al realizaer el Insert 
                            //se muestra un mensaje de éxito al usuario 

                            
                            MessageBox.Show("Usuario agregado correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            LlenarListaUsuarios();
                            ActivarBotonAgregar();

                        }

                    }
                    else
                    {
                        //indicar al usuario qué está mal 

                        if (CedulaExiste)
                        {
                            MessageBox.Show("La Cédula ya está siendo usada", "Aviso del sistema", MessageBoxButtons.OK);
                            TxtCedula.Focus();
                            TxtCedula.SelectAll();
                        }
                        else if (IdExiste)
                        {
                            MessageBox.Show("La Id ya está siendo usado", "Aviso del sistema", MessageBoxButtons.OK);
                            TxtIdUsuario.Focus();
                            TxtIdUsuario.SelectAll();
                        }

                    }

                }

            }

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            MdiParent = Locales.ObjetosGlobales.MiFormPrincipal;

            LlenarListaUsuarios();

            LimpiarFormulario();

            ActivarBotonAgregar();
        }

        private void LimpiarFormulario()
        {
            //metodo para limpiar cada control y evitar que se mezclen datos de un objeto a otro.
            TxtIdUsuario.Clear();

            TxtNombre.Clear();
            TxtCedula.Clear();
            TxtTelefono.Clear();
            TxtContrasena.Clear();
            
            CbActivo.Checked = false;

        }

        private void LlenarListaUsuarios()
        {
            //se llama la clase empleado para manipular los datos.
            VLogica.Cliente MiCliente = new VLogica.Cliente();
            try
            {
                ListaUsuariosNormal = MiCliente.ListarTodos();

                DgvListaUsuarios.DataSource = ListaUsuariosNormal;

                DgvListaUsuarios.ClearSelection();
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

                if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasena.Text.Trim()) &&

                Herramientas.ValidarEmail(TxtNombre.Text.Trim()) == true ||
                Herramientas.ValidarPass(TxtContrasena.Text.Trim()) == true)
                
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


        //Método que permite modifica los datos del usuario
        //Se emplea el método de consulta por Id de la clase
        //de usuario para poder modificar sus datos
        //Se emplea el método para limpiar el formulario
        //Se emplea el método para llenar la lista con los datos del usuario
        //Se emplea el método para activar el botón de agregar.
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //valida los datos existentes y los modofica
            if (ValidarDatosRequeridos())
            {
                VLogica.Usuario MiUsuario = new VLogica.Usuario();

                MiUsuario.IdUsuario = Convert.ToInt32(TxtIdUsuario.Text.Trim());

                MiUsuario.NombreCompleto = TxtNombre.Text.Trim();
                MiUsuario.Cedula = TxtCedula.Text.Trim();
                MiUsuario.Telefono = TxtTelefono.Text.Trim();
                MiUsuario.Contrasena = "";

                if (MiUsuario.ConsultarPorID())
                { 
                    //Se emplea el metodo editar de la clase.
                    if(MiUsuario.Editar())
                    {
                        MessageBox.Show("Usuario modificado correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LimpiarFormulario();
                        LlenarListaUsuarios();
                        ActivarBotonAgregar();

                    }
                

                }
            }
        }

        //Método que permite eliminar los datos del usuario
        //Se emplea el método de consulta por Id de la clase
        //de usuario para poder eliminar sus datos.
        //Se emplea el método para limpiar el formulario
        //Se emplea el método para llenar la lista con los datos del usuario
        //Se emplea el método para activar el botón de agregar.
        private void BtnEliminar_Click(object sender, EventArgs e)
        {


        }
    }
}

