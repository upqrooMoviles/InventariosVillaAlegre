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
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
            user.Text = valores.Usuario;
            fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //hora.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            agregarUsuario au = new agregarUsuario();
            au.FormBorderStyle = FormBorderStyle.None;
            au.TopLevel = false;
            au.Parent = contenedor;
            au.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            modificarUsuario mu = new modificarUsuario();
            mu.FormBorderStyle = FormBorderStyle.None;
            mu.TopLevel = false;
            mu.Parent = contenedor;
            mu.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            eliminarUsuario eu = new eliminarUsuario();
            eu.FormBorderStyle = FormBorderStyle.None;
            eu.TopLevel = false;
            eu.Parent = contenedor;
            eu.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            listaUsuario lu = new listaUsuario();
            lu.FormBorderStyle = FormBorderStyle.None;
            lu.TopLevel = false;
            lu.Parent = contenedor;
            lu.Show();

        }

        private void usuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal p = new principal();
            p.Show();
        }
    }
}
