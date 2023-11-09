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
    public class N_Productos
    {
        public static DataTable Listado_p(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listado_p(cTexto);
        }

        public static string Guardar_p(int nOpcion, E_Productos oPr)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Guardar_p(nOpcion, oPr);
        }
        public static string Eliminar_p(int codigo_p)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Eliminar_p(codigo_p); ;
        }
        public static DataTable Listado_m_p(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listado_m_p(cTexto);
        }

        public static DataTable Listado_um_p(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listado_um(cTexto);
        }
        public static DataTable Listado_ca_p(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listado_ca_p(cTexto);
        }
        public static DataTable Listado_stock_actual(int nCodigo_p)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listado_stock_actual(nCodigo_p);
        }

    }
     
}
