using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_DATOS_
{
    public class Conexion
    {
        
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-73SOM12; Initial Catalog = LaEstampida; Integrated Security=true";
            return cn;
        }
    }
}
