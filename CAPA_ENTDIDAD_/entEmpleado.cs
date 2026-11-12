using System;

namespace CAPA_ENTDIDAD_
{
    public class entEmpleado
    {
        public int idEmpleado { get; set; }
        public string dni { get; set; }
        public string nombres { get; set; }
        public string cargo { get; set; }
        public string turno { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public Boolean estado { get; set; }
    }
}