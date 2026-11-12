using System;

namespace CAPA_ENTDIDAD_
{
    public class entInsumos
    {
        public int idInsumo { get; set; }
        public int idCategoriaInsumo { get; set; }
        public string categoria { get; set; } 
        public string descripcion { get; set; }
        public decimal stock { get; set; }
        public string unidadMedida { get; set; }
        public Boolean estado { get; set; }
    }
}