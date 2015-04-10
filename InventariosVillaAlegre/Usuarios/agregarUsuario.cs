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
    public partial class agregarUsuario : Form
    {
        public agregarUsuario()
        {
            InitializeComponent();
        }

        private void agregarUsuario_Load(object sender, EventArgs e)
        {
            tipo.SelectedIndex = 0;
            nombre.Focus();
        }
        metodosSQL m = new metodosSQL();
        private void usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.letrasNumerosSinEspacios(e);
        }

        private void contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.sinEspacios(e); 
        }

        private void contraseñaconfirmacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.sinEspacios(e); 
        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.sinNumeros(e); 
        }

        private void correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.sinEspacios(e); 
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == true&&existenciaUsuario()==true)
            {
                if (checarCaracteres.validarcorreo(correo.Text) == true)
                {
                    if (contraseña.Text.ToString().Equals(contraseñaconfirmacion.Text.ToString()))
                    {
                            encripDatos en = new encripDatos();                    
                            string valoresCampos = "'" + nombre.Text + "', '" + usuario.Text + "', '" + en.encrip(contraseña.Text) + "','"+tipo.SelectedItem.ToString()+"','" + correo.Text + "'";
                            if (m.insertar("usuarios", "nombre, usuario, contraseña, tipo_usuario, correo", valoresCampos) == true)
                            {
                                MessageBox.Show("¡Registro insertado con exito!");
                                limpiarCampos();
                            }
                            else
                                MessageBox.Show("¡Registro no insertado! Intente de nuevo o contacte al proovedor de software.");
                    }
                    else
                    {
                        MessageBox.Show("¡Las contraseñas no coinciden!");
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
        public Boolean existenciaUsuario() {
            try
            {
                DataSet busquedauser = m.busqueda("usuarios", "idusuarios", "usuario='" + usuario.Text + "'");
                string verif = busquedauser.Tables[0].Rows[0][0].ToString();
                MessageBox.Show("¡El usuario indicado ya existe!");
                return false;
            }
            catch
            {
                return true;
            }
        }
        public void limpiarCampos() {
            tipo.SelectedItem = "General";
            nombre.Text = "";
            usuario.Text = "";
            contraseña.Text = "";
            contraseñaconfirmacion.Text = "";
            correo.Text = "";
            
        }
    }
}
