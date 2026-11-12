using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS_
{
    public class datInsumos
    {
        #region Singleton
        private static readonly datInsumos _instancia = new datInsumos();
        public static datInsumos Instancia => _instancia;
        #endregion

        public List<entInsumos> ListarInsumos()
        {
            SqlCommand cmd = null;
            List<entInsumos> lista = new List<entInsumos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarInsumos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entInsumos ins = new entInsumos();
                    ins.idInsumos = Convert.ToInt32(dr["idInsumo"]);
                    ins.nombreInsumos = dr["nombreInsumo"].ToString();
                    ins.stockInsumos = Convert.ToDecimal(dr["stockInsumo"]);
                    ins.precioInsumos = Convert.ToDecimal(dr["precioInsumo"]);
                    ins.estInsumos = Convert.ToBoolean(dr["estInsumo"]);
                    ins.fecRegInsumos = Convert.ToDateTime(dr["fecRegInsumo"]);
                    lista.Add(ins);
                }
            }
            catch (Exception e) { throw e; }
            finally { cmd?.Connection.Close(); }
            return lista;
        }

        public Boolean InsertarInsumo(entInsumos Ins)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreInsumo", Ins.nombreInsumo);
                cmd.Parameters.AddWithValue("@stockInsumo", Ins.stockInsumo);
                cmd.Parameters.AddWithValue("@precioInsumo", Ins.precioInsumo);
                cmd.Parameters.AddWithValue("@estInsumo", Ins.estInsumo);
                cmd.Parameters.AddWithValue("@fecRegInsumo", Ins.fecRegInsumo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) inserta = true;
            }
            catch (Exception e) { throw e; }
            finally { cmd?.Connection.Close(); }
            return inserta;
        }

        public Boolean EditarInsumo(entInsumos Ins)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idInsumo", Ins.idInsumo);
                cmd.Parameters.AddWithValue("@nombreInsumo", Ins.nombreInsumo);
                cmd.Parameters.AddWithValue("@stockInsumo", Ins.stockInsumo);
                cmd.Parameters.AddWithValue("@precioInsumo", Ins.precioInsumo);
                cmd.Parameters.AddWithValue("@estInsumo", Ins.estInsumo);
                cmd.Parameters.AddWithValue("@fecRegInsumo", Ins.fecRegInsumo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) edita = true;
            }
            catch (Exception e) { throw e; }
            finally { cmd?.Connection.Close(); }
            return edita;
        }

        public Boolean DeshabilitarInsumo(entInsumos Ins)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarInsumo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idInsumo", Ins.idInsumos);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) delete = true;
            }
            catch (Exception e) { throw e; }
            finally { cmd?.Connection.Close(); }
            return delete;
        }
    }
}
