using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class LocalidadNegocio
    {

        public List<Localidad> ListarLocalidades()
        {
            List<Localidad> listado = new List<Localidad>();
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            Localidad Loc;
            try
            {
                accesoDatos.setearConsulta("select * from LOCALIDADES");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    Loc = new Localidad();
                    Loc.id = (int)accesoDatos.Lector["idlocalidad"];
                    Loc.nombre = accesoDatos.Lector["nombre"].ToString();

                    listado.Add(Loc);
                }

                return listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AgregarLocalidad(Localidad loc)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            try
            {
                accesoDatos.setearConsulta("INSERT INTO LOCALIDADES (NOMBRE) VALUES (@NOMBRE)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@NOMBRE", loc.nombre);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
         
        }


        public void ModificarLocalidad(Localidad Modificada)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("UPDATE LOCALIDADES SET NOMBRE = @nombre WHERE IDLOCALIDAD = @id ");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@id", Modificada.id);
                accesoDatos.Comando.Parameters.AddWithValue("@NOMBRE", Modificada.nombre);

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
