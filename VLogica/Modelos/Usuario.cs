using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VLogica
{
    public class Usuario
    {

        public int IdUsuario { get; set; }

        public string NombreCompleto { get; set; }

        public string Cedula { get; set; }

        public string Telefono { get; set; }

        public string Contrasena { get; set; }

        public string Estado { get; set; }


        public Usuario()
        {

        }

        public bool Agregar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                Crypto MiEncriptador = new Crypto();

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@NombreCompleto", this.NombreCompleto));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));

                string MiPasswordEncriptado = MiEncriptador.EncriptarEnUnSentido(this.Contrasena);

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Pass", MiPasswordEncriptado));

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

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Id", this.IdUsuario));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@NombreCompleto", this.NombreCompleto));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));

                Crypto MiEncriptador = new Crypto();
                string PasswordEncriptado = "";

                if (!string.IsNullOrEmpty(this.Contrasena))
                {
                    PasswordEncriptado = MiEncriptador.EncriptarEnUnSentido(this.Contrasena);
                }

                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Pass", PasswordEncriptado));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPUsuarioEditarModificar");

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

        public bool ModificarContra()
        {

            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@NombreCompleto", this.NombreCompleto));

            Crypto Encriptador = new Crypto();

            string ClaveEncriptada = Encriptador.EncriptarEnUnSentido(this.Contrasena);

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@Contrasena", ClaveEncriptada));

            return (MyCnn.DMLUpdateDeleteInsert("SPUsuarioModificarContra") > 0 ? true : false);
        }

        public bool Desactivar()
        {
            bool R = false;

            try
            {
                Conexion MiCnn = new Conexion();

                //Lista de parametros que llegaran al SP
                MiCnn.ListadoDeParametros.Add(new SqlParameter("@Id", this.IdUsuario));

                int retorno = MiCnn.DMLUpdateDeleteInsert("SPUsuarioDesactivar");

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

        public bool ConsultarPorID()
        {
            bool R = false;

            try
            {
                Conexion MiConexion = new Conexion();

                MiConexion.ListadoDeParametros.Add(new SqlParameter("@Id", this.IdUsuario));

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

        public int ValidarLogin(string pUsuario, string pPass)
        {
            int R = 0;

            this.NombreCompleto = pUsuario;
            this.Contrasena = pPass;

            Crypto MiEncriptador = new Crypto();

            string PasswordEncriptado = MiEncriptador.EncriptarEnUnSentido(this.Contrasena);

            Conexion MiCnn = new Conexion();

            MiCnn.ListadoDeParametros.Add(new SqlParameter("@User", this.NombreCompleto));
            MiCnn.ListadoDeParametros.Add(new SqlParameter("@Pass", PasswordEncriptado));

            DataTable Respuesta = MiCnn.DMLSelect("SPUsuarioValidarLogin");

            if (Respuesta != null && Respuesta.Rows.Count > 0)
            {
                DataRow MiFila = Respuesta.Rows[0];

                R = Convert.ToInt32(MiFila["IdUsuario"]);
            }

            return R;
        }

        public DataTable Listar(bool VerActivos, string Filtro)
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
