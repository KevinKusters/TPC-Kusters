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
    public partial class AgregarMascotas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rdbPerro.Font.Size = 15;
                rdbGato.Font.Size = 15;
                rdbOtro.Font.Size = 15;
                lblEspecie.Font.Size = 15;
                lblNombre.Font.Size = 15;
                lblRaza.Font.Size = 15;

                cargarRazas();
            }
        }

        private void cargarRazas()
        {
            RazaNegocio negocio = new RazaNegocio();

            drpRazas.DataSource = negocio.listarRazas();
            drpRazas.DataTextField = "nombre";
            drpRazas.DataValueField = "id";
            drpRazas.DataBind();
            drpRazas.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }


        protected void rdbPerro_CheckedChanged(object sender, EventArgs e)
        {
            rdbGato.Checked = false;
            rdbOtro.Checked = false;
            txtOtro.Enabled = false;
            drpRazas.Enabled = true;
        }

        protected void rdbOtro_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbOtro.Checked == true)
            {
                txtOtro.Enabled = true;
                rdbGato.Checked = false;
                rdbPerro.Checked = false;
                drpRazas.SelectedIndex = 1;
                drpRazas.Enabled = false;
            }
            else
            {
                txtOtro.Enabled = false;
                drpRazas.Enabled = true;
            }
        }

        protected void rdbGato_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGato.Checked == true)
            {
                rdbPerro.Checked = false;
                rdbOtro.Checked = false;
                txtOtro.Enabled = false;
                drpRazas.SelectedIndex = 1;
                drpRazas.Enabled = false;
            }
            else
            {
                rdbGato.Checked = false;
                drpRazas.Enabled = true;
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                Response.Write("Debe llenar todos los campos");
            }
            else
            {
                Animal mascota = new Animal();
                AnimalNegocio mascotaNegocio = new AnimalNegocio();
                Cliente cliente = new Cliente();
                ClienteNegocio clientenegocio = new ClienteNegocio();
                int idMascota;

                cliente = clientenegocio.DevolverClienteWEB((int)Session["variable_sesion"]);

                mascota.nombre = txtNombre.Text;
                mascota.apellido = cliente.apellido;

                if (rdbPerro.Checked == true)
                {
                    mascota.especie = "Perro";
                }
                else if (rdbGato.Checked == true)
                {
                    mascota.especie = "Gato";
                }
                else
                {
                    mascota.especie = "Otro";
                }

                mascota.idcliente = cliente.id;

                mascota.raza = new Raza();

                mascota.raza.id = Convert.ToInt32(drpRazas.SelectedItem.Value);

                mascotaNegocio.AgregarAnimal(mascota);
                idMascota=mascotaNegocio.buscar_ultimo_idanimal();
                mascotaNegocio.AgregarAnimalXcliente(cliente.id, idMascota);

                Response.Write("<script>window.alert('Mascota agregada');</script>");
                txtNombre.Text = "";
                txtOtro.Text = "";
            }
        }

        protected void BtnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Miperfil.aspx");
        }
    }
}