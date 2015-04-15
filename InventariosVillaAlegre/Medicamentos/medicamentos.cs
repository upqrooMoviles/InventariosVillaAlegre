using InventariosVillaAlegre.Medicamentos;
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
                actualizarM.Visible = true;
                modificarR.Visible = true;
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

        private void fichaR_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            FichaR i =new FichaR();
            i.FormBorderStyle = FormBorderStyle.None;
            i.TopLevel = false;
            i.Parent = contenedor;
            i.Show();

        }

        private void medicamentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal p = new principal();
            p.Show();
        }


        private void fichaR_Click_1(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            FichaR m = new FichaR();
            m.FormBorderStyle = FormBorderStyle.None;
            m.TopLevel = false;
            m.Parent = contenedor;
            m.Show();
        }

        private void buscarM_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            BuscarM m = new BuscarM();
            m.FormBorderStyle = FormBorderStyle.None;
            m.TopLevel = false;
            m.Parent = contenedor;
            m.Show();
        }

        private void listaR_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            ListaR m = new ListaR();
            m.FormBorderStyle = FormBorderStyle.None;
            m.TopLevel = false;
            m.Parent = contenedor;
            m.Show();
        }

        private void listaM_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            ListaM m = new ListaM();
            m.FormBorderStyle = FormBorderStyle.None;
            m.TopLevel = false;
            m.Parent = contenedor;
            m.Show();
        }

        private void actualizarM_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            ModificarM m = new ModificarM();
            m.FormBorderStyle = FormBorderStyle.None;
            m.TopLevel = false;
            m.Parent = contenedor;
            m.Show();
        }

        private void modificarR_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            ModificarR m = new ModificarR();
            m.FormBorderStyle = FormBorderStyle.None;
            m.TopLevel = false;
            m.Parent = contenedor;
            m.Show();
        }

        private void agregarR_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            AgregarR m = new AgregarR();
            m.FormBorderStyle = FormBorderStyle.None;
            m.TopLevel = false;
            m.Parent = contenedor;
            m.Show();
        }

        private void agregarM_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            AgregarM m = new AgregarM();
            m.FormBorderStyle = FormBorderStyle.None;
            m.TopLevel = false;
            m.Parent = contenedor;
            m.Show();
        }

        private void eliminarR_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            EliminarR m = new EliminarR();
            m.FormBorderStyle = FormBorderStyle.None;
            m.TopLevel = false;
            m.Parent = contenedor;
            m.Show();
        }

        private void eliminarM_Click(object sender, EventArgs e)
        {
            if (this.contenedor.Controls.Count != 0)
                this.contenedor.Controls.RemoveAt(0);
            EliminarM m = new EliminarM();
            m.FormBorderStyle = FormBorderStyle.None;
            m.TopLevel = false;
            m.Parent = contenedor;
            m.Show();
        }
    }
}
