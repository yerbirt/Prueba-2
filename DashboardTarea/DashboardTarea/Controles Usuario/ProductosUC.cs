using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardTarea.Controles_Usuario
{
    public partial class ProductosUC : UserControl
    {
        public ProductosUC(String seleccion)
        {
            InitializeComponent();

            List<Utilidades.ProductosVO> datosProductos;
            datosProductos = BLL.BLLConsultas.ConsultarProductos(seleccion);

            //Estructura
            List<string> x1 = new List<string>();
            List<int> y1 = new List<int>();

            for(int i = 0; i < datosProductos.Count; i++)
            {
                x1.Add(datosProductos[i].Nombre);
                y1.Add(datosProductos[i].Cantidad);
            }
            //Agregamos datos
            chart1.Series["Cantidad de Producto"].Points.DataBindXY(x1.ToArray(), y1.ToArray());

            //Areas
            chart1.ChartAreas[0].AxisX.Title = "Producto";
            chart1.ChartAreas[0].AxisY.Title = "Cantidad";

            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
