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

        public Cliente ConsultarPorId(int ID)
        {
            Cliente R = new Cliente();

            //esta funcion retorna un objeto de tipo cliente con la data correspondiente
            //para el ID suministrado a traves del parametro

            Conexion MyCnn = new Conexion();
            DataTable Tabla = new DataTable();

            //Se agrega un parametro que pueda llegar al SP con el valor del Id del cliente
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdCliente", ID));

            Tabla = MyCnn.DMLSelect("SPClienteConsultaPorID");

            //Se evalua que el DT tenga datos y se asigna a al objeto de retorno R

            if (Tabla.Rows.Count > 0)
            {
                DataRow Fila = Tabla.Rows[0];

                R.IdCliente = ID;
                R.NombreCompleto = Fila["NombreCompleto"].ToString();
                R.Cedula = Fila["Cedula"].ToString();
                R.Telefono = Fila["Telefono"].ToString();
                R.CorreoElectronico = Fila["CorreoElectronico"].ToString();
                R.Direccion = Fila["Direccion"].ToString();
            }

            return R;
            
        }



        //Consulta los datos del cliente por la cedula en la Base de Datos

        public bool ConsultarPorCedula(string Cedula)
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
