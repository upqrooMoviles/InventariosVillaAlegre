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
    public partial class modificaciones : Form
    {
        public modificaciones()
        {
            InitializeComponent();
        }
        private void modificaciones_Load(object sender, EventArgs e)
        {
            DataSet resultado = m.busqueda("alimentos", "idalimentos", null);
            int i = 0;
            try
            {

                while (true)
                {
                    claveP.Items.Add(resultado.Tables[0].Rows[i][0].ToString());
                    i++;
                }
            }
            catch
            {
                if (i == 0)
                    MessageBox.Show("¡No tiene productos dados de alta!");
            }

        }
        metodosSQL m = new metodosSQL();
        private void nombreP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.sinNumeros(e);
        }

        private void existenciaP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.numerosDecimales(e);
        }

        private void nombreR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.sinNumeros(e);
        }

        private void nombreM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.sinNumeros(e);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                nombreP.Text = "";
                nombreP.Enabled = false;
                existenciaP.Text = "";
                existenciaP.Enabled = false;
                categoriaP.SelectedIndex = -1;
                categoriaP.Enabled = false;
                medidaP.SelectedIndex = -1;
                medidaP.Enabled = false;
                modificarP.Enabled = false;

                claveP.Focus();
                claveP.Items.Clear();
                DataSet resultado = m.busqueda("alimentos", "idalimentos", null);
                int i = 0;
                try
                {
                    while (true)
                    {
                        claveP.Items.Add(resultado.Tables[0].Rows[i][0].ToString());
                        i++;
                    }
                }
                catch
                {
                    if (i == 0)
                        MessageBox.Show("¡No tiene productos dados de alta!");
                }

            }
            else if (tabControl1.SelectedIndex == 1)
            {
                nombreR.Text = "";
                nombreR.Enabled = false;
                tipoR.SelectedIndex = -1;
                tipoR.Enabled = false;
                tablaIngredientes.AutoGenerateColumns = false;
                tablaIngredientes.Columns.Clear();
                modificarR.Enabled = false;

                claveR.Focus();
                claveR.Items.Clear();
                DataSet resultado = m.busqueda("recetas", "idrecetas", null);
                int i = 0;
                try
                {
                    while (true)
                    {
                        claveR.Items.Add(resultado.Tables[0].Rows[i][0].ToString());
                        i++;
                    }
                }
                catch
                {
                    if (i == 0)
                        MessageBox.Show("¡No tiene recetass dados de alta!");
                }
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                tablaMenu.AutoGenerateColumns = false;
                tablaMenu.Columns.Clear();
                nombreM.Text = "";
                nombreM.Enabled = false;
                modificarM.Enabled = false;

                claveM.Focus();
                claveM.Items.Clear();
                DataSet resultado = m.busqueda("menus", "idmenus", null);
                int i = 0;
                try
                {
                    while (true)
                    {
                        claveM.Items.Add(resultado.Tables[0].Rows[i][0].ToString());
                        i++;
                    }
                }
                catch
                {
                    if (i == 0)
                        MessageBox.Show("¡No tiene menus dados de alta!");
                }
            }

        }

        private void claveP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (claveP.SelectedIndex > -1)
                try
                {
                    modificarP.Enabled = true;
                    DataSet busquedauser = m.busqueda("alimentos", "*", "idalimentos='" + claveP.SelectedItem.ToString() + "'");
                    string clavePr = busquedauser.Tables[0].Rows[0][0].ToString();
                    nombreP.Text = busquedauser.Tables[0].Rows[0][1].ToString();
                    categoriaP.SelectedItem = busquedauser.Tables[0].Rows[0][2].ToString();
                    medidaP.SelectedItem = busquedauser.Tables[0].Rows[0][3].ToString();
                    existenciaP.Text = busquedauser.Tables[0].Rows[0][4].ToString();
                    nombreP.Enabled = true;
                    existenciaP.Enabled = true;
                    categoriaP.Enabled = true;
                    medidaP.Enabled = true;
                    //valoresalimento();
                    
                }
                catch (Exception ex)
                {
                    modificarP.Enabled = false;
                    MessageBox.Show(ex.ToString());
                }
            else
            {
                nombreP.Text = "";
                nombreP.Enabled = false;
                existenciaP.Text = "";
                existenciaP.Enabled = false;
                categoriaP.SelectedIndex = -1;
                categoriaP.Enabled = false;
                medidaP.SelectedIndex = -1;
                medidaP.Enabled = false;
                modificarP.Enabled = false;


                claveP.Focus();
                claveP.Items.Clear();
                DataSet resultado = m.busqueda("alimentos", "idalimentos", null);
                int i = 0;
                try
                {
                    while (true)
                    {
                        claveP.Items.Add(resultado.Tables[0].Rows[i][0].ToString());
                        i++;
                    }
                }
                catch
                {
                    if (i == 0)
                        MessageBox.Show("¡No tiene productos dados de alta!");
                }
            }
        }

        private void claveR_SelectedIndexChanged(object sender, EventArgs e)
        {
            tablaIngredientes.AutoGenerateColumns = false;
            tablaIngredientes.Columns.Clear();
            DataTable dt = new DataTable();
            if (claveR.SelectedIndex > -1)
            {
                try
                {
                    DataSet busquedauser2 = m.busqueda("recetas", "nombre, tipo", "idrecetas='" + claveR.SelectedItem.ToString() + "'");
                    nombreR.Text = busquedauser2.Tables[0].Rows[0][0].ToString();
                    tipoR.SelectedItem = busquedauser2.Tables[0].Rows[0][1].ToString();
                    modificarR.Enabled = true;
                    DataSet busquedauser = m.busqueda("ingredientes_recetas", "*", "idrecetas='" + claveR.SelectedItem.ToString() + "'");
                    dt.Columns.Add("clave", typeof(String));
                    dt.Columns.Add("cantidad", typeof(String));
                    dt.Columns.Add("medida", typeof(String));
                    int i = 0;
                
                    while (true)
                    {
                        string claveAl = busquedauser.Tables[0].Rows[i][2].ToString();
                        string cantidadRes = busquedauser.Tables[0].Rows[i][3].ToString();
                        string medidaRes = m.busqueda("alimentos", "medida", "idalimentos='"+claveAl+"'").Tables[0].Rows[0][0].ToString();
                        dt.Rows.Add(claveAl, cantidadRes, medidaRes);
                        i++;
                    }
                }
            catch{
                    modificarR.Enabled = true;
                 }
                    DataGridViewComboBoxColumn clav = new DataGridViewComboBoxColumn();
                    DataSet resultado = m.busqueda("alimentos", "idalimentos", null);
                    int j = 0;
                    try
                    {
                        while (true)
                        {
                            clav.Items.Add(resultado.Tables[0].Rows[j][0].ToString());
                            j++;
                        }
                    }
                    catch { }
                    clav.HeaderText = "CLAVE ALIMENTO";
                    clav.DataPropertyName = "clave";

                    DataGridViewTextBoxColumn can = new DataGridViewTextBoxColumn();
                    can.HeaderText = "CANTIDAD";
                    can.DataPropertyName = "cantidad";

                    DataGridViewTextBoxColumn med = new DataGridViewTextBoxColumn();
                    med.HeaderText = "MEDIDA";
                    med.DataPropertyName = "medida";
                    
                    
                    tablaIngredientes.DataSource = dt;
                    tablaIngredientes.Columns.AddRange(clav,can, med );
                    tablaIngredientes.Columns[2].ReadOnly = true;

                    nombreR.Enabled = true;
                    tipoR.Enabled = true;
                    tablaIngredientes.Enabled = true;
            }
            else
            {
                nombreR.Text = "";
                nombreR.Enabled = false;
                tipoR.SelectedIndex = -1;
                tipoR.Enabled = false;
                tablaIngredientes.AutoGenerateColumns = false;
                tablaIngredientes.Columns.Clear();
                modificarR.Enabled = false;

                claveR.Focus();
                claveR.Items.Clear();
                DataSet resultado = m.busqueda("recetas", "idrecetas", null);
                int i = 0;
                try
                {
                    while (true)
                    {
                        claveR.Items.Add(resultado.Tables[0].Rows[i][0].ToString());
                        i++;
                    }
                }
                catch
                {
                    if (i == 0)
                        MessageBox.Show("¡No tiene recetass dados de alta!");
                }
            }
        }

        private void claveM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void modificarP_Click(object sender, EventArgs e)
        {

        }

        private void modificarR_Click(object sender, EventArgs e)
        {

        }

        private void modificarM_Click(object sender, EventArgs e)
        {

        }




        

    }
}
