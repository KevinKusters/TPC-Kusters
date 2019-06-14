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
            dgvServicios.Columns[3].Visible = false;

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

                if (rdbPeluqueria.Checked == true)
                {
                    nuevo.rubro = rdbPeluqueria.Text;
                }
                else
                {
                    nuevo.rubro = rdbVeterinaria.Text;
                }

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

            if (modificar.rubro == "Peluqueria")
            {
                rdbPeluqueriaMod.Checked = true;
            }
            else
            {
                rdbVeterinariaMod.Checked = true;
            }


            txtDescripcionMod.Enabled = true;
            txtPrecioMod.Enabled = true;
            rdbPeluqueriaMod.Enabled = true;
            rdbVeterinariaMod.Enabled = true;
        }

        private void btnAceptarMod_Click(object sender, EventArgs e)
        {
            Servicio modificado = new Servicio();
            ServicioNegocio negocio = new ServicioNegocio();

            modificado.id = int.Parse(txtIdMod.Text);
            modificado.descripcion = txtDescripcionMod.Text;
            modificado.precio = decimal.Parse(txtPrecioMod.Text);

            if(rdbPeluqueriaMod.Checked == true)
            {
                modificado.rubro = rdbPeluqueriaMod.Text;
            }
            else
            {
                modificado.rubro = rdbVeterinariaMod.Text;
            }

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Servicio eliminar = new Servicio();
            ServicioNegocio negocio = new ServicioNegocio();

            eliminar = (Servicio)dgvServicios.CurrentRow.DataBoundItem;

            if(eliminar == null)
            {
                MessageBox.Show("Debe seleccionar un servicio de la lista", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                negocio.eliminarServicio(eliminar);
                cargarGrilla();
            }
        }
    }
}
