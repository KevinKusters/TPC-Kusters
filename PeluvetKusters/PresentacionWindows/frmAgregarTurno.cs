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

    public partial class frmAgregarTurno : Form
    {
        frmListarCliente cliente;
        frmBuscarMascota mascota;
        List<Empleado> ListaLocalEmpleados;      

        public frmAgregarTurno()
        {            
            InitializeComponent();

            DtpFecha.Format = DateTimePickerFormat.Custom;
            DtpFecha.CustomFormat = "dd/MM/yyyy ,HH:mm";
            DtpFecha.ShowUpDown = true;

            lblAviso.Visible = false;

            cargarListaEmpleados();
            cargarServicios();            
        }

        private void cargarListaEmpleados()
        {
            EmpleadoNegocio negocio = new EmpleadoNegocio();
            ListaLocalEmpleados = new List<Empleado>();

            if (rdbPeluqueria.Checked == true)
            {
                ListaLocalEmpleados = negocio.ListarEmpleadosXPuesto(rdbPeluqueria.Text);
                dgvempleados.DataSource = ListaLocalEmpleados;
                dgvempleados.Columns[0].Visible = false;
                dgvempleados.Columns[1].Visible = false;
                dgvempleados.Columns[2].Visible = false;
            }
            else
            {
                ListaLocalEmpleados = negocio.ListarEmpleadosXPuesto(rdbVeterinaria.Text);
                dgvempleados.DataSource = ListaLocalEmpleados;
                dgvempleados.Columns[0].Visible = false;
                dgvempleados.Columns[1].Visible = false;
                dgvempleados.Columns[2].Visible = false;
            }                          
        }

        private void cargarServicios()
        {

            if(rdbPeluqueria.Checked==true)
            {
                ServicioNegocio negocio = new ServicioNegocio();
                Servicio aux = new Servicio();

                cbmservicio.DataSource = negocio.ListarServiciosXRubro(rdbPeluqueria.Text);
                cbmservicio.DisplayMember = "Descripcion";
                cbmservicio.ValueMember = "id";

                aux = (Servicio)cbmservicio.SelectedItem;
                txtCosto.Text = negocio.DevolverPrecioServicio(aux.id).ToString();
            }
            else
            {

                ServicioNegocio negocio = new ServicioNegocio();
                Servicio aux = new Servicio();

                cbmservicio.DataSource = negocio.ListarServiciosXRubro(rdbVeterinaria.Text);
                cbmservicio.DisplayMember = "Descripcion";
                cbmservicio.ValueMember = "id";

                aux = (Servicio)cbmservicio.SelectedItem;
                txtCosto.Text = negocio.DevolverPrecioServicio(aux.id).ToString();
            }          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cliente == null)
            {                     
                cliente = new frmListarCliente("turno");
                cliente.Owner = this;               
                cliente.FormClosed += new FormClosedEventHandler(ClienteFormClosed);
                cliente.ShowDialog();             
            }
        }

        private void ClienteFormClosed (object sender, EventArgs e)
        {
            cliente = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(mascota == null)
            {
                if (txtIDcliente.Text == "")
                {
                    MessageBox.Show("Primero debe seleccionar un cliente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mascota = new frmBuscarMascota(int.Parse(txtIDcliente.Text));
                    mascota.Owner = this;
                    mascota.FormClosed += new FormClosedEventHandler(MascotaFormClosed);
                    mascota.ShowDialog();
                }
                                 
            }
        }

        private void MascotaFormClosed(object sender, EventArgs e)
        {
            mascota = null;
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbmservicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servicio aux = new Servicio();
            ServicioNegocio negocio = new ServicioNegocio();

            aux = (Servicio)cbmservicio.SelectedItem;
            txtCosto.Text = negocio.DevolverPrecioServicio(aux.id).ToString();
        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {          
            txtFechaTurno.Text = DtpFecha.Value.ToShortDateString();
            txtHora.Text = DtpFecha.Value.ToShortTimeString();                   
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool flag;
            TurnoNegocio negocio = new TurnoNegocio();
            Empleado empleado = new Empleado();

            empleado = (Empleado)dgvempleados.CurrentRow.DataBoundItem;

            flag=negocio.VerificarHora(txtHora.Text,empleado.id,txtFechaTurno.Text);


            if(txtapellidocli.Text == "" || txtnombrecli.Text == "" || txtnombremasc.Text==""|| txtEspecie.Text == "" || txtapellidomasc.Text == "" || txtraza.Text == "" || txtHora.Text=="" || txtHora.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(flag == true)
            {
                lblAviso.Show();                                                                                         
            }
            else
            {
                lblAviso.Visible = false;
                int aux2;

                Turno nuevo = new Turno();           
                Empleado aux = new Empleado();
                nuevo.cliente = new Cliente();
                nuevo.animal = new Animal();
                nuevo.servicio = new Servicio();
                nuevo.empleado = new Empleado();

                aux = (Empleado)dgvempleados.CurrentRow.DataBoundItem;

                nuevo.cliente.id = int.Parse (txtIDcliente.Text);
                nuevo.animal.id = int.Parse(txtIDmascota.Text);
                nuevo.empleado.id = aux.id;
                nuevo.servicio.id = (int)cbmservicio.SelectedValue;
                nuevo.fecha =txtFechaTurno.Text;
                nuevo.hora = txtHora.Text;

                negocio.cargarTurno(nuevo);
                aux2 = negocio.DevolverUltimoID();

                if(rdbPeluqueria.Checked == true)
                {
                    negocio.CargarHorasTomadasPeluqueria(txtHora.Text,txtFechaTurno.Text, aux,aux2);
                }
                if (rdbVeterinaria.Checked == true)
                {
                    negocio.CargarHorasTomadasVeterinaria(txtHora.Text, txtFechaTurno.Text, aux,aux2);
                }             

                MessageBox.Show("Turno guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdbVeterinaria_CheckedChanged(object sender, EventArgs e)
        {
            cargarListaEmpleados();
            cargarServicios();
        }

        private void rdbPeluqueria_CheckedChanged(object sender, EventArgs e)
        {
            cargarListaEmpleados();
            cargarServicios();
        }

        private void txtHora_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
