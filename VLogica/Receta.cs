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


    }
}
