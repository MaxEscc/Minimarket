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
    public class N_S_Productos
    {
        public static DataTable Listado_sp (string cTexto)
        {
            D_S_Productos Datos = new D_S_Productos();
            return Datos.Listado_sp(cTexto);
        }

        public static DataTable Listado_detalle_ep(int codigo_sp)
        {
            D_S_Productos Datos = new D_S_Productos();
            return Datos.Listado_detalle_sp(codigo_sp);
        }

        public static string Guardar_sp(E_S_Productos oSp, DataTable dTabla)
        {
            D_S_Productos Datos = new D_S_Productos();
            return Datos.Guardar_sp(oSp, dTabla);
        }
        public static string Eliminar_sp(int codigo_sp)
        {
            D_S_Productos Datos = new D_S_Productos();
            return Datos.Eliminar_sp(codigo_sp); ;
        }
        public static DataTable Listado_ed()
        {
            D_S_Productos Datos = new D_S_Productos();
            return Datos.Listado_ed();
        }

        public static DataTable Listado_clsp(string cTexto)
        {
            D_S_Productos Datos = new D_S_Productos();
            return Datos.Listado_clsp(cTexto);
        }
        public static DataTable Listado_Sproductos(string cTexto)
        {
            D_S_Productos Datos = new D_S_Productos();
            return Datos.Listado_Sproductos(cTexto);
        }


    }

}
