using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosVillaAlegre
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try {
                metodosSQL m = new metodosSQL();
                DataSet inicio=m.busqueda("usuarios","idusuarios","tipo_usuario='General'");
                inicio.Tables[0].Rows[0][0].ToString();
                Application.Run(new principal());

                }
            catch { 
            Application.Run(new registro());
            }
        }
    }
}
