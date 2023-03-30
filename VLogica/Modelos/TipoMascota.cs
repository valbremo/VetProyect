using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLogica
{
    public class TipoMascota
    {
        public int IdTipoMascota { get; set; }

        public string Nombre { get; set; }


        public TipoMascota()
        {

        }


        public bool Agregar()
        {
            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
           

            return MyCnn.DMLUpdateDeleteInsert("SPTipoMascotaAgregar") > 0 ? true : false;
        }

        public bool Desactivar()
        {
            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("IdTipoMascota", this.IdTipoMascota));

            return (MyCnn.DMLUpdateDeleteInsert("SPTipoMascotaEliminar") > 0 ? true : false);
        }

        public DataTable ListarTodos()
        {
            DataTable R = new DataTable();

            Conexion MiConexion = new Conexion();

            R = MiConexion.DMLSelect("SPTipoMascotaListar");

            return R;

        }

    }
}
