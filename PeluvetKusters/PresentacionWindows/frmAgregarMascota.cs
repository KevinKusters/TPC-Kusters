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
    public partial class frmAgregarMascota : Form
    {
        public Cliente aux = new Cliente();
        private List<Animal> ListaLocalAnimales;

        public frmAgregarMascota(Cliente cliente)
        {
            InitializeComponent();

            RazaNegocio negocio = new RazaNegocio();

            txtID.Text = cliente.id.ToString();
            txtnombre.Text = cliente.nombre;
            txtapellido.Text = cliente.apellido;
                       
            cmbRazas.DataSource = negocio.listarRazas();
            cmbRazas.ValueMember = "id";
            cmbRazas.DisplayMember = "nombre";

            cmbrazaMod.DataSource = negocio.listarRazas();
            cmbrazaMod.ValueMember = "id";
            cmbrazaMod.DisplayMember = "nombre";
            
            cargarGrilla();
        }
        private void frmListaMascota_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
           
        private void cargarGrilla()
        {
            AnimalNegocio negocio = new AnimalNegocio();
            ListaLocalAnimales = new List<Animal>();

            ListaLocalAnimales= negocio.ListarAnimalesXcliente(int.Parse(txtID.Text));
            dgvMascotas.DataSource = ListaLocalAnimales;
            dgvMascotas.Columns[0].Visible = false;
            dgvMascotas.Columns[1].Visible = false;
            dgvMascotas.Columns[5].Visible = false;
        }

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            if (txtNombreMasc.Text == "" || rdbOtro.Checked == true && txtOtro.Text == "")
            {
                MessageBox.Show("Debe completar TODOS los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AnimalNegocio negocio = new AnimalNegocio();
                Animal animal = new Animal();
                int aux;

                animal.nombre = txtNombreMasc.Text;
                animal.apellido = txtapellido.Text;
                animal.idcliente = int.Parse(txtID.Text);
                animal.raza = (Raza)cmbRazas.SelectedItem;

                if (rbtGato.Checked == true)
                {
                    animal.especie = "Gato";
                }
                if (rbtPerro.Checked == true)
                {
                    animal.especie = "Perro";
                }
                if (rdbOtro.Checked == true)
                {
                    txtOtro.Enabled = true;
                    animal.especie = txtOtro.Text;              
                }

                animal.idcliente = int.Parse(txtID.Text);                

                negocio.AgregarAnimal(animal);

                aux = negocio.buscar_ultimo_idanimal();

                negocio.AgregarAnimalXcliente(int.Parse(txtID.Text), aux);
                MessageBox.Show("Mascota agregada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarGrilla();
            }
        }

        private void rdbOtro_CheckedChanged(object sender, EventArgs e)
        {
            cmbRazas.Enabled = false;

            if (rdbOtro.Checked == true)
            {
                txtOtro.Enabled = true;
                cmbRazas.SelectedIndex = 0;
            }
            else
            {
                txtOtro.Enabled = false;
            }
        }

        private void rbtPerro_CheckedChanged(object sender, EventArgs e)
        {
            cmbRazas.Enabled = true;

            if (rbtPerro.Checked == true)
            {
                txtOtro.Text = "";
                txtOtro.Enabled = false;
            }
        }

        private void rbtGato_CheckedChanged(object sender, EventArgs e)
        {
            cmbRazas.Enabled = false;
            cmbRazas.SelectedIndex = 0;

            if(rbtGato.Checked == true)
            {
                txtOtro.Text = "";
                txtOtro.Enabled = false;
            }            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Animal modificar = new Animal();

            modificar = (Animal)dgvMascotas.CurrentRow.DataBoundItem;

            txtIdMod.Text = modificar.id.ToString();
            txtNombreMod.Text = modificar.nombre;
            cmbrazaMod.SelectedIndex = modificar.raza.id;

            if(modificar.especie == "Perro")
            {
                rdbPerroMod.Checked = true;
            }
            else if(modificar.especie == "Gato")
            {
                rdbGatoMod.Checked = true;
            }
            else
            {
                rdbOtroMod.Checked = true;
                txtOtroMod.Text = modificar.especie;
            }
            
            EnableTxt();
        }

        private void EnableTxt()
        {
            txtNombreMod.Enabled = true;
            rdbGatoMod.Enabled = true;
            rdbPerroMod.Enabled = true;
            rdbOtroMod.Enabled = true;
        }

        private void DisableTxt()
        {
            txtNombreMod.Enabled = false;
            rdbGatoMod.Enabled = false;
            rdbPerroMod.Enabled = false;
            rdbOtroMod.Enabled = false;
        }

        private void rdbOtroMod_CheckedChanged(object sender, EventArgs e)
        {
            cmbrazaMod.Enabled = false;
            cmbrazaMod.SelectedIndex = 0;

            if (rdbOtroMod.Checked == true)
            {
                txtOtroMod.Enabled = true;
            }          
        }

        private void rdbGatoMod_CheckedChanged(object sender, EventArgs e)
        {
            cmbrazaMod.Enabled = false;
            cmbrazaMod.SelectedIndex = 0;

            if (rdbGatoMod.Checked == true)
            {
                txtOtroMod.Text = "";
                txtOtroMod.Enabled = false;
            }
        }

        private void rdbPerroMod_CheckedChanged(object sender, EventArgs e)
        {
            cmbrazaMod.Enabled = true;      
            txtOtroMod.Text = "";
            txtOtroMod.Enabled = false;
        }

        private void btnAceptarMod_Click(object sender, EventArgs e)
        {
            Animal modificado = new Animal();
            AnimalNegocio negocio = new AnimalNegocio();

            if (txtNombreMod.Text == "" || rdbOtroMod.Checked == true && txtOtroMod.Text == "")
            {
                MessageBox.Show("Debe completar TODOS los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rdbOtro.Checked == true)
            {
                if (txtOtroMod.Text == "")
                {
                    MessageBox.Show("Debe especificar la especie", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                modificado.id = int.Parse(txtIdMod.Text);
                modificado.nombre = txtNombreMod.Text;
                modificado.apellido = txtapellido.Text;
                modificado.raza = (Raza)cmbrazaMod.SelectedItem;
                modificado.idcliente = int.Parse(txtID.Text);

                if (rdbPerroMod.Checked == true)
                {
                    modificado.especie = "Perro";
                }
                else if (rdbGatoMod.Checked == true)
                {
                    modificado.especie = "Gato";
                }
                else
                {
                    modificado.especie = txtOtroMod.Text;
                }

                negocio.ModificarAnimal(modificado);
                DisableTxt();
                cargarGrilla();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombreMasc.Text = "";
            cmbRazas.SelectedIndex = 0;
            rbtPerro.Checked = true;
        }

        private void btnCancelarMod_Click(object sender, EventArgs e)
        {
            txtIdMod.Text = "";
            txtNombreMod.Text = "";
            txtOtroMod.Text = "";
            cmbrazaMod.SelectedIndex = 0;
            rdbPerroMod.Checked = true;

            DisableTxt();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Animal eliminar = new Animal();
            AnimalNegocio negocio = new AnimalNegocio();

            eliminar = (Animal)dgvMascotas.CurrentRow.DataBoundItem;

            if(eliminar == null)
            {
                MessageBox.Show("Debe seleccionar un animal de la lista", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                negocio.eliminarAnimal(eliminar);
                cargarGrilla();
            }         
        }
    }
}
