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
    public partial class HistorialUC : UserControl
    {
        public HistorialUC(String seleccion)
        {
            InitializeComponent();

            dGVHistorial.DataSource = BLL.BLLConsultas.ConsultaHistorial(seleccion);
        }

        private void dGVHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
