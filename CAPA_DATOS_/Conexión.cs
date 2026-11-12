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
            //Conexión de Daniel a la base de datos
            //cn.ConnectionString = "Data Source=DESKTOP-7DBAIV9; Initial Catalog = LaEstampida; Integrated Security=true";

            //Conexión de José a la base de datos
            cn.ConnectionString = "Data Source=DESKTOP-53GBULM; Initial Catalog = LaEstampida; Integrated Security=true";

            return cn;
        }
    }
}
