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
    public partial class Registro : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarLocalidades();
            }
            
        }

        private void CargarLocalidades()
        {
            LocalidadNegocio negocio = new LocalidadNegocio();

            drpLocalidades.DataSource = negocio.ListarLocalidades();            
            drpLocalidades.DataTextField = "nombre";
            drpLocalidades.DataValueField = "id";
            drpLocalidades.DataBind();
            drpLocalidades.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        protected void drpLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            Cliente cliente = new Cliente();
            ClienteNegocio clientenegocio = new ClienteNegocio();
            UsuarioNegocio usuarionegocio = new UsuarioNegocio();
            LocalidadNegocio localidadnegocio = new LocalidadNegocio();
            int aux;
            //CAMBIAR FLAG CUADNO SE ARREGLE LA FUNCION VALIDARNOMBREUSUARIO QUE DE REPENTE NO QUIERE ANDAR
            bool flag = false;

            if (txtUsuario.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtContraseña.Text == "" || txtcontacto.Text == "" || Convert.ToInt32(drpLocalidades.SelectedValue) == 0)
            {
                Response.Write("<script>window.alert('Debe compeltar todos los campos');</script>");
            }
            else
            {

                cliente.nombre = txtNombre.Text;
                cliente.apellido = txtApellido.Text;
                cliente.contacto = txtcontacto.Text;                
                cliente.localidad = new Localidad();
                cliente.localidad.nombre = drpLocalidades.Text;
                cliente.localidad.id = Convert.ToInt32(drpLocalidades.SelectedValue);
                cliente.estado = true;

                usuario.NombreUsuario = txtUsuario.Text;
                flag = usuarionegocio.ValidarNombreUsuario(txtUsuario.Text);

                if (flag == true)
                {
                    Response.Write("<script>window.alert('El nombre de usuario ya esta en uso');</script>");
                }
                else
                {
                    clientenegocio.agregarCliente(cliente);
                    aux = clientenegocio.RecuperarUltimoId();
                    usuario.Contraseña = txtContraseña.Text;
                    usuarionegocio.RegistroWeb(usuario, aux);

                    Response.Write("<script>window.alert('Registro completado');</script>");
                    Response.Redirect("Default.aspx");
                }
            }
        }
    }
}