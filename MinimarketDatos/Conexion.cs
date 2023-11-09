using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimarketDatos
{
   public class Conexion
    {
        private string Bd;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;


        private Conexion()
        {
            this.Bd = "Mimimarket";
            this.Servidor = "DESKTOP-S0IO036\\SQLEXPRESS";
            this.Usuario = "sistemas";
            this.Clave = "1991941245";
            this.Seguridad = false;
        }

     public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString="Server=" +this.Servidor + "; Database= " + this.Bd + ";";
                if (Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security =SSPI";

                }
                else
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id=" + this.Usuario + "; Password=" + this.Clave;
                }
            }
            catch(Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion(); 
            }
            return Con;
        }
    }
}
