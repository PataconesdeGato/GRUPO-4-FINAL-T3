using CAPA_DATOS_;
using CAPA_ENTDIDAD_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_LOGICA_
{
    public class Log_Categoria_Productos
    {
        #region sigleton
       
        private static readonly Log_Categoria_Productos _instancia = new Log_Categoria_Productos();
        public static Log_Categoria_Productos Instancia
        {
            get
            {
                return Log_Categoria_Productos._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<ent_Categoria_Productos> ListarCategoriaProducto()
        {
            return dat_Categoria_Productos.Instancia.ListarCategoriaProducto();
        }
        ///inserta
        public void InsertaCategoriaProducto(ent_Categoria_Productos Cat)
        {
            dat_Categoria_Productos.Instancia.InsertarCategoriaProducto(Cat);
        }
        //edita
        public void EditaCategoriaProducto(ent_Categoria_Productos Cat)
        {
            dat_Categoria_Productos.Instancia.EditarCategoriaProducto(Cat);
        }
        public void DeshabilitarCategoriaProducto(ent_Categoria_Productos Cat)
        {
            dat_Categoria_Productos.Instancia.DeshabilitarCategoriaProducto(Cat);
        }
        #endregion metodos
    }
}
