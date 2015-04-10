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
using InventariosVillaAlegre.Clases_auxiliares;

namespace InventariosVillaAlegre
{
    public partial class reportesCorreo : Form
    {
        public reportesCorreo()
        {
            InitializeComponent();
        }
        private void reportesCorreo_Load(object sender, EventArgs e)
        {
            asuntoenviar.Text = valores.Asunto;
            rutaarchivo.Text = valores.Nombrepdf;
            mensaje.Text = valores.Mensaje;
            new ToolTip().SetToolTip(enviar, "Enviar Correo");
            this.ActiveControl = correoenviar;
            correoenviar.Focus();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
           if (checarCaracteres.validarcorreo(correoenviar.Text) == true&&validarCampos()==true)
                {
                    enviar.Enabled = false;
                    if(enviarCorreo.enviarPDF(correoenviar.Text,asuntoenviar.Text,mensaje.Text)==true)
                     this.Hide();
                    else
                        enviar.Enabled = true;
                }
        }

        public Boolean validarCampos() {
            string campos = "";
            int validar = 0;
            if (correoenviar.Text.Length <= 5)
            {
                validar++;
                campos += "Correo\n";
            }
            if (asuntoenviar.Text.Length <= 5)
            {
                validar++;
                campos += "Asunto\n";
            }
            if (validar != 0)
            {
                if (validar == 1)
                    MessageBox.Show("Falta rellenar el campo "+campos);
                else
                    MessageBox.Show("Falta rellenar los campos:\n " + campos);
                return false; 
            }
            else 
            { 
                return true; 
            }
        }

        private void correoenviar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.sinEspacios(e);
        }
        

    }
}
