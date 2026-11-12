using System.Collections.Generic;
using CAPA_ENTDIDAD_;
using CAPA_DATOS_;

namespace CAPA_LOGICA_
{
    public class logEmpleado
    {
        // Patrón Singleton
        private static readonly logEmpleado _instancia = new logEmpleado();
        public static logEmpleado Instancia
        {
            get { return logEmpleado._instancia; }
        }

        public List<entEmpleado> ListarEmpleado()
        {
            return datEmpleado.Instancia.ListarEmpleado();
        }

        public void InsertaEmpleado(entEmpleado Emp)
        {
            datEmpleado.Instancia.InsertarEmpleado(Emp);
        }

        public void EditaEmpleado(entEmpleado Emp)
        {
            datEmpleado.Instancia.EditarEmpleado(Emp);
        }

        public void DeshabilitarEmpleado(entEmpleado Emp)
        {
            datEmpleado.Instancia.DeshabilitarEmpleado(Emp);
        }
    }
}