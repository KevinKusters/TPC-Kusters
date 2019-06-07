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
    public partial class frmListaMascotas : Form
    {
        List<Animal> ListaLocalAnimales;

        public frmListaMascotas()
        {
            InitializeComponent();
        }

        public frmListaMascotas(Cliente aux)
        {
            InitializeComponent();

            txtID.Text = aux.id.ToString();
            txtnombre.Text = aux.nombre;
            txtapellido.Text = aux.apellido;

            cargarGrilla();
                
        }

        private void cargarGrilla()
        {
            AnimalNegocio negocio = new AnimalNegocio();
            ListaLocalAnimales = new List<Animal>();

            ListaLocalAnimales = negocio.ListarAnimalesXcliente(int.Parse(txtID.Text));
            dgvMascotas.DataSource = ListaLocalAnimales;
            dgvMascotas.Columns[0].Visible = false;
            dgvMascotas.Columns[1].Visible = false;
            dgvMascotas.Columns[5].Visible = false;
        }
    }
}
