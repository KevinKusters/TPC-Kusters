using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class VentaNegocio
    {
        public List<Venta> ListarVentas()
        {
            List<Venta> listado = new List<Venta>();
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            Venta venta;

            try
            {
                accesoDatos.setearSP("sp_Listar_Ventas");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    venta = new Venta();

                    venta.IdVenta = (int)accesoDatos.Lector["idventa"];
                    venta.Costo = (decimal)accesoDatos.Lector["costo"];
                    venta.PrecioVenta = (decimal)accesoDatos.Lector["precio"];
                    venta.cantidad = (int)accesoDatos.Lector["cantidad"];

                    venta.producto = new Producto();
                    venta.producto.descripcion = accesoDatos.Lector["descripcion"].ToString();
                    
                    venta.Fecha = (DateTime)accesoDatos.Lector["fecha"];

                    listado.Add(venta);
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

        public void CargarVenta(Venta nueva)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("INSERT INTO VENTAS (COSTO,PRECIO,IDPRODUCTO,FECHA,CANTIDAD) VALUES (@costo, @precio, @idproducto,@fecha,@cantidad)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@costo", nueva.Costo);
                accesoDatos.Comando.Parameters.AddWithValue("@precio", nueva.PrecioVenta);
                accesoDatos.Comando.Parameters.AddWithValue("@idproducto", nueva.producto.idProducto);
                accesoDatos.Comando.Parameters.AddWithValue("@fecha", nueva.Fecha);
                accesoDatos.Comando.Parameters.AddWithValue("@cantidad", nueva.cantidad);

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

        public void CancelarVenta(Venta Cancelada)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("UPDATE VENTAS ESTADO = @estado WHERE ID = @id");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@estado", 1);
                accesoDatos.Comando.Parameters.AddWithValue("@id", Cancelada.IdVenta);

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

        public decimal CalcularRecaudacionHOY()
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            decimal aux = 0;            

            try
            {
                accesoDatos.setearConsulta("SELECT * FROM VENTAS WHERE DATEPART(YEAR,FECHA) LIKE DATEPART(YEAR,GETDATE()) AND  DATEPART(MONTH,FECHA) LIKE DATEPART(MONTH,GETDATE()) AND  DATEPART(DAY,FECHA) LIKE DATEPART(DAY,GETDATE())");            

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    aux += (decimal)accesoDatos.Lector["PRECIO"] - (decimal)accesoDatos.Lector["COSTO"];
                }

                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public decimal traerCostoHOY()
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            decimal aux = 0;

            try
            {
                accesoDatos.setearConsulta("SELECT COSTO FROM VENTAS WHERE FECHA LIKE @fecha");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@fecha", DateTime.Now);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    aux += (decimal)accesoDatos.Lector["COSTO"];
                }

                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Venta> ListarVentasHOY()
        {
            List<Venta> listado = new List<Venta>();
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            Venta venta;

            try
            {
                accesoDatos.setearSP("sp_Listar_ventas_hoy");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    venta = new Venta();

                    venta.IdVenta = (int)accesoDatos.Lector["idventa"];
                    venta.Costo = (decimal)accesoDatos.Lector["costo"];
                    venta.PrecioVenta = (decimal)accesoDatos.Lector["precio"];
                    venta.cantidad = (int)accesoDatos.Lector["cantidad"];

                    venta.producto = new Producto();
                    venta.producto.descripcion = accesoDatos.Lector["descripcion"].ToString();                    
                    venta.Fecha = (DateTime)accesoDatos.Lector["fecha"];

                    listado.Add(venta);
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

        public void reducirStock(Producto vendido,int cantidad)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("UPDATE PRODUCTOS SET STOCK =  @stock WHERE ID = @id");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@stock", vendido.stock - cantidad);
                accesoDatos.Comando.Parameters.AddWithValue("@id", vendido.idProducto);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Venta> listarVentasXFecha(string fecha)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            List<Venta> listado = new List<Venta>();
            Venta venta;

            try
            {
                accesoDatos.setearConsulta("SELECT * FROM VENTAS WHERE ESTADO LIKE 0 AND DATEPART(YEAR,FECHA) LIKE DATEPART(YEAR,@fecha) AND DATEPART(MONTH,FECHA) LIKE DATEPART(MONTH, @fecha) AND DATEPART(DAY,FECHA) LIKE DATEPART(DAY,@fecha)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@fecha", DateTime.Parse(fecha));

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    venta = new Venta();

                    venta.IdVenta = (int)accesoDatos.Lector["idventa"];
                    venta.Costo = (decimal)accesoDatos.Lector["costo"];
                    venta.PrecioVenta = (decimal)accesoDatos.Lector["precio"];
                    venta.cantidad = (int)accesoDatos.Lector["cantidad"];

                    venta.producto = new Producto();
                    venta.producto.descripcion = accesoDatos.Lector["descripcion"].ToString();

                    venta.Fecha = (DateTime)accesoDatos.Lector["fecha"];

                    listado.Add(venta);
                }

                return listado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
