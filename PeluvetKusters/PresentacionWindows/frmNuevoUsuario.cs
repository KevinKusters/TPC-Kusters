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
    public partial class frmNuevoUsuario : Form
    {
        public frmNuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario nuevo = new Usuario();
            UsuarioNegocio negocio = new UsuarioNegocio();
            bool Flag;

            nuevo.NombreUsuario = txtUsuario.Text;
            nuevo.Contraseña = txtContraseña.Text;

            if(chkAdmin.Checked == true)
            {
                nuevo.Admin = true;
                Flag = negocio.VerificarAdmin();
                if(Flag == true)
                {
                    MessageBox.Show("Solo puede haber un usuario ADMINISTRADOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    negocio.RegistroAdmnin(nuevo);
                }            
            }
            else
            {
                nuevo.Admin = false;
                negocio.RegistroUsuario(nuevo);
                MessageBox.Show("Usuario registrado","",MessageBoxButtons.OK);
            }
        }
    }
}
