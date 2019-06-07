using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class ProductoNegocio
    {
        public List<Producto> listarProductos()
        {
            List<Producto> listado = new List<Producto>();
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            Producto prod;
            try
            {
                accesoDatos.setearConsulta("SELECT * FROM PRODUCTOS where estado like 1");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    prod = new Producto();

                    prod.idProducto = (int)accesoDatos.Lector["ID"];
                    prod.descripcion = accesoDatos.Lector["DESCRIPCION"].ToString();
                    prod.stock = (int)accesoDatos.Lector["STOCK"];
                    prod.precio = (decimal)accesoDatos.Lector["PRECIO"];
                    prod.precioVenta = (decimal)accesoDatos.Lector["PRECIOVENTA"];
                    prod.porcentGanancia = (int)accesoDatos.Lector["PORCENTAJEGANANCIA"];
                    prod.marca = accesoDatos.Lector["MARCA"].ToString();
                    prod.estado = (bool)accesoDatos.Lector["ESTADO"];
                   
                    listado.Add(prod);
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

        public int  Agregarproducto(Producto prod)
        {
            
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();            
            try
            {            
                accesoDatos.setearConsulta("INSERT INTO PRODUCTOS output inserted.id values (@descripcion,@stock,@precio,@precioventa,@porcentajeganancia,@marca,@estado)");               
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@descripcion", prod.descripcion);
                accesoDatos.Comando.Parameters.AddWithValue("@stock", prod.stock);
                accesoDatos.Comando.Parameters.AddWithValue("@precio", prod.precio);
                accesoDatos.Comando.Parameters.AddWithValue("@marca", prod.marca);
                accesoDatos.Comando.Parameters.AddWithValue("@estado", prod.estado);
                accesoDatos.Comando.Parameters.AddWithValue("@precioventa", prod.precioVenta);
                accesoDatos.Comando.Parameters.AddWithValue("@porcentajeganancia", prod.porcentGanancia);

                accesoDatos.abrirConexion();
                return accesoDatos.ejecutarAccionReturn();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ModificarProducto(Producto mod)
        {
            ManagerAccesoDatos conexion;
            try
            {
                conexion = new ManagerAccesoDatos();
                conexion.setearConsulta("update PRODUCTOS set DESCRIPCION = @descripcion, STOCK = @stock, PRECIO = @precio, PRECIOVENTA = @precioventa, PORCENTAJEGANANCIA = @porcentajeganancia, MARCA = @marca Where Id = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@descripcion", mod.descripcion);
                conexion.Comando.Parameters.AddWithValue("@stock", mod.stock);
                conexion.Comando.Parameters.AddWithValue("@precio", mod.precio);
                conexion.Comando.Parameters.AddWithValue("@precioventa", mod.precioVenta);
                conexion.Comando.Parameters.AddWithValue("@porcentajeganancia", mod.porcentGanancia);
                conexion.Comando.Parameters.AddWithValue("@marca", mod.marca);
                conexion.Comando.Parameters.AddWithValue("@id", mod.idProducto);

                conexion.abrirConexion();
                conexion.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            } 
        }

        public int buscar_ultimo_idprod()
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            int aux;
            try
            {
                accesoDatos.setearConsulta("select max(id) as ID from productos");
                //accesoDatos.setearSP("sp_buscarMax_id_prod");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                if (accesoDatos.Lector.Read())
                {
                    aux = (int)accesoDatos.Lector["ID"];
                    return aux;   
                }

                return accesoDatos.ejecutarAccionReturn();
                            
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

