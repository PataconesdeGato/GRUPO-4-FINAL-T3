using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CAPA_ENTDIDAD_;

namespace CAPA_DATOS_
{
    public class datInsumos
    {
        private static readonly datInsumos _instancia = new datInsumos();
        public static datInsumos Instancia
        {
            get { return datInsumos._instancia; }
        }

        public List<entInsumos> ListarInsumos()
        {
            SqlCommand cmd = null;
            List<entInsumos> lista = new List<entInsumos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Insumo_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entInsumos ins = new entInsumos();
                    ins.idInsumo = Convert.ToInt32(dr["idInsumo"]);
                    ins.idCategoriaInsumo = Convert.ToInt32(dr["idCategoriaInsumo"]);
                    ins.categoria = dr["categoria"].ToString(); // Si tu SP cruza datos
                    ins.descripcion = dr["descripcion"].ToString();
                    ins.stock = Convert.ToDecimal(dr["stock"]);
                    ins.unidadMedida = dr["unidadMedida"].ToString();
                    ins.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(ins);
                }
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return lista;
        }

        public Boolean InsertarInsumos(entInsumos ins)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Insumo_Insertar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCategoriaInsumo", ins.idCategoriaInsumo);
                cmd.Parameters.AddWithValue("@descripcion", ins.descripcion);
                cmd.Parameters.AddWithValue("@stock", ins.stock);
                cmd.Parameters.AddWithValue("@unidadMedida", ins.unidadMedida);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) inserta = true;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean EditarInsumos(entInsumos ins)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Insumo_Editar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idInsumo", ins.idInsumo);
                cmd.Parameters.AddWithValue("@idCategoriaInsumo", ins.idCategoriaInsumo);
                cmd.Parameters.AddWithValue("@descripcion", ins.descripcion);
                cmd.Parameters.AddWithValue("@stock", ins.stock);
                cmd.Parameters.AddWithValue("@unidadMedida", ins.unidadMedida);
                cmd.Parameters.AddWithValue("@estado", ins.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) edita = true;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return edita;
        }

        public Boolean DeshabilitarInsumos(entInsumos ins)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Insumo_Deshabilitar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idInsumo", ins.idInsumo);
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