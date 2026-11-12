using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CAPA_ENTDIDAD_;

namespace CAPA_DATOS_
{
    public class datRecetas
    {
        private static readonly datRecetas _instancia = new datRecetas();
        public static datRecetas Instancia
        {
            get { return datRecetas._instancia; }
        }

        public List<entRecetas> ListarRecetas()
        {
            SqlCommand cmd = null;
            List<entRecetas> lista = new List<entRecetas>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Receta_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRecetas rec = new entRecetas();
                    rec.idReceta = Convert.ToInt32(dr["idReceta"]);
                    rec.idProducto = Convert.ToInt32(dr["idProducto"]);
                    rec.producto = dr["producto"].ToString();
                    rec.descripcion = dr["descripcion"].ToString();
                    rec.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(rec);
                }
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return lista;
        }

        public Boolean InsertarRecetas(entRecetas rec)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Receta_Insertar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", rec.idProducto);
                cmd.Parameters.AddWithValue("@descripcion", rec.descripcion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) inserta = true;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean EditarRecetas(entRecetas rec)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Receta_Editar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idReceta", rec.idReceta);
                cmd.Parameters.AddWithValue("@descripcion", rec.descripcion);
                cmd.Parameters.AddWithValue("@estado", rec.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) edita = true;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return edita;
        }

        public Boolean DeshabilitarRecetas(entRecetas rec)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Receta_Deshabilitar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idReceta", rec.idReceta);
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