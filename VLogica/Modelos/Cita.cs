using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLogica
{
    public class Cita
    {
        public int IdCita { get; set; }

        public DateTime Fecha { get; set; }

        public string Especificacion { get; set; }


        // se escriben las composiciones

        public Cliente MiCliente { get; set; }

        public Mascota MiMascota { get; set; }

        public Cita()
        {
            MiCliente = new VLogica.Cliente();
            MiMascota = new VLogica.Mascota();  
        }

        public bool Agregar()
        {
            bool R = false;

            try
            { 
                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Fecha", this.Fecha));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Especificacion", this.Especificacion));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdCliente", this.MiCliente.IdCliente));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdMascota", this.MiMascota.IdMascota));

                int retorno = MyCnn.DMLUpdateDeleteInsert("SPCitaAgregar");

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

        public bool Modificar()
        {
            bool R = false;

            try
            {
                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("IdCita", this.IdCita));

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Fecha", this.Fecha));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Especificacion", this.Especificacion));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdCliente", this.MiCliente.IdCliente));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdMascota", this.MiMascota.IdMascota));

                int retorno = MyCnn.DMLUpdateDeleteInsert("SPCitaModificar");

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


        public Cita Consultar(int pIdCita)
        {
            Cita R = new Cita();

            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdCita", pIdCita));

            DataTable DatosProducto = new DataTable();
            DatosProducto = MyCnn.DMLSelect("SPCitaConsultarPorID");

            if (DatosProducto.Rows.Count > 0)
            {

                DataRow MiFila = DatosProducto.Rows[0];

                R.IdCita = Convert.ToInt32(MiFila["IdCita"]);
                R.Fecha = Convert.ToDateTime(MiFila["Fecha"]);
                R.Especificacion = Convert.ToString(MiFila["Especificacion"]);
                R.MiCliente.IdCliente = Convert.ToInt32(MiFila["IdCliente"]);
                R.MiMascota.IdMascota = Convert.ToInt32(MiFila["IdMascota"]);
                

            }
            return R;
        }


        public bool ConsultarPorId()
        {
            bool R = false;

            try
            {
                Conexion MiConexion = new Conexion();

                MiConexion.ListadoDeParametros.Add(new SqlParameter("@IdCita", this.IdCita));

                DataTable retorno = MiConexion.DMLSelect("SPCitaConsultarPorID");

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


        //Eliminar la Cita

        public bool Desactivar()
        {
            bool R = false;

            try
            { 
                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("IdCita", this.IdCita));

                int retorno = MyCnn.DMLUpdateDeleteInsert("SPCitaEliminar");

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


        //Listar todas las citas

        public DataTable ListarTodos()
        {
            DataTable R = new DataTable();

            Conexion MiConexion = new Conexion();

            R = MiConexion.DMLSelect("SPCitaListar");

            return R;

        }

    }


}
