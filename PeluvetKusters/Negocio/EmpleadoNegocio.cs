using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class EmpleadoNegocio
    {
        public List<Empleado> ListarEmpleados()
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            Empleado empleado;
            List<Empleado> Listado = new List<Empleado>();

            try
            {
                accesoDatos.setearSP("sp_listar_empleados");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    empleado = new Empleado();

                    empleado.id = (int)accesoDatos.Lector["ID"];
                    empleado.nombre = accesoDatos.Lector["NOMBRE"].ToString();
                    empleado.apellido = accesoDatos.Lector["APELLIDO"].ToString();
                    empleado.contacto = accesoDatos.Lector["CONTACTO"].ToString();
                    empleado.rubro = accesoDatos.Lector["RUBRO"].ToString();

                    empleado.puesto = new Puesto();

                    empleado.puesto.Descripcion = accesoDatos.Lector["PUESTO"].ToString();
                    empleado.puesto.Id = (int)accesoDatos.Lector["idpuesto"];

                    Listado.Add(empleado);
                }

                return Listado;       

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void CargarEmpleado(Empleado nuevo)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            try
            {
                accesoDatos.setearConsulta("INSERT INTO EMPLEADOS (NOMBRE, APELLIDO, CONTACTO,RUBRO, PUESTO, ESTADO ) VALUES (@NOMBRE, @APELLIDO, @CONTACTO,@RUBRO, @PUESTO, @ESTADO)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@NOMBRE",nuevo.nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@APELLIDO", nuevo.apellido);
                accesoDatos.Comando.Parameters.AddWithValue("@CONTACTO", nuevo.contacto);
                accesoDatos.Comando.Parameters.AddWithValue("@RUBRO", nuevo.rubro);
                accesoDatos.Comando.Parameters.AddWithValue("@PUESTO", nuevo.puesto.Id);
                accesoDatos.Comando.Parameters.AddWithValue("@ESTADO", true);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Empleado> ListarEmpleadosXPuesto(string rubro)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            Empleado empleado;
            List<Empleado> Listado = new List<Empleado>();

            try
            {
                accesoDatos.setearConsulta("select e.id, e.nombre, e.apellido, e.contacto,e.rubro, p.descripcion as puesto, p.id as idpuesto from empleados as e inner join puestos as p on p.id = e.puesto where e.estado like 1 and e.rubro like @rubro");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@rubro", rubro);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    empleado = new Empleado();

                    empleado.id = (int)accesoDatos.Lector["ID"];
                    empleado.nombre = accesoDatos.Lector["NOMBRE"].ToString();
                    empleado.apellido = accesoDatos.Lector["APELLIDO"].ToString();
                    empleado.rubro = accesoDatos.Lector["RUBRO"].ToString();

                    empleado.puesto = new Puesto();

                    empleado.puesto.Descripcion = accesoDatos.Lector["PUESTO"].ToString();
                    empleado.puesto.Id = (int)accesoDatos.Lector["idpuesto"];

                    Listado.Add(empleado);
                }

                return Listado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void ModificarEmpleado(Empleado modificado)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            try
            {
                accesoDatos.setearConsulta("UPDATE EMPLEADOS SET  NOMBRE = @nombre, APELLIDO = @apellido, CONTACTO = @contacto, PUESTO = @puesto, RUBRO = @rubro WHERE ID =  @id");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@nombre", modificado.nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@apellido",modificado.apellido);
                accesoDatos.Comando.Parameters.AddWithValue("@contacto",modificado.contacto);
                accesoDatos.Comando.Parameters.AddWithValue("@puesto", modificado.puesto.Id);
                accesoDatos.Comando.Parameters.AddWithValue("@rubro", modificado.rubro);
                accesoDatos.Comando.Parameters.AddWithValue("@id", modificado.id);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarEmpleado(Empleado eliminado)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("UPDATE EMPLEADOS SET ESTADO = 0 WHERE id = @id");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@id", eliminado.id);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}