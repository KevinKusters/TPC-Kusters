﻿using System;
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
                accesoDatos.setearConsulta("select * from LOCALIDADES WHERE ESTAD LIKE 1");
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


        public void eliminarLocalidad(Localidad eliminado)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("UPDATE LOCALIDADES SET ESTADO = 0 WHERE id = @id");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@id", eliminado.id);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int DevolverID(string nombre)
        {
            
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            int devuelve = -1;

            try
            {
                accesoDatos.setearConsulta("select IDLOCALIDAD from LOCALIDADES WHERE ESTAD LIKE 1 and NOMBRE LIKE '@NOMBRE'");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@NOMBRE", nombre);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                if (accesoDatos.Lector.Read())
                {
                    devuelve = (int)accesoDatos.Lector["ID"];
                }

                return devuelve;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
