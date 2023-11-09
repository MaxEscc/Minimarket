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
    public class N_Departamento
    {
        public static DataTable Listado_de(string cTexto)
        {
            D_Departamento Datos = new D_Departamento();
            return Datos.Listado_de(cTexto);
        }

        public static string Guardar_de(int nOpcion, E_Departamento oDe)
        {
            D_Departamento Datos = new D_Departamento();
            return Datos.Guardar_de(nOpcion, oDe);
        }
        public static string Eliminar_de(int codigo_de)
        {
            D_Departamento Datos = new D_Departamento();
            return Datos.Eliminar_de(codigo_de); ;
        }
    }
}
