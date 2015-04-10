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
    public partial class modificarUsuario : Form
    {

        public modificarUsuario()
        {
            InitializeComponent();
            tipo.SelectedItem = "General";
        }
        private void modificarUsuario_Load(object sender, EventArgs e)
        {
            usuario.Focus();
        }
        metodosSQL m = new metodosSQL();
        String nombre1, correo1, contraseña1, contraseñaconfirmacion1, tipo1;

        private void buscar_Click(object sender, EventArgs e)
        {
            if (usuario.Text.Length >=5)
            {
                try
                {
                    encripDatos en = new encripDatos();
                    DataSet busquedauser = m.busqueda("usuarios", "nombre, contraseña, tipo_usuario, correo", "usuario='" + usuario.Text + "'");
                    nombre1= busquedauser.Tables[0].Rows[0][0].ToString();
                    contraseña1= busquedauser.Tables[0].Rows[0][1].ToString();
                    tipo1= busquedauser.Tables[0].Rows[0][2].ToString();
                    correo1= busquedauser.Tables[0].Rows[0][3].ToString();
                    contraseña1 = en.desencrip(contraseña1);
                    contraseñaconfirmacion1 = contraseña1;
                    nombre.Text = nombre1;
                    contraseña.Text = contraseña1;
                    tipo.SelectedItem = tipo1;
                    correo.Text = correo1;
                    contraseñaconfirmacion.Text = contraseñaconfirmacion1;
                    contraseña.Enabled = true;
                    tipo.Enabled = true;
                    correo.Enabled = true;
                    contraseñaconfirmacion.Enabled = true;
                    nombre.Enabled = true;
                    modificar.Visible = true;
                    modificar.Enabled = true;
                    buscar.Enabled = false;
                    usuario.Enabled=false;
                }
                catch {
                    MessageBox.Show("¡Usuario no encontrado!");
                }

            }
            else
                MessageBox.Show("Ingrese un usuario valido entre 5 y 10 caracteres!");
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            int validacion=validar();
            if (validacion != 0)
            {
                if (validarCampos() == true)
                {
                    if (contraseña.Text == contraseñaconfirmacion.Text & validarcorreo(correo.Text) == true)
                    {
                        encripDatos en = new encripDatos();
                        Boolean ver = m.modificar("usuarios", "nombre='" + nombre.Text + "', contraseña='" + en.encrip(contraseña.Text) + "', tipo_usuario='" + tipo.SelectedItem.ToString() + "', correo='" + correo.Text + "'", "usuario='" + usuario.Text + "'");
                        if (validacion == 1 && ver == true)
                        {
                            MessageBox.Show("Dato modificado con exito");
                            limpiarvalores();
                        }
                        else if (ver == true)
                        {
                            MessageBox.Show("Datos modificado con exito");
                            limpiarvalores();
                        }
                        else MessageBox.Show("Datos no modificados!, intente de nuevo o contacte a su proveedor de software.");

                    }

                    else if (contraseña.Text != contraseñaconfirmacion.Text)
                        MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            else
            { 
                MessageBox.Show("Ningun dato ha sido cambiado!");
                limpiarvalores();
            }
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

        private void contraseñaconfirmacion_KeyPress(object sender, KeyPressEventArgs e)
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

        public int validar()
        {
            int valor = 0;
            if (nombre.Text != nombre1)
                valor++;

            if (contraseña.Text != contraseña1)
                valor++;

            if (tipo.SelectedItem.ToString() != tipo1)
                valor++;
            if (correo.Text != correo1)
                valor++;
            return valor;
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
        public void limpiarvalores()
        {
            tipo.SelectedItem = "General";
            nombre.Text = "";
            usuario.Text = "";
            contraseña.Text = "";
            contraseñaconfirmacion.Text = "";
            correo.Text = "";
            contraseña.Enabled = false;
            tipo.Enabled = false;
            correo.Enabled = false;
            contraseñaconfirmacion.Enabled = false;
            nombre.Enabled = false;
            modificar.Visible = false;
            modificar.Enabled = false;
            buscar.Enabled = true;
            usuario.Enabled = true;
            usuario.Focus();
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

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void contraseñaconfirmacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void correo_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
