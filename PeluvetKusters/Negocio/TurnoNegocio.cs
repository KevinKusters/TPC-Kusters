using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class TurnoNegocio
    {
        public List<Turno> listarTurnos()
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            List<Turno> Listado = new List<Turno>();
            Turno turno;
            try
            {
                accesoDatos.setearSP("sp_listar_turnos");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    turno = new Turno();

                    turno.id = (int)accesoDatos.Lector["idTurno"];

                    turno.cliente = new Cliente();
                    turno.cliente.nombre = accesoDatos.Lector["Nombre"].ToString();
                    turno.cliente.apellido = accesoDatos.Lector["Apellido"].ToString();

                    turno.animal = new Animal();
                    turno.animal.nombre = accesoDatos.Lector["Mascota"].ToString();

                    turno.animal.raza = new Raza();
                    turno.animal.raza.nombre = accesoDatos.Lector["Raza"].ToString();

                    turno.servicio = new Servicio();
                    turno.servicio.descripcion = accesoDatos.Lector["Servicio"].ToString();
                    turno.servicio.precio = (decimal)accesoDatos.Lector["Precio"];

                    turno.empleado = new Empleado();
                    turno.empleado.nombre = accesoDatos.Lector["NombreEmpleado"].ToString();
                    turno.empleado.apellido = accesoDatos.Lector["ApellidoEmpleado"].ToString();

                    turno.fecha = (DateTime)accesoDatos.Lector["Fecha"];
                    turno.hora = (DateTime)accesoDatos.Lector["Hora"];

                    Listado.Add(turno);
                }

                return Listado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cargarTurno(Turno nuevo)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            try
            {
                accesoDatos.setearConsulta("INSERT INTO TURNOS (IDCLIENTE,IDMASCOTA,IDSERVICIO,IDEMPLEADO,FECHA,HORA,ESTADO) VALUES (@IDCLIENTE,@IDMASCOTA,@IDSERVICIO,@IDEMPLEADO,@FECHA,@HORA,@ESTADO)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@IDCLIENTE", nuevo.cliente.id);
                accesoDatos.Comando.Parameters.AddWithValue("@IDMASCOTA", nuevo.animal.id);
                accesoDatos.Comando.Parameters.AddWithValue("@IDSERVICIO", nuevo.servicio.id);
                accesoDatos.Comando.Parameters.AddWithValue("@IDEMPLEADO", nuevo.empleado.id);
                accesoDatos.Comando.Parameters.AddWithValue("@FECHA", nuevo.fecha);
                accesoDatos.Comando.Parameters.AddWithValue("@HORA",nuevo.hora);
                accesoDatos.Comando.Parameters.AddWithValue("@ESTADO", true);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Turno> listarTurnosHoy()
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            List<Turno> Listado = new List<Turno>();
            Turno turno;
            try
            {
                accesoDatos.setearSP("sp_listar_turnos_hoy");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    turno = new Turno();

                    turno.id = (int)accesoDatos.Lector["idTurno"];

                    turno.cliente = new Cliente();
                    turno.cliente.nombre = accesoDatos.Lector["Nombre"].ToString();
                    turno.cliente.apellido = accesoDatos.Lector["Apellido"].ToString();

                    turno.animal = new Animal();
                    turno.animal.nombre = accesoDatos.Lector["Mascota"].ToString();

                    turno.animal.raza = new Raza();
                    turno.animal.raza.nombre = accesoDatos.Lector["Raza"].ToString();

                    turno.servicio = new Servicio();
                    turno.servicio.descripcion = accesoDatos.Lector["Servicio"].ToString();
                    turno.servicio.precio = (decimal)accesoDatos.Lector["Precio"];

                    turno.empleado = new Empleado();
                    turno.empleado.nombre = accesoDatos.Lector["NombreEmpleado"].ToString();
                    turno.empleado.apellido = accesoDatos.Lector["ApellidoEmpleado"].ToString();

                    turno.fecha = (DateTime)accesoDatos.Lector["Fecha"];
                    turno.hora = (DateTime)accesoDatos.Lector["Hora"];

                    Listado.Add(turno);
                }

                return Listado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
