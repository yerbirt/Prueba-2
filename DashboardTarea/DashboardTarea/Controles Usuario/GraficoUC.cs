using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;

namespace DashboardTarea.Controles_Usuario
{

    public partial class GraficoUC : UserControl
    {
        private String elec;
        public string Elec { get => elec; set => elec = value; }

        public GraficoUC(String seleccion)
        {
            InitializeComponent();
            
            dGV1.DataSource = BLL.BLLConsultas.RealizarConsultaComboBox(seleccion);

        }


        private void dGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public static void seleccion(String seleccion)
        {
             
        }
    }


}
