using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace PeluvetKustersWeb
{
    public partial class Misturnos : System.Web.UI.Page
    {

        List<Turno> listalocalturnos;

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            dgvTurnos.Font.Size = 15;
        }

        private void cargarGrilla()
        {
            TurnoNegocio negocio = new TurnoNegocio();
            Cliente cliente = new Cliente();
            ClienteNegocio clientenegocio = new ClienteNegocio();
            listalocalturnos = new List<Turno>();
            int auxID;

            auxID = (int)Session["variable_sesion"];

            cliente = clientenegocio.DevolverClienteWEB(auxID);

            listalocalturnos = negocio.listarTurnosXclienteWEB(cliente.id);
            dgvTurnos.DataSource = listalocalturnos;       
            dgvTurnos.DataBind();            
        }

        protected void dgvTurnos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[4].Visible = false;
            e.Row.Cells[5].Visible = false;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void dgvTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }

        protected void btnPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("Miperfil.aspx");
        }
    }
}