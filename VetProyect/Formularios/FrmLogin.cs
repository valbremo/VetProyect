using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VLogica;

namespace VetProyect.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Formulario de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeInformacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Formulario de Gestión Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private DialogResult MensajePregunta(string Mensaje)
        {
            return MessageBox.Show(Mensaje, "Formulario de Gestión Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private bool ValidarCampos()
        {
            bool R = false;
            if ((!string.IsNullOrEmpty(TxtUsuario.Text.Trim())) &&
                (!string.IsNullOrEmpty(TxtContrasena.Text.Trim())))
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtUsuario.Text.Trim()))
                {
                    MensajeError("Debes ingresar el Usuario/Email");
                    TxtUsuario.Focus();
                }
                if (string.IsNullOrEmpty(TxtContrasena.Text.Trim()))
                {
                    MensajeError("Debes ingresar la contraseña");
                    TxtContrasena.Focus();
                }
            }
            return R;
        }



            private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsuario.Text.Trim()) &&
                 !string.IsNullOrEmpty(TxtContrasena.Text.Trim()))
            {

                string u = TxtUsuario.Text.Trim();
                string c = TxtContrasena.Text.Trim();

                VLogica.Usuario MiUsuario = new VLogica.Usuario();

                int IdUsuarioValidado = MiUsuario.ValidarLogin(u, c);

                if (IdUsuarioValidado > 0)
                {

                    Locales.ObjetosGlobales.MiUsuarioGlobal = MiUsuario.Consultar(IdUsuarioValidado);

                    Locales.ObjetosGlobales.MiFormPrincipal.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña son incorrectas", ":(", MessageBoxButtons.OK);
                    TxtContrasena.Focus();
                    TxtContrasena.SelectAll();
                }

            }


        }
    }
}
