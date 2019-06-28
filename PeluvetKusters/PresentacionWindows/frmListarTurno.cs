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
        frmAgregarTurno turnos;


        public frmListarTurno()
        {
            InitializeComponent();
            cargarGrillaHoy();
        }

        private void cargarGrillaRealizados()
        {
            TurnoNegocio negocio = new TurnoNegocio();
            ListaLocalTurnos = new List<Turno>();

            ListaLocalTurnos = negocio.listarTurnosRealizados();
            dgvTurnos.DataSource = ListaLocalTurnos;
            dgvTurnos.Columns[0].Visible = false;
            dgvTurnos.Columns[1].Visible = false;
        }


        private void cargarGrilla()
        {          
            TurnoNegocio negocio = new TurnoNegocio();
            ListaLocalTurnos = new List<Turno>();

            ListaLocalTurnos = negocio.listarTurnos();
            dgvTurnos.DataSource = ListaLocalTurnos;
            dgvTurnos.Columns[0].Visible = false;
            dgvTurnos.Columns[1].Visible = false;
        }

        private void cargarGrillaHoy()
        {
            TurnoNegocio negocio = new TurnoNegocio();
            ListaLocalTurnos = new List<Turno>();

            ListaLocalTurnos = negocio.listarTurnosHoy();
            dgvTurnos.DataSource = ListaLocalTurnos;
            dgvTurnos.Columns[0].Visible = false;
            dgvTurnos.Columns[1].Visible = false;
        }

        private void cargarGrillaFecha(string fecha)
        {
            TurnoNegocio negocio = new TurnoNegocio();
            ListaLocalTurnos = new List<Turno>();

            ListaLocalTurnos = negocio.listarTurnosXfecha(fecha);
            dgvTurnos.DataSource = ListaLocalTurnos;
            dgvTurnos.Columns[0].Visible = false;
            dgvTurnos.Columns[1].Visible = false;
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if(txtFecha.Text == "")
            {
                MessageBox.Show("Debe seleccionar una fecha", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cargarGrillaFecha(txtFecha.Text);
            }            
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            txtFecha.Text = dtpFecha.Text;
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            cargarGrillaHoy();
        }

        private void btnNuevoTurno_Click(object sender, EventArgs e)
        {
            if(turnos == null)
            {
                turnos = new frmAgregarTurno();
                turnos.MdiParent = this.MdiParent;
                turnos.FormClosed += new FormClosedEventHandler(TurnosFormClosed);
                turnos.Show();                     
            }
        }

        private void TurnosFormClosed(object sender, EventArgs e)
        {
            turnos = null;
        }

        private void btnCancelarTurno_Click(object sender, EventArgs e)
        {
            TurnoNegocio negocio = new TurnoNegocio();
            Turno cancelado = new Turno();

            if(dgvTurnos.RowCount == 0)
            {
                MessageBox.Show("No hay turnos cargados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cancelado = (Turno)dgvTurnos.CurrentRow.DataBoundItem;
                cancelado.estado = false;
                negocio.CancelarTurno(cancelado);
                negocio.CancelarTurnoTomado(cancelado.id);

                cargarGrillaHoy();
            }         
        }

        private void btnRealizado_Click(object sender, EventArgs e)
        {
            TurnoNegocio negocio = new TurnoNegocio();
            Turno turno = new Turno();
            
            if(dgvTurnos.RowCount == 0)
            {
                MessageBox.Show("No hay turnos cargados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                  
            else
            {
                turno = (Turno)dgvTurnos.CurrentRow.DataBoundItem;
                turno.realizado = true;
                negocio.TurnoRealizado(turno);
                cargarGrillaHoy();
            }
            
        }

        private void btnCancelados_Click(object sender, EventArgs e)
        {
            cargarGrillaRealizados();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscador.Text == "")
            {
                cargarGrilla();
            }
            else
            {
                if (txtBuscador.Text.Length >= 3)
                {
                    List<Turno> Lista = new List<Turno>();
                    Lista = ListaLocalTurnos.FindAll(X => X.cliente.nombre.Contains(txtBuscador.Text));
                   dgvTurnos.DataSource = Lista;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
