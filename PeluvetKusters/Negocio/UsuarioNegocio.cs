using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public List<Usuario> DevolverUsuarios()
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            List<Usuario> Listado= new List<Usuario>();
            Usuario usuario;

            try
            {
                accesoDatos.setearConsulta("SELECT * FROM USUARIOS WHERE ESTADO LIKE 1");               
           
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    usuario = new Usuario();
                    usuario.id = (int)accesoDatos.Lector["ID"];
                    usuario.NombreUsuario = accesoDatos.Lector["NOMBREUSUARIO"].ToString();
                    usuario.Contraseña = accesoDatos.Lector["CONTRASEÑA"].ToString();
                    usuario.Admin = (bool)accesoDatos.Lector["ADMINISTRADOR"];

                    Listado.Add(usuario);                    
                }

                return Listado;
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

        public void RegistroUsuario(Usuario Nuevo)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("INSERT INTO USUARIOS (NOMBREUSUARIO,CONTRASEÑA) VALUES (@nombre, @contraseña)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@nombre", Nuevo.NombreUsuario);
                accesoDatos.Comando.Parameters.AddWithValue("@contraseña", Nuevo.Contraseña);

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

        public bool VerificarAdmin()
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            bool Flag=false;
            try
            {
                accesoDatos.setearConsulta("SELECT * FROM USUARIOS WHERE ESTADO LIKE 1 AND ADMINISTRADOR LIKE 1");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                if (accesoDatos.Lector.Read())
                {
                    Flag = true;
                    return Flag;
                }
                else
                {
                    return Flag;
                }                
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

        public void RegistroAdmnin(Usuario Admin)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("INSERT INTO USUARIOS (NOMBREUSUARIO,CONTRASEÑA,ADMINISTRADOR) VALUES (@nombre,@contraseña,@admin)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@nombre",Admin.NombreUsuario);
                accesoDatos.Comando.Parameters.AddWithValue("@contraseña",Admin.Contraseña);
                accesoDatos.Comando.Parameters.AddWithValue("@admin",true);

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

        public void EliminarUsuario(Usuario eliminado)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("USPATE USUARIOS SET ESTADO = @estado WHERE IDUSUARIO = @id");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@estado", false);
                accesoDatos.Comando.Parameters.AddWithValue("@id", eliminado.id);

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


        public void RegistroWeb(Usuario Nuevo, int id)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("INSERT INTO registrosWeb (IDCLIENTE,USUARIO,CONTRASEÑA) VALUES (@id,@nombre, @contraseña)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@nombre", Nuevo.NombreUsuario);
                accesoDatos.Comando.Parameters.AddWithValue("@contraseña", Nuevo.Contraseña);
                accesoDatos.Comando.Parameters.AddWithValue("@id", id);

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


        public bool ValidarNombreUsuario(string nombre)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("SELECT USUARIO FROM registrosWeb WHERE ESTADO LIKE 1 AND USUARIO LIKE @nombre");

                accesoDatos.setearConsulta("SELECT * FROM REGISTROSWEB WHERE USUARIO LIKE @nombre");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("nombre", nombre);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();              

                if (accesoDatos.Lector.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
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

        public List<Usuario> DevolverUsuariosWEB()
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            List<Usuario> Listado = new List<Usuario>();
            Usuario usuario;

            try
            {
                accesoDatos.setearConsulta("SELECT * FROM registrosWeb WHERE ESTADO LIKE 1");

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    usuario = new Usuario();
                    usuario.id = (int)accesoDatos.Lector["ID"];
                    usuario.NombreUsuario = accesoDatos.Lector["USUARIO"].ToString();
                    usuario.Contraseña = accesoDatos.Lector["CONTRASEÑA"].ToString();                    

                    Listado.Add(usuario);
                }

                return Listado;
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
    }
}
