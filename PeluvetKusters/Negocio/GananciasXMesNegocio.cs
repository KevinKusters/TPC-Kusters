using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class GananciasXMesNegocio
    {


        public List<GananciasXMes> ListarGananciasPorMes()
        {
            List<GananciasXMes> Listado = new List<GananciasXMes>();

            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            GananciasXMes GanMes= new GananciasXMes();;
            DateTime aux;
           

            try
            {

                //Por error el estado por default de una venta es 0 (FALSE), solo en este caso el 0 significa que la venta esta activa y no fue cancelada

                accesoDatos.setearConsulta("SELECT * FROM VENTAS WHERE ESTADO LIKE 0 AND DATEPART(YEAR,FECHA) like DATEPART(YEAR,GETDATE())");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                   
                    aux = (DateTime)accesoDatos.Lector["FECHA"];
                  
                    if(aux.Month == 1)
                    {
                        GanMes.numeroMes = 1;
                        GanMes.nombre = "Enero";
                        GanMes.ganancia += (decimal)accesoDatos.Lector["PRECIO"] - (decimal)accesoDatos.Lector["COSTO"];
                    }
                    if (aux.Month == 2)
                    {
                        GanMes.numeroMes = 2;
                        GanMes.nombre = "Febrero";
                        GanMes.ganancia += (decimal)accesoDatos.Lector["PRECIO"] - (decimal)accesoDatos.Lector["COSTO"];
                    }
                    if (aux.Month == 3)
                    {
                        GanMes.numeroMes = 3;
                        GanMes.nombre = "Marzo";
                        GanMes.ganancia += (decimal)accesoDatos.Lector["PRECIO"] - (decimal)accesoDatos.Lector["COSTO"];
                    }
                    if (aux.Month == 4)
                    {
                        GanMes.numeroMes = 4;
                        GanMes.nombre = "Abril";
                        GanMes.ganancia += (decimal)accesoDatos.Lector["PRECIO"] - (decimal)accesoDatos.Lector["COSTO"];
                    }
                    if (aux.Month == 5)
                    {
                        GanMes.numeroMes = 5;
                        GanMes.nombre = "Mayo";
                        GanMes.ganancia += (decimal)accesoDatos.Lector["PRECIO"] - (decimal)accesoDatos.Lector["COSTO"];
                    }
                    if (aux.Month == 6)
                    {
                        GanMes.numeroMes = 6;
                        GanMes.nombre = "Junio";
                        GanMes.ganancia += (decimal)accesoDatos.Lector["PRECIO"] - (decimal)accesoDatos.Lector["COSTO"];
                    }
                    if (aux.Month == 7)
                    {
                        GanMes.numeroMes = 7;
                        GanMes.nombre = "Julio";
                        GanMes.ganancia += (decimal)accesoDatos.Lector["PRECIO"] - (decimal)accesoDatos.Lector["COSTO"];
                    }
                    if (aux.Month == 8)
                    {
                        GanMes.numeroMes = 8;
                        GanMes.nombre = "Agosto";
                        GanMes.ganancia += (decimal)accesoDatos.Lector["PRECIO"] - (decimal)accesoDatos.Lector["COSTO"];
                    }
                    if (aux.Month == 9)
                    {
                        GanMes.numeroMes = 9;
                        GanMes.nombre = "Septiembre";
                        GanMes.ganancia += (decimal)accesoDatos.Lector["PRECIO"] - (decimal)accesoDatos.Lector["COSTO"];
                    }
                    if (aux.Month == 10)
                    {
                        GanMes.numeroMes = 10;
                        GanMes.nombre = "Octubre";
                        GanMes.ganancia += (decimal)accesoDatos.Lector["PRECIO"] - (decimal)accesoDatos.Lector["COSTO"];
                    }
                    if (aux.Month == 11)
                    {
                        GanMes.numeroMes = 11;
                        GanMes.nombre = "Noviembre";
                        GanMes.ganancia += (decimal)accesoDatos.Lector["PRECIO"] - (decimal)accesoDatos.Lector["COSTO"];
                    }
                    if (aux.Month == 12)
                    {
                        GanMes.numeroMes = 12;
                        GanMes.nombre = "Diciembre";
                        GanMes.ganancia += (decimal)accesoDatos.Lector["PRECIO"] - (decimal)accesoDatos.Lector["COSTO"];
                    }
                   
                }

                Listado.Add(GanMes);
                return Listado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
