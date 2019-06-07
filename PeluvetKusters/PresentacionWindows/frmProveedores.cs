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
    public partial class frmProveedores : Form
    {
        private List<Proveedor> listaprovLocal;
        
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void cargar_grilla()
        {
            ProveedorNegocio negocio = new ProveedorNegocio();
            try
            {                
                listaprovLocal = negocio.ListarProveedor();
                dgvProveedores.DataSource = listaprovLocal;

                dgvProveedores.Columns[7].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            cargar_grilla();
            dgvProveedores.Columns[0].Visible = false;
            dgvProveedores.Columns[3].Visible = false;
            dgvProveedores.Columns[4].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Proveedor aux = new Proveedor();
            PersonaJuridicaNegocio auxnegocio = new PersonaJuridicaNegocio();
            ProveedorNegocio negocio = new ProveedorNegocio();

            try
            {
                if(txtCuit.Text == "" || txtNombreProv.Text == "" || txtRazonSocial.Text == "" || txtTelefono.Text == "")
                {
                    MessageBox.Show("Solo el campo EMAIL puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int auxint;
                    aux.Nombre = txtNombreProv.Text;
                    aux.Telefono = txtTelefono.Text;
                    aux.contacto = txtContacto.Text;
                    aux.razonSocial = txtRazonSocial.Text;
                    aux.cuit = Int64.Parse(txtCuit.Text);
                    aux.estado = true;

                    auxnegocio.Agregar_PersonaJuridica(aux.razonSocial, aux.cuit,aux.estado);

                    auxint = auxnegocio.recuperar_id();
                    aux.id = auxint;

                    negocio.Agregar_proveedor(aux);

                    cargar_grilla();
                }              
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                txtNombreProv.Text = "";
                txtTelefono.Text="";
                txtContacto.Text="";
                txtRazonSocial.Text="";
                txtCuit.Text = "";
            }


        }
    }
}
