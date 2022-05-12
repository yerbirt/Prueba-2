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
    public partial class GraficoPedidosUC : UserControl
    {
        public GraficoPedidosUC(String seleccion)
        {
            InitializeComponent();

            List<Utilidades.InfoPedidoVO> pedidos = BLL.BLLConsultas.ConsultaPedidos(seleccion);

            tB1.Text = pedidos[0].NombrePoducto;
            tB2.Text = pedidos[1].NombrePoducto;
            tB3.Text = pedidos[2].NombrePoducto;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GraficoPedidosUC_Load(object sender, EventArgs e)
        {

        }
    }
}
