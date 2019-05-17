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

                    Listado.Add(cliente);
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

