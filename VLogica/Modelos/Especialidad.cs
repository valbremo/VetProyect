using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLogica
{
    public class Especialidad
    {
        public int IdEspecialidad { get; set; }

        public string Nombre { get; set; }



        public Especialidad()
        {

        }


        public bool Agregar()
        {
            bool R = false;

            try
            {
                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));

                int retorno = MyCnn.DMLUpdateDeleteInsert("SPEspecialidadAgregar");

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

                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("IdEspecialidad", this.IdEspecialidad));

                int retorno = MyCnn.DMLUpdateDeleteInsert("SPEspecialidadEliminar");

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

        public Especialidad Consultar(int pIdEspecialidad)
        {
            Especialidad R = new Especialidad();

            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("IdEspecialidad", pIdEspecialidad));

            DataTable DatosEspecialidad = new DataTable();

            DatosEspecialidad = MyCnn.DMLSelect("SPEspecialidadConsultarPorID");

            //Valida los datos de la Especialidad

            if (DatosEspecialidad.Rows.Count > 0)
            {

                DataRow MiFila = DatosEspecialidad.Rows[0];

                R.IdEspecialidad = Convert.ToInt32(MiFila["IdEspecialidad"]);
                R.Nombre = Convert.ToString(MiFila["Nombre"]);
            }

            return R;
        }

        public bool Modificar()
        {
            bool R = false;

            try
            {
                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("IdEspecialidad", this.IdEspecialidad));

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
  

                int retorno = MyCnn.DMLUpdateDeleteInsert("SPEspecialidadModificar");

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

        public bool ConsultarPorId()
        {
            bool R = false;

            try
            {
                Conexion MiConexion = new Conexion();

                MiConexion.ListadoDeParametros.Add(new SqlParameter("@IdEspecialidad", this.IdEspecialidad));

                DataTable retorno = MiConexion.DMLSelect("SPEspecialidadConsultarPorID");

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
        public bool ConsultarPorNombre()
        {
            bool R = false;

            try
            {
                Conexion MiConexion = new Conexion();

                MiConexion.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));

                DataTable retorno = MiConexion.DMLSelect("SPEspecialidadConsultarPorNombre");

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

        public DataTable ListarTodos()
        {
            DataTable R = new DataTable();

            Conexion MiConexion = new Conexion();

            R = MiConexion.DMLSelect("SPEspecialidadListar");

            return R;

        }
    }
}
