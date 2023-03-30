using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLogica
{
    public class Receta
    {
        public int IdReceta { get; set; }

        public string Tratamiento { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Precio { get; set; }

         //Composiciones

        public Historial MiHistorial { get; set; }

        public Usuario MiUsuario { get; set; }


        public Receta()
        {
            MiHistorial = new Historial();
            MiUsuario = new Usuario();
        }


        public bool Agregar()
        {
            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@Tratamiento", this.Tratamiento));
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@Fecha", this.Fecha));
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@Precio", this.Precio));
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdHistorial", this.MiHistorial.IdHistorial));
            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdUsuario", this.MiUsuario.IdUsuario));

            return MyCnn.DMLUpdateDeleteInsert("SPRecetaAgregar") > 0 ? true : false;
        }

        public bool Modificar()
        {
            bool R = false;

            try
            {
                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("IdReceta", this.IdReceta));

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Tratamiento", this.Tratamiento));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Fecha", this.Fecha));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Precio", this.Precio));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdHistorial", this.MiHistorial.IdHistorial));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdUsuario", this.MiUsuario.IdUsuario));

                int retorno = MyCnn.DMLUpdateDeleteInsert("SPRecetaModificar");

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

                MiConexion.ListadoDeParametros.Add(new SqlParameter("@IdReceta", this.IdReceta));

                DataTable retorno = MiConexion.DMLSelect("SPRecetaConsultarPorID");

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

            MyCnn.ListadoDeParametros.Add(new SqlParameter("IdReceta", this.IdReceta));

            return (MyCnn.DMLUpdateDeleteInsert("SPRecetaEliminar") > 0 ? true : false);
        }


        //Listar todas las citas

        public DataTable ListarTodos()
        {
            DataTable R = new DataTable();

            Conexion MiConexion = new Conexion();

            R = MiConexion.DMLSelect("SPRecetaListar");

            return R;

        }
    }
}
