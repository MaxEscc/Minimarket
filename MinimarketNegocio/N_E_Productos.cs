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
    public class N_E_Productos
    {
        public static DataTable Listado_ep(string cTexto)
        {
            D_E_Productos Datos = new D_E_Productos();
            return Datos.Listado_ep(cTexto);
        }
        
         public static DataTable Listado_detalle_ep(int codigo_ep)
        {
            D_E_Productos Datos = new D_E_Productos();
            return Datos.Listado_detalle_ep(codigo_ep);
        }

        public static string Guardar_ep( E_E_Productos oEp,DataTable dTabla)
        {
            D_E_Productos Datos = new D_E_Productos();
            return Datos.Guardar_ep( oEp,dTabla);
        }
        public static string Eliminar_ep(int codigo_ep)
        {
            D_E_Productos Datos = new D_E_Productos();
            return Datos.Eliminar_ep(codigo_ep); ;
        }
        public static DataTable Listado_ed()
        {
            D_E_Productos Datos = new D_E_Productos();
            return Datos.Listado_ed ();
        }

        public static DataTable Listado_e_al( )
        {
            D_E_Productos Datos = new D_E_Productos();
            return Datos.Listado_e_al();
        }
        public static DataTable Listado_epv(string cTexto)
        {
            D_E_Productos Datos = new D_E_Productos();
            return Datos.Listado_epv(cTexto);
        }
        public static DataTable Listado_Eproductos(string cTexto)
        {
            D_E_Productos Datos = new D_E_Productos();
            return Datos.Listado_Eproductos(cTexto);
        }


    }

}
