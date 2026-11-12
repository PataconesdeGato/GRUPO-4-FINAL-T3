using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CAPA_ENTDIDAD_; // Conectamos con la entidad

namespace CAPA_DATOS_
{
    public class datEmpleado
    {
        // Patrón Singleton
        private static readonly datEmpleado _instancia = new datEmpleado();
        public static datEmpleado Instancia
        {
            get { return datEmpleado._instancia; }
        }

        // 1. Listar
        public List<entEmpleado> ListarEmpleado()
        {
            SqlCommand cmd = null;
            List<entEmpleado> lista = new List<entEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // Asegúrate de tener tu clase Conexion
                cmd = new SqlCommand("mant.usp_Empleado_Listar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEmpleado Emp = new entEmpleado();
                    Emp.idEmpleado = Convert.ToInt32(dr["idEmpleado"]);
                    Emp.dni = dr["dni"].ToString();
                    Emp.nombres = dr["nombres"].ToString();
                    Emp.cargo = dr["cargo"].ToString();
                    Emp.turno = dr["turno"].ToString();
                    Emp.telefono = dr["telefono"].ToString();
                    Emp.correo = dr["correo"].ToString();
                    Emp.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(Emp);
                }
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return lista;
        }

        // 2. Insertar
        public Boolean InsertarEmpleado(entEmpleado Emp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Empleado_Insertar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", Emp.dni);
                cmd.Parameters.AddWithValue("@nombres", Emp.nombres);
                cmd.Parameters.AddWithValue("@cargo", Emp.cargo);
                cmd.Parameters.AddWithValue("@turno", Emp.turno);
                cmd.Parameters.AddWithValue("@telefono", Emp.telefono);
                cmd.Parameters.AddWithValue("@correo", Emp.correo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) inserta = true;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return inserta;
        }

        // 3. Editar
        public Boolean EditarEmpleado(entEmpleado Emp)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Empleado_Editar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", Emp.idEmpleado);
                cmd.Parameters.AddWithValue("@dni", Emp.dni);
                cmd.Parameters.AddWithValue("@nombres", Emp.nombres);
                cmd.Parameters.AddWithValue("@cargo", Emp.cargo);
                cmd.Parameters.AddWithValue("@turno", Emp.turno);
                cmd.Parameters.AddWithValue("@telefono", Emp.telefono);
                cmd.Parameters.AddWithValue("@correo", Emp.correo);
                cmd.Parameters.AddWithValue("@estado", Emp.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) edita = true;
            }
            catch (Exception e) { throw e; }
            finally { if (cmd != null) cmd.Connection.Close(); }
            return edita;
        }

        // 4. Deshabilitar
        public Boolean DeshabilitarEmpleado(entEmpleado Emp)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("mant.usp_Empleado_Deshabilitar", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", Emp.idEmpleado);
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