using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class ProveedorNegocio
    {
        public List<Proveedor> ListarProveedor()
        {
            List<Proveedor> listado = new List<Proveedor>();
            ManagerAccesoDatos AccesoDatos = new ManagerAccesoDatos();
            Proveedor Prov;
            try
            {
                //AccesoDatos.setearConsulta("select p.idproveedor,p.nombre,p.contacto,l.idlocalidad,l.nombre as Localidad,pj.Razonsocial,pj.cuit as cuit_empresa,pj.idperjuridica from proveedores as p inner join personasJuridicas as pj on pj.idperjuridica = p.idperjuridica inner join localidades as l on l.idlocalidad = p.idlocalidad");
                AccesoDatos.setearSP("sp_listar_proveedores");
                AccesoDatos.abrirConexion();
                AccesoDatos.ejecutarConsulta();
                while (AccesoDatos.Lector.Read())
                {

                    Prov = new Proveedor();

                    Prov.idProveedor = (int)AccesoDatos.Lector["idproveedor"];
                    Prov.Nombre = AccesoDatos.Lector["nombre"].ToString();
                    Prov.contacto = AccesoDatos.Lector["email"].ToString();
                    Prov.Telefono = AccesoDatos.Lector["telefono"].ToString();
                    Prov.id = (int)AccesoDatos.Lector["idperjuridica"];
                    Prov.razonSocial = AccesoDatos.Lector["Razonsocial"].ToString();
                    Prov.cuit = (Int64)AccesoDatos.Lector["cuit_empresa"];                    

                    listado.Add(Prov);
                }
                    
                return listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Agregar_proveedor(Proveedor aux)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            try
            {
                accesoDatos.setearConsulta("INSERT INTO PROVEEDORES (nombre, idperjuridica, email, telefono, estado) VALUES (@NOMBRE,@IDPERJURIDICA,@EMAIL,@TELEFONO,@ESTADO)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@NOMBRE", aux.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@IDPERJURIDICA", aux.id);
                accesoDatos.Comando.Parameters.AddWithValue("@EMAIL", aux.contacto);
                accesoDatos.Comando.Parameters.AddWithValue("@TELEFONO", aux.Telefono);
                accesoDatos.Comando.Parameters.AddWithValue("@estado", aux.estado);

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

        public bool ChequearProducto(int idproducto, int idproveedor)
        {
            bool existe = false;
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            accesoDatos.setearConsulta("select * from  ProductosXproveedores where idproducto like  @idproducto and idproveedor like @idproveedor");
            accesoDatos.Comando.Parameters.Clear();
            accesoDatos.Comando.Parameters.AddWithValue("@idproducto", idproducto);
            accesoDatos.Comando.Parameters.AddWithValue("@idproveedor", idproveedor);

            accesoDatos.abrirConexion();
            accesoDatos.ejecutarAccion();

            if (accesoDatos.Lector.Read()) {
                existe = true;
                return existe;
            }
            else
            {
                return existe;
            }
        }

        public void CargarProdXProv(int idprov, int idprod)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("insert into ProductosXproveedores (idproveedor,idproducto) values (@idproveedor,@idproducto)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@idproveedor", idprov);
                accesoDatos.Comando.Parameters.AddWithValue("@idproducto", idprod);

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

        public List<Proveedor> cargarComboProv()
        {
            List<Proveedor> listado = new List<Proveedor>();
            ManagerAccesoDatos AccesoDatos = new ManagerAccesoDatos();
            Proveedor Prov;
            try
            {
                //AccesoDatos.setearConsulta("select idproveedor,nombre from proveedores");
                AccesoDatos.setearSP("sp_cargar_cbo_proveedores");
                AccesoDatos.abrirConexion();
                AccesoDatos.ejecutarConsulta();
                while (AccesoDatos.Lector.Read())
                {
                    Prov = new Proveedor();
                    Prov.idProveedor = (int)AccesoDatos.Lector["idproveedor"];
                    Prov.Nombre = AccesoDatos.Lector["nombre"].ToString();

                    listado.Add(Prov);
                }
                
                return listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                AccesoDatos.cerrarConexion();
            }
        }

    }
}
