using InventariosVillaAlegre.Clases_auxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
                limpiarCamposP();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                limpiarCamposR();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                limpiarCamposM();
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
                    variablesAlimentos.NombreP = nombreP.Text;
                    variablesAlimentos.CategoriaP = categoriaP.Text;
                    variablesAlimentos.MedidaP = medidaP.Text;
                    variablesAlimentos.ExisteciaP = existenciaP.Text;
                    
                }
                catch (Exception ex)
                {
                    modificarP.Enabled = false;
                    MessageBox.Show(ex.ToString());
                }
            else
            {
                limpiarCamposP();
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
                    DataSet busquedauser2 = m.busqueda("recetas", "nombre, tipo, ingredientes", "idrecetas='" + claveR.SelectedItem.ToString() + "'");
                    nombreR.Text = busquedauser2.Tables[0].Rows[0][0].ToString();
                    tipoR.SelectedItem = busquedauser2.Tables[0].Rows[0][1].ToString();
                    variablesAlimentos.IngredientesR = Convert.ToInt32(busquedauser2.Tables[0].Rows[0][2].ToString());
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
                    variablesAlimentos.NombreR = nombreR.Text;
                    variablesAlimentos.TipoR = tipoR.Text;
                    variablesAlimentos.TablaR = dt;
            }
            else
            {
                limpiarCamposR();
            }
        }

        private void claveM_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            nombreM.Enabled = true;
            modificarM.Enabled = true;
            tablaMenu.Enabled = true;
            tablaMenu.AutoGenerateColumns = false;
            tablaMenu.Columns.Clear();
            if (claveM.SelectedIndex > -1)
            {
                
                DataTable dt = new DataTable();
                dt.Columns.Add("dia", typeof(String));
                dt.Columns.Add("desayuno", typeof(String));
                dt.Columns.Add("comida", typeof(String));
                dt.Columns.Add("cena", typeof(String));
                try
                {
                    DataSet busquedauser2 = m.busqueda("menus", "nombre", "idmenus='" + claveM.SelectedItem.ToString() + "'");
                    nombreM.Text = busquedauser2.Tables[0].Rows[0][0].ToString();
                    DataSet busquedauser = m.busqueda("recetas_menus", "dia, tipo, idrecetas", "idmenus='" + claveM.SelectedItem.ToString() + "'");

                    int i = 0;
                    while (true)
                    {
                        string diaM = busquedauser.Tables[0].Rows[i][0].ToString();
                        string desayunoM = busquedauser.Tables[0].Rows[i][2].ToString();
                        string comidaM = busquedauser.Tables[0].Rows[i + 1][2].ToString();
                        string cenaM = busquedauser.Tables[0].Rows[i + 2][2].ToString();
                        dt.Rows.Add(diaM, desayunoM, comidaM, cenaM);
                        i = i + 3;
                    }
                }
                catch{ }
                
                DataGridViewComboBoxColumn des = new DataGridViewComboBoxColumn();
                DataSet resultado = m.busqueda("recetas", "idrecetas", "tipo='DESAYUNO' or tipo='GENERAL'");
                int j = 0;
                try
                {
                    while (true)
                    {
                        des.Items.Add(resultado.Tables[0].Rows[j][0].ToString());
                        j++;
                    }
                }
                catch { }
                des.HeaderText = "DESAYUNO";
                des.DataPropertyName = "desayuno";

                DataGridViewComboBoxColumn com = new DataGridViewComboBoxColumn();
                resultado = m.busqueda("recetas", "idrecetas", "tipo='COMIDA' or tipo='GENERAL'");
                j = 0;
                try
                {
                    while (true)
                    {
                        com.Items.Add(resultado.Tables[0].Rows[j][0].ToString());
                        j++;
                    }
                }
                catch { }
                com.HeaderText = "COMIDA";
                com.DataPropertyName = "comida";

                DataGridViewComboBoxColumn cen = new DataGridViewComboBoxColumn();
                resultado = m.busqueda("recetas", "idrecetas", "tipo='CENA' or tipo='GENERAL'");
                j = 0;
                try
                {
                    while (true)
                    {
                        cen.Items.Add(resultado.Tables[0].Rows[j][0].ToString());
                        j++;
                    }
                }
                catch { }
                cen.HeaderText = "CENA";
                cen.DataPropertyName = "cena";
                


                DataGridViewTextBoxColumn dia = new DataGridViewTextBoxColumn();
                dia.HeaderText = "Dia";
                dia.DataPropertyName = "dia";
                tablaMenu.DataSource = dt;
                tablaMenu.Columns.AddRange(dia, des, com, cen);
                tablaMenu.Columns[0].ReadOnly = true;
                variablesAlimentos.TablaM = dt;
                variablesAlimentos.NombreM = nombreM.Text;
            }
            else
            {
                limpiarCamposM();
            }

            
        }

        private void modificarP_Click(object sender, EventArgs e)
        {
            if (validarCamposProductos()== true & validarNumero(existenciaP.Text) == true)
            {
                if (diferenciasProducto() == true)
                {
                    string actualizar = "producto='"+nombreP.Text+"', categoria='"+categoriaP.Text+"', medida='"+medidaP.Text+"', existencia="+existenciaP.Text;
                    string clausula = "idalimentos='"+claveP.SelectedItem.ToString()+"'";
                    m.modificar("alimentos", actualizar, clausula);
                        limpiarCamposP();
                    
                }
                else
                    MessageBox.Show("¡No actualizado!. Ningun campo ha sido modificado.");
            }
        }

        private void modificarR_Click(object sender, EventArgs e)
        {
            //int borrarultima = tablaIngredientes.RowCount - 1;
            //tablaIngredientes.Rows.RemoveAt(borrarultima); 
            tablaIngredientes.AllowUserToAddRows = false;
            if (validarCamposRecetas()==true)
            {
                if (diferenciasReceta() == true)
                {
                    string actualizar = "nombre='" + nombreR.Text + "', tipo='" + tipoR.SelectedItem.ToString() + "', ingredientes=" + tablaIngredientes.RowCount;
                    string clausula = "idrecetas='" + claveR.SelectedItem.ToString() + "'";
                    m.modificar("recetas", actualizar, clausula);
                    m.eliminar("ingredeintes_recetas", "idrecetas='"+claveR.SelectedItem.ToString()+"'");
                    for (int i = 0; i < tablaIngredientes.RowCount; i++)
                    {
                         string ingredientes = tablaIngredientes.Rows[i].Cells[0].Value.ToString();
                         string cantidad=tablaIngredientes.Rows[i].Cells[2].Value.ToString();
                         string valores = "'"+claveR.SelectedItem.ToString()+"'"+ingredientes+"', "+cantidad;
                         m.insertar("ingredeintes_recetas", "idrecetas, idalimentos, cantidad", valores);
                    }
                        limpiarCamposR();
                        tablaIngredientes.AllowUserToAddRows = true;
                }
                else
                    MessageBox.Show("¡No actualizado!. Ningun campo ha sido modificado.");
            }

        }

        private void modificarM_Click(object sender, EventArgs e)
        {
            if (nombreR.Text.Trim().Length < 4)
            {
                if (diferenciasReceta() == true)
                {
                    string actualizar = "nombre='" + nombreM.Text + "'";
                    string clausula = "idmenus='" + claveM.SelectedItem.ToString() + "'";
                    m.modificar("menus", actualizar, clausula);
                    m.eliminar("recetas_menus", "idrmenus='" + claveM.SelectedItem.ToString() + "'");
                    string menu = claveM.Text;
                    for (int i = 0; i < 7; i++)
                    {
                        string dia = "", tipo = "", receta = "";
                        dia = tablaMenu.Rows[i].Cells[0].Value.ToString();
                        for (int j = 1; j < 4; j++)
                        {
                            tipo = tablaMenu.Columns[j].HeaderText;
                            receta = tablaMenu.Rows[i].Cells[j].Value.ToString();
                            string valoresCampos = "'" + dia + "', '" + tipo + "','" + receta + "','" + menu + "'";
                            m.insertar("recetas_menus", "dia, tipo, idrecetas, idmenus", valoresCampos);
                        }
                    }
                    limpiarCamposM();
                }
                else
                    MessageBox.Show("¡No actualizado!. Ningun campo ha sido modificado.");
            }
            else
                MessageBox.Show("El nombre de la receta debe ser entre 4 y 45 caracteres.");

        }

        public Boolean validarNumero(string numero)
        {
            try
            {
                float.Parse(numero, CultureInfo.InvariantCulture.NumberFormat);
                return true;
            }
            catch
            {
                MessageBox.Show("¡Cantidad no valida!. Verifique sus cantidades.");
                return false;
            }

        }

        public Boolean validarCamposProductos()
        {
            int validar = 0;
            string campos = "";
            if (nombreP.Text.Trim().Length < 3)
            {
                campos += "Nombre del producto entre 3 y 45 digitos\n";
                validar++;
                nombreP.Focus();
            }
            if (existenciaP.Text.Trim().Length <= 0)
            {
                campos += "Cantidad en existencia del producto";
                validar++;
                existenciaP.Focus();
            }
            if (validar == 0)
                return true;
            else
            {
                if (validar == 1)
                    MessageBox.Show("Falta completar el campo " + campos);
                else
                    MessageBox.Show("Falta completar los siguientes campos:\n" + campos);
                return false;
            }
        }
        public Boolean validarCamposRecetas()
        {
            int validar = 0;
            string campos = "";
            if (nombreR.Text.Trim().Length < 4)
            {
                campos += "Nombre de la receta entre r y 45 digitos\n";
                validar++;
                nombreR.Focus();
            }
            if (tablaIngredientes.Rows.Count == 0)
            {
                campos += "Tiene que ingresar al menos un ingrediente en la tabla\n";
                validar++;
                tablaIngredientes.Focus();
            }
            else
            for (int i = 0; i < tablaIngredientes.RowCount; i++)
            {
                string cantidad = tablaIngredientes.Rows[i].Cells[1].Value.ToString();

                try
                {
                    float.Parse(cantidad, CultureInfo.InvariantCulture.NumberFormat);
                }
                catch
                {
                    validar++;
                    int fila = i + 1;
                    campos = "Cantidad no valida en el ingrediente de la fila " + fila + "\n";
                } 

            }
            if (validar == 0)
                return true;
            else
            {
                if (validar == 1)
                    MessageBox.Show("Falta completar el campo " + campos);
                else
                    MessageBox.Show("Falta completar los siguientes campos:\n" + campos);
                return false;
            }
        }

        public Boolean diferenciasProducto() {
            int verif = 0;
            if (variablesAlimentos.NombreP != nombreP.Text)
                verif++;
            if (variablesAlimentos.CategoriaP !=categoriaP.Text)
                verif++;
            if (variablesAlimentos.MedidaP !=medidaP.Text)
                verif++;
            if (variablesAlimentos.ExisteciaP != existenciaP.Text)
                verif++;
            if (verif != 0)
            {
                if (verif == 1)
                    MessageBox.Show("¡Campo actualizado!");
                else
                    MessageBox.Show("Campos actualizados!");
                return true;
            }
            else
                return false;
        }

        public Boolean diferenciasReceta()
        {
            int verif = 0;
            if (variablesAlimentos.NombreR != nombreR.Text)
                verif++;
            if (variablesAlimentos.TipoR != tipoR.Text)
                verif++;

            DataView dv = (DataView)(tablaIngredientes.DataSource);

            if (compararTablas(dv.ToTable(), variablesAlimentos.TablaR) == false)
                verif++;
            if (verif != 0)
            {
                if (verif == 1)
                    MessageBox.Show("¡Campo actualizado!");
                else
                    MessageBox.Show("Campos actualizados!");
                return true;
            }
            else
                return false;
            
        }
        public Boolean diferenciasMenu()
        {
            int verif = 0;
            if (variablesAlimentos.NombreM != nombreM.Text)
                verif++;

            DataView dv = (DataView)(tablaMenu.DataSource);

            if (compararTablas(dv.ToTable(), variablesAlimentos.TablaM) == false)
                verif++;
            if (verif != 0)
            {
                if (verif == 1)
                    MessageBox.Show("¡Campo actualizado!");
                else
                    MessageBox.Show("Campos actualizados!");
                return true;
            }
            else
                return false;
        }
        public static bool compararTablas (DataTable tbl1, DataTable tbl2)
        {
            if (tbl1.Rows.Count != tbl2.Rows.Count || tbl1.Columns.Count != tbl2.Columns.Count)
                return false;


            for (int i = 0; i < tbl1.Rows.Count; i++)
            {
                for (int c = 0; c < tbl1.Columns.Count; c++)
                {
                    if (!Equals(tbl1.Rows[i][c], tbl2.Rows[i][c]))
                        return false;
                }
            }
            return true;
        }
        public void limpiarCamposP()
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
        public void limpiarCamposR() { 
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
        public void limpiarCamposM()
        {
                tablaMenu.AutoGenerateColumns = false;
                tablaMenu.Columns.Clear();
                nombreM.Text = "";
                nombreM.Enabled = false;
                modificarM.Enabled = false;
                tablaMenu.Enabled = false;
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
    }

