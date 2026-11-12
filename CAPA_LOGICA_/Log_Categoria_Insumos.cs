using System.Collections.Generic;
using CAPA_ENTDIDAD_;
using CAPA_DATOS_;

namespace CAPA_LOGICA_
{
    public class log_Categori_Insumos
    {
        private static readonly log_Categori_Insumos _instancia = new log_Categori_Insumos();
        public static log_Categori_Insumos Instancia
        {
            get { return log_Categori_Insumos._instancia; }
        }

        public List<ent_Categori_Insumos> ListarCategoriaInsumos()
        {
            return dat_Categori_Insumos.Instancia.ListarCategoriaInsumos();
        }

        public void InsertaCategoriaInsumos(ent_Categori_Insumos cat)
        {
            dat_Categori_Insumos.Instancia.InsertarCategoriaInsumos(cat);
        }

        public void EditaCategoriaInsumos(ent_Categori_Insumos cat)
        {
            dat_Categori_Insumos.Instancia.EditarCategoriaInsumos(cat);
        }

        public void DeshabilitarCategoriaInsumos(ent_Categori_Insumos cat)
        {
            dat_Categori_Insumos.Instancia.DeshabilitarCategoriaInsumos(cat);
        }
    }
}