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

        public bool ConsultarPorId()
        {
            bool R = false;

            try
            {
                Conexion MiConexion = new Conexion();

                MiConexion.ListadoDeParametros.Add(new SqlParameter("@IdMascota", this.IdMascota));

                DataTable retorno = MiConexion.DMLSelect("SPMascotaConsutarPorID");

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

                DataTable retorno = MiConexion.DMLSelect("SPMascotaConsultarPorNombre");

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
