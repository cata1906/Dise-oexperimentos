using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class dAnimal
    {
        Database db = new Database();

        public List<eAnimal> Listar()
        {
            try
            {
                // Lista
                List<eAnimal> listAnimals = new List<eAnimal>();
                eAnimal animal = null;

                // Genera la conexion y Ejecuta el comando
                SqlConnection conn = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("sp_animales_list", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                // Lectura de datos
                while (reader.Read())
                {
                    animal = new eAnimal();
                    animal.codigo = (int)reader["Codigo"];
                    animal.tipo = (string)reader["Tipo"];
                    animal.nombre = (string)reader["Nombre"];
                    animal.raza = (string)reader["Raza"];
                    animal.edad = (int)reader["Edad"];
                    animal.sexo = (string)reader["Sexo"];
                    animal.color = (string)reader["Color"];
                    animal.proveniencia = (string)reader["Proveniencia"];
                    animal.estado = (string)reader["Estado"];
                    listAnimals.Add(animal);
                }
                reader.Close();

                // Retorna la lista con todos los datos leídos de la base de datos
                return listAnimals;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                // Siempre se ejecuta
                db.DesconectaDb();
            }
        }
        public string Insertar(eAnimal o)
        {
            try
            {
                SqlConnection conn = db.ConectaDb();
                string insert = "sp_animales_insert";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@codigo", o.codigo);
                cmd.Parameters.AddWithValue("@tipo", o.tipo);
                cmd.Parameters.AddWithValue("@nombre", o.nombre);
                cmd.Parameters.AddWithValue("@raza", o.raza);
                cmd.Parameters.AddWithValue("@edad", o.edad);
                cmd.Parameters.AddWithValue("@sexo", o.sexo);
                cmd.Parameters.AddWithValue("@color", o.color);
                cmd.Parameters.AddWithValue("@proveniencia", o.proveniencia);
                cmd.Parameters.AddWithValue("@estado", o.estado);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return "true";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public string Eliminar(int codigo)
        {
            try
            {
                SqlConnection conn = db.ConectaDb();
                string delete = "sp_animales_delete";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@codigo", codigo);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return "true";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public string Actualizar(eAnimal o)
        {
            try
            {
                SqlConnection conn = db.ConectaDb();
                string update = "sp_animales_update";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@tipo", o.tipo);
                cmd.Parameters.AddWithValue("@nombre", o.nombre);
                cmd.Parameters.AddWithValue("@raza", o.raza);
                cmd.Parameters.AddWithValue("@edad", o.edad);
                cmd.Parameters.AddWithValue("@sexo", o.sexo);
                cmd.Parameters.AddWithValue("@color", o.color);
                cmd.Parameters.AddWithValue("@proveniencia", o.proveniencia);
                cmd.Parameters.AddWithValue("@estado", o.estado);
                cmd.Parameters.AddWithValue("@codigo", o.codigo);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                return "true";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
    }
}