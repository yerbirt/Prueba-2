using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace DAL_SQLServer
{
    public class ConsultaSQL
    {
        public static void AbrirConexion()
        {
            //cadena de conexion
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            try
            {
                conn.Open();
                Console.WriteLine("Conexión abierta");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error de conexión");
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexión cerrada");
            }
        }

        public static List<InfoClienteVO> RealizarConsultaClientes()
        {
            //cadena de conexion
            SqlConnection conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand command;

            //Consulta
            String consulta = @"select * from dbo.Customers";

            //objeto para lectura de datos
            SqlDataReader datos;

            try
            {
                conexion.Open();
                command = new SqlCommand(consulta, conexion);

                //ejecutar la consulta
                datos = command.ExecuteReader();

                List<InfoClienteVO> clientes = new List<InfoClienteVO>();

                while (datos.Read())
                {
                    InfoClienteVO cliente = new InfoClienteVO();

                    //Parseamos los datos
                    cliente.IdCliente = datos.GetValue(0).ToString();
                    cliente.NombreEmpresas = datos.GetValue(1).ToString();
                    cliente.NombreContacto = datos.GetValue(2).ToString();
                    cliente.CategoriaContacto = datos.GetValue(3).ToString();
                    cliente.Direccion = datos.GetValue(4).ToString();
                    cliente.Ciudad = datos.GetValue(5).ToString();
                    cliente.Region = datos.GetValue(6).ToString();
                    cliente.CodigoPostal = datos.GetValue(7).ToString();
                    cliente.Pais = datos.GetValue(8).ToString();
                    cliente.Telefono = datos.GetValue(9).ToString();
                    cliente.Fax = datos.GetValue(10).ToString();

                    clientes.Add(cliente);

                }
                datos.Close();

                return clientes;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public static List<InfoClienteVO> RealizarConsultaComboBox(String seleccion)
        {
            //cadena de conexion
            SqlConnection conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand command;

            //Consulta
            String consulta = @"select * from dbo.Customers where ContactName = '" + seleccion + "'";

            //objeto para lectura de datos
            SqlDataReader datos;

            try
            {
                conexion.Open();
                command = new SqlCommand(consulta, conexion);

                //ejecutar la consulta
                datos = command.ExecuteReader();

                List<InfoClienteVO> clientes = new List<InfoClienteVO>();

                while (datos.Read())
                {
                    InfoClienteVO cliente = new InfoClienteVO();

                    //Parseamos los datos
                    cliente.IdCliente = datos.GetValue(0).ToString();
                    cliente.NombreEmpresas = datos.GetValue(1).ToString();
                    cliente.NombreContacto = datos.GetValue(2).ToString();
                    cliente.CategoriaContacto = datos.GetValue(3).ToString();
                    cliente.Direccion = datos.GetValue(4).ToString();
                    cliente.Ciudad = datos.GetValue(5).ToString();
                    cliente.Region = datos.GetValue(6).ToString();
                    cliente.CodigoPostal = datos.GetValue(7).ToString();
                    cliente.Pais = datos.GetValue(8).ToString();
                    cliente.Telefono = datos.GetValue(9).ToString();
                    cliente.Fax = datos.GetValue(10).ToString();

                    clientes.Add(cliente);

                }
                datos.Close();

                return clientes;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public static List<InfoClienteVO> FiltrarCiudad(String seleccion)
        {
            //cadena de conexion
            SqlConnection conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand command;

            //Consulta
            String consulta = @"select * from dbo.Customers where City = '" + seleccion + "'";

            //objeto para lectura de datos
            SqlDataReader datos;

            try
            {
                conexion.Open();
                command = new SqlCommand(consulta, conexion);

                //ejecutar la consulta
                datos = command.ExecuteReader();

                List<InfoClienteVO> clientes = new List<InfoClienteVO>();

                while (datos.Read())
                {
                    InfoClienteVO cliente = new InfoClienteVO();

                    //Parseamos los datos
                    cliente.IdCliente = datos.GetValue(0).ToString();
                    cliente.NombreEmpresas = datos.GetValue(1).ToString();
                    cliente.NombreContacto = datos.GetValue(2).ToString();
                    cliente.CategoriaContacto = datos.GetValue(3).ToString();
                    cliente.Direccion = datos.GetValue(4).ToString();
                    cliente.Ciudad = datos.GetValue(5).ToString();
                    cliente.Region = datos.GetValue(6).ToString();
                    cliente.CodigoPostal = datos.GetValue(7).ToString();
                    cliente.Pais = datos.GetValue(8).ToString();
                    cliente.Telefono = datos.GetValue(9).ToString();
                    cliente.Fax = datos.GetValue(10).ToString();

                    clientes.Add(cliente);

                }
                datos.Close();

                return clientes;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public static List<InfoPedidoVO> ConsultaPedidos(String seleccion)
        {
            //cadena de conexion
            SqlConnection conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand command;

            //Consulta
            String consulta = @"select ContactName, ProductName, count(2) Conteo from dbo.Customers a cross join Orders b cross join dbo.[Order Details] c cross join dbo.Products d 
                                where ContactName = '" + seleccion + "'group by ContactName, ProductName order by ContactName, ProductName offset 0 rows fetch next 3 rows only;";

            //objeto para lectura de datos
            SqlDataReader datos;

            try
            {
                conexion.Open();
                command = new SqlCommand(consulta, conexion);

                //ejecutar la consulta
                datos = command.ExecuteReader();

                List<InfoPedidoVO> pedidos = new List<InfoPedidoVO>();

                while (datos.Read())
                {
                    InfoPedidoVO pedido = new InfoPedidoVO();

                    //Parseamos los datos
                    pedido.NombreContacto = datos.GetValue(0).ToString();
                    pedido.NombrePoducto = datos.GetValue(1).ToString();
                    pedido.Conteo = (int)Int64.Parse(datos.GetValue(2).ToString());

                    pedidos.Add(pedido);

                }
                datos.Close();

                return pedidos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public static List<HistorialVO> ConsultaHistorial(String seleccion) {

            //cadena de conexion
            SqlConnection conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand command;

            //Consulta
            String consulta = @"select distinct d.ProductID, d.UnitPrice, Quantity, OrderDate, ShippedDate from [Order Details] a cross join Orders b cross join Customers c cross join Products d  where ContactName = '" + seleccion + "' order by Quantity offset 0 rows fetch next 1000 rows only;";
            //objeto para lectura de datos
            SqlDataReader datos;

            try
            {
                conexion.Open();
                command = new SqlCommand(consulta, conexion);

                //ejecutar la consulta
                datos = command.ExecuteReader();

                List<HistorialVO> historial = new List<HistorialVO>();

                while (datos.Read())
                {
                    HistorialVO h = new HistorialVO();

                    //Parseamos los datos
                    h.IdProducto = datos.GetValue(0).ToString();
                    h.PrecioUnidad = datos.GetValue(1).ToString();
                    h.Cantidad = datos.GetValue(2).ToString();
                    h.FechaPedido = datos.GetValue(3).ToString();
                    h.LlegadaPedido = datos.GetValue(4).ToString();

                    historial.Add(h);

                }
                datos.Close();

                return historial;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public static List<ProductosVO> ConsultarProductos(String seleccion)
        {
            //cadena de conexion
            SqlConnection conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand command;

            //Consulta
            String consulta = @"select  ProductName, COUNT(Quantity) from [Order Details] cross join Customers  cross join Products where ContactName = '" + seleccion + "'  group by ProductName, Quantity ";
            //objeto para lectura de datos
            SqlDataReader datos;

            try
            {
                conexion.Open();
                command = new SqlCommand(consulta, conexion);

                //ejecutar la consulta
                datos = command.ExecuteReader();

                List<ProductosVO> produc = new List<ProductosVO>();

                while (datos.Read())
                {
                    ProductosVO p = new ProductosVO();

                    //Parseamos los datos
                    p.Nombre = datos.GetValue(0).ToString();
                    p.Cantidad = (int)Int64.Parse(datos.GetValue(1).ToString());


                    produc.Add(p);

                }
                datos.Close();

                return produc;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conexion.Close();
            }
    }

    }
}
