using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTDIDAD_
{
    public class entInsumos
    {
        public int idInsumo { get; set; }
        public string nombreInsumo { get; set; }
        public decimal stockInsumo { get; set; }
        public decimal precioInsumo { get; set; }
        public bool estInsumo { get; set; }
        public DateTime fecRegInsumo { get; set; }
    }
}
