using InventariosVillaAlegre.Clases_auxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosVillaAlegre
{
    public partial class olvidarContraseña : Form
    {
        public olvidarContraseña()
        {
            InitializeComponent();
        }

        private void olvidarContraseña_Load(object sender, EventArgs e)
        {
            user.Select();
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.letrasNumerosSinEspacios(e);
        }
        private void mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.sinEspacios(e);
        }
        private void enviarcontraseña_Click(object sender, EventArgs e)
        {
            if (validacionCampos() == true)
            {
                if (checarCaracteres.validarcorreo(mail.Text) == true)
                {
                    try
                    {
                        metodosSQL m = new metodosSQL();
                        DataSet busquedauser = m.busqueda("usuarios", "nombre, contraseña, correo", "usuario='" + user.Text + "' and correo='" + mail.Text + "'");
                        String nombre = busquedauser.Tables[0].Rows[0][0].ToString();
                        String contraseña = busquedauser.Tables[0].Rows[0][1].ToString();
                        String correo = busquedauser.Tables[0].Rows[0][2].ToString();
                        if (enviarCorreo.enviarContraseña(correo, contraseña, nombre) == true)
                            this.Hide();
                    }
                    catch
                    {
                        MessageBox.Show("¡Correo y/o usuario no encontrados!");
                        user.Focus();
                    }
                }
            }
        }

        
        public Boolean validacionCampos()
        {
            int validacion = 0;
            string campos = "";

            if (user.Text.Trim().ToString().Length < 1)
            {
                validacion++;
                campos += "Usuario\n";
                user.Focus();
            }
            if (mail.Text.Trim().ToString().Length < 1)
            {
                validacion++;
                campos += "Contraseña\n";
                mail.Focus();
            }
            if (validacion == 0)
                return true;
            else
            {
                if (validacion == 1)
                    MessageBox.Show("Falta rellenar el campo " + campos);
                else
                    MessageBox.Show("Falta rellenar los campos: \n" + campos);
                return false;
            }
        }

    }
}
