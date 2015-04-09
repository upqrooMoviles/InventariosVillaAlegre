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
    public partial class medicamentos : Form
    {
        public medicamentos()
        {
            InitializeComponent();
            user.Text = valores.Usuario;
            fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //hora.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();
            if (valores.Tipo_usuario == "AdminMedicamentos" || valores.Tipo_usuario == "General")
            {
                actualizar.Visible = true;
                agregarR.Visible = true;
                agregarM.Visible = true;
                eliminarR.Visible = true;
                eliminarM.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToLongTimeString(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void medicamentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal p = new principal();
            p.Show();
        }
    }
}
