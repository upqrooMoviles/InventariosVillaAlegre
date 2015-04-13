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
    public partial class altas : Form
    {
        public altas()
        {
            InitializeComponent();
            claveP.Focus();
            categoriaP.SelectedIndex = 0;
            medidaP.SelectedIndex = 0;
            tipoR.SelectedIndex = 0;

        }
        private void altas_Load(object sender, EventArgs e)
        {
            claveP.Focus();

        }
        metodosSQL m = new metodosSQL();
        int ingredientesusados = 0;
        private void clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= checarCaracteres.sinEspacios(e);
        }

        private void nombe_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.sinNumeros(e);
        }

        private void existencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.numerosDecimales(e);
        }

        private void cantidadingrediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.numerosDecimales(e);
        }

        private void claveR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.sinEspacios(e);
        }

        private void nombreR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.sinNumeros(e);
        }

        private void claveM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.sinEspacios(e);
        }

        private void nombreM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = checarCaracteres.sinNumeros(e);
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                claveR.Focus();
                comboBoxIngredientes.Items.Clear();
                DataSet resultado = m.busqueda("alimentos", "idalimentos", null);
                try
                {

                    int i = 0;
                    while (true)
                    {
                        comboBoxIngredientes.Items.Add(resultado.Tables[0].Rows[i][0].ToString());
                        i++;
                    }
                }
                catch { }
                try
                {
                    comboBoxIngredientes.SelectedIndex = 0;
                    altaR.Enabled = true;
                    DataSet busquedauser = m.busqueda("alimentos", "medida", "idalimentos='" + comboBoxIngredientes.SelectedItem.ToString() + "'");
                    labelMedida.Text = busquedauser.Tables[0].Rows[0][0].ToString();
                }
                catch
                {
                    MessageBox.Show("¡No tiene productos dados de alta!");
                    añadiringrediente.Enabled = false;
                    altaR.Enabled = false;
                    cantidadingrediente.Enabled = false;
                    comboBoxIngredientes.Enabled = false;
                }
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                claveM.Enabled = true;
                nombreM.Enabled = true;
                altaM.Enabled = true;
                tablaMenu();
            }
        }
        private void comboBoxIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet busquedauser = m.busqueda("alimentos", "medida", "idalimentos='" + comboBoxIngredientes.SelectedItem.ToString() + "'");
            labelMedida.Text = busquedauser.Tables[0].Rows[0][0].ToString();
        }

        
        private void altaP_Click(object sender, EventArgs e)
        {
            if (validarCamposProductos() == true && validarNumero(existenciaP.Text) == true)
            {
                try
                {
                    DataSet busquedauser = m.busqueda("alimentos", "idalimentos", "idalimentos='" + claveP.Text + "'");
                    MessageBox.Show("La clave " + busquedauser.Tables[0].Rows[0][0].ToString() + "ya existe. Indique una diferente");
                    claveP.Focus();
                }
                catch
                {
                    string valoresCampos = "'" + claveP.Text + "', '" + nombreP.Text + "', '" + categoriaP.SelectedItem.ToString() + "','" + medidaP.SelectedItem.ToString() + "'," + existenciaP.Text;
                    if (m.insertar("alimentos", "idalimentos, producto, categoria, medida, existencia", valoresCampos) == true)
                    {
                        MessageBox.Show("¡Registro insertado con exito!");
                        limpiarCamposP();
                    }
                    else
                        MessageBox.Show("¡Registro no insertado, intente de nuevo o contacte al proovedor de software!");
                }
            }
        }
        
        private void altaR_Click(object sender, EventArgs e)
        {
            if (claveR.Text.Length > 4 && nombreR.Text.Trim().Length > 4)
            {
                try
                {
                    DataSet busquedauser = m.busqueda("recetas", "idrecetas", "idrecetas='" + claveR.Text + "'");
                    MessageBox.Show("La clave " + busquedauser.Tables[0].Rows[0][0].ToString() + "ya existe. Indique una diferente");
                    claveR.Focus();
                }
                catch
                {
                    string valoresCampos = "'" + claveR.Text + "', '" + nombreR.Text + "', '" + tipoR.SelectedItem.ToString() + "',0";
                    if (m.insertar("recetas", "idrecetas, nombre, tipo, ingredientes", valoresCampos) == true)
                    {
                        MessageBox.Show("¡Receta agregada! Agregar los ingredientes");
                        claveR.Enabled = false;
                        nombreR.Enabled = false;
                        tipoR.Enabled = false;
                        altaR.Enabled = false;
                        finalizarR.Visible = true;
                        finalizarR.Enabled = false;
                        añadiringrediente.Enabled = true;
                        cantidadingrediente.Enabled = true;
                        comboBoxIngredientes.Enabled = true;
                        cantidadingrediente.Focus();
                    }
                    else
                        MessageBox.Show("¡Registro no insertado, intente de nuevo o contacte al proovedor de software!");
                }

            }
            else
                MessageBox.Show("Por favor ingrese la clave de la receta entre 4 y 15 caracteres y el nombre entre 4 y 45 caracteres para continuar.");
        }
             
        private void añadiringrediente_Click(object sender, EventArgs e)
        {
            if (validarNumero(cantidadingrediente.Text) == true)
            {
                string valoresCampos = "'" + claveR.Text + "', '" + comboBoxIngredientes.SelectedItem.ToString() + "'," + cantidadingrediente.Text;
                if (m.insertar("ingredientes_recetas", "idrecetas, idalimentos,cantidad", valoresCampos) == true)
                {
                    ingredientesusados++;
                    listaIngredientes.Text = listaIngredientes.Text + ingredientesusados + ". " + comboBoxIngredientes.SelectedItem.ToString() + ": " + cantidadingrediente.Text + " " + labelMedida.Text + "\n";
                    finalizarR.Enabled = true;
                    cantidadingrediente.Focus();
                    cantidadingrediente.Text = "";
                    comboBoxIngredientes.SelectedIndex = 0;
                }

            }
            else
                cantidadingrediente.Focus();
        }

        private void finalizarR_Click(object sender, EventArgs e)
        {
            if (m.modificar("recetas", "ingredientes=" + ingredientesusados, "idrecetas='" + claveR.Text + "'") == true)
            {
                MessageBox.Show("¡Receta " + claveR.Text + " agregada!");
                claveR.Text = "";
                nombreR.Text = "";
                cantidadingrediente.Text = "";
                tipoR.SelectedItem = 0;
                comboBoxIngredientes.SelectedItem = 0;
                claveR.Enabled = true;
                nombreR.Enabled = true;
                tipoR.Enabled = true;
                altaR.Enabled = true;
                finalizarR.Visible = false;
                finalizarR.Enabled = false;
                añadiringrediente.Enabled = false;
                cantidadingrediente.Enabled = false;
                comboBoxIngredientes.Enabled = false;
                claveR.Focus();
                listaIngredientes.Text = "";
                ingredientesusados = 0;
            }
            else
                MessageBox.Show("Error al finalizar receta. intente de nuevo o contacte a su proovedor de software ");
        }

        private void altaM_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet busquedauser = m.busqueda("menus", "idmenus", "idmenus='" + claveM.Text + "'");
                MessageBox.Show("La clave " + busquedauser.Tables[0].Rows[0][0].ToString() + "ya existe. Indique una diferente");
                claveR.Focus();
            }
            catch
            {
                if (claveM.Text.Length > 4 && nombreM.Text.Trim().Length > 4)
                {
                    try
                    {
                        DataSet busquedauser = m.busqueda("menus", "idmenus", "idmenus='" + claveR.Text + "'");
                        MessageBox.Show("La clave " + busquedauser.Tables[0].Rows[0][0].ToString() + "ya existe. Indique una diferente");
                        claveM.Focus();
                    }
                    catch
                    {
                        altaM.Enabled = false;
                        claveM.Enabled = false;
                        nombreM.Enabled = false;
                        string valoresCampos = "'" + claveM.Text + "', '" + nombreM.Text + "'";
                        if (m.insertar("menus", "idmenus, nombre", valoresCampos) == true)
                        {
                            string menu = claveM.Text;
                            for (int i = 0; i < 7; i++)
                            {
                                string dia = "", tipo = "", receta = "";
                                dia = menuSemanal.Rows[i].Cells[0].Value.ToString();
                                for (int j = 1; j < 4; j++)
                                {
                                    tipo = menuSemanal.Columns[j].HeaderText;
                                    receta = menuSemanal.Rows[i].Cells[j].Value.ToString();
                                    valoresCampos = "'" + dia + "', '" + tipo + "','" + receta + "','" + menu + "'";
                                    m.insertar("recetas_menus", "dia, tipo, idrecetas, idmenus", valoresCampos);
                                }
                            }

                            MessageBox.Show("Menu " + claveM.Text + " agregado.");
                            tablaMenu();
                            claveM.Text = "";
                            nombreM.Text = "";
                            claveM.Enabled = true;
                            nombreM.Enabled = true;
                            claveM.Focus();
                            altaM.Enabled = true;

                        }
                        else
                            MessageBox.Show("¡Registro no insertado, intente de nuevo o contacte al proovedor de software!");
                    }

                }
                else
                    MessageBox.Show("Por favor ingrese la clave del menu entre 4 y 15 caracteres y el nombre entre 4 y 45 caracteres para continuar.");
            }
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
            if (claveP.Text.Trim().Length < 3)
            {
                campos += "Clave entre 3 y 10 digitos\n";
                validar++;
                claveP.Focus();
            }
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
        
        public void limpiarCamposP()
        {
            categoriaP.SelectedItem = "CARNES, PESCADOS Y HUEVOS";
            medidaP.SelectedItem = "GRAMOS";
            claveP.Text = "";
            nombreP.Text = "";
            existenciaP.Text = "";
            claveP.Focus();
        }
        
        public void tablaMenu()
        {



            menuSemanal.AutoGenerateColumns = false;
            menuSemanal.Columns.Clear();
                DataTable dt = new DataTable();
                dt.Columns.Add("dia", typeof(String));
                dt.Columns.Add("desayuno", typeof(String));
                dt.Columns.Add("comida", typeof(String));
                dt.Columns.Add("cena", typeof(String));
                dt.Rows.Add("JUEVES","","","");
                dt.Rows.Add("VIERNES", "", "", "");
                dt.Rows.Add("SABADO", "", "", "");
                dt.Rows.Add("DOMINGO", "", "", "");
                dt.Rows.Add("LUNES", "", "", "");
                dt.Rows.Add("MARTES", "", "", "");
                dt.Rows.Add("MIERCOLES", "", "", "");

                DataGridViewComboBoxColumn des = new DataGridViewComboBoxColumn();
                DataSet resultado = m.busqueda("recetas", "idrecetas", "tipo='DESAYUNO' or tipo='GENERAL'");
                int i = 0;
                try
                {
                    while (true)
                    {
                        des.Items.Add(resultado.Tables[0].Rows[i][0].ToString());
                        i++;
                    }
                }
                catch { }
                des.HeaderText = "DESAYUNO";
                des.DataPropertyName = "desayuno";

                DataGridViewComboBoxColumn com = new DataGridViewComboBoxColumn();
                resultado = m.busqueda("recetas", "idrecetas", "tipo='COMIDA' or tipo='GENERAL'");
                i = 0;
                try
                {
                    while (true)
                    {
                        com.Items.Add(resultado.Tables[0].Rows[i][0].ToString());
                        i++;
                    }
                }
                catch { }
                com.HeaderText = "COMIDA";
                com.DataPropertyName = "comida";

                DataGridViewComboBoxColumn cen = new DataGridViewComboBoxColumn();
                resultado = m.busqueda("recetas", "idrecetas", "tipo='CENA' or tipo='GENERAL'");
                i = 0;
                try
                {
                    while (true)
                    {
                        cen.Items.Add(resultado.Tables[0].Rows[i][0].ToString());
                        i++;
                    }
                }
                catch { }
                cen.HeaderText = "CENA";
                cen.DataPropertyName = "cena";
                if (i == 0)
                {
                    MessageBox.Show("No hay suficientes recetas para dar de alta el menu.");
                    claveM.Enabled = false;
                    nombreM.Enabled = false;
                    altaM.Enabled = false;
                }


                DataGridViewTextBoxColumn dia = new DataGridViewTextBoxColumn();
                dia.HeaderText = "Dia";
                dia.DataPropertyName = "dia";
                menuSemanal.DataSource = dt;
                menuSemanal.Columns.AddRange(dia, des, com, cen);
                menuSemanal.Columns[0].ReadOnly = true;

                try
                {
                    foreach (DataGridViewRow row in menuSemanal.Rows)
                    {
                        DataGridViewComboBoxCell cell = row.Cells[1] as DataGridViewComboBoxCell;
                        if (cell != null)
                        {
                            cell.Value = cell.Items[0];
                        }
                    }
                }
                catch { }
                try
                {
                    foreach (DataGridViewRow row in menuSemanal.Rows)
                    {
                        DataGridViewComboBoxCell cell = row.Cells[2] as DataGridViewComboBoxCell;
                        if (cell != null)
                        {
                            cell.Value = cell.Items[0];
                        }
                    }
                }
                catch { }
                try
                {
                    foreach (DataGridViewRow row in menuSemanal.Rows)
                    {
                        DataGridViewComboBoxCell cell = row.Cells[3] as DataGridViewComboBoxCell;
                        if (cell != null)
                        {
                            cell.Value = cell.Items[0];
                        }
                    }
                }
                catch { }

        }


        

    }
}
