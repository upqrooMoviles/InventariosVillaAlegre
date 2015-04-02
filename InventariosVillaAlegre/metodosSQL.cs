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

        /*metodo busqueda
        *Se tiene que enviar el nombre de la tabla, los campos separados por comas y la clausula o clauslas a buscar
        *Ejemplo:
         *string tabla="usuarios";
         *string campos= "id, nombre"; 
         *string clausula="nombre='maria' ";
        */
        public DataSet busqueda(string tabla, string campos, string clausula)
        {
            
            DataSet resultado;
            if (clausula == null)
                resultado = con.resultado("SELECT " + campos + " FROM " + tabla);
            else
                resultado = con.resultado("SELECT " + campos + " fROM " + tabla + " WHERE "+clausula);
            return resultado; //Esto nos retornara un dataset (una tabla no fisica de donde se pueden extraer los datos)
        }



        /*metodo insertar
        *Se tiene que enviar el nombre de la tabla, los campos separados por comas y los valores a insertar en los campos con comillas simples si no son datos enteros
        *Ejemplo:
         *string tabla="usuarios";
         *string campos= "id, nombre, usuario"; 
         *string valores="0, 'mariana', 'mar'";
        */
        public Boolean insertar(string tabla, string campos, string valores)
        {
            return con.comando("INSERT INTO "+tabla+" ("+campos+") VALUES ("+valores+");");//retorna false si no se ejecuto
        }


        /*metodo eliminar
        *Se tiene que enviar el nombre de la tabla y la clausula o clausulas para eliminar
        *Ejemplo:
         *string tabla="usuarios";
         *string clausula="nombre='maria' ";
        */
        public Boolean eliminar(string tabla, string clausula)
        {
            return con.comando("DELETE FROM " + tabla + " WHERE " + clausula + ";");//retorna false si no se ejecuto
        }


        /*metodo modificar
        *Se tiene que enviar el nombre de la tabla, los valores a modificar y la clausula o clauslas donde se modificara
        *Ejemplo:
         *string tabla="usuarios";
         *string valores= "nombre='marisol' and user='mari01'"; 
         *string clausula="id=0 ";
        */
        public Boolean modificar(string tabla, string valores, string clausula)
        {
            return con.comando("UPDATE " + tabla + " SET " + valores + " WHERE " + clausula + ";");//retorna false si no se ejecuto
            
        }

    }
}
