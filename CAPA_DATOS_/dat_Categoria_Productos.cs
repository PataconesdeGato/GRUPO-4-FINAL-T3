using CAPA_ENTDIDAD_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CAPA_ENTDIDAD_.ent_Categoria_Productos;

namespace CAPA_DATOS_
{
    public class dat_Categoria_Productos
    {
        #region singleton
        private static readonly dat_Categoria_Productos _instancia = new dat_Categoria_Productos();
        public static dat_Categoria_Productos Instancia
        {
            get { return dat_Categoria_Productos._instancia; }
        }
        #endregion singleton

        #region metodos
        ////////////////////categorías activas (para el ComboBox)
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
                    ent_Categoria_Productos c = new ent_Categoria_Productos();
                    c.idCategoriaProducto = Convert.ToInt32(dr["idCategoriaProducto"]);
                    c.nombre = dr["nombre"].ToString();
                    c.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(c);
                }
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return lista;
        }

        #endregion metodos
    }
}
