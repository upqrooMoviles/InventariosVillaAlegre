using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventariosVillaAlegre
{
    class metodosSQL
    {
        conexion con = new conexion();

        
        public DataSet busqueda(string tabla, string campos, string clausula)
        {
            DataSet resultado;
            if (clausula == null)
                resultado = con.resultado("SELECT " + campos + " FROM " + tabla);
            else
                resultado = con.resultado("SELECT " + campos + " fROM " + tabla + " WHERE "+clausula);
            return resultado;
        }

        public Boolean insertar(string tabla, string campos, string valores)
        {
            return con.comando("INSERT INTO "+tabla+" ("+campos+") VALUES ("+valores+");");
        }
        public Boolean eliminar(string tabla, string clausula)
        {
            return con.comando("DELETE FROM " + tabla + " WHERE " + clausula + ";");
        }
        public Boolean modificar(string tabla, string valores, string clausula)
        {
            return con.comando("UPDATE " + tabla + " SET " + valores + " WHERE " + clausula + ";");
            
        }

    }
}
