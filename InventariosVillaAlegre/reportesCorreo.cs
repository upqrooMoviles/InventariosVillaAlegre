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
            rutaarchivo.Text = valores.Nombrepdf;
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

                    mnsj.Subject = valores.Nombrepdf;

                    mnsj.To.Add(new MailAddress(correoenviar.Text));

                    mnsj.From = new MailAddress("villaalegressystem@gmail.com", "Villa Alegre System");

                    /* Si deseamos Adjuntar algún archivo*/
                    mnsj.Attachments.Add(new Attachment(valores.Rutapdf));

                    mnsj.Body = mensaje.Text;

                    /* Enviar */
                    Cr.MandarCorreo(mnsj);
                    //Enviado = true;

                    MessageBox.Show("Correo Enviado Correctamente", "Confirmacion de correo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Correo no enviado, intente nuevamente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
