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
            user.Text = "Usuario 1";
            fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //hora.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();

            //tabControl1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToLongTimeString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            //tabControl1.Visible = true;
            
            //if (this.contenido.Controls.Count > 0)
            //this.contenido.Controls.RemoveAt(0);
            //inventarioalimentos form = Application.OpenForms.OfType<inventarioalimentos>().FirstOrDefault();
            //inventarioalimentos hijo1 = form ?? new inventarioalimentos();
            //hijo1.FormBorderStyle = FormBorderStyle.None;
            //hijo1.Dock = DockStyle.Fill
            //this.contenido.Controls.Add(hijo1);
            //this.contenido.Tag = hijo1;
            //hijo1.Show();
        }
    }
}
