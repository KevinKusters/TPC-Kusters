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

        public void ModificarCliente(Cliente modificado)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("UPDATE CLIENTES SET NOMBRE = @nombre, APELLIDO = @apellido, CONTACTO = @contacto, LOCALIDAD = @localidad WHERE ID LIKE @id");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@nombre", modificado.nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@apellido", modificado.apellido);
                accesoDatos.Comando.Parameters.AddWithValue("@contacto", modificado.contacto);
                accesoDatos.Comando.Parameters.AddWithValue("@localidad", modificado.localidad.id);
                accesoDatos.Comando.Parameters.AddWithValue("@ID", modificado.id);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int RecuperarUltimoId()
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            int devuelvo = -1;

            try
            {
                accesoDatos.setearConsulta("SELECT MAX(ID) AS ID FROM CLIENTES WHERE ESTADO LIKE 1");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                if (accesoDatos.Lector.Read())
                {
                    devuelvo = (int)accesoDatos.Lector["ID"];
                }

                return devuelvo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Cliente DevolverClienteWEB(int idUsuario)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            Cliente cliente = new Cliente();

            try
            {
                accesoDatos.setearConsulta("SELECT C.* FROM CLIENTES AS C INNER JOIN REGISTROsWEB AS R ON R.ID = @id");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@id", idUsuario);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                if (accesoDatos.Lector.Read())
                {                   
                    cliente.id = (int)accesoDatos.Lector["id"];
                    cliente.nombre = accesoDatos.Lector["nombre"].ToString();
                    cliente.apellido = accesoDatos.Lector["apellido"].ToString();
                    cliente.contacto = accesoDatos.Lector["contacto"].ToString();
                }

                return cliente;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        } 
        


    }
}

