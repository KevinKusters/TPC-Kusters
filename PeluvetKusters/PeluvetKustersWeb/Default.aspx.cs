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
    public partial class _Default : Page
    {
        List<Usuario> Listalocalusuarios;


        protected void Page_Load(object sender, EventArgs e)
        {
            btnPedirTurno.Enabled = false;
            if(Session["variable_sesion"] != null)
            {
                btnPerfil.Visible = true;
                btnPedirTurno.Enabled = true;
                lblUsuario.Visible = false;
                lblContraseña.Visible = false;
                btnLogin.Visible = false;
                btnRegistrarse.Visible = false;
                txtNombreUsuario.Visible = false;
                TxtContraseña.Visible = false;
            }
            else
            {
                btnPerfil.Visible = false;
                btnPedirTurno.Enabled = false;
                lblUsuario.Visible =true;
                lblContraseña.Visible = true;
                btnLogin.Visible = true;
                btnRegistrarse.Visible = true;
                txtNombreUsuario.Visible = true;
                TxtContraseña.Visible = true;
            }
        }     

        protected void btnPedirTurno_Click1(object sender, EventArgs e)
        {
            Response.Redirect("PedirTurno.aspx");
        }

        protected void brnRegistrarse_Click(object sender, EventArgs e)
        {
             Response.Redirect("Registro.aspx");
        }

        protected void btnLogin_Onclick(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            UsuarioNegocio negocio = new UsuarioNegocio();
            bool flag = false;
           
           
            

            usuario.NombreUsuario = txtNombreUsuario.Text;
            usuario.Contraseña = TxtContraseña.Text;

            Listalocalusuarios = negocio.DevolverUsuariosWEB();

            foreach (Usuario user in Listalocalusuarios)
            {
                if (usuario.NombreUsuario == user.NombreUsuario && usuario.Contraseña == user.Contraseña)
                {
                    usuario.id = user.id;                   
                    flag = true;
                    break;
                }
            }

            if (flag == true)
            {
                Response.Write("<script>window.alert('Logeado!');</script>");
                btnPerfil.Visible = true;
                lblUsuario.Visible = false;
                lblContraseña.Visible = false;
                btnLogin.Visible = false;
                btnRegistrarse.Visible = false;
                txtNombreUsuario.Visible = false;
                TxtContraseña.Visible = false;

                int id;
                id = usuario.id;
                Session["variable_sesion"] = id;
                btnPedirTurno.Enabled = true;
            }
            else
            {
                Response.Write("<script>window.alert('Usuario o contraseña incorrectos');</script>");
            }
          
        }

        protected void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("Miperfil.aspx");
        }

        protected void txtNombreUsuario_TextChanged1(object sender, EventArgs e)
        {

        }
    }
}