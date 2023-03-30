using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLogica
{
    public class Cliente
    {
        //definimos las propiedades simples de la clase

        public int IdCliente { get; set; }
        public string NombreCompleto { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Direccion { get; set; }

        // Constructor

        public Cliente()
        {

        }

        //Metodos
        //Se agregan los datos del cliente en la Base de Datos

        public bool Agregar()
        {
            bool R = false;
            
            try
            {

                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@NombreCompleto", this.NombreCompleto));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@CorreoElectronico", this.CorreoElectronico));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));

                int retorno = MyCnn.DMLUpdateDeleteInsert("SPClienteAgregar");

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

        //Se modifican los datos del cliente en la Base de Datos

        public bool Modificar()
        {
            bool R = false;

            try 
            {
                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("IdCliente", this.IdCliente));

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@NombreCompleto", this.NombreCompleto));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@CorreoElectronico", this.CorreoElectronico));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));

                int retorno = MyCnn.DMLUpdateDeleteInsert("SPClienteModificar");

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

        //Consulta los datos del cliente por el Id en la Base de Datos

        public bool ConsultarPorId()
        {
            bool R = false;

            try
            {
                Conexion MiConexion = new Conexion();

                MiConexion.ListadoDeParametros.Add(new SqlParameter("@IdCliente", this.IdCliente));

                DataTable retorno = MiConexion.DMLSelect("SPClienteConsultarPorID");

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


        //Consulta los datos del cliente por la cedula en la Base de Datos

        public bool ConsultarPorCedula()
        {

            bool R = false;
            try
            {
                Conexion MiConexion = new Conexion();

                MiConexion.ListadoDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));

                DataTable retorno = MiConexion.DMLSelect("SPClienteConsultarPorCedula");

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

        //Eliminar el Cliente

        public bool Desactivar()
        {
            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("IdCliente", this.IdCliente));

            return (MyCnn.DMLUpdateDeleteInsert("SPClienteEliminar") > 0 ? true : false);
        }

        //Listar todos los clientes

        public DataTable ListarTodos()
        {
            DataTable R = new DataTable();

            Conexion MiConexion = new Conexion();

            R = MiConexion.DMLSelect("SPClienteListar");

            return R;

        }

    }
}
