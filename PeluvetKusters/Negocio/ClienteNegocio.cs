using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class ClienteNegocio
    {
        public List<Cliente> ListarClientes()
        {

            List<Cliente> Listado = new List<Cliente>();
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            Cliente cliente;
            
            try
            {
                accesoDatos.setearSP("sp_listar_clientes");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    cliente = new Cliente();                    

                    cliente.id = (int)accesoDatos.Lector["id"];
                    cliente.nombre = accesoDatos.Lector["nombre"].ToString();
                    cliente.apellido = accesoDatos.Lector["apellido"].ToString();
                    cliente.contacto = accesoDatos.Lector["contacto"].ToString();

                    cliente.localidad = new Localidad();

                    cliente.localidad.nombre = accesoDatos.Lector["Localidad"].ToString();
                    cliente.localidad.id = (int)accesoDatos.Lector["idlocalidad"];

                    Listado.Add(cliente);
                }

                return Listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void agregarCliente(Cliente nuevo)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            try
            {
                accesoDatos.setearConsulta("INSERT INTO CLIENTES (NOMBRE, APELLIDO,CONTACTO,LOCALIDAD,ESTADO) VALUES (@NOMBRE,@APELLIDO,@CONTACTO,@LOCALIDAD,@ESTADO)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@NOMBRE", nuevo.nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@APELLIDO", nuevo.apellido);
                accesoDatos.Comando.Parameters.AddWithValue("@CONTACTO", nuevo.contacto);
                accesoDatos.Comando.Parameters.AddWithValue("@LOCALIDAD", nuevo.localidad.id);
                accesoDatos.Comando.Parameters.AddWithValue("@ESTADO", nuevo.estado);

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
