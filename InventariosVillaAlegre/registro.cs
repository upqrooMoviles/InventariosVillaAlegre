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
            nombre.Focus();
        }
        private void usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (Char.IsLetter(e.KeyChar)) //Al pulsar una letra
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (Char.IsControl(e.KeyChar)) //Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false; //Se acepta (todo OK)
            }
           else if (Char.IsNumber(e.KeyChar)) //Al pulsar una letra
           {
               e.Handled = false; //Se acepta (todo OK)
           }
            else //Para todo lo demas
            {
                e.Handled = true; //No se acepta (si pulsas cualquier otra cosa pues no se envia)
            }
        }

        private void contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) //Al pulsar una letra
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) //Al pulsar una letra
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
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
        
        

        private void registro_Click(object sender, EventArgs e)
        {
            if (validar() == true)
            {
                if(validarcorreo(correo.Text)==true)
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
                                        MessageBox.Show("Registro insertado con exito!");
                                        principal p = new principal();
                                        this.Hide();
                                        p.Show();
                                    }
                                    else
                                        MessageBox.Show("Registro no insertado, intente de nuevo o contacte al proovedor de software!");
                                }
                                else
                                {
                                    MessageBox.Show("Clave de registro incorrecta!");
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
        

        private void clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) //Al pulsar una letra
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
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

        

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)) //Al pulsar una letra
            {
                e.Handled = true; //Se acepta (todo OK)
            }
            else //Para todo lo demas
            {
                e.Handled = false; //No se acepta (si pulsas cualquier otra cosa pues no se envia)
            }
        }

        private void correo_KeyPress(object sender, KeyPressEventArgs e)
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

        public Boolean validar()
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
