using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class AnimalNegocio
    {
        public List<Animal> ListarAnimales()
        {
            List<Animal> Listado = new List<Animal>();
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            Animal animal;
            try
            {
                accesoDatos.setearSP("sp_listar_mascotas");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    animal = new Animal();

                    animal.nombre = accesoDatos.Lector["nombre"].ToString();
                    animal.apellido = accesoDatos.Lector["apellido"].ToString();
                    animal.especie = accesoDatos.Lector["especie"].ToString();
                    animal.raza = new Raza();
                    animal.raza.id = (int)accesoDatos.Lector["id"];
                    animal.raza.nombre = accesoDatos.Lector["RazaNombre"].ToString();

                    Listado.Add(animal);
                }

                return Listado;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void AgregarAnimal(Animal nuevo)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            try
            {
                accesoDatos.setearConsulta("INSERT INTO ANIMALES (idraza,nombre,apellido,especie,estado,idcliente) values (@idraza,@nombre,@apellido,@especie,@estado,@idcliente)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@idraza", nuevo.raza.id);
                accesoDatos.Comando.Parameters.AddWithValue("@nombre", nuevo.nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@apellido", nuevo.apellido);
                accesoDatos.Comando.Parameters.AddWithValue("@especie", nuevo.especie);
                accesoDatos.Comando.Parameters.AddWithValue("@idcliente",nuevo.idcliente);

                accesoDatos.Comando.Parameters.AddWithValue("@estado", true);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Animal> ListarAnimalesXcliente(int idcliente)
        {
            List<Animal> Listado = new List<Animal>();
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            Animal animal;
            try
            {
                //accesoDatos.setearConsulta("select distinct a.nombre,a.apellido,a.especie,r.nombre as Raza from animales as a inner join razas as r on r.id = a.idraza inner join clientes as cli on cli.id = a.idcliente inner join animalesxCliente as axc on axc.idcliente = @idCLIENTE ");
                accesoDatos.setearConsulta("SELECT DISTINCT A.ID, A.NOMBRE, A.APELLIDO,A.ESPECIE,R.NOMBRE AS RAZA FROM ANIMALESXCLIENTE AS AXC INNER JOIN CLIENTES AS CLI ON CLI.ID = AXC.IDCLIENTE INNER JOIN ANIMALES AS A ON A.ID = AXC.IDANIMAL INNER JOIN RAZAS AS R ON R.ID = A.IDRAZA WHERE AXC.IDCLIENTE LIKE @idCLIENTE");
;                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@idCLIENTE", idcliente);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    animal = new Animal();

                    animal.id = (int)accesoDatos.Lector["ID"];
                    animal.nombre = accesoDatos.Lector["nombre"].ToString();
                    animal.apellido = accesoDatos.Lector["apellido"].ToString();
                    animal.especie = accesoDatos.Lector["especie"].ToString();
                    animal.raza = new Raza();
                    animal.raza.nombre = accesoDatos.Lector["Raza"].ToString();

                    Listado.Add(animal);
                }

                return Listado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void AgregarAnimalXcliente(int idcliente, int idanimal)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("INSERT INTO ANIMALESXCLIENTE (IDANIMAL,IDCLIENTE) VALUES (@IDANIMAL,@IDCLIENTE)");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@IDANIMAL", idanimal);
                accesoDatos.Comando.Parameters.AddWithValue("@IDCLIENTE", idcliente);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();            
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
         
        public int buscar_ultimo_idanimal()
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();
            int aux;
            try
            {
                accesoDatos.setearConsulta("SELECT MAX(ID) as id FROM ANIMALES");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                if (accesoDatos.Lector.Read())
                {
                    aux = (int)accesoDatos.Lector["id"];
                    return aux;
                }

                return accesoDatos.ejecutarAccionReturn();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ModificarAnimal(Animal Modificado)
        {
            ManagerAccesoDatos accesoDatos = new ManagerAccesoDatos();

            try
            {
                accesoDatos.setearConsulta("UPDATE ANIMALES SET idraza = @IDRAZA, nombre = @NOMBRE, especie = @ESPECIE WHERE ID = @ID");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@IDRAZA", Modificado.raza.id);
                accesoDatos.Comando.Parameters.AddWithValue("@NOMBRE", Modificado.nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@ESPECIE", Modificado.especie);
                accesoDatos.Comando.Parameters.AddWithValue("@ID", Modificado.id);

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


