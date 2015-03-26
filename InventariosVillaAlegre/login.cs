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
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            if (valores.Opcion == "alimentos")
            {
                alimentos ss = new alimentos();
                ss.Show();
                this.Hide();
            }

            if (valores.Opcion == "medicamentos")
            {
                medicamentos ss = new medicamentos();
                ss.Show();
                this.Hide();
            }

            if (valores.Opcion == "usuarios")
            {
                agregarUsuario ss = new agregarUsuario();
                ss.Show();
                this.Hide();
            }
        }
    }
}
