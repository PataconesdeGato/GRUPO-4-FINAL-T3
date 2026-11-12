using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_LOGICA_
{
    public class logInsumos
    {
        #region Singleton
        private static readonly logInsumos _instancia = new logInsumos();
        public static logInsumos Instancia => _instancia;
        #endregion

        public List<entInsumo> ListarInsumos() => datInsumo.Instancia.ListarInsumos();

        public void InsertaInsumos(entInsumo Ins) => datInsumos.Instancia.InsertarInsumos(Ins);

        public void EditaInsumos(entInsumo Ins) => datInsumos.Instancia.EditarInsumos(Ins);

        public void DeshabilitarInsumos(entInsumo Ins) => datInsumos.Instancia.DeshabilitarInsumos(Ins);
    }
}
