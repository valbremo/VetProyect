using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VetProyect.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {

            if (!Locales.ObjetosGlobales.MiFormUsuario.Visible)
            {
                Locales.ObjetosGlobales.MiFormUsuario = new FrmUsuario();
                Locales.ObjetosGlobales.MiFormUsuario.Show();
            }
        }

        //Carga las opciones del menú según los permisos del usuario
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {


        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {

            if (!Locales.ObjetosGlobales.MiFormCliente.Visible)
            {
                Locales.ObjetosGlobales.MiFormCliente = new FrmCliente();
                Locales.ObjetosGlobales.MiFormCliente.Show();
            }

        }

        private void BtnMascotas_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormMascota.Visible)
            {
                Locales.ObjetosGlobales.MiFormMascota = new FrmMascota();
                Locales.ObjetosGlobales.MiFormMascota.Show();
            }
        }

        private void BtnCitas_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormCita.Visible)
            {
                Locales.ObjetosGlobales.MiFormCita = new FrmCita();
                Locales.ObjetosGlobales.MiFormCita.Show();
            }
        }

        private void BtnRecetas_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormReceta.Visible)
            {
                Locales.ObjetosGlobales.MiFormReceta = new FrmReceta();
                Locales.ObjetosGlobales.MiFormReceta.Show();
            }

        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormHistorial.Visible)
            {
                Locales.ObjetosGlobales.MiFormHistorial = new FrmHistorial();
                Locales.ObjetosGlobales.MiFormHistorial.Show();
            }
        }

        private void BtnTipoMascota_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormTipoMascota.Visible)
            {
                Locales.ObjetosGlobales.MiFormTipoMascota = new FrmTipoMascota();
                Locales.ObjetosGlobales.MiFormTipoMascota.Show();
            }
        }

        private void BtnEspecialidad_Click(object sender, EventArgs e)
        {
            if (!Locales.ObjetosGlobales.MiFormEspecialidad.Visible)
            {
                Locales.ObjetosGlobales.MiFormEspecialidad = new FrmEspecialidad();
                Locales.ObjetosGlobales.MiFormEspecialidad.Show();
            }
        }

        private void BtnAcercaDe_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
