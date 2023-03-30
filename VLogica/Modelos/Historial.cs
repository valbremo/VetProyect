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
            MiMascota = new Mascota();
            MiEspecialidad = new Especialidad();
        }


        public bool Agregar()
        {
            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@Sintomas", this.Sintomas));
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@Fecha", this.Fecha));
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@Diagnostico", this.Diagnostico));
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdMascota", this.MiMascota.IdMascota));
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdEspecialidad", this.MiEspecialidad.IdEspecialidad));

            return MyCnn.DMLUpdateDeleteInsert("SPHistorialAgregar") > 0 ? true : false;
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
    }
}
