﻿using System;
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

        public bool Modificar()
        {
            bool R = false;

            try
            {
                Conexion MyCnn = new Conexion();

                MyCnn.ListadoDeParametros.Add(new SqlParameter("IdTipoMascota", this.IdTipoMascota));

                MyCnn.ListadoDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));


                int retorno = MyCnn.DMLUpdateDeleteInsert("SPTipoMascotaModificar");

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


        public TipoMascota Consultar(int pIdTipoMascota)
        {
            TipoMascota R = new TipoMascota();

            Conexion MyCnn = new Conexion();

            MyCnn.ListadoDeParametros.Add(new SqlParameter("IdTipoMascota", pIdTipoMascota));

            DataTable DatosTipoMascota = new DataTable();

            DatosTipoMascota = MyCnn.DMLSelect("SPTipoMascotaConsultar");

            //Valida los datos de el tipo de mascota

            if (DatosTipoMascota.Rows.Count > 0)
            {

                DataRow MiFila = DatosTipoMascota.Rows[0];

                R.IdTipoMascota = Convert.ToInt32(MiFila["IdTipoMascota"]);
                R.Nombre = Convert.ToString(MiFila["Nombre"]);
            }

            return R;
        }

            public bool ConsultarPorId()
        {
            bool R = false;

            try
            {
                Conexion MiConexion = new Conexion();

                MiConexion.ListadoDeParametros.Add(new SqlParameter("@IdTipoMascota", this.IdTipoMascota));

                DataTable retorno = MiConexion.DMLSelect("SPTipoMascotaConsultarPorID");

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
