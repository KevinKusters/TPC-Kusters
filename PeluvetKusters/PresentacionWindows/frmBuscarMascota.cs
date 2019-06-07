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
    public partial class frmBuscarMascota : Form
    {
        List<Animal> ListaLocalAnimales;

        public frmBuscarMascota(int id)
        {
            InitializeComponent();
            cargarGrilla(id);
        }

        private void cargarGrilla(int id)
        {
            AnimalNegocio negocio = new AnimalNegocio();
            ListaLocalAnimales = new List<Animal>();

            ListaLocalAnimales = negocio.ListarAnimalesXcliente(id);
            dgvMascotas.DataSource = ListaLocalAnimales;
            dgvMascotas.Columns[0].Visible = false;
            dgvMascotas.Columns[1].Visible = false;            
            dgvMascotas.Columns[5].Visible = false;
        }

        private void dgvMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarTurno turnos = Owner as frmAgregarTurno;

            Animal animal = new Animal();    
            animal=(Animal)dgvMascotas.CurrentRow.DataBoundItem;

            turnos.txtIDmascota.Text = animal.id.ToString();
            turnos.txtnombremasc.Text = animal.nombre;
            turnos.txtapellidomasc.Text = animal.apellido;
            turnos.txtraza.Text = animal.raza.nombre;
            turnos.txtEspecie.Text = animal.especie;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
