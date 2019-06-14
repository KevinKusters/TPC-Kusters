using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class PuestoNegocio
    {
        public List<Puesto> ListarPuestos()
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            Puesto puesto;
            List<Puesto> Listado = new List<Puesto>();
            try
            {
                accesoDatos.setearConsulta("SELECT * FROM PUESTOS");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    puesto = new Puesto();
                    puesto.Id = (int)accesoDatos.Lector["ID"];
                    puesto.Descripcion = accesoDatos.Lector["DESCRIPCION"].ToString();

                    Listado.Add(puesto);
                }

                return Listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cargarPuesto(Puesto nuevo)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("INSERT INTO PUESTOS (DESCRIPCION) VALUES (@DESCRIPCION)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@DESCRIPCION", nuevo.Descripcion);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarPuesto(Puesto Modificado)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            try
            {
                accesoDatos.setearConsulta("UPDATE PUESTOS SET DESCRIPCION = @DESCRIPCION WHERE ID LIKE @ID");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@ID", Modificado.Id);
                accesoDatos.Comando.Parameters.AddWithValue("@DESCRIPCION", Modificado.Descripcion);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void eliminarPuesto(Puesto eliminado)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("UPDATE PUESTOS SET ESTADO = 0 WHERE id = @id");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@id", eliminado.Id);

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
