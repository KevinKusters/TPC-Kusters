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
    public partial class frmLocalidades : Form
    {
        public frmLocalidades()
        {
            InitializeComponent();
            cargar_grilla();
        }

        void cargar_grilla()
        {
            LocalidadNegocio negocio = new LocalidadNegocio();

            dgvLocalidades.DataSource = negocio.ListarLocalidades();
            dgvLocalidades.Columns[0].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtNombreLoc.Text == "")
            {
                MessageBox.Show("El campo 'Nombre' no puede estar vacio","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Localidad nueva = new Localidad();
                LocalidadNegocio negocio = new LocalidadNegocio();

                nueva.nombre = txtNombreLoc.Text;
                negocio.AgregarLocalidad(nueva);

                MessageBox.Show("Localidad Agregada!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargar_grilla();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Localidad Loc = new Localidad();

            Loc = (Localidad)dgvLocalidades.CurrentRow.DataBoundItem;

            txtID.Text = Loc.id.ToString();
            txtNombreMod.Text = Loc.nombre;

            txtNombreMod.Enabled = true;
        }

        private void btnAcepotarmod_Click(object sender, EventArgs e)
        {
            Localidad Loc = new Localidad();
            LocalidadNegocio negocio = new LocalidadNegocio();

            Loc.id =int.Parse(txtID.Text);
            Loc.nombre = txtNombreMod.Text;        
            negocio.ModificarLocalidad(Loc);

            txtID.Text = "";
            txtNombreMod.Text = "";
            txtNombreMod.Enabled = false;
            
            MessageBox.Show("Localidad Modificada", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            cargar_grilla();
        }
    }
}
