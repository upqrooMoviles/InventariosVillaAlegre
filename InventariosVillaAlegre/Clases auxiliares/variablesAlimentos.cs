using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventariosVillaAlegre.Clases_auxiliares
{
    class variablesAlimentos
    {
        private static string nombreP = "";
        private static string categoriaP = "";
        private static string existeciaP = "";
        private static string medidaP = "";
        private static int ingredientesR = 0;
        private static string nombreR = "";
        private static string tipoR = "";
        private static DataTable tablaR;
        private static string nombreM = "";
        private static DataTable tablaM;
       

        public static DataTable TablaM
        {
            get { return variablesAlimentos.tablaM; }
            set { variablesAlimentos.tablaM = value; }
        }

        public static string NombreM
        {
            get { return variablesAlimentos.nombreM; }
            set { variablesAlimentos.nombreM = value; }
        }
        

        public static DataTable TablaR
        {
            get { return variablesAlimentos.tablaR; }
            set { variablesAlimentos.tablaR = value; }
        }

        public static string TipoR
        {
            get { return variablesAlimentos.tipoR; }
            set { variablesAlimentos.tipoR = value; }
        }

        public static string NombreR
        {
            get { return variablesAlimentos.nombreR; }
            set { variablesAlimentos.nombreR = value; }
        }

        public static int IngredientesR
        {
            get { return variablesAlimentos.ingredientesR; }
            set { variablesAlimentos.ingredientesR = value; }
        }

        

        public static string MedidaP
        {
            get { return variablesAlimentos.medidaP; }
            set { variablesAlimentos.medidaP = value; }
        }
        public static string ExisteciaP
        {
            get { return variablesAlimentos.existeciaP; }
            set { variablesAlimentos.existeciaP = value; }
        }

        public static string CategoriaP
        {
            get { return variablesAlimentos.categoriaP; }
            set { variablesAlimentos.categoriaP = value; }
        }

        public static string NombreP
        {
            get { return variablesAlimentos.nombreP; }
            set { variablesAlimentos.nombreP = value; }
        }
    }
}
