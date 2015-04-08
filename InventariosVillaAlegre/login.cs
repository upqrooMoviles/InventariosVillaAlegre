using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosVillaAlegre
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            user.Focus();
        }
        String usuario = "", tipo_usuario = "";
        private void entrar_Click(object sender, EventArgs e)
        {
            metodosSQL m = new metodosSQL();
            if (validacion() == true)
            {
                try
                {

                    DataSet busquedauser = m.busqueda("usuarios", "usuario, tipo_usuario", "usuario='"+user.Text+"' and contraseña='"+pass.Text+"'");
                    usuario=busquedauser.Tables[0].Rows[0][0].ToString();
                    tipo_usuario= busquedauser.Tables[0].Rows[0][1].ToString();
                    valores.Tipo_usuario = tipo_usuario;
                    valores.Usuario = usuario;
                    llamaformulario();
                }
                catch
                {
                    MessageBox.Show("Usuario y/o contraseña no validos!");
                }
                

            }

            
        }


        private void user_KeyPress(object sender, KeyPressEventArgs e)
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

        private void pass_KeyPress(object sender, KeyPressEventArgs e)
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

        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            olvidarContraseña o = new olvidarContraseña();
            o.Show();
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
            if (pass.Text.Trim().ToString().Length < 1)
            {
                validacion++;
                campos += "Contraseña\n";
                pass.Focus();
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
        public void llamaformulario()
        {
            if (valores.Opcion == "alimentos" && valores.Tipo_usuario == "General" || valores.Opcion == "alimentos" && valores.Tipo_usuario == "AdminAlimentos" || valores.Opcion == "alimentos" && valores.Tipo_usuario == "BasicoAlimentos")
            {
                alimentos ss = new alimentos();
                ss.Show();
                this.Hide();
            }

            else if (valores.Opcion == "medicamentos" && valores.Tipo_usuario == "General" || valores.Opcion == "medicamentos" && valores.Tipo_usuario == "AdminMedicamentos" || valores.Opcion == "medicamentos" && valores.Tipo_usuario == "BasicoMedicamentos")
            {
                medicamentos ss = new medicamentos();
                ss.Show();
                this.Hide();
            }

            else if (valores.Opcion == "usuarios" && valores.Tipo_usuario == "General")
            {
                usuarios ss = new usuarios();
                ss.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Verifique sus credenciales de usuario!.\n No es posible accesar al contenido especificado con ese nivel de usuario");
                principal p = new principal();
                p.Show();
                this.Hide();
            }

        }

    }
}
