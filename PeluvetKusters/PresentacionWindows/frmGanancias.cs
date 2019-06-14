using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace PresentacionWindows
{
    public partial class frmGanancias : Form
    {
        public frmGanancias()
        {
            InitializeComponent();
            cargarGrilla();
            GananciasHoy();
        }

        private void cargarGrilla()
        {
            GananciasXMesNegocio negocio = new GananciasXMesNegocio();

            dgvGananciasXmes.DataSource = negocio.ListarGananciasPorMes();
            dgvGananciasXmes.Columns[1].Visible = false;
        }

        private void GananciasHoy()
        {            
            VentaNegocio negocio = new VentaNegocio();

            decimal totalRecaudacion;
            decimal Costos;

            totalRecaudacion = negocio.CalcularRecaudacionHOY();
            Costos = negocio.traerCostoHOY();

            totalRecaudacion = totalRecaudacion - Costos;

            txtGananciasHoy.Text = totalRecaudacion.ToString();            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
