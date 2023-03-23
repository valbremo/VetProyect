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
            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));


            return MyCnn.DMLUpdateDeleteInsert("SPEspecialidadAgregar") > 0 ? true : false;
        }

        public bool Desactivar()
        {
            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("IdEspecialidad", this.IdEspecialidad));

            return (MyCnn.DMLUpdateDeleteInsert("SPEspecialidadEliminar") > 0 ? true : false);
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
