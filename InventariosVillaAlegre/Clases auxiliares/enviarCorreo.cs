using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosVillaAlegre.Clases_auxiliares
{
    class enviarCorreo
    {

        public static SmtpClient credenciales()
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("villaalegresystem@gmail.com", "R351d3Nc14L"),
                EnableSsl = true
            };
            return client;

        }
        
        
        
        public static Boolean enviarContraseña(String correo, String contraseña, String nombre)
        {
            encripDatos en = new encripDatos();
            string body = "¡Hola " + nombre + "! \n Tu clave de acceso es: " + en.desencrip(contraseña) + "\n Residencial villa alegre.\n " + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss") + "\n Este mensaje fue generado de manera automatica. No responder sobre este mail";
            try
            {
                credenciales().Send("villaalegresystem@gmail.com", correo, "Recordatorio de contraseña", body);
                MessageBox.Show("¡Contraseña enviada al correo proporcionado!");
                return true;
            }
            catch
            {
                MessageBox.Show("¡Correo no enviado, compruebe su conexion a internet.");
                return false;
            }
        }

        public static Boolean enviarPDF(String correo, String asunto, String mensaje)
        {
            try
            {
                MailMessage mnsj = new MailMessage();
                mnsj.Subject = asunto;
                mnsj.To.Add(new MailAddress(correo));
                mnsj.From = new MailAddress("villaalegresystem@gmail.com", "Sistema villa alegre");
                mnsj.Attachments.Add(new Attachment(valores.Rutapdf));
                mnsj.Body = mensaje + "\nEste mensaje fue generado de manera automatica. No responder sobre este mail";
                credenciales().Send(mnsj);
                MessageBox.Show("Correo Enviado Correctamente");
                return true;
            }
            catch
            {
                MessageBox.Show("¡Correo no enviado, compruebe su conexion a internet.");
                return false;
            }
        }

    }
}
