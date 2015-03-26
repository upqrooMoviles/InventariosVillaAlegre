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
    public partial class agregarUsuario : Form
    {
        public agregarUsuario()
        {
            InitializeComponent();
        }

        private void agregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Imágenes |*.jpg; *.png; *.gif";
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Buscar Imagen";
            BuscarImagen.InitialDirectory = "C:\\"; BuscarImagen.FileName = this.rutafoto.Text;
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                this.rutafoto.Text = BuscarImagen.FileName;
                String Direccion = BuscarImagen.FileName;
                this.imagenproducto.ImageLocation = Direccion;
                imagenproducto.SizeMode = PictureBoxSizeMode.StretchImage;
            } 
        }
    }
}
