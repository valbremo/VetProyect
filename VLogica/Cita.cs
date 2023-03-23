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

        public bool Disponible { get; set; }

        // se escriben las composiciones

        public Cliente MiCliente { get; set; }

        public Mascota MiMascota { get; set; }

        public Cita()
        {
            MiCliente = new Cliente();
            MiMascota = new Mascota();  
        }

        public bool Agregar()
        {
            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@Fecha", this.Fecha));
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@Especificacion", this.Especificacion));
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@Disponible", this.Disponible));
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdCliente", this.MiCliente.IdCliente));
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdMascota", this.MiMascota.IdMascota));

            return MyCnn.DMLUpdateDeleteInsert("SPCitaAgregar") > 0 ? true : false;

        }

        public bool Modificar()
        {
            bool R = false;

            try
            {
                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("IdCita", this.IdCita));

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Fecha", this.Fecha));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Espeficicacion", this.Especificacion));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Disponible", this.Disponible));
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

        public Cita ConsultarPorId(int ID)
        {
            Cita MiCita = new Cita();
            DataTable Tabla = new DataTable();
            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdCita", ID));

            Tabla = MyCnn.DMLSelect("SPCitaConsultarPorId");

            if (Tabla.Rows.Count > 0)
            {
                DataRow Fila = Tabla.Rows[0];
                MiCita.IdCita = ID;
                MiCita.Fecha = Convert.ToDateTime(Fila["Fecha"]);
                MiCita.Especificacion = Fila["Especificacion"].ToString();
                MiCita.Disponible = Convert.ToBoolean(Fila["Disponible"]);
                MiCita.MiCliente.IdCliente = Convert.ToInt32(Fila["IdCliente"]);
                MiCita.MiMascota.IdMascota = Convert.ToInt32(Fila["IdMascota"]);
            }


            return MiCita;
        }


        //Eliminar la Cita

        public bool Desactivar()
        {
            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("IdCita", this.IdCita));

            return (MyCnn.DMLUpdateDeleteInsert("SPCitaEliminar") > 0 ? true : false);
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
