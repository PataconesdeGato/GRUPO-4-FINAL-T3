using System;

namespace CAPA_ENTDIDAD_
{
    public class entRecetas
    {
        public int idReceta { get; set; }
        public int idProducto { get; set; }
        public string producto { get; set; } 
        public string descripcion { get; set; }
        public Boolean estado { get; set; }
    }
}