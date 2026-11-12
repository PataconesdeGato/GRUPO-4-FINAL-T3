using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CAPA_ENTDIDAD_;

namespace CAPA_DATOS_
{
    public class datCliente
    {
        private static readonly datCliente _instancia = new datCliente();
        public static datCliente Instancia
        {
            get { return datCliente._instancia; }
        }

        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Cliente_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente cli = new entCliente();
                    cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    cli.dni = dr["dni"].ToString();
                    cli.nombres = dr["nombres"].ToString();
                    cli.telefono = dr["telefono"].ToString();
                    cli.correo = dr["correo"].ToString();
                    cli.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(cli);
                }
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return lista;
        }

        public Boolean InsertarCliente(entCliente cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Cliente_Insertar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", cli.dni);
                cmd.Parameters.AddWithValue("@nombres", cli.nombres);
                cmd.Parameters.AddWithValue("@telefono", cli.telefono);
                cmd.Parameters.AddWithValue("@correo", cli.correo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) inserta = true;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean EditarCliente(entCliente cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Cliente_Editar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", cli.idCliente);
                cmd.Parameters.AddWithValue("@dni", cli.dni);
                cmd.Parameters.AddWithValue("@nombres", cli.nombres);
                cmd.Parameters.AddWithValue("@telefono", cli.telefono);
                cmd.Parameters.AddWithValue("@correo", cli.correo);
                cmd.Parameters.AddWithValue("@estado", cli.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) edita = true;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return edita;
        }

        public Boolean DeshabilitarCliente(entCliente cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Cliente_Deshabilitar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", cli.idCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) delete = true;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return delete;
        }
    }
}