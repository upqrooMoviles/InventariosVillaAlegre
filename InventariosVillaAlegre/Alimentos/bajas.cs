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
    public partial class bajas : Form
    {
        public bajas()
        {
            InitializeComponent();
            eliminarP.Enabled = false;
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
                catch {
                        if(i==0)
                        MessageBox.Show("¡No tiene productos dados de alta!");
                      }
        }
        metodosSQL m = new metodosSQL();
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex ==0)
            {
                eliminarP.Enabled = false;
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
                catch {
                        if (i == 0)
                        MessageBox.Show("¡No tiene productos dados de alta!");
                      }
                
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                eliminarR.Enabled = false;
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
                eliminarM.Enabled = false;
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
            tablaProducto.AutoGenerateColumns = false;
            tablaProducto.Columns.Clear();
            if(claveP.SelectedIndex>-1)
            try
            {
                eliminarP.Enabled = true;
                DataSet busquedauser = m.busqueda("alimentos", "producto, categoria,medida, existencia", "idalimentos='" + claveP.SelectedItem.ToString() + "'");
                string productoP = busquedauser.Tables[0].Rows[0][0].ToString();
                string categoriaP = busquedauser.Tables[0].Rows[0][1].ToString();
                string medidaP = busquedauser.Tables[0].Rows[0][2].ToString();
                string existenciaP = busquedauser.Tables[0].Rows[0][3].ToString();
                string clavePr = claveP.SelectedItem.ToString();
                
                tablaProducto.Columns.Add("clave", "CLAVE");
                tablaProducto.Columns.Add("categoria", "CATEGORIA");
                tablaProducto.Columns.Add("producto", "PRODUCTO");
                tablaProducto.Columns.Add("medida", "MEDIDA");
                tablaProducto.Columns.Add("existencia", "EXISTENCIA");
                tablaProducto.Rows.Insert(0, clavePr, categoriaP, productoP, medidaP, existenciaP);
                
            }
            catch (Exception ex){ eliminarP.Enabled = false;
            MessageBox.Show(ex.ToString());
            }
            else { eliminarP.Enabled = false;
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
                catch {
                        if (i == 0)
                        MessageBox.Show("¡No tiene productos dados de alta!");
                      }}
        }

        private void claveR_SelectedIndexChanged(object sender, EventArgs e)
        {
            ingredientesR.Text = "";
            nombreR.Text = "";
            tipoR.Text = "";
            if (claveR.SelectedIndex > -1)
                try
                {
                    eliminarP.Enabled = true;
                    DataSet busquedauser = m.busqueda("recetas", "nombre, tipo", "idrecetas='" + claveR.SelectedItem.ToString() + "'");
                    nombreR.Text = busquedauser.Tables[0].Rows[0][0].ToString();
                    tipoR.Text = busquedauser.Tables[0].Rows[0][1].ToString();
                    try
                    {
                        eliminarR.Enabled = true;
                        busquedauser = m.busqueda("ingredientes_recetas", "idalimentos, cantidad", "idrecetas='" + claveR.SelectedItem.ToString() + "'");
                        int i = 0;
                        while (true)
                        {
                            string alimentoR = busquedauser.Tables[0].Rows[i][0].ToString();
                            string cantidadR = busquedauser.Tables[0].Rows[i][1].ToString();
                            DataSet busquedauser2 = m.busqueda("alimentos", "medida", "idalimentos='" + alimentoR + "'");
                            string medidaR = busquedauser2.Tables[0].Rows[0][0].ToString();
                            i++;
                            ingredientesR.Text = ingredientesR.Text + i + ". " + alimentoR + ": " + cantidadR + " " + medidaR + "\n";
                        }
                    }
                    catch { }
                }
                catch { }
            else {
                eliminarR.Enabled = false;
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
                        MessageBox.Show("¡No tiene recetas dados de alta!");
                }
            }
        }

        private void claveM_SelectedIndexChanged(object sender, EventArgs e)
        {
            tablaMenu.AutoGenerateColumns = false;
            tablaMenu.Columns.Clear();
            if (claveM.SelectedIndex > -1)
                try
                {
                    DataSet busquedauser2=m.busqueda("menus", "nombre", "idmenus='" + claveM.SelectedItem.ToString() + "'");
                    nombreM.Text = busquedauser2.Tables[0].Rows[0][0].ToString();
                    eliminarM.Enabled = true;
                    DataSet busquedauser = m.busqueda("recetas_menus", "dia, tipo, idrecetas", "idmenus='" + claveM.SelectedItem.ToString() + "'");
                    //string producto = busquedauser.Tables[0].Rows[0][0].ToString();
                    tablaMenu.Columns.Add("dia", "DIA");
                    tablaMenu.Columns.Add("desayuno", "DESAYUNO");
                    tablaMenu.Columns.Add("comida", "COMIDA");
                    tablaMenu.Columns.Add("cena", "CENA");
                
                    int i = 0;

                    while (true)
                    {
                        string diaM = busquedauser.Tables[0].Rows[i][0].ToString();
                        string desayunoM = busquedauser.Tables[0].Rows[i][2].ToString();
                        string comidaM = busquedauser.Tables[0].Rows[i + 1][2].ToString();
                        string cenaM = busquedauser.Tables[0].Rows[i + 2][2].ToString();
                        tablaMenu.Rows.Add(diaM, desayunoM, comidaM, cenaM);
                        i = i + 3;
                    }
                }
                catch
                {
                    eliminarM.Enabled = true;
                }
            else {
                eliminarM.Enabled = false;
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
        private void eliminarP_Click(object sender, EventArgs e)
        {
            int i=0;
            string valores = "";
            try
            {
                
                DataSet busqueda = m.busqueda("ingredientes_recetas", "idrecetas", "idalimentos='" + claveP.SelectedItem.ToString() + "'");
                while(true)
                {
                    valores+=busqueda.Tables[0].Rows[i][0].ToString()+"\n";
                    i++;
                }
            }
            catch
            {
                if (i != 0)
                {
                    string lareceta = "la receta ";
                    if (i != 1)
                        lareceta = "las siguientes recetas:\n";
                    MessageBox.Show("El producto "+claveP.SelectedItem.ToString()+" no se puede eliminar ya que esta asociado a "+lareceta +valores+"\nModifique o elimine dichas recetas en caso de querer eliminar este producto. ");
 
                }
                else if (m.eliminar("alimentos", "idalimentos='" + claveP.SelectedItem.ToString() + "'") == true)
                {
                    claveP.SelectedIndex = -1;
                    claveP.Focus();
                    tablaProducto.AutoGenerateColumns = false;
                    tablaProducto.Columns.Clear();
                    MessageBox.Show("¡Producto eliminado!");
                }
                else
                    MessageBox.Show("Registro no eliminado. Intente de nuevo o contacte a su proovedor de software.");
            }
        }

        private void eliminarR_Click(object sender, EventArgs e)
        {
            int i=0;
            string valores = "";
            try
            {

                DataSet busqueda = m.busqueda("recetas_menus", "idmenus", "idrecetas='" + claveR.SelectedItem.ToString() + "'");
                string anterior = "", nuevo="";
                while (true)
                {
                    nuevo = busqueda.Tables[0].Rows[i][0].ToString();
                    if(anterior!=nuevo)
                    valores += nuevo + "\n";
                    anterior = busqueda.Tables[0].Rows[i][0].ToString();
                    i++;

                }
            }
            catch
            {
                if (i != 0)
                {
                    string elmenu = "el menu ";
                    if (i != 1)
                        elmenu = "llos siguientes menus:\n";
                    MessageBox.Show("La receta " + claveR.SelectedItem.ToString() + " no se puede eliminar ya que esta asociada a " + elmenu + valores + "\nModifique o elimine dichos menus en caso de querer eliminar esta receta. ");

                }

                else if (m.eliminar("recetas", "idrecetas='" + claveR.SelectedItem.ToString() + "'") == true && m.eliminar("ingredientes_recetas", "idrecetas='" + claveR.SelectedItem.ToString() + "'") == true)
                {
                    claveR.SelectedIndex = -1;
                    claveR.Focus();
                    ingredientesR.Text = "";
                    nombreR.Text = "";
                    tipoR.Text = "";
                    MessageBox.Show("¡Receta eliminado!");
                }
                else
                    MessageBox.Show("Registro no eliminado. Intente de nuevo o contacte a su proovedor de software.");
            }
        }

        private void eliminarM_Click(object sender, EventArgs e)
        {
            if (m.eliminar("menus", "idmenus='" + claveM.SelectedItem.ToString() + "'") == true && m.eliminar("recetas_menus", "idmenus='" + claveM.SelectedItem.ToString() + "'") == true)
            {
                m.modificar("historial_menu","observaciones='INEXISTENTE'","idmenus='"+claveM.SelectedItem.ToString()+"'");
                claveM.SelectedIndex = -1;
                claveM.Focus();
                nombreM.Text = "";
                MessageBox.Show("¡Menu eliminado!");
            }
            else
                MessageBox.Show("Registro no eliminado. Intente de nuevo o contacte a su proovedor de software.");

        }


    }
}
