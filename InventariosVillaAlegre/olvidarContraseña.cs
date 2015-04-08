using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
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

        private void button9_Click(object sender, EventArgs e)
        {
            if (validacion() == true)
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
                catch{
                    MessageBox.Show("Correo y/o usuario no encontrados!");
                    user.Focus();
                }
            }
        }

        public void enviar(String correo, String contraseña, String nombre) {
            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress(correo));
            email.From = new MailAddress("villaalegresystem@gmail.com");
            email.Subject = "Recordatorio de contraseña";
            email.Body = "Hola! "+nombre+"\n Tu clave de acceso es: \n <b>"+contraseña+"</b> \n Residencial villa alegre.\n " + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss")+"\n Este mensaje fue generado de manera automatica. No responder sobre este mail";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "gmail.com";
            smtp.Port = 2525;
            smtp.EnableSsl = false;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("villaalegresystem@gmail.com", "R351d3Nc14L");
            string output = null;
            try
            {
                smtp.Send(email);
                email.Dispose();
                MessageBox.Show("¡La contraseña fue enviada a el correo ingresado!");
                this.Hide();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error enviando el correo, Verifique su conexion a internet.");
                MessageBox.Show(ex.ToString());
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
    }
}
