using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetProyect.Formularios
{
    public partial class FrmUsuario : Form
    {

        private VLogica.Usuario MiUsuarioLocal { get; set; }

        public DataTable ListaUsuariosNormal { get; set; }

        public DataTable ListaUsuariosConFiltro { get; set; }

        public FrmUsuario()
        {
            InitializeComponent();

            MiUsuarioLocal = new VLogica.Usuario();

            ListaUsuariosNormal = new DataTable();
        }

        


       
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //primero debemos validar que hayan datos en los cuadros
            //de texto requisito (los que no permiten NULL a nivel 
            //de base de datos. 

            if (ValidarDatosRequeridos())
            {
                //hay data en cada campo requerido

                DialogResult RespuestaUsuario = MessageBox.Show("¿Está seguro de Agregar el nuevo usuario?", "Confirmación requerida", MessageBoxButtons.YesNo);

                if (RespuestaUsuario == DialogResult.Yes)
                {

                    //paso 1.1 y 1.2 
                    Logica.Usuario MiUsuario = new Logica.Usuario();

                    //Se asignan los datos de cada control del form 
                    //a los atribs del objeto usuario
                    MiUsuario.Cedula = TxtCedula.Text.Trim();
                    MiUsuario.Nombre = TxtNombre.Text.Trim();
                    MiUsuario.Telefono = TxtTelefono.Text.Trim();
                    MiUsuario.Direccion = TxtDireccion.Text.Trim();
                    MiUsuario.Email = TxtEmail.Text.Trim();
                    MiUsuario.Constrasennia = TxtPassword1.Text.Trim();
                    MiUsuario.Rol.IDUsuarioRol = Convert.ToInt32(CboxTipoUsuario.SelectedValue);

                    //paso 1.3 y 1.3.6
                    bool CedulaExiste = MiUsuario.ConsultarPorCedula();

                    //paso 1.4 y 1.4.6
                    bool EmailExiste = MiUsuario.ConsultarPorEmail();

                    //paso 1.5
                    if (!CedulaExiste && !EmailExiste)
                    {
                        //No existe un usuario con la cédula y el correo proporcionado 

                        //paso 1.6, 1.6.6 y 1.7
                        // en la llamada a funciones anteriores usé una var bool para 
                        //almacenar el retorno de la función. Acá evaluaremos el 
                        //retorno de la función de forma directa. 

                        if (MiUsuario.Agregar())
                        {
                            //todo salió bien al realizaer el Insert 
                            //se muestra un mensaje de éxito al usuario 

                            //Paso 1.8
                            MessageBox.Show("Usuario agregado correctamente", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();
                            LlenarListaUsuarios(true);
                            ActivarBotonAgregar();

                        }

                    }
                    else
                    {
                        //indicar al usuario qué está mal 

                        if (CedulaExiste)
                        {
                            MessageBox.Show("La Cédula ya está siendo usada", ":(", MessageBoxButtons.OK);
                            TxtCedula.Focus();
                            TxtCedula.SelectAll();
                        }
                        else if (EmailExiste)
                        {
                            MessageBox.Show("La Email ya está siendo usado", ":(", MessageBoxButtons.OK);
                            TxtEmail.Focus();
                            TxtEmail.SelectAll();
                        }

                    }

                }

            }

        }


    }
    }
}
