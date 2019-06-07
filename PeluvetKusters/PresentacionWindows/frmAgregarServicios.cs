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
    public partial class frmAgregarServicios : Form
    {
        public frmAgregarServicios()
        {
            InitializeComponent();
            cargarGrilla();
        }

        private void lblNombreAlta_Click(object sender, EventArgs e)
        {        }


        private void cargarGrilla()
        {
            ServicioNegocio negocio = new ServicioNegocio();

            dgvServicios.DataSource = negocio.ListarServicios();
            dgvServicios.Columns[0].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if(txtDescripcionAlta.Text=="" || txtPrecioAlta.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Servicio nuevo = new Servicio();
                ServicioNegocio negocio = new ServicioNegocio();

                nuevo.descripcion = txtDescripcionAlta.Text;
                nuevo.precio = decimal.Parse(txtPrecioAlta.Text);

                negocio.agregarServicio(nuevo);
                cargarGrilla();
            }
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Servicio modificar = new Servicio();

            modificar = (Servicio)dgvServicios.CurrentRow.DataBoundItem;

            txtIdMod.Text = modificar.id.ToString();
            txtDescripcionMod.Text = modificar.descripcion;
            txtPrecioMod.Text = modificar.precio.ToString();

            txtDescripcionMod.Enabled = true;
            txtPrecioMod.Enabled = true;
        }

        private void btnAceptarMod_Click(object sender, EventArgs e)
        {
            Servicio modificado = new Servicio();
            ServicioNegocio negocio = new ServicioNegocio();

            modificado.id = int.Parse(txtIdMod.Text);
            modificado.descripcion = txtDescripcionMod.Text;
            modificado.precio = decimal.Parse(txtPrecioMod.Text);

            negocio.ModificarServicio(modificado);

            txtIdMod.Text = "";
            txtDescripcionMod.Text = "";
            txtPrecioMod.Text = "";
            txtDescripcionMod.Enabled = false;
            txtPrecioMod.Enabled = false;

            cargarGrilla();
        }

        private void btnCancelarMod_Click(object sender, EventArgs e)
        {

        }
    }
}
