using System.Collections.Generic;
using CAPA_ENTDIDAD_;
using CAPA_DATOS_;

namespace CAPA_LOGICA_
{
    public class logRecetas
    {
        private static readonly logRecetas _instancia = new logRecetas();
        public static logRecetas Instancia
        {
            get { return logRecetas._instancia; }
        }

        public List<entRecetas> ListarRecetas()
        {
            return datRecetas.Instancia.ListarRecetas();
        }

        public void InsertaRecetas(entRecetas rec)
        {
            datRecetas.Instancia.InsertarRecetas(rec);
        }

        public void EditaRecetas(entRecetas rec)
        {
            datRecetas.Instancia.EditarRecetas(rec);
        }

        public void DeshabilitarRecetas(entRecetas rec)
        {
            datRecetas.Instancia.DeshabilitarRecetas(rec);
        }
    }
}