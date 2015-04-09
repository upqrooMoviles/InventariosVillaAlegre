using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosVillaAlegre
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }
        private void registro_Load(object sender, EventArgs e)
        {
            nombre.Select();
        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.sinNumeros(e);
        }

        private void usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.letrasNumerosSinEspacios(e);
        }

        private void contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.letrasNumerosSinEspacios(e);
        }
        private void contraseñaconfirmacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.letrasNumerosSinEspacios(e);
        }
        private void correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.sinEspacios(e);

        }
        private void clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.sinEspacios(e);
        }
        
        private void registrar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true)
            {
                if(checarCaracteres.validarcorreo(correo.Text)==true)
                        {
                            if (contraseña.Text.ToString().Equals(contraseñaconfirmacion.Text.ToString()))
                            {
                                if (clave.Text.ToString().Equals("R3sVi114a1"))
                                {
                                    encripDatos en = new encripDatos();
                                    string valoresCampos = "'"+nombre.Text+"', '"+usuario.Text+"', '"+ en.encrip(contraseña.Text)+"','General','"+correo.Text+"'";
                                    metodosSQL m = new metodosSQL();
                                    if (m.insertar("usuarios", "nombre, usuario, contraseña, tipo_usuario, correo", valoresCampos) == true)
                                    {
                                        MessageBox.Show("¡Registro insertado con exito!");
                                        principal p = new principal();
                                        this.Hide();
                                        p.Show();
                                    }
                                    else
                                        MessageBox.Show("¡Registro no insertado! Intente de nuevo o contacte al proovedor de software.");
                                }
                                else
                                {
                                    MessageBox.Show("¡Clave de registro incorrecta!");
                                    clave.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Las contraseñas no coinciden!");
                                contraseña.Focus();
                            }
                        }
            }
        }
        
        public Boolean validarCampos()
        {
            int validacion = 0;
            string campos = "";
            if (nombre.Text.Trim().ToString().Length < 5)
            {
                validacion++;
                campos += "Nombre de 5 a 45 caracteres\n";
                nombre.Focus();
            }
            if (usuario.Text.Trim().ToString().Length < 5)
            {
                validacion++;
                campos += "Usuario de 5 a 10 caracteres\n";
                usuario.Focus();
            }
            if (contraseña.Text.Trim().ToString().Length < 5)
            {
                validacion++;
                campos += "Contraseña de 5 a 12 caracteres\n";
                contraseña.Focus();
            }
            if (contraseñaconfirmacion.Text.Trim().ToString().Length < 5)
            {
                validacion++;
                campos += "Confirmacion de la contraseña de 5 a 12 caracteres\n";
                contraseñaconfirmacion.Focus();
            }
            if (correo.Text.Trim().ToString().Length < 5)
            {
                validacion++;
                campos += "Correo de 5 a 45 caracteres\n";
                correo.Focus();
            }
            if (clave.Text.Trim().ToString().Length < 10)
            {
                validacion++;
                campos += "Clave de registro de 10 caracteres\n";
                clave.Focus();
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
