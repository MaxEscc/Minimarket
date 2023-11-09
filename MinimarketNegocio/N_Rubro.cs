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
    public class N_Rubro
    {
        public static DataTable Listado_rb(string cTexto)
        {
            D_Rubro Datos = new D_Rubro();
            return Datos.Listado_rb(cTexto);
        }

        public static string Guardar_rb(int nOpcion, E_Rubro oRb)
        {
            D_Rubro Datos = new D_Rubro();
            return Datos.Guardar_rb(nOpcion, oRb);
        }
        public static string Eliminar_rb(int codigo_rb)
        {
            D_Rubro Datos = new D_Rubro();
            return Datos.Eliminar_rb(codigo_rb); ;
        }
    }
}
