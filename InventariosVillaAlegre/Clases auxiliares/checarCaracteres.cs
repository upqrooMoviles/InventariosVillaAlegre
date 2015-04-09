using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventariosVillaAlegre
{
    class checarCaracteres
    {
        public static Boolean sinNumeros(KeyPressEventArgs e)
        {
            
        if (Char.IsNumber(e.KeyChar)) 
                return true;
            else 
                return false;
        }

        public static Boolean letrasNumerosSinEspacios(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) 
                return false; 
            else if (Char.IsControl(e.KeyChar)) 
                return false; 
            else if (Char.IsNumber(e.KeyChar)) 
                return false;
            else      
                return true;
        }
        public static Boolean sinEspacios(KeyPressEventArgs e){
            if (Char.IsWhiteSpace(e.KeyChar)) 
                return true; 
            else 
                return false; 
        }

        public static Boolean validarcorreo(string email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Formato de correo no valido!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Formato de correo no valido!");
                return false;
            }
        }
    }
}
