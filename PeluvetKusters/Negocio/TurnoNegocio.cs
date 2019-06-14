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
                    turno.animal.especie = accesoDatos.Lector["especie"].ToString();

                    turno.animal.raza = new Raza();
                    turno.animal.raza.nombre = accesoDatos.Lector["Raza"].ToString();

                    turno.servicio = new Servicio();
                    turno.servicio.descripcion = accesoDatos.Lector["Servicio"].ToString();
                    turno.servicio.precio = (decimal)accesoDatos.Lector["Precio"];

                    turno.empleado = new Empleado();
                    turno.empleado.nombre = accesoDatos.Lector["NombreEmpleado"].ToString();
                    turno.empleado.apellido = accesoDatos.Lector["ApellidoEmpleado"].ToString();

                    turno.fecha = Convert.ToDateTime(accesoDatos.Lector["Fecha"]).ToShortDateString().ToString();              
                    turno.hora = accesoDatos.Lector["Hora"].ToString();

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
                accesoDatos.Comando.Parameters.AddWithValue("@FECHA", DateTime.Parse(nuevo.fecha));
                accesoDatos.Comando.Parameters.AddWithValue("@HORA",TimeSpan.Parse(nuevo.hora));
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
                    turno.animal.especie = accesoDatos.Lector["especie"].ToString();

                    turno.animal.raza = new Raza();
                    turno.animal.raza.nombre = accesoDatos.Lector["Raza"].ToString();

                    turno.servicio = new Servicio();
                    turno.servicio.descripcion = accesoDatos.Lector["Servicio"].ToString();
                    turno.servicio.precio = (decimal)accesoDatos.Lector["Precio"];

                    turno.empleado = new Empleado();
                    turno.empleado.nombre = accesoDatos.Lector["NombreEmpleado"].ToString();
                    turno.empleado.apellido = accesoDatos.Lector["ApellidoEmpleado"].ToString();

                    turno.fecha = Convert.ToDateTime(accesoDatos.Lector["Fecha"]).ToShortDateString().ToString();
                    turno.hora = accesoDatos.Lector["Hora"].ToString();

                    Listado.Add(turno);
                }

                return Listado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Turno> listarTurnosXfecha(string fecha)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            List<Turno> Listado = new List<Turno>();
            Turno turno;
            try
            {
                accesoDatos.setearConsulta("select t.id as IdTurno,t.fecha as Fecha,t.hora as Hora, c.nombre as Nombre,c.apellido as Apellido,a.nombre as Mascota,a.Especie as especie,r.nombre as Raza,s.descripcion as Servicio,s.precio as Precio,e.nombre as NombreEmpleado ,e.apellido as ApellidoEmpleado from turnos as t inner join clientes as c on c.id = t.idcliente inner join animales as a on a.id = t.idmascota inner join razas as r on r.id = a.idraza inner join servicios as s on s.id = t.idservicio inner join empleados as e on e.id = t.idempleado where t.estado like 1 and t.realizado like 0 and DATEPART(year, t.fecha) like DATEPART(year, @fecha) and DATEPART(MONTH, t.fecha) like DATEPART(MONTH, @fecha) and DATEPART(DAY, t.fecha) like DATEPART(DAY, @fecha)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@fecha", DateTime.Parse(fecha));

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
                    turno.animal.especie = accesoDatos.Lector["Especie"].ToString();

                    turno.animal.raza = new Raza();
                    turno.animal.raza.nombre = accesoDatos.Lector["Raza"].ToString();

                    turno.servicio = new Servicio();
                    turno.servicio.descripcion = accesoDatos.Lector["Servicio"].ToString();
                    turno.servicio.precio = (decimal)accesoDatos.Lector["Precio"];

                    turno.empleado = new Empleado();
                    turno.empleado.nombre = accesoDatos.Lector["NombreEmpleado"].ToString();
                    turno.empleado.apellido = accesoDatos.Lector["ApellidoEmpleado"].ToString();

                    turno.fecha = Convert.ToDateTime(accesoDatos.Lector["Fecha"]).ToShortDateString().ToString();
                    turno.hora = accesoDatos.Lector["Hora"].ToString();

                    Listado.Add(turno);
                }

                return Listado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void CancelarTurno(Turno cancelado)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("UPDATE TURNOS SET ESTADO = @estado WHERE ID LIKE @id");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@estado", cancelado.estado);
                accesoDatos.Comando.Parameters.AddWithValue("@ID", cancelado.id);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void TurnoRealizado(Turno turno)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("UPDATE TURNOS SET REALIZADO = @realizado WHERE ID LIKE @id");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@realizado", turno.realizado);
                accesoDatos.Comando.Parameters.AddWithValue("@ID", turno.id);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Turno> listarTurnosRealizados()
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            List<Turno> Listado = new List<Turno>();
            Turno turno;
            try
            {
                accesoDatos.setearSP("sp_listar_turnos_realizados");
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
                    turno.animal.especie = accesoDatos.Lector["especie"].ToString();

                    turno.animal.raza = new Raza();
                    turno.animal.raza.nombre = accesoDatos.Lector["Raza"].ToString();

                    turno.servicio = new Servicio();
                    turno.servicio.descripcion = accesoDatos.Lector["Servicio"].ToString();
                    turno.servicio.precio = (decimal)accesoDatos.Lector["Precio"];

                    turno.empleado = new Empleado();
                    turno.empleado.nombre = accesoDatos.Lector["NombreEmpleado"].ToString();
                    turno.empleado.apellido = accesoDatos.Lector["ApellidoEmpleado"].ToString();

                    turno.fecha = Convert.ToDateTime(accesoDatos.Lector["Fecha"]).ToShortDateString().ToString();
                    turno.hora = accesoDatos.Lector["Hora"].ToString();

                    Listado.Add(turno);
                }

                return Listado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool VerificarHora(string hora,int id,string fecha)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            bool flag = false;

            try
            {
                accesoDatos.setearConsulta("SELECT * FROM TURNOSTOMADOS WHERE ESTADO LIKE 1 AND REALIZADO LIKE 0");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    if(TimeSpan.Parse(hora) >= (TimeSpan)accesoDatos.Lector["HORAINICIO"] && TimeSpan.Parse(hora) <= (TimeSpan)accesoDatos.Lector["HORAFIN"] && DateTime.Parse(fecha) == (DateTime)accesoDatos.Lector["fecha"] && id == (int)accesoDatos.Lector["idempleado"])
                    {
                        flag = true;
                        return flag;
                    }
                }

                return flag;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
     
        public void CargarHorasTomadasPeluqueria(String hora, string fecha,Empleado empleado,int id)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            TimeSpan aux1;
            TimeSpan aux2;            

            try
            {
                accesoDatos.setearConsulta("INSERT INTO TURNOSTOMADOS (FECHA, HORAINICIO, HORAFIN,IDEMPLEADO,IDTURNO) VALUES (@fecha, @horainicio,@horafin,@idempleado,@idturno)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@fecha", DateTime.Parse(hora));
                accesoDatos.Comando.Parameters.AddWithValue("@horainicio", TimeSpan.Parse(hora));

                aux1 = TimeSpan.Parse(hora);
                aux2 = TimeSpan.Parse("02:00");
                aux1 = aux1 + aux2;             

                accesoDatos.Comando.Parameters.AddWithValue("@horafin", aux1);
                accesoDatos.Comando.Parameters.AddWithValue("@idempleado", empleado.id);
                accesoDatos.Comando.Parameters.AddWithValue("@idturno", id);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

        public void CargarHorasTomadasVeterinaria(String hora, string fecha, Empleado empleado,int id)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            TimeSpan aux1;
            TimeSpan aux2;

            try
            {
                accesoDatos.setearConsulta("INSERT INTO TURNOSTOMADOS (FECHA, HORAINICIO, HORAFIN,IDEMPLEADO,IDTURNO) VALUES (@fecha, @horainicio,@horafin,@idempleado,@idturno)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@fecha", DateTime.Parse(hora));
                accesoDatos.Comando.Parameters.AddWithValue("@horainicio", TimeSpan.Parse(hora));                

                aux1 = TimeSpan.Parse(hora);
                aux2 = TimeSpan.Parse("00:30");
                aux1 = aux1 + aux2;

                accesoDatos.Comando.Parameters.AddWithValue("@horafin",aux1);
                accesoDatos.Comando.Parameters.AddWithValue("@idempleado", empleado.id);
                accesoDatos.Comando.Parameters.AddWithValue("@idturno", id);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

        public void CancelarTurnoTomado(int id)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("UPDATE TURNOSTOMADOS SET ESTADO = @estado WHERE IDTURNO LIKE @idturno");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@estado",false);
                accesoDatos.Comando.Parameters.AddWithValue("@idturno", id);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int DevolverUltimoID()
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            int aux = 0;

            try
            {
                accesoDatos.setearConsulta("SELECT MAX(ID) as ID FROM TURNOS");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                if (accesoDatos.Lector.Read())
                {
                    aux = (int)accesoDatos.Lector["ID"];
                }

                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
