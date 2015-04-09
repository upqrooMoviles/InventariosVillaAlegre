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
            user.Select();
        }

        private void precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) //Al pulsar una letra
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (Char.IsControl(e.KeyChar)) //Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else //Para todo lo demas
            {
                e.Handled = true; //No se acepta (si pulsas cualquier otra cosa pues no se envia)
            }

        }

        private void enviarcontraseña_Click(object sender, EventArgs e)
        {
            if (validacion() == true)
            {
                if (validarcorreo(mail.Text) == true)
                {
                    try
                    {
                        metodosSQL m = new metodosSQL();
                        DataSet busquedauser = m.busqueda("usuarios", "nombre, contraseña, correo", "usuario='" + user.Text + "' and correo='" + mail.Text + "'");
                        String nombre = busquedauser.Tables[0].Rows[0][0].ToString();
                        String contraseña = busquedauser.Tables[0].Rows[0][1].ToString();
                        String correo = busquedauser.Tables[0].Rows[0][2].ToString();
                        enviar(correo, contraseña, nombre);
                    }
                    catch
                    {
                        MessageBox.Show("Correo y/o usuario no encontrados!");
                        user.Focus();
                    }
                }
            }
        }

        public void enviar(String correo, String contraseña, String nombre) {
            encripDatos en = new encripDatos();
            string body = "Hola "+nombre+"! \n Tu clave de acceso es: "+en.desencrip(contraseña)+"\n Residencial villa alegre.\n " + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss")+"\n Este mensaje fue generado de manera automatica. No responder sobre este mail";
            var client = new SmtpClient("smtp.gmail.com", 587) {
                Credentials = new NetworkCredential("villaalegresystem@gmail.com", "R351d3Nc14L"),EnableSsl = true
            };

            try
            {
                client.Send("villaalegresystem@gmail.com", correo, "Recordatorio de contraseña", body);
                MessageBox.Show("¡Contraseña enviada al correo proporcionado!");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Correo no enviado, compruebe su conexion a internet.");
            }
            

        }
        public Boolean validacion()
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

        private void mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar)) //Al pulsar una letra
            {
                e.Handled = true; //Se acepta (todo OK)
            }
            else //Para todo lo demas
            {
                e.Handled = false; //No se acepta (si pulsas cualquier otra cosa pues no se envia)
            }

        }

        public Boolean validarcorreo(string email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Formato de correo no valido!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Formato de correo no valido!");
                return false;
            }
        }
    }
}
