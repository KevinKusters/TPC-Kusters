using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class RazaNegocio
    {
        public List<Raza> listarRazas()
        {
            List<Raza> listado = new List<Raza>();
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            Raza raz = new Raza();
            try
            {
                accesoDatos.setearConsulta("SELECT * FROM RAZAS");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    raz = new Raza();
                    raz.id = (int)accesoDatos.Lector["ID"];
                    raz.nombre = accesoDatos.Lector["NOMBRE"].ToString();
                    listado.Add(raz);
                }

                return listado;
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

        public int AgregarRaza(Raza raza)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            try
            {
                accesoDatos.setearConsulta("INSERT INTO RAZAS output inserted.id values (@nombre)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@nombre", raza.nombre);
                accesoDatos.abrirConexion();
                

                return accesoDatos.ejecutarAccionReturn();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void modificarRaza(Raza mod)
        {
            ManagerAccesoDatos conexion;
            try
            {
                conexion = new ManagerAccesoDatos();
                conexion.setearConsulta("update RAZAS set NOMBRE = @nombre Where Id = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", mod.nombre);
                conexion.Comando.Parameters.AddWithValue("@id", mod.id);

                conexion.abrirConexion();
                conexion.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
