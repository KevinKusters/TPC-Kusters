using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;
using AccesoDatos;

namespace Negocio
{
    public class PersonaJuridicaNegocio
    {
        public void Agregar_PersonaJuridica(string razon, Int64 cuit) {

            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            try
            {
                accesoDatos.setearConsulta("insert into personasJuridicas (Razonsocial, cuit) values (@RAZONSOCIAL,@CUIT)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@RAZONSOCIAL", razon);
                accesoDatos.Comando.Parameters.AddWithValue("@CUIT", cuit);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int recuperar_id()
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            int aux;
            try
            {
                accesoDatos.setearConsulta("SELECT max(idperjuridica) as IDPER from personasJuridicas");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                if (accesoDatos.Lector.Read())
                {
                    aux = (int)accesoDatos.Lector["IDPER"];
                    return aux;
                }

                return 0;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
