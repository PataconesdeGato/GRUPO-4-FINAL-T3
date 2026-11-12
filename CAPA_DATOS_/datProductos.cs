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
    public class datProductos
    {
        #region singleton
        private static readonly datProductos _instancia = new datProductos();
        public static datProductos Instancia
        {
            get { return datProductos._instancia; }
        }
        #endregion singleton

        #region metodos

        public List<entProductos> ListarProducto(Boolean soloActivos)
        {
            SqlCommand cmd = null;
            List<entProductos> lista = new List<entProductos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Producto_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@soloActivos", soloActivos);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProductos p = new entProductos();
                    p.idProducto = Convert.ToInt32(dr["idProducto"]);
                    p.codigo = dr["codigo"].ToString();
                    p.nombre = dr["nombre"].ToString();
                    p.precio = Convert.ToDecimal(dr["precio"]);
                    p.idCategoriaProducto = Convert.ToInt32(dr["idCategoriaProducto"]);
                    p.categoria = dr["categoria"].ToString();
                    p.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(p);
                }
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return lista;
        }

      
        public Boolean InsertarProducto(entProductos p)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Producto_Insertar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", p.codigo);
                cmd.Parameters.AddWithValue("@nombre", p.nombre);
                cmd.Parameters.AddWithValue("@precio", p.precio);
                cmd.Parameters.AddWithValue("@idCategoriaProducto", p.idCategoriaProducto);
                cn.Open();
                object id = cmd.ExecuteScalar();
                inserta = (id != null);
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return inserta;
        }

 
        public Boolean EditarProducto(entProductos p)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Producto_Editar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", p.idProducto);
                cmd.Parameters.AddWithValue("@codigo", p.codigo);
                cmd.Parameters.AddWithValue("@nombre", p.nombre);
                cmd.Parameters.AddWithValue("@precio", p.precio);
                cmd.Parameters.AddWithValue("@idCategoriaProducto", p.idCategoriaProducto);
                cmd.Parameters.AddWithValue("@estado", p.estado);
                cn.Open();
                cmd.ExecuteNonQuery();
                edita = true;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return edita;
        }

        public Boolean DeshabilitarProducto(entProductos p)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Producto_Deshabilitar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", p.idProducto);
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
