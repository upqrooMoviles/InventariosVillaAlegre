using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventariosVillaAlegre
{
    class valores
    {
        private static string opcion = "";
        private static string usuario = "";
        private static string tipo_usuario = "";
        private static string rutapdf = "";
        private static string nombrepdf = "";
        public static string Rutapdf
        {
            get { return valores.rutapdf; }
            set { valores.rutapdf = value; }
        }
        public static string Nombrepdf
        {
            get { return valores.nombrepdf; }
            set { valores.nombrepdf = value; }
        }

        public static string Tipo_usuario
        {
            get { return valores.tipo_usuario; }
            set { valores.tipo_usuario = value; }
        }
        public static string Usuario
        {
            get { return valores.usuario; }
            set { valores.usuario = value; }
        }
        

        public static string Opcion
        {
            get { return valores.opcion; }
            set { valores.opcion = value; }
        }

        //variables para el correo
        
    }
}
