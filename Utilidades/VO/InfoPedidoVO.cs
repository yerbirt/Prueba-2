using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
   public class InfoPedidoVO
    {
        #region Atributos
        private string nombreContacto;
        private string nombrePoducto;
        private int conteo;

        #endregion

        #region constructor
        public InfoPedidoVO()
        {
        }

        #endregion

        #region Popiedades
        public string NombreContacto { get => nombreContacto; set => nombreContacto = value; }
        public string NombrePoducto { get => nombrePoducto; set => nombrePoducto = value; }
        public int Conteo { get => conteo; set => conteo = value; }

        #endregion
    }
}
