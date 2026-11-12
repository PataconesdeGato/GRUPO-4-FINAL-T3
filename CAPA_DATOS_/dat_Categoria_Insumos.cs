using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CAPA_ENTDIDAD_;

namespace CAPA_DATOS_
{
    public class dat_Categori_Insumos
    {
        private static readonly dat_Categori_Insumos _instancia = new dat_Categori_Insumos();
        public static dat_Categori_Insumos Instancia
        {
            get { return dat_Categori_Insumos._instancia; }
        }

        public List<ent_Categori_Insumos> ListarCategoriaInsumos()
        {
            SqlCommand cmd = null;
            List<ent_Categori_Insumos> lista = new List<ent_Categori_Insumos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_CategoriaInsumo_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ent_Categori_Insumos cat = new ent_Categori_Insumos();
                    cat.idCategoriaInsumo = Convert.ToInt32(dr["idCategoriaInsumo"]);
                    cat.descripcion = dr["descripcion"].ToString();
                    cat.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(cat);
                }
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return lista;
        }

        public Boolean InsertarCategoriaInsumos(ent_Categori_Insumos cat)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_CategoriaInsumo_Insertar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", cat.descripcion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) inserta = true;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean EditarCategoriaInsumos(ent_Categori_Insumos cat)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_CategoriaInsumo_Editar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCategoriaInsumo", cat.idCategoriaInsumo);
                cmd.Parameters.AddWithValue("@descripcion", cat.descripcion);
                cmd.Parameters.AddWithValue("@estado", cat.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) edita = true;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return edita;
        }

        public Boolean DeshabilitarCategoriaInsumos(ent_Categori_Insumos cat)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_CategoriaInsumo_Deshabilitar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCategoriaInsumo", cat.idCategoriaInsumo);
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