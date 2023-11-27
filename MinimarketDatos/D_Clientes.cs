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
    public class D_Clientes
    {
        public DataTable Listado_cl(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_cl", SQLCon);
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

        public string Guardar_cl(int nOpcion, E_Clientes oCl)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Guardar_cl", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@nCodigo_cl", SqlDbType.Int).Value = oCl.codigo_cl;
                Comando.Parameters.Add("@nCodigo_pc", SqlDbType.Int).Value = oCl.codigo_pc;
                Comando.Parameters.Add("@cNrodocumento_cl", SqlDbType.VarChar).Value = oCl.nrodocumento_cl;
                Comando.Parameters.Add("@cRazon_social_cl", SqlDbType.VarChar).Value = oCl.razon_social_cl;
                Comando.Parameters.Add("@cNombres", SqlDbType.VarChar).Value = oCl.nombres;
                Comando.Parameters.Add("@cApellidos", SqlDbType.VarChar).Value = oCl.apellidos;
                Comando.Parameters.Add("@nCodigo_sx", SqlDbType.Int).Value = oCl.codigo_sx;
                Comando.Parameters.Add("@nCodigo_rb", SqlDbType.Int).Value = oCl.codigo_rb;
                Comando.Parameters.Add("@cEmail_cl", SqlDbType.VarChar).Value = oCl.email_cl;
                Comando.Parameters.Add("@cTelefono_cl", SqlDbType.VarChar).Value = oCl.telefono_cl;
                Comando.Parameters.Add("@cMovil_cl", SqlDbType.VarChar).Value = oCl.movil_cl;
                Comando.Parameters.Add("@cDireccion_cl", SqlDbType.VarChar).Value = oCl.direccion_cl;
                Comando.Parameters.Add("@nCodigo_dis", SqlDbType.Int).Value = oCl.codigo_dis;
                Comando.Parameters.Add("@cObservacion_cl", SqlDbType.VarChar).Value = oCl.observacion_cl;



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

        public string Eliminar_cl(int codigo_cl)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Eliminar_cl", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@nCodigo_cl", SqlDbType.Int).Value = codigo_cl;

                SqlCon.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "NO SE PUDO ELIMINAR LOS DATOS";
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

        public DataTable Listado_pc()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_pc", SQLCon);
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


        public DataTable Listado_sx()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_sx", SQLCon);
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


        public DataTable Listado_rb_cl(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_rb_pv", SQLCon);
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


        public DataTable Listado_dis_cl(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_dis_pv", SQLCon);
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
