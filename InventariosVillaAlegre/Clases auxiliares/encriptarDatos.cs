using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventariosVillaAlegre
{
    class encripDatos
    {

        public String encrip(String variable)
        {
            String resultado = "";
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(variable);
            resultado = Convert.ToBase64String(encryted);
            return resultado;
        }
        public String desencrip(String variable)
        {
            String resultado = "";
            byte[] decryted = Convert.FromBase64String(variable);
            resultado = System.Text.Encoding.Unicode.GetString(decryted);
            return resultado;
        }
 

    }
}
