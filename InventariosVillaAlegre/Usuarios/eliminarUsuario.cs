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
    public partial class eliminarUsuario : Form
    {
        public eliminarUsuario()
        {
            InitializeComponent();
        }
        private void eliminarUsuario_Load(object sender, EventArgs e)
        {
            usuario.Focus();
        }
        metodosSQL m = new metodosSQL();

        private void usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.letrasNumerosSinEspacios(e);
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (usuario.Text != valores.Usuario)
            {
                if (usuario.Text.Length >= 5)
                {
                    try
                    {
                        encripDatos en = new encripDatos();
                        DataSet busquedauser = m.busqueda("usuarios", "nombre, tipo_usuario, correo", "usuario='" + usuario.Text + "'");
                        nombre.Text = busquedauser.Tables[0].Rows[0][0].ToString();
                        tipo.SelectedItem = busquedauser.Tables[0].Rows[0][1].ToString();
                        correo.Text = busquedauser.Tables[0].Rows[0][2].ToString();
                        eliminar.Visible = true;
                        buscar.Enabled = false;
                        usuario.Enabled = false;
                    }
                    catch
                    {
                        MessageBox.Show("¡Usuario no encontrado!");
                    }

                }
                else
                    MessageBox.Show("¡Ingrese un usuario valido entre 5 y 10 caracteres!");
            }
            else
                MessageBox.Show("¡No es posible la eliminacion de una cuenta en uso! Debe ser desde una cuenta General distinta.");
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            Boolean validar=m.eliminar("usuarios", "usuario='"+usuario.Text+"'");
            if (validar == true)
            {
                MessageBox.Show("¡Usuario eliminado!");
                eliminar.Visible = false;
                buscar.Enabled = true;
                usuario.Enabled = true;
                limpiarCampos();
            }
            else
                MessageBox.Show("¡Usuario no eliminado!.\n Intente nuevamente o contacte a su proveedor de software.");
        }

        public void limpiarCampos()
        {
            tipo.SelectedItem = "General";
            nombre.Text = "";
            usuario.Text = "";
            correo.Text = "";
            tipo.SelectedIndex = -1;
            usuario.Focus();
        }

    }
}
