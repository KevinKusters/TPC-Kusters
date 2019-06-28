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
    public partial class frmAgregarCliente : Form
    {
        public Cliente Auxiliar;
        frmAgregarMascota mascota;

        public frmAgregarCliente()
        {
            InitializeComponent();
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            ClienteNegocio negocio = new ClienteNegocio();

            dgbAgregarCliente.DataSource = negocio.ListarClientes();
            dgbAgregarCliente.Columns[1].Visible = false;
        }

        private void dgbAgregarCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            LocalidadNegocio negocio = new LocalidadNegocio();        

            cmbLocalidades.DataSource = negocio.ListarLocalidades();
            cmbLocalidadMod.DataSource = negocio.ListarLocalidades();

            cmbLocalidades.DisplayMember = "nombre";
            cmbLocalidades.ValueMember = "id";

            cmbLocalidadMod.DisplayMember = "nombre";
            cmbLocalidadMod.ValueMember = "id";
           
        }

        private void cmbLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {          
        }

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();

            if(dgbAgregarCliente.RowCount == 0)
            {
                MessageBox.Show("No hay clientes cargados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cli =(Cliente) dgbAgregarCliente.CurrentRow.DataBoundItem;

                    if(mascota == null)
                    {
                        mascota = new frmAgregarMascota(cli);
                        mascota.MdiParent = this.MdiParent;
                        mascota.FormClosed += new FormClosedEventHandler(MascotaFormClosed);
                        mascota.Show();
                    } 
            }                              
        }

        void MascotaFormClosed (object sender, EventArgs e)
        {
            mascota = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtNombreCli.Text == "" || txtApellidoCli.Text == "" || txtContacto.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos de cliente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cliente cliente = new Cliente();
                ClienteNegocio negocio = new ClienteNegocio();
            
                cliente.nombre = txtNombreCli.Text;
                cliente.apellido = txtApellidoCli.Text;
                cliente.contacto = txtContacto.Text;
                cliente.estado = true;
                cliente.localidad = (Localidad)cmbLocalidades.SelectedItem;

                negocio.agregarCliente(cliente);
            
                cargarGrilla();            
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombreCli.Text = "";
            txtApellidoCli.Text = "";
            txtContacto.Text = "";
            cmbLocalidades.SelectedIndex = 0;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Cliente modificar = new Cliente();
            ClienteNegocio negocio = new ClienteNegocio();

            if(dgbAgregarCliente.RowCount == 0)
            {
                MessageBox.Show("No hay clientes cargados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                modificar = (Cliente)dgbAgregarCliente.CurrentRow.DataBoundItem;
                txtIdMod.Text = modificar.id.ToString();
                txtNombreMod.Text = modificar.nombre;
                txtApellidoMod.Text = modificar.apellido;
                txtContactoMod.Text = modificar.contacto;

                cmbLocalidadMod.SelectedIndex = modificar.localidad.id-1;
                enabletxt();
            }    
        }

        private void enabletxt()
         {
            txtNombreMod.Enabled = true;
            txtApellidoMod.Enabled = true;
            txtContactoMod.Enabled = true;
            cmbLocalidadMod.Enabled = true;
         }

        private void disabletxt()
        {
            txtNombreMod.Enabled = false;
            txtApellidoMod.Enabled = false;
            txtContactoMod.Enabled = false;
            cmbLocalidadMod.Enabled = false;
        }

        private void btnAceptarMod_Click(object sender, EventArgs e)
        {
            if(txtNombreMod.Text=="" || txtApellidoCli.Text == "" || txtContacto.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClienteNegocio negocio = new ClienteNegocio();
                Cliente modificado = new Cliente();

                modificado.id = int.Parse(txtIdMod.Text);
                modificado.nombre = txtNombreMod.Text;
                modificado.apellido = txtApellidoMod.Text;
                modificado.localidad = (Localidad)cmbLocalidadMod.SelectedItem;

                negocio.ModificarCliente(modificado);

                txtIdMod.Text = "";
                txtNombreMod.Text = "";
                txtApellidoMod.Text = "";
                txtContactoMod.Text = "";
                cmbLocalidadMod.SelectedText = "";

                disabletxt();
                cargarGrilla();
            }
        }

        private void btnCancelarMod_Click(object sender, EventArgs e)
        {
            txtIdMod.Text = "";
            txtNombreMod.Text = "";
            txtApellidoMod.Text = "";
            txtContactoMod.Text = "";
            cmbLocalidadMod.SelectedText = "";

            disabletxt();
        }
    }

    
}
