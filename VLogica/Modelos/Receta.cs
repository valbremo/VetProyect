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
            MiHistorial = new VLogica.Historial();
            MiUsuario = new VLogica.Usuario();
        }


        public bool Agregar()
        {
            bool R = false;

            try 
            { 

                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Tratamiento", this.Tratamiento));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Fecha", this.Fecha));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Precio", this.Precio));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdHistorial", this.MiHistorial.IdHistorial));
                MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdUsuario", this.MiUsuario.IdUsuario));

                int retorno = MyCnn.DMLUpdateDeleteInsert("SPRecetaAgregar");

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


        public Receta Consultar(int pIdReceta)
        {
            Receta R = new Receta();

            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("@IdReceta", pIdReceta));

            DataTable DatosProducto = new DataTable();
            DatosProducto = MyCnn.DMLSelect("SPRecetaConsultarPorID");

            if (DatosProducto.Rows.Count > 0)
            {

                DataRow MiFila = DatosProducto.Rows[0];

                R.IdReceta = Convert.ToInt32(MiFila["IdReceta"]);
                R.Tratamiento = Convert.ToString(MiFila["Tratamiento"]);
                R.Fecha = Convert.ToDateTime(MiFila["Fecha"]);
                R.Precio = Convert.ToDecimal(MiFila["Precio"]);
                R.MiHistorial.IdHistorial = Convert.ToInt32(MiFila["IdHistorial"]);
                R.MiUsuario.IdUsuario = Convert.ToInt32(MiFila["IdUsuario"]);

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

            bool R = false;

            try
            { 

                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("IdReceta", this.IdReceta));

                int retorno = MyCnn.DMLUpdateDeleteInsert("SPRecetaEliminar");

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

            R = MiConexion.DMLSelect("SPRecetaListar");

            return R;

        }
    }
}
