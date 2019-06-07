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
    public partial class frmListarTurno : Form
    {
        List<Turno> ListaLocalTurnos;


        public frmListarTurno()
        {
            InitializeComponent();
            cargarGrilla();
        }


        private void cargarGrilla()
        {
            TurnoNegocio negocio = new TurnoNegocio();
            ListaLocalTurnos = new List<Turno>();

            ListaLocalTurnos = negocio.listarTurnosHoy();
            dgvTurnos.DataSource = ListaLocalTurnos;
        }
    }
}
