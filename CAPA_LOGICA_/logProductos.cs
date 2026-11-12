using CAPA_DATOS_;
using CAPA_ENTDIDAD_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_LOGICA_
{
    public class logProductos
    {
        #region singleton
        private static readonly logProductos _instancia = new logProductos();
        public static logProductos Instancia
        {
            get { return logProductos._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entProductos> ListarProducto(Boolean soloActivos)
        {
            return datProductos.Instancia.ListarProducto(soloActivos);
        }

        public List<ent_Categoria_Productos> ListarCategoriaProducto()
        {
            return dat_Categoria_Productos.Instancia.ListarCategoriaProducto();
        }

        
        private void Validar(entProductos p)
        {
            if (string.IsNullOrWhiteSpace(p.codigo)) throw new ApplicationException("Ingrese el código del producto.");
            if (string.IsNullOrWhiteSpace(p.nombre)) throw new ApplicationException("Ingrese el nombre del producto.");
            if (p.precio < 0) throw new ApplicationException("El precio no puede ser negativo.");
            if (p.idCategoriaProducto <= 0) throw new ApplicationException("Seleccione una categoría.");
        }

        public Boolean InsertaProducto(entProductos p)
        {
            Validar(p);
            return datProductos.Instancia.InsertarProducto(p);
        }

        public Boolean EditaProducto(entProductos p)
        {
            Validar(p);
            return datProductos.Instancia.EditarProducto(p);
        }

        public Boolean DeshabilitarProducto(entProductos p)
        {
            return datProductos.Instancia.DeshabilitarProducto(p);
        }
        #endregion metodos
    }
}

