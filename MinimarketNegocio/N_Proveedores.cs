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
    public class N_Proveedores
    {
        public static DataTable Listado_pv(string cTexto)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Listado_pv(cTexto);
        }

        public static string Guardar_pv(int nOpcion, E_Proveedores oPv)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Guardar_pv(nOpcion, oPv);
        }
        public static string Eliminar_pv(int codigo_pv)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Eliminar_pv(codigo_pv); ;
        }
        public static DataTable Listado_pc()
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Listado_pc ();
        }
        public static DataTable Listado_sx()
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Listado_sx();
        }
        public static DataTable Listado_rb_pv(string cTexto)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Listado_rb_pv(cTexto);
        }
        public static DataTable Listado_dis_pv(string cTexto)
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Listado_dis_pv(cTexto);
        }

    }

}
