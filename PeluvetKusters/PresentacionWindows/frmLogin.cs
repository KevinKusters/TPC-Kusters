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
    public partial class frmLogin : Form
    {
        frmPrincipal principal;
        frmNuevoUsuario nuevo;
        List<Usuario> ListalocalUsuarios;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            UsuarioNegocio negocio = new UsuarioNegocio();
            bool Flag = false;
          

            usuario.NombreUsuario = txtUsuario.Text;
            usuario.Contraseña = txtContraseña.Text;

            ListalocalUsuarios = negocio.DevolverUsuarios();

            foreach (Usuario user in ListalocalUsuarios)
            {
                if(usuario.NombreUsuario == user.NombreUsuario && usuario.Contraseña == user.Contraseña)
                {
                    usuario.id = user.id;
                    usuario.Admin = user.Admin;  
                    Flag = true;
                    break;
                }                
            }

            if(Flag == true)
            {
                principal = new frmPrincipal(usuario.Admin);                
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }     
        }

        private void PrincipalFormClosed(object sender, EventArgs e)
        {
            principal = null;
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            if(nuevo == null)
            {
                nuevo = new frmNuevoUsuario();
                nuevo.FormClosed += new FormClosedEventHandler(NuevoFormClosed);
                nuevo.Show();
            }
        }
        private void NuevoFormClosed(object sender, EventArgs e)
        {
            nuevo = null;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
