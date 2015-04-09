using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace InventariosVillaAlegre
{
    class Correos
    {
        class correos
        {
            /*
             * Cliente SMTP
             * Gmail:  smtp.gmail.com  puerto:587
             * Hotmail: smtp.liva.com  puerto:25
             */
            SmtpClient server = new SmtpClient("smtp.gmail.com", 587);

            public correos()
            {
                /*
                 * Autenticacion en el Servidor
                 * Utilizaremos nuestra cuenta de correo
                 *
                 * Direccion de Correo (Gmail o Hotmail)
                 * y Contrasena correspondiente
                 */
                server.Credentials = new System.Net.NetworkCredential("villaalegressystem@gmail.com", "R351d3Nc14L");
                server.EnableSsl = true;
            }

            public void MandarCorreo(MailMessage mensaje)
            {
                server.Send(mensaje);
            }
        }

        internal void MandarCorreo(MailMessage mnsj)
        {
            throw new NotImplementedException();
        }
    }
}
