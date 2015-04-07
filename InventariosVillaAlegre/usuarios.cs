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
            user.Text = "Usuario 1";
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
    }
}
