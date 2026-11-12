using CAPA_ENTDIDAD_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS_
{
    public class dat_Categoria_Productos
    {
        #region sigleton
        private static readonly dat_Categoria_Productos _instancia = new dat_Categoria_Productos();
        public static dat_Categoria_Productos Instancia
        {
            get { return dat_Categoria_Productos._instancia; }
        }
        #endregion singleton

        #region metodos
       
        public List<ent_Categoria_Productos> ListarCategoriaProducto()
        {
            SqlCommand cmd = null;
            List<ent_Categoria_Productos> lista = new List<ent_Categoria_Productos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_CategoriaProducto_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ent_Categoria_Productos Cat = new ent_Categoria_Productos();
                    Cat.idCategoriaProducto = Convert.ToInt32(dr["idCategoriaProducto"]);
                    Cat.nombre = dr["nombre"].ToString();
                    Cat.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(Cat);
                }
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return lista;
        }

  
        public Boolean InsertarCategoriaProducto(ent_Categoria_Productos Cat)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_CategoriaProducto_Insertar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Cat.nombre);
                cn.Open();
                object id = cmd.ExecuteScalar();
                if (id != null) { inserta = true; }
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return inserta;
        }

        
        public Boolean EditarCategoriaProducto(ent_Categoria_Productos Cat)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_CategoriaProducto_Editar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCategoriaProducto", Cat.idCategoriaProducto);
                cmd.Parameters.AddWithValue("@nombre", Cat.nombre);
                cmd.Parameters.AddWithValue("@estado", Cat.estado);
                cn.Open();
                cmd.ExecuteNonQuery();
                edita = true;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return edita;
        }

     
        public Boolean DeshabilitarCategoriaProducto(ent_Categoria_Productos Cat)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_CategoriaProducto_Deshabilitar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCategoriaProducto", Cat.idCategoriaProducto);
                cn.Open();
                cmd.ExecuteNonQuery();
                delete = true;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return delete;
        }
        #endregion metodos
    }
}
