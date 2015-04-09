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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void alimentos_Click(object sender, EventArgs e)
        {
            valores.Opcion = "alimentos";
            login ss = new login();
            ss.Show();
            this.Hide();
        }

        private void medicamentos_Click(object sender, EventArgs e)
        {
            valores.Opcion = "medicamentos";
            login ss = new login();
            ss.Show();
            this.Hide();
        }

        private void usuarios_Click(object sender, EventArgs e)
        {
            valores.Opcion = "usuarios";
            login ss = new login();
            ss.Show();
            this.Hide();
        }
    }
}
