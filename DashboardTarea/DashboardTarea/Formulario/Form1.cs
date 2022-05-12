using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_SQLServer;
using Utilidades;

namespace DashboardTarea
{
    public partial class Form1 : Form
    {
        private TableLayoutPanel tlp;
        private TableLayoutPanel tlp2;
        private UserControl dgv;
        private UserControl inf;
        public Form1()
        {
            InitializeComponent();

            tlp = tableLayoutPanel3;
            tlp2 = tLPInfo;


            List<InfoClienteVO> datosClientes;
            datosClientes = BLL.BLLConsultas.RealizarConsultaClientes();

            for(int i = 0; i<datosClientes.Count;i++) {
                cBoxSeleccion.Items.Add(datosClientes[i].NombreContacto);
            }

            for (int i = 0; i < datosClientes.Count; i++)
            {
                comboBoxCiudad.Items.Add(datosClientes[i].Ciudad);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tlp.Controls.Remove(dgv);
            tlp2.Controls.Remove(inf);
            string seleccion = cBoxSeleccion.Text;
            inf = new Controles_Usuario.InfoUC(seleccion);

            //tlp.Controls.Add(dgv, 1, 1);
            tlp2.Controls.Add(inf, 0, 0);

            btInfo1.Visible = true;
            btInfo2.Visible = true;
            btInfo3.Visible = true;
            button1.Visible = true;
            buttonInforme.Visible = true;



        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cBoxSeleccion.Items.Clear();
            string seleccion = comboBoxCiudad.Text;
            List<InfoClienteVO> datosSeleccion;
            datosSeleccion = BLL.BLLConsultas.FiltrarCiudad(seleccion);

            for (int i = 0; i < datosSeleccion.Count; i++)
            {
                cBoxSeleccion.Items.Add(datosSeleccion[i].NombreContacto);
            }
        }

        private void tLPInfo_Paint(object sender, PaintEventArgs e)
        {
            //tlp.Controls.Remove(dgv);
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btInfo1_Click(object sender, EventArgs e)
        {
            string seleccion = cBoxSeleccion.Text;
            dgv = new Controles_Usuario.GraficoUC(seleccion);

            tlp.Controls.Add(dgv, 1, 1);
        }

        private void btInfo2_Click(object sender, EventArgs e)
        {
            tlp.Controls.Remove(dgv);
            string seleccion = cBoxSeleccion.Text;
            dgv = new Controles_Usuario.GraficoPedidosUC(seleccion);


            tlp.Controls.Add(dgv, 1, 1);
        }

        private void btInfo3_Click(object sender, EventArgs e)
        {
            tlp.Controls.Remove(dgv);
            string seleccion = cBoxSeleccion.Text;
            dgv = new Controles_Usuario.HistorialUC(seleccion);


            tlp.Controls.Add(dgv, 1, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tlp.Controls.Remove(dgv);
            string seleccion = cBoxSeleccion.Text;
            dgv = new Controles_Usuario.ProductosUC(seleccion);


            tlp.Controls.Add(dgv, 1, 1);
        }

        private void buttonInforme_Click(object sender, EventArgs e)
        {

        }
    }
}
