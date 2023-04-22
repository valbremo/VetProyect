using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLogica
{
    public class Usuario
    {

        public int IdUsuario { get; set; }

        public string NombreCompleto { get; set; }

        public string Cedula { get; set; }

        public string Telefono { get; set; }

        public string Contrasena { get; set; }



        public Usuario()
        {
            
        }

        public bool Agregar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@NombreCompleto", this.NombreCompleto));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Contrasena", this.Contrasena));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPUsuarioAgregar");

                if (retorno > 0)
                {
                    R = true;
                }


            }
            catch (Exception)
            {

                throw;
            }

            return R;
        }

        public bool Editar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@IdUsuario", this.IdUsuario));

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@NombreCompleto", this.NombreCompleto));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Contrasena", this.Contrasena));


                int retorno = MiCnn.DMLUpdateDeleteInsert("SPUsuarioModificar");

                if (retorno > 0)
                {
                    R = true;
                }

            }
            catch (Exception)
            {

                throw;
            }

            return R;
        }

        

        public bool Desactivar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                //Lista de parametros que llegaran al SP
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@IdUsuario", this.IdUsuario));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPUsuarioEliminar");

                if (retorno > 0)
                {
                    R = true;
                }


            }
            catch (Exception)
            {

                throw;
            }

            return R;
        }

        public Usuario Consultar(int pIDUsuario)
        {
            Usuario R = new Usuario();

            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdUsuario", pIDUsuario));

            DataTable DatosUsuario = new DataTable();

            DatosUsuario = MyCnn.DMLSelect("SPUsuarioConsultarPorID");


            if (DatosUsuario.Rows.Count > 0)
            {

                DataRow MiFila = DatosUsuario.Rows[0];

                R.IdUsuario = Convert.ToInt32(MiFila["IdUsuario"]);
                R.NombreCompleto = Convert.ToString(MiFila["NombreCompleto"]);
                R.Cedula = Convert.ToString(MiFila["Cedula"]);
                R.Telefono = Convert.ToString(MiFila["Telefono"]);
                R.Contrasena = Convert.ToString(MiFila["Contrasena"]);

               

            }

            return R;
        }

            public bool ConsultarPorID()
            {
                bool R = false;

                try
                {
                    Conexion MiConexion = new Conexion();

                    MiConexion.ListadoDeParametros.Add(new SqlParameter("@IdUsuario", this.IdUsuario));

                    DataTable retorno = MiConexion.DMLSelect("SPUsuarioConsultarPorID");

                    if (retorno.Rows.Count > 0)
                    {
                        R = true;
                    }

                }
                catch (Exception)
                {

                    throw;
                }

                return R;

            }

            public bool ConsultarPorCedula()
            {
                bool R = false;

                try
                {
                    Conexion MiConexion = new Conexion();

                    MiConexion.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));

                    DataTable retorno = MiConexion.DMLSelect("SPUsuarioConsultarPorCedula");

                    if (retorno.Rows.Count > 0)
                    {
                        R = true;
                    }

                }
                catch (Exception)
                {
                    throw;
                }

                return R;
            }

            public int ValidarLogin(string pUsuario, string pContrasena)
            {
                int R = 0;

                this.NombreCompleto = pUsuario;
                this.Contrasena = pContrasena;


                Conexion MiCnn = new Conexion();

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@NombreCompleto", this.NombreCompleto));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Contrasena", pContrasena));

                DataTable Respuesta = MiCnn.DMLSelect("SPUsuarioValidarLogin");

                if (Respuesta != null && Respuesta.Rows.Count > 0)
                {
                    DataRow MiFila = Respuesta.Rows[0];

                    R = Convert.ToInt32(MiFila["IdUsuario"]);
                }

                return R;
            }

            public DataTable Listar(bool VerActivos = true, string Filtro = "")
            {
                DataTable R = new DataTable();

                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@VerActivo", VerActivos));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Filtro", Filtro));

                R = MyCnn.DMLSelect("SPUsuarioListarActivos");

                return R;
            }

            public DataTable ListarTodos()
            {
                DataTable R = new DataTable();

                Conexion MiConexion = new Conexion();

                R = MiConexion.DMLSelect("SPUsuarioListarTodos");

                return R;

            }


        }
    } 
