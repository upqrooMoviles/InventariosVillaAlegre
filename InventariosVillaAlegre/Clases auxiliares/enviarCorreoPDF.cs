using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace InventariosVillaAlegre
{
    public partial class reportesCorreo : Form
    {
        public reportesCorreo()
        {
            InitializeComponent();
            asuntoenviar.Text = "Factura de compra";
            rutaarchivo.Text = valores.nombrepdf;
            mensaje.Text = "Factura de compra - Gamers";
            new ToolTip().SetToolTip(enviar, "Enviar Correo");
            this.ActiveControl = correoenviar;
            correoenviar.Focus();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComprobarFormatoEmail(correoenviar.Text) == false)
                {
                    MessageBox.Show("Formato de correo no valido", "Sistema Gamers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Correos Cr = new Correos();
                    MailMessage mnsj = new MailMessage();

                    mnsj.Subject = valores.nombrepdf;

                    mnsj.To.Add(new MailAddress(correoenviar.Text));

                    mnsj.From = new MailAddress("pabloc.hay@outlook.com", "Sistema Gamers");

                    /* Si deseamos Adjuntar algún archivo*/
                    mnsj.Attachments.Add(new Attachment(valores.rutapdf));

                    mnsj.Body = mensaje.Text;

                    /* Enviar */
                    Cr.MandarCorreo(mnsj);
                    //Enviado = true;

                    MessageBox.Show("Correo Enviado Correctamente", "Sistema Gamers", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Correo no enviado", "Sistema Gamers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
            }
        }

        public static bool ComprobarFormatoEmail(string sEmailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(sEmailAComprobar, sFormato))
            {
                if (Regex.Replace(sEmailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
