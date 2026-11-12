using System.Collections.Generic;
using CAPA_ENTDIDAD_;
using CAPA_DATOS_;

namespace CAPA_LOGICA_
{
    public class logCliente
    {
        private static readonly logCliente _instancia = new logCliente();
        public static logCliente Instancia
        {
            get { return logCliente._instancia; }
        }

        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }

        public void InsertaCliente(entCliente cli)
        {
            datCliente.Instancia.InsertarCliente(cli);
        }

        public void EditaCliente(entCliente cli)
        {
            datCliente.Instancia.EditarCliente(cli);
        }

        public void DeshabilitarCliente(entCliente cli)
        {
            datCliente.Instancia.DeshabilitarCliente(cli);
        }
    }
}