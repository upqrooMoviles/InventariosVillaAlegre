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
    public partial class alimentos : Form
    {
        public alimentos()
        {
            InitializeComponent();
            
        }

        private void alimentos_Load(object sender, EventArgs e)
        {
            user.Text = valores.Usuario;
            fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //hora.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();
            if (valores.Tipo_usuario == "AdminAlimentos"||valores.Tipo_usuario == "General")
            {
                altas.Visible = true;
                bajas.Visible = true;
                modificaciones.Visible = true;
            }

            //tabControl1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToLongTimeString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count!=0)
                this.contenedor.Controls.RemoveAt(0);
            menus m = new menus();
            m.FormBorderStyle = FormBorderStyle.None;
            m.TopLevel = false;
            m.Parent = contenedor;
            m.Show();
        }

        private void inventario_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            inventarioalimentos i = new inventarioalimentos();
            i.FormBorderStyle = FormBorderStyle.None;
            i.TopLevel = false;
            i.Parent = contenedor;
            i.Show();

        }

        private void altas_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            altas a = new altas();
            a.FormBorderStyle = FormBorderStyle.None;
            a.TopLevel = false;
            a.Parent = contenedor;
            a.Show();

        }

        private void bajas_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            bajas b = new bajas();
            b.FormBorderStyle = FormBorderStyle.None;
            b.TopLevel = false;
            b.Parent = contenedor;
            b.Show();

        }

        private void modificaciones_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            modificaciones m = new modificaciones();
            m.FormBorderStyle = FormBorderStyle.None;
            m.TopLevel = false;
            m.Parent = contenedor;
            m.Show();

        }

        private void reportes_Click(object sender, EventArgs e)
        {
            
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            
             reportes r = new reportes();
             r.FormBorderStyle = FormBorderStyle.None;
             r.TopLevel = false;
             r.Parent = contenedor;
             r.Show();
        }

        private void alimentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal p = new principal();
            p.Show();
        }
    }
}
