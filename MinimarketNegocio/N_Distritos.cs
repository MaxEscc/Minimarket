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
    public class N_Distritos
    {
        public static DataTable Listado_dis(string cTexto)
        {
            D_Distritos Datos = new D_Distritos();
            return Datos.Listado_dis(cTexto);
        }

        public static string Guardar_dis(int nOpcion, E_Distritos oDi)
        {
            D_Distritos Datos = new D_Distritos();
            return Datos.Guardar_dis(nOpcion, oDi);
        }
        public static string Eliminar_dis(int codigo_dis)
        {
            D_Distritos Datos = new D_Distritos();
            return Datos.Eliminar_dis(codigo_dis); ;
        }

        //departamento
        public static DataTable Listado_pp(string cTexto)
        {
            D_Distritos Datos = new D_Distritos();
            return Datos.Listado_pp(cTexto);
        }

    }
}
