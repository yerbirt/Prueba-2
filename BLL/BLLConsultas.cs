using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace BLL
{
    public class BLLConsultas
    {
        public static List<InfoClienteVO> RealizarConsultaClientes()
        {
            return DAL_SQLServer.ConsultaSQL.RealizarConsultaClientes();
        }

        public static List<InfoClienteVO> RealizarConsultaComboBox(String seleccion)
        {
            return DAL_SQLServer.ConsultaSQL.RealizarConsultaComboBox(seleccion);
        }

        public static List<InfoClienteVO> FiltrarCiudad(String seleccion)
        {
            return DAL_SQLServer.ConsultaSQL.FiltrarCiudad(seleccion);
        }

        public static List<InfoPedidoVO> ConsultaPedidos(String seleccion)
        {
            return DAL_SQLServer.ConsultaSQL.ConsultaPedidos(seleccion);
        }

        public static List<HistorialVO> ConsultaHistorial(String seleccion)
        {
            return DAL_SQLServer.ConsultaSQL.ConsultaHistorial(seleccion);
        }

        public static List<ProductosVO> ConsultarProductos(String seleccion)
        {
            return DAL_SQLServer.ConsultaSQL.ConsultarProductos(seleccion);
        }
    }
}
