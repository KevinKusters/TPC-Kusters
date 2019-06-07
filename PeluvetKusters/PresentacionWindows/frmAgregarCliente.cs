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
            cmbLocalidades.DisplayMember = "nombre";
            cmbLocalidades.ValueMember = "id";         

            cargarGrilla();
        }

        private void cmbLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {          
        }

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli =(Cliente) dgbAgregarCliente.CurrentRow.DataBoundItem;

            if(mascota == null)
            {
                mascota = new frmAgregarMascota(cli);
                mascota.MdiParent = this.MdiParent;
                mascota.FormClosed += new FormClosedEventHandler(MascotaFormClosed);
                mascota.Show();
            }                       
        }

        void MascotaFormClosed (object sender, EventArgs e)
        {
            mascota = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteNegocio negocio = new ClienteNegocio();
            
            cliente.nombre = txtNombreCli.Text;
            cliente.apellido = txtApellidoCli.Text;
            cliente.contacto = txtContacto.Text;
            cliente.estado = true;
            cliente.localidad = (Localidad)cmbLocalidades.SelectedItem;

            negocio.agregarCliente(cliente);

            MessageBox.Show("Cliente agregado", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            cargarGrilla();            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombreCli.Text = "";
            txtApellidoCli.Text = "";
            txtContacto.Text = "";
            cmbLocalidades.SelectedIndex = 0;
        }
    }
}
