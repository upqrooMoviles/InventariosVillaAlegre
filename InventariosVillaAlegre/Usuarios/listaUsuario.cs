using InventariosVillaAlegre.Clases_auxiliares;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosVillaAlegre
{
    public partial class listaUsuario : Form
    {
        public listaUsuario()
        {
            InitializeComponent();
            System.IO.Directory.CreateDirectory("C:\\Reportes\\ListasUsuarios");
        }
        string[] encabezados = { "NOMBRE","USUARIO","TIPO DE USUARIO","CORREO"};
        private void listaUsuario_Load(object sender, EventArgs e)
        {
            metodosSQL m = new metodosSQL();
            DataSet resultados=m.busqueda("usuarios", "nombre, usuario, tipo_usuario, correo", null);
                usuarios.DataSource = resultados.Tables[0];
                usuarios.Columns[0].HeaderText = encabezados[0];
                usuarios.Columns[1].HeaderText = encabezados[1];
                usuarios.Columns[2].HeaderText = encabezados[2];
                usuarios.Columns[3].HeaderText = encabezados[3];
        }

        private void archivo_Click(object sender, EventArgs e)
        {
            pdf(true);
        }
        private void enviar_Click(object sender, EventArgs e)
        {
            if (pdf(false) == true)
            {
                valores.Asunto = "Repote lista usuarios";
                valores.Mensaje = "Archivo ajdunto de reporte de usuarios.\n";
                reportesCorreo frm = new reportesCorreo();
                frm.Show();
            }
        }

        public Boolean pdf(Boolean abrir)
        {
            DateTime hora = DateTime.Now;
            string fcha_ttal = Convert.ToDateTime(hora).Day + "/" + Convert.ToDateTime(hora).Month + "/" + Convert.ToDateTime(hora).Year;
            Document doc = new Document(PageSize.A4, 9, 9, 10, 10);
            string ruta = @"C:\\Reportes\\ListasUsuarios\\";
            string nombrearchivo = "Repote lista usuarios ";
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            return generarPDF.TablaPDF(usuarios, nombrearchivo, ruta, "LISTA DE USUARIOS", encabezados, abrir);

        }

        }
    }

