using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace InventariosVillaAlegre
{
    class conexion
    {



        public MySqlConnection conectar;
        public void crearconexion()
        {
            string conec = "Server=localhost;database=villaalegre;uid=root;pwd=;";
            conectar = new MySqlConnection(conec);
            conectar.Open();
        }

        public void cerrarconexion()
        {
            conectar.Close();
        }

        public MySqlConnection getConexion()
        {
            return conectar;
        }

        public DataSet resultado(string buscar)
        {
            DataSet data = new DataSet();
            crearconexion();
            MySqlCommand busquedaSearch = new MySqlCommand(buscar, getConexion());
            MySqlDataAdapter cmc = new MySqlDataAdapter(busquedaSearch);
            busquedaSearch.Connection = getConexion();
            cmc.Fill(data);
            return data;
        }


        public Boolean comando(string actualizar)
        {
            crearconexion();
            try
            {
                MySqlCommand Ins = new MySqlCommand(actualizar);
                Ins.Connection = getConexion();
                Ins.ExecuteNonQuery();
                cerrarconexion();
                return true;
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            finally
            {
                cerrarconexion();
            }
        }

    }
}
