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
    public partial class frmEmpleados : Form
    {
        private List<Empleado> listaempleadolocal;

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {           
            cargarGrilla();
            cargarCombobox();
        }

        void cargarCombobox()
        {
            PuestoNegocio negocio = new PuestoNegocio();

            cmbPuestosAgr.DataSource = negocio.ListarPuestos();
            cmbPuestosAgr.ValueMember = "ID";
            cmbPuestosAgr.DisplayMember = "DESCRIPCION";
            cmbPuestoMod.DataSource = negocio.ListarPuestos();
            cmbPuestoMod.ValueMember = "ID";
            cmbPuestoMod.DisplayMember = "DESCRIPCION";
        }

        void cargarGrilla()
        {
            listaempleadolocal = new List<Empleado>();
            
            EmpleadoNegocio negocio = new EmpleadoNegocio();

            listaempleadolocal = negocio.ListarEmpleados();
            dgvEmpleados.DataSource = listaempleadolocal;

            dgvEmpleados.Columns[0].Visible = false;
            dgvEmpleados.Columns[1].Visible = false;
            dgvEmpleados.Columns[2].Visible = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            if(txtNombreAgr.Text == "" || txtApellidoAgr.Text=="" || txtContactoAgr.Text == "" || cmbPuestosAgr.Items.Count <= 0)
            {
                MessageBox.Show("Debe completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Empleado empleado = new Empleado();
                EmpleadoNegocio negocio = new EmpleadoNegocio();

                empleado.nombre = txtNombreAgr.Text;
                empleado.apellido = txtApellidoAgr.Text;
                empleado.contacto = txtContactoAgr.Text;
                empleado.puesto = (Puesto)cmbPuestosAgr.SelectedItem;

                if (rdbPeluqueria.Checked == true)
                {
                    empleado.rubro = rdbPeluqueria.Text;
                }
                if (rdbVeterinaria.Checked == true)
                {
                    empleado.rubro = rdbVeterinaria.Text;
                }

                negocio.CargarEmpleado(empleado);
                cargarGrilla();

                txtApellidoAgr.Text = "";
                txtNombreAgr.Text = "";
                txtContactoAgr.Text = "";
            }
 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtApellidoMod.Text = "";
            txtNombreMod.Text = "";
            txtContactoMod.Text = "";
            txtIDMod.Text = "";

            txtNombreMod.Enabled = false;
            txtApellidoMod.Enabled = false;
            txtContactoMod.Enabled = false;
            cmbPuestoMod.Enabled = false;
            rdbPeluqueriaMod.Enabled = false;
            rdbVeterinariaMod.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (txtNombreMod.Text == "" || txtApellidoMod.Text == "" || txtContactoMod.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Empleado modificar = new Empleado();

                modificar = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
                txtIDMod.Text = modificar.id.ToString();
                txtNombreMod.Text = modificar.nombre;
                txtApellidoMod.Text = modificar.apellido;
                txtContactoMod.Text = modificar.contacto;
                cmbPuestoMod.SelectedValue = modificar.puesto.Id;

                if (modificar.rubro == "Veterinaria")
                {
                    rdbVeterinariaMod.Checked = true;
                }
                else
                {
                    rdbPeluqueriaMod.Checked = true;
                }

                txtNombreMod.Enabled = true;
                txtApellidoMod.Enabled = true;
                txtContactoMod.Enabled = true;
                rdbPeluqueriaMod.Enabled = true;
                rdbVeterinariaMod.Enabled = true;
                cmbPuestoMod.Enabled = true;
            }       
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtNombreMod.Text == "" || txtApellidoMod.Text == "" || txtContactoMod.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Empleado modificado = new Empleado();
                EmpleadoNegocio negocio = new EmpleadoNegocio();

                modificado.id = int.Parse(txtIDMod.Text);
                modificado.nombre = txtNombreMod.Text;
                modificado.apellido = txtApellidoMod.Text;
                modificado.contacto = txtContactoMod.Text;
                modificado.puesto = (Puesto)cmbPuestoMod.SelectedItem;
                if (rdbPeluqueriaMod.Checked == true)
                {
                    modificado.rubro = rdbPeluqueriaMod.Text;
                }
                else
                {
                    modificado.rubro = rdbVeterinariaMod.Text;
                }

                negocio.ModificarEmpleado(modificado);

                txtNombreMod.Enabled = false;
                txtApellidoMod.Enabled = false;
                txtContactoMod.Enabled = false;
                rdbPeluqueriaMod.Enabled = false;
                rdbVeterinariaMod.Enabled = false;
                cmbPuestoMod.Enabled = false;

                txtIDMod.Text = "";
                txtNombreMod.Text = "";
                txtApellidoMod.Text = "";
                txtContactoMod.Text = "";
                rdbPeluqueriaMod.Text = "";
                rdbVeterinariaMod.Text = "";
                cmbPuestoMod.Text = "";

                cargarGrilla();
            }              
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvEmpleados.Rows.Count == 0)
            {
                MessageBox.Show("No hay empleados cargados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Empleado eliminar = new Empleado();
                EmpleadoNegocio negocio = new EmpleadoNegocio();
                eliminar = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;

                if (eliminar == null)
                {
                    MessageBox.Show("Debe seleccionar un empleado de la lista", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    negocio.eliminarEmpleado(eliminar);
                    cargarGrilla();
                }
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
