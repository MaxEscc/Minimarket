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
    public class D_S_Productos
    {
        public DataTable Listado_sp(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_sp", SQLCon);
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

        public DataTable Listado_detalle_sp(int nCodigo_sp)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_Detalle_sp", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nCodigo_sp", SqlDbType.Int).Value = nCodigo_sp;
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




        public string Guardar_sp(E_S_Productos oSp, DataTable dTabla)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Guardar_sp", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nCodigo_ed", SqlDbType.Int).Value = oSp.codigo_ed;
                Comando.Parameters.Add("@cNrodocumento_sp", SqlDbType.VarChar).Value = oSp.nrodocumento_sp;
                Comando.Parameters.Add("@nCodigo_cl", SqlDbType.Int).Value = oSp.codigo_cl;

                Comando.Parameters.Add("@cNrodocumento_cl", SqlDbType.Text).Value = oSp.nrodocumento_cl;
                Comando.Parameters.Add("@cRazon_social_cl", SqlDbType.Text).Value = oSp.razon_social_cl;

                Comando.Parameters.Add("@fFecha_sp", SqlDbType.Date).Value = oSp.fecha_sp;

                Comando.Parameters.Add("@cObservacion_sp", SqlDbType.Text).Value = oSp.observacion_sp;

                Comando.Parameters.Add("@nSubtotal", SqlDbType.Decimal).Value = oSp.subtotal;
                Comando.Parameters.Add("@nIva", SqlDbType.Decimal).Value = oSp.iva;
                Comando.Parameters.Add("@nTotal_importe", SqlDbType.Decimal).Value = oSp.total_importe;
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

        public string Eliminar_sp(int codigo_sp)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Eliminar_sp", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@nCodigo_sp", SqlDbType.Int).Value = codigo_sp;

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


        public DataTable Listado_clsp(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_spv", SQLCon);
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


        public DataTable Listado_Sproductos(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_s_p", SQLCon);
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
