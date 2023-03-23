using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLogica
{
    public class Mascota
    {
        public int IdMascota { get; set; }
        
        public string Nombre { get; set; }  

        public DateTime FechaNacimiento { get; set; }

        public string Raza { get; set; }

        public string Observacion { get; set; }

        // Se escriben composiciones
        public TipoMascota MiTipoMascota { get; set; }

        public Cliente MiCliente { get; set; }



        public Mascota()
        {
            MiTipoMascota = new TipoMascota();
            MiCliente = new Cliente();
        }

        public bool Agregar()
        {
            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@FechaNacimiento", this.FechaNacimiento));
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@Raza", this.Raza));
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@Observacion", this.Observacion));
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdTipoMascota", this.MiTipoMascota.IdTipoMascota));
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdCliente", this.MiCliente.IdCliente));

            return MyCnn.DMLUpdateDeleteInsert("SPMascotaAgregar") > 0 ? true : false;
        }

        public bool Modificar()
        {
            bool R = false;

            try
            {
                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("IdMascota", this.IdMascota));

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@FechaNacimiento", this.FechaNacimiento));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Raza", this.Raza));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Observacion", this.Observacion));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdTipoMascota", this.MiTipoMascota.IdTipoMascota));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdCliente", this.MiCliente.IdCliente));

                int retorno = MyCnn.DMLUpdateDeleteInsert("SPMascotaModificar");

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

        public Mascota ConsultarPorId(int ID)
        {
            Mascota MiMascota = new Mascota();
            DataTable Tabla = new DataTable();
            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdMascota", ID));

            Tabla = MyCnn.DMLSelect("SPMascotaConsultarPorID");

            if (Tabla.Rows.Count > 0)
            {
                DataRow Fila = Tabla.Rows[0];
                MiMascota.IdMascota = ID;
                MiMascota.Nombre = Fila["Nombre"].ToString();
                MiMascota.FechaNacimiento = Convert.ToDateTime(Fila["FechaNacimiento"]);
                MiMascota.Raza = Fila["Raza"].ToString();
                MiMascota.Observacion = Fila["Observacion"].ToString();
                MiMascota.MiTipoMascota.IdTipoMascota = Convert.ToInt32(Fila["IdTipoMascota"]);
                MiMascota.MiCliente.IdCliente = Convert.ToInt32(Fila["IdCliente"]);
                
            }


            return MiMascota;
        }

        public bool ConsultarPorNombre(string Nombre)
        {
            DataTable Tabla = new DataTable();
            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", Nombre));

            Tabla = MyCnn.DMLSelect("SPMascotaConsultarPorNombre");

            return (Tabla.Rows.Count > 0 ? true : false);
        }

        public bool Desactivar()
        {
            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("IdMascota", this.IdMascota));

            return (MyCnn.DMLUpdateDeleteInsert("SPMascotaEliminar") > 0 ? true : false);
        }


        public DataTable ListarTodos()
        {
            DataTable R = new DataTable();

            Conexion MiConexion = new Conexion();

            R = MiConexion.DMLSelect("SPMascotaListar");

            return R;

        }
    }
    }
