using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS_;
using CAPA_ENTDIDAD_;

namespace CAPA_LOGICA_
{
    public class logMesas
    {
        #region singleton
        // Patrón Singleton
        private static readonly logMesas _instancia = new logMesas();

        public static logMesas Instancia
        {
            get
            {
                return logMesas._instancia;
            }
        }
        #endregion singleton

        #region metodos

        // Listado de Mesas
        public List<entMesas> ListarMesa()
        {
            return datMesas.Instancia.ListarMesa();
        }

        public void InsertaMesa(entMesas mes)
        {
            datMesas.Instancia.InsertarMesa(mes);
        }

        public void EditaMesa(entMesas mes)
        {
            datMesas.Instancia.EditarMesa(mes);
        }

        public void DeshabilitarMesa(entMesas mes)
        {
            datMesas.Instancia.DeshabilitarMesa(mes);
        }

        #endregion metodos
    }
}
