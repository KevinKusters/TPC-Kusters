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
    public partial class Miperfil : System.Web.UI.Page
    {

        List<Animal> ListalocalAnimales;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrilla();
                gvMascotas.Font.Size = 15;
                lblMisMascotas.Font.Size = 15;
            }
           
        }

        protected void btnAgregarMascotas_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarMascotas.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnPedirTurno_Click(object sender, EventArgs e)
        {
            Response.Redirect("PedirTurno.aspx");
        }

        protected void btnMisTurnos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Misturnos.aspx");
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["variable_sesion"] = null;
            Response.Redirect("Default.aspx");
        }

        private void cargarGrilla()
        {
            AnimalNegocio negocio = new AnimalNegocio();
            Cliente cliente = new Cliente();
            ClienteNegocio clientenegocio = new ClienteNegocio();
            ListalocalAnimales = new List<Animal>();

            cliente = clientenegocio.DevolverClienteWEB((int)Session["variable_sesion"]);
            ListalocalAnimales=negocio.ListarAnimalesXcliente(cliente.id);
            gvMascotas.DataSource = ListalocalAnimales;            gvMascotas.DataBind();
    
        }

        protected void gvMascotas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
            e.Row.Cells[1].Visible = false;           
            e.Row.Cells[5].Visible = false;
        }
    }
}