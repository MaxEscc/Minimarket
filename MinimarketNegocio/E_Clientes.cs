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
    public class N_Clientes
    {
        public static DataTable Listado_cl(string cTexto)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Listado_cl(cTexto);
        }

        public static string Guardar_cl(int nOpcion, E_Clientes oCl)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Guardar_cl(nOpcion, oCl);
        }
        public static string Eliminar_pv(int codigo_cl)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Eliminar_cl(codigo_cl); ;
        }
        public static DataTable Listado_pc()
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Listado_pc();
        }

        public static DataTable Listado_sx()
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Listado_sx();
        }

        public static DataTable Listado_rb_cl(string cTexto)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Listado_rb_cl(cTexto);
        }
        public static DataTable Listado_dis_cl(string cTexto)
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Listado_dis_cl(cTexto);
        }

    }

}
