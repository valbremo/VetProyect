using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLogica
{
    public class Historial
    {
        public int IdHistorial { get; set; }

        public string Sintomas { get; set; }

        public DateTime Fecha  { get; set; }

        public string Diagnostico { get; set; }


        // Se escriben composiciones
        public Mascota MiMascota { get; set; }

        public Especialidad MiEspecialidad { get; set; }


        public Historial()
        {
            MiMascota = new  VLogica.Mascota();
            MiEspecialidad = new VLogica.Especialidad();
        }


        public bool Agregar()
        {

            bool R = false;

            try
            { 
                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Sintomas", this.Sintomas));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Fecha", this.Fecha));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Diagnostico", this.Diagnostico));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdMascota", this.MiMascota.IdMascota));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdEspecialidad", this.MiEspecialidad.IdEspecialidad));

                int retorno = MyCnn.DMLUpdateDeleteInsert("SPHistorialAgregar");

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

                MyCnn.ListadoDeParametros.Add(new SqlParameter("IdHistorial", this.IdHistorial));

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Sintomas", this.Sintomas));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Fecha", this.Fecha));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Diagnostico", this.Diagnostico));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdMascota", this.MiMascota.IdMascota));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdEspecialidad", this.MiEspecialidad.IdEspecialidad));

                int retorno = MyCnn.DMLUpdateDeleteInsert("SPHistorialModificar");

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


        public Historial Consultar(int pHistorial)
        {
            Historial R = new Historial();

            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdHistorial", pHistorial));

            DataTable DatosProducto = new DataTable();
            DatosProducto = MyCnn.DMLSelect("SPHistorialConsultarPorID");

            if (DatosProducto.Rows.Count > 0)
            {

                DataRow MiFila = DatosProducto.Rows[0];

                R.IdHistorial = Convert.ToInt32(MiFila["IdHistorial"]);
                R.Sintomas = Convert.ToString(MiFila["Sintomas"]);
                R.Fecha = Convert.ToDateTime(MiFila["Fecha"]);
                R.Diagnostico = Convert.ToString(MiFila["Diagnostico"]);
                R.MiMascota.IdMascota = Convert.ToInt32(MiFila["IdMascota"]);
                R.MiEspecialidad.IdEspecialidad = Convert.ToInt32(MiFila["IdEspecialidad"]);

            }
            return R;
        }

        public bool ConsultarPorId()
        {
            bool R = false;

            try
            {
                Conexion MiConexion = new Conexion();

                MiConexion.ListadoDeParametros.Add(new SqlParameter("@IdHistorial", this.IdHistorial));

                DataTable retorno = MiConexion.DMLSelect("SPHistorialConsultarPorID");

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

        public bool Desactivar()
        {
            bool R = false;

            try
            {
                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("IdHistorial", this.IdHistorial));

                int retorno = MyCnn.DMLUpdateDeleteInsert("SPHistorialEliminar");

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




        public DataTable ListarTodos()
        {
            DataTable R = new DataTable();

            Conexion MiConexion = new Conexion();

            R = MiConexion.DMLSelect("SPHistorialListar");

            return R;

        }

        public DataTable ConsultarPorFecha(DateTime Fecha, DateTime FechaFin)
        {
            DataTable Tabla = new DataTable();
            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@Fecha", Fecha));
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@FechaFin", FechaFin));

            return Tabla = MyCnn.DMLSelect("SPSPHistorialConsultarPorFecha");
        }


        public DataTable ListarRHi()
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            R = MyCnn.DMLSelect("SPRecetaListarHistorial");

            return R;
        }
    }
}
