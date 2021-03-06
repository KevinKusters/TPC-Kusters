﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;                      

namespace AccesoDatos
{
    public class ManagerAccesoDatos
    {   
        //poner server...

        public static string cadenaConexion = "server=CLARIS ; database=peluvet; integrated security = true";
        private SqlCommand comando;
        private SqlConnection conexion;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public SqlCommand Comando
        {
            get { return comando; }
        }
        public ManagerAccesoDatos()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public void setearConsulta(string consulta)
        {
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void setearSP(string sp)
        {
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = sp;
        }
        public void abrirConexion()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ejecutarAccion()
        {
            try
            {
                comando.Connection = conexion;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ejecutarAccionReturn()
        {
            try
            {
                comando.Connection = conexion;
                return (int)comando.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ejecutarConsulta()
        {
            try
            {
                comando.Connection = conexion;
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}
