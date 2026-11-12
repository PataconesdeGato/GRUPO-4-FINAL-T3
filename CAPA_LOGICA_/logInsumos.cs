using System.Collections.Generic;
using CAPA_ENTDIDAD_;
using CAPA_DATOS_;

namespace CAPA_LOGICA_
{
    public class logInsumos
    {
        private static readonly logInsumos _instancia = new logInsumos();
        public static logInsumos Instancia
        {
            get { return logInsumos._instancia; }
        }

        public List<entInsumos> ListarInsumos()
        {
            return datInsumos.Instancia.ListarInsumos();
        }

        public void InsertaInsumos(entInsumos ins)
        {
            datInsumos.Instancia.InsertarInsumos(ins);
        }

        public void EditaInsumos(entInsumos ins)
        {
            datInsumos.Instancia.EditarInsumos(ins);
        }

        public void DeshabilitarInsumos(entInsumos ins)
        {
            datInsumos.Instancia.DeshabilitarInsumos(ins);
        }
    }
}