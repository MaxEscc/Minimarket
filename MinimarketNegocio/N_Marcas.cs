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
    public class N_Marcas
    {
        public static DataTable Listado_m(string cTexto)
        {
            D_Marcas Datos = new D_Marcas();
            return Datos.Listado_m(cTexto);
        }

        public static string Guardar_m(int nOpcion, E_Marcas oMa)
        {
            D_Marcas Datos = new D_Marcas();
            return Datos.Guardar_m(nOpcion, oMa);
        }
        public static string Eliminar_m(int codigo_m)
        {
            D_Marcas Datos = new D_Marcas();
            return Datos.Eliminar_m(codigo_m); ;
        }
    }
}
