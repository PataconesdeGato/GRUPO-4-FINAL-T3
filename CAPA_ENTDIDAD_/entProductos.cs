using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTDIDAD_
{
    public class entProductos
    {
        public int idProducto { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public int idCategoriaProducto { get; set; }
        public string categoria { get; set; }      
        public Boolean estado { get; set; }
    }
}
