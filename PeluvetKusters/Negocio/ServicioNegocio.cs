using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class ServicioNegocio
    {
        public List<Servicio> ListarServicios()
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            List<Servicio> Listado = new List<Servicio>();
            Servicio servicio;

            try
            {
                accesoDatos.setearConsulta("SELECT * FROM SERVICIOS WHERE ESTADO LIKE 1");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    servicio = new Servicio();
                    servicio.id = (int)accesoDatos.Lector["ID"];
                    servicio.descripcion = accesoDatos.Lector["DESCRIPCION"].ToString();
                    servicio.precio = (decimal)accesoDatos.Lector["PRECIO"];

                    Listado.Add(servicio);
                }

                return Listado;              
  
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregarServicio(Servicio nuevo)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("INSERT INTO SERVICIOS (DESCRIPCION,PRECIO,ESTADO) VALUES (@DESCRIPCION, @PRECIO, @ESTADO)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@DESCRIPCION", nuevo.descripcion);
                accesoDatos.Comando.Parameters.AddWithValue("@PRECIO", nuevo.precio);
                accesoDatos.Comando.Parameters.AddWithValue("@ESTADO", true);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
                   
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarServicio(Servicio Modificado)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            try
            {
                accesoDatos.setearConsulta("UPDATE SERVICIOS SET DESCRIPCION = @descripcion, PRECIO = @precio WHERE ID = @ID");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@ID", Modificado.id);
                accesoDatos.Comando.Parameters.AddWithValue("@descripcion", Modificado.descripcion);
                accesoDatos.Comando.Parameters.AddWithValue("@precio", Modificado.precio);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public decimal DevolverPrecioServicio(int id)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            decimal precio;

            try
            {
                accesoDatos.setearConsulta("SELECT precio FROM SERVICIOS WHERE ID LIKE @id");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@id",id);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                if(accesoDatos.Lector.Read())
                {
                    precio = (decimal)accesoDatos.Lector["precio"];
                    return precio;
                }

                return -1;
                                               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        


    }
}
