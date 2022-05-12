using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class HistorialVO
    {
        #region Atributos
        private string idProducto;
        private string precioUnidad;
        private string cantidad;
        private string fechaPedido;
        private string llegadaPedido;

        #endregion

        #region Constructor
        public HistorialVO()
        {
        }

        #endregion

        #region Propiedades
        public string IdProducto { get => idProducto; set => idProducto = value; }
        public string PrecioUnidad { get => precioUnidad; set => precioUnidad = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
        public string FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public string LlegadaPedido { get => llegadaPedido; set => llegadaPedido = value; }


        #endregion
    }
}
