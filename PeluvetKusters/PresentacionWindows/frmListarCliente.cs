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
    public partial class frmListarCliente : Form
    {
        List<Cliente> ListaClienteLocal;
        frmListaMascotas listamascota;

        public frmListarCliente()
        {
            InitializeComponent();

            btnAgregar.Visible = false;            
            cargarGrilla();                   
        }

        public frmListarCliente(string turno)
        {
            InitializeComponent();
            btnAgregar.Visible = true;
            btnVerMascotas.Visible = false;
            cargarGrilla();
        }

        void cargarGrilla()
        {
            ClienteNegocio negocio = new ClienteNegocio();
            ListaClienteLocal = new List<Cliente>();

            ListaClienteLocal=negocio.ListarClientes();
            dgvClientes.DataSource = ListaClienteLocal;
            dgvClientes.Columns[1].Visible = false;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if(txtBusqueda.Text == "")
            {
                cargarGrilla();
            }
            else
            {
                if(txtBusqueda.Text.Length >= 3)
                {
                    List<Cliente> Lista = new List<Cliente>();
                    Lista = ListaClienteLocal.FindAll(X => X.nombre.Contains(txtBusqueda.Text));
                    dgvClientes.DataSource = Lista;
                }
            }
        }

        private void btnVerMascotas_Click(object sender, EventArgs e)
        {
            if (listamascota == null)
            {
                Cliente cli = new Cliente();

                if(dgvClientes.RowCount == 0)
                {
                    MessageBox.Show("No hay Clientes cargados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cli = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                    listamascota = new frmListaMascotas(cli);
                    listamascota.MdiParent = this.MdiParent;
                    listamascota.FormClosed += new FormClosedEventHandler(ListaMascotaFormClosed);
                    listamascota.Show();
                }          
            }
        }

        void ListaMascotaFormClosed(object sender, EventArgs e)
        {
            listamascota = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {            
            frmAgregarTurno turnos = Owner as frmAgregarTurno;

            Cliente cliente = new Cliente();
            cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            
            turnos.txtIDcliente.Text = cliente.id.ToString();
            turnos.txtnombrecli.Text = cliente.nombre;
            turnos.txtapellidocli.Text = cliente.apellido;                 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
