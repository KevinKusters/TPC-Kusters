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


    public partial class PedirTurno : System.Web.UI.Page
    {
        List<Empleado> listalocalempleados;
        List<Animal> Listalocalmascotas;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarRubros();
                cargarProfesionales();
                CargarMascota();
            }
        }      
        private void cargarRubros()
        {
            drpRubro.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            drpRubro.Items.Insert(1, new ListItem("Peluqueria", "1"));
            drpRubro.Items.Insert(2, new ListItem("Veterinaria", "2"));
        }
        private void cargarProfesionales()
        {
            EmpleadoNegocio negocio = new EmpleadoNegocio();
            listalocalempleados = new List<Empleado>();

            if(drpRubro.SelectedItem.Text == "Peluqueria" || drpRubro.SelectedItem.Text == "Veterinaria")
            {
                listalocalempleados = negocio.ListarEmpleadosXPuesto(drpRubro.SelectedItem.Text);
                drpProfesionales.DataSource = listalocalempleados;
                drpProfesionales.DataTextField = "nombre";
                drpProfesionales.DataValueField = "id";                
                drpProfesionales.DataBind();
                CargarServicios();
            }
            else
            {
                drpProfesionales.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            }
        }

        private void CargarMascota()
        {
            Listalocalmascotas = new List<Animal>();
            AnimalNegocio negocio = new AnimalNegocio();
            int auxID;
            auxID = (int)Session["variable_sesion"];

            Listalocalmascotas = negocio.ListarAnimalesXcliente(auxID);
            drpMascotas.DataSource = Listalocalmascotas;

            drpMascotas.DataTextField = "nombre";
            drpMascotas.DataValueField = "id";
            drpMascotas.DataBind();
        }
        
        protected void drpRubro_TextChanged(object sender, EventArgs e)
        {
            cargarProfesionales();
        }

        private void CargarServicios()
        {
            ServicioNegocio negocio = new ServicioNegocio();

            drpServicios.DataSource = negocio.ListarServiciosXRubro(drpRubro.SelectedItem.Text);
            drpServicios.DataTextField = "descripcion";
            drpServicios.DataValueField = "id";
            drpServicios.DataBind();
            cargarCosto();
        }


        protected void txtHoraFinal_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtHora_TextChanged(object sender, EventArgs e)
        {
            cargarHoraFIN();
        }

        private void cargarHoraFIN()
        {
            TimeSpan duracionTurno;
            TimeSpan horaTurno;

            if (txtHora.Text == "")
            {
            }
            else
            {
                horaTurno = TimeSpan.Parse(txtHora.Text);

                if (drpRubro.SelectedItem.Text == "Peluqueria")
                {
                    duracionTurno = TimeSpan.Parse("02:00");
                }
                else
                {
                    duracionTurno = TimeSpan.Parse("00:30");
                }

                txtHoraFinal.Text = (horaTurno + duracionTurno).ToString();
            }
        }

        private void cargarCosto()
        {
            ServicioNegocio negocio = new ServicioNegocio();
            int aux;

            aux = Convert.ToInt32(drpServicios.SelectedValue);
            txtCosto.Text = negocio.DevolverPrecioServicio(aux).ToString();
        }


        protected void drpServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCosto();
        }


        protected void btnAceptar_Click(object sender, EventArgs e)
        {            
            ClienteNegocio clientenegocio = new ClienteNegocio();
            Turno turno = new Turno();
            TurnoNegocio turnonegocio = new TurnoNegocio();
            int aux;
            bool flag;


            flag = turnonegocio.VerificarHora(txtHora.Text, Convert.ToInt32(drpProfesionales.SelectedValue), txtFecha.Text);

            if (txtCosto.Text == "" || txtFecha.Text == "" || txtHora.Text == "" || txtHoraFinal.Text == "")
            {
                Response.Write("<script>window.alert('Debe completar todos los campos para pedir un turno');</script>");
            }
            else if(flag == true)
            {
                Response.Write("<script>window.alert('El turno seleccionado esta ocupado');</script>");
            }
              else
              {
                turno.animal = new Animal();
                turno.empleado = new Empleado();
                turno.servicio = new Servicio();

                turno.cliente = clientenegocio.DevolverClienteWEB((int)Session["variable_sesion"]);
                turno.animal.id =Convert.ToInt32(drpMascotas.SelectedItem.Value);
                turno.empleado.id = Convert.ToInt32(drpProfesionales.SelectedValue);
                turno.servicio.id = Convert.ToInt32(drpServicios.SelectedValue);
                turno.fecha = txtFecha.Text;
                turno.hora = txtHora.Text;
                turno.estado = true;
             
                turnonegocio.cargarTurno(turno);
                aux = turnonegocio.DevolverUltimoID();

                 if (drpRubro.SelectedItem.Text == "Peluqueria")
                 {
                    turnonegocio.CargarHorasTomadasPeluqueria(txtHora.Text, txtFecha.Text, Convert.ToInt32(drpProfesionales.SelectedValue), aux);
                 }
                   else if (drpRubro.SelectedItem.Text == "Veterinaria")
                   {
                      turnonegocio.CargarHorasTomadasVeterinaria(txtHora.Text, txtFecha.Text, Convert.ToInt32(drpProfesionales.SelectedValue), aux);
                   }
                     else
                     {
                        Response.Write("ERROR");
                     }
              }
        }
    }
}
