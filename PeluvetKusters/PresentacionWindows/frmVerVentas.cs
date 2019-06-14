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
    public partial class frmVerVentas : Form
    {
        frmVentas ventas;
        frmGanancias ganancias;
        List<Venta> ListalocalVentas;


        public frmVerVentas()
        {
            InitializeComponent();
            cargarVentasHoy();            
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {                       
                if (ventas == null)
                {
                    ventas = new frmVentas();
                    ventas.MdiParent = this.MdiParent;
                    ventas.FormClosed += new FormClosedEventHandler(VentasFormClosed);
                    ventas.Show();
                }
            }

            private void VentasFormClosed(object sender, EventArgs e)
            {
                ventas = null;
            }       

        private void btnVerVentasHoy_Click(object sender, EventArgs e)
        {
            cargarVentasHoy();
        }
        private void cargarVentasHoy()
        {
            VentaNegocio negocio = new VentaNegocio();
            ListalocalVentas = new List<Venta>();

            ListalocalVentas = negocio.ListarVentasHOY();
            dgvVentas.DataSource = ListalocalVentas;
            dgvVentas.Columns[4].Visible = false;
        }

        private void btnRecaudacionXmes_Click(object sender, EventArgs e)
        {
            if(ganancias == null)
            {
                ganancias = new frmGanancias();
                ganancias.MdiParent = this.MdiParent;
                ganancias.FormClosed += new FormClosedEventHandler(GananciasFormClosed);
                ganancias.Show();
            }
        }

        private void GananciasFormClosed(object sender, EventArgs e)
        {
            ganancias = null;
        }

        private void btnVerTodas_Click(object sender, EventArgs e)
        {
            VentaNegocio negocio = new VentaNegocio();
            ListalocalVentas = new List<Venta>();

            ListalocalVentas = negocio.ListarVentas();
            dgvVentas.DataSource = ListalocalVentas;
            dgvVentas.Columns[4].Visible = false;
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            txtFecha.Text = dtpFecha.Text;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtFecha.Text == "")
            {
                MessageBox.Show("Debe seleccionar una fecha", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                VentaNegocio negocio = new VentaNegocio();
                ListalocalVentas = new List<Venta>();
                ListalocalVentas = negocio.listarVentasXFecha(txtFecha.Text);
                dgvVentas.DataSource = ListalocalVentas;
                dgvVentas.Columns[4].Visible = false;
            }         
        }
    }
}
