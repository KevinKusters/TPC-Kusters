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
    public partial class frmPuestos : Form
    {
        public frmPuestos()
        {
            InitializeComponent();
        }

        private void frmPuestos_Load(object sender, EventArgs e)
        {          
            cargarGrilla();            
        }

        void cargarGrilla()
        {
            PuestoNegocio negocio = new PuestoNegocio();
            dgvPuestos.DataSource = negocio.ListarPuestos();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtDescripcionAgr.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripcion para el puesto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Puesto puesto = new Puesto();
                PuestoNegocio negocio = new PuestoNegocio();

                puesto.Descripcion = txtDescripcionAgr.Text;
                negocio.cargarPuesto(puesto);

                cargarGrilla();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Puesto modificar = new Puesto();

            modificar =(Puesto)dgvPuestos.CurrentRow.DataBoundItem;

            txtID.Text = modificar.Id.ToString();
            txtDecripcionMod.Text = modificar.Descripcion;
            txtDecripcionMod.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtDecripcionMod.Text = "";
            txtDecripcionMod.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PuestoNegocio negocio = new PuestoNegocio();
            Puesto modificado = new Puesto();

            modificado.Id = int.Parse(txtID.Text);
            modificado.Descripcion = txtDecripcionMod.Text;

            negocio.ModificarPuesto(modificado);

            txtID.Text = "";
            txtDecripcionMod.Text = "";
            txtDecripcionMod.Enabled = false;
            cargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Puesto eliminar = new Puesto();
            PuestoNegocio negocio = new PuestoNegocio();

            eliminar = (Puesto)dgvPuestos.CurrentRow.DataBoundItem;

            if (eliminar == null)
            {
                MessageBox.Show("Debe seleccionar un Puesto de la lista", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                negocio.eliminarPuesto(eliminar);
                cargarGrilla();
            }
        }
    }
}
