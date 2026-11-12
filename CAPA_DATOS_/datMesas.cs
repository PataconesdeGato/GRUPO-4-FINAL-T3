using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_ENTDIDAD_;

namespace CAPA_DATOS_
{
    public class datMesas
    {
        #region singleton
        // Patrón Singleton
        private static readonly datMesas _instancia = new datMesas();

        public static datMesas Instancia
        {
            get
            {
                return datMesas._instancia;
            }
        }
        #endregion singleton

        #region metodos
        public List<entMesas> ListarMesa()
        {
            SqlCommand cmd = null;
            List<entMesas> lista = new List<entMesas>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Mesa_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entMesas mes = new entMesas();
                        mes.IdMesa = Convert.ToInt32(dr["idMesa"]);
                        mes.Numero = Convert.ToInt32(dr["numero"]);
                        mes.Capacidad = Convert.ToInt32(dr["capacidad"]);
                        mes.Ubicacion = dr["ubicacion"] == DBNull.Value ? null : dr["ubicacion"].ToString();
                        mes.Estado = Convert.ToBoolean(dr["estado"]);
                        lista.Add(mes);
                    }
                }
            }
            catch (SqlException e)
            {
                throw Traducir(e);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return lista;
        }

        public Boolean InsertarMesa(entMesas mes)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Mesa_Insertar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero", mes.Numero);
                cmd.Parameters.AddWithValue("@capacidad", mes.Capacidad);
                cmd.Parameters.AddWithValue("@ubicacion", UbicacionOrNull(mes.Ubicacion));
                cn.Open();
                object id = cmd.ExecuteScalar();
                if (id != null && id != DBNull.Value)
                {
                    mes.IdMesa = Convert.ToInt32(id);
                    inserta = true;
                }
            }
            catch (SqlException e)
            {
                throw Traducir(e);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return inserta;
        }

        public Boolean EditarMesa(entMesas mes)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Mesa_Editar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMesa", mes.IdMesa);
                cmd.Parameters.AddWithValue("@numero", mes.Numero);
                cmd.Parameters.AddWithValue("@capacidad", mes.Capacidad);
                cmd.Parameters.AddWithValue("@ubicacion", UbicacionOrNull(mes.Ubicacion));
                cmd.Parameters.AddWithValue("@estado", mes.Estado);
                cn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                throw Traducir(e);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
        }

        public Boolean DeshabilitarMesa(entMesas mes)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Mesa_Deshabilitar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMesa", mes.IdMesa);
                cn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                throw Traducir(e);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
        }
        #endregion metodos

        #region auxiliares
        private static object UbicacionOrNull(string ubicacion)
        {
            return string.IsNullOrWhiteSpace(ubicacion) ? (object)DBNull.Value : ubicacion.Trim();
        }

        // 2627 / 2601 = violación de UNIQUE (número de mesa repetido)
        private static Exception Traducir(SqlException e)
        {
            if (e.Number == 2627 || e.Number == 2601)
                return new Exception("Ya existe una mesa con ese número.");
            return e;
        }
        #endregion auxiliares
    }
}
