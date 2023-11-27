using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MinimarketEntidades;

namespace MinimarketDatos
{
    public class D_E_Productos
    {
        public DataTable Listado_ep(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_ep", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SQLCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }

        public DataTable Listado_detalle_ep(int nCodigo_ep)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_Detalle_ep", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nCodigo_ep", SqlDbType.Int).Value = nCodigo_ep;
                SQLCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }




        public string Guardar_ep(E_E_Productos oEp,DataTable dTabla)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Guardar_ep", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nCodigo_ed", SqlDbType.Int).Value = oEp.codigo_ed;
                Comando.Parameters.Add("@cNrodocumento_ep", SqlDbType.VarChar).Value = oEp.nrodocumento_ep;
                Comando.Parameters.Add("@nCodigo_pv", SqlDbType.Int).Value = oEp.codigo_pv;
                Comando.Parameters.Add("@fFecha_ep", SqlDbType.Date).Value = oEp.fecha_ep;

                Comando.Parameters.Add("@nCodigo_al", SqlDbType.Int).Value = oEp.codigo_al;

                Comando.Parameters.Add("@cObservacion_ep", SqlDbType.Text).Value = oEp.observacion_pv;

                Comando.Parameters.Add("@nSubtotal", SqlDbType.Decimal).Value = oEp.subtotal;
                Comando.Parameters.Add("@nIva", SqlDbType.Decimal).Value = oEp.iva;
                Comando.Parameters.Add("@nTotal_importe", SqlDbType.Decimal).Value = oEp.total_importe;
                Comando.Parameters.Add("@tDetalle", SqlDbType.Structured).Value = dTabla;


                SqlCon.Open();
                Respuesta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "NO SE PUDO REGISTRAR LOS DATOS";
            }
            catch (Exception ex)
            {

                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        public string Eliminar_ep(int codigo_ep)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Eliminar_ep", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@nCodigo_ep", SqlDbType.Int).Value = codigo_ep;

                SqlCon.Open();
                Respuesta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "NO SE PUDO ELIMINAR LOS DATOS";
            }
            catch (Exception ex)
            {

                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        public DataTable Listado_ed()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_ed", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
     
                SQLCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }

        public DataTable Listado_e_al()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_e_al", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
              
                SQLCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }

        public DataTable Listado_epv(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_epv", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SQLCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }


        public DataTable Listado_Eproductos(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_eproductos", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SQLCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }



    }
}
