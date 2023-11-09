using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MinimarketEntidades;
using MinimarketDatos;

namespace MinimarketNegocio
{
    public class N_Almacen
    {
        public static DataTable Listado_al(string cTexto)
        {
            D_Almacen Datos = new D_Almacen();
            return Datos.Listado_al(cTexto);
        }

        public static string Guardar_al(int nOpcion, E_Almacen oAl)
        {
            D_Almacen Datos = new D_Almacen();
            return Datos.Guardar_al(nOpcion, oAl);
        }
        public static string Eliminar_al(int codigo_al)
        {
            D_Almacen Datos = new D_Almacen();
            return Datos.Eliminar_al(codigo_al); ;
        }
    }
}
