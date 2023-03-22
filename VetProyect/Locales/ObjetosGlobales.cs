using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetProyect.Locales
{
    public static class ObjetosGlobales
    {
        public static Form MiFormPrincipal = new Formularios.FrmPrincipal();

        public static VLogica.Usuario MiUsuarioGlobal = new Formularios.FrmUsuario();

        public static Formularios.FrmCliente MiFormCliente = new Formularios.FrmCliente();

        public static Formularios.FrmCita MiFormCita = new Formularios.FrmCita();

        public static Formularios.FrmMascota MiFormMascota = new Formularios.FrmMascota();

        public static Formularios.FrmTipoMascota MiFormTipoMascota = new Formularios.FrmTipoMascota();

        public static Formularios.FrmHistorial MiFormHistorial = new Formularios.FrmHistorial();

        public static Formularios.FrmEspecialidad MiFormEspecialidad = new Formularios.FrmEspecialidad();

        public static Formularios.FrmReceta MiFormReceta = new Formularios.FrmReceta();

    
    }
}
