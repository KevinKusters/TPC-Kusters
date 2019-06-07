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
    public partial class frmListaRazas : Form
    {
        private List<Raza> listaRazasLocal;

        public frmListaRazas()
        {
            InitializeComponent();
        }

        private void frmListaRazas_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            RazaNegocio negocio = new RazaNegocio();
            try
            {
                listaRazasLocal = negocio.listarRazas();
                dgvListaRazas.DataSource = listaRazasLocal;

                dgvListaRazas.Columns[2].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreAgr.Text == "")
            {
                MessageBox.Show("Debe rellenar el campo NOMBRE DE RAZA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Raza agregar = new Raza();
                    RazaNegocio agregarnuevo = new RazaNegocio();

                    agregar.nombre = txtNombreAgr.Text;
                    agregar.estado = true;
                    agregarnuevo.AgregarRaza(agregar);
                    MessageBox.Show("Raza agregada", "Mesnaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cargarGrilla();
                }
                catch (Exception ex)
                {
                    throw ex;
                }                
            }
        }      

        private void btnModificarSelect_Click(object sender, EventArgs e)
        {
            try
            {
                Raza modificar;
                modificar = (Raza)dgvListaRazas.CurrentRow.DataBoundItem;
                txtIdRaza.Text = modificar.id.ToString();
                txtnombreMod.Text = modificar.nombre;              
            }
            catch (Exception ex)
            {
                throw ex;
            }          
        }

        private void btnaceptarMod_Click(object sender, EventArgs e)
        {
            if(txtnombreMod.Text == null)
            {
                MessageBox.Show("El Campo Nombre de raza no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Raza modificada = new Raza();
                    RazaNegocio ModNegocio = new RazaNegocio();

                    modificada.id = int.Parse(txtIdRaza.Text);
                    modificada.nombre = txtnombreMod.Text;
                    ModNegocio.modificarRaza(modificada);                   
                    MessageBox.Show("Raza Modificada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtIdRaza.Text = "";
                    txtnombreMod.Text = "";

                    cargarGrilla();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
