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
    public partial class InfoUC : UserControl

    {
        public InfoUC(String seleccion)
        {
            InitializeComponent();
            List<InfoClienteVO> usuario = BLL.BLLConsultas.RealizarConsultaComboBox(seleccion);
            textBox1.Text = usuario[0].NombreContacto;
            textBox2.Text = usuario[0].Direccion;
        }

        private void InfoUC_Load(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
          
        }
    }
}