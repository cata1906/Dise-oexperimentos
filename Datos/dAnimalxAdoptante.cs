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
    public class dAnimalxAdoptante
    {
        Database db = new Database();

        public List<eAnimalxAdoptante> Listar()
        {
            try
            {
                // Lista
                List<eAnimalxAdoptante> listaAnimalesxAdoptante = new List<eAnimalxAdoptante>();
                eAnimalxAdoptante animalxAdoptante = null;
                // Genera la conexion y Ejecuta el comando
                SqlConnection conn = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("sp_animalesXadoptante_list", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                // Lectura de datos
                while (reader.Read())
                {
                    animalxAdoptante = new eAnimalxAdoptante();
                    animalxAdoptante.codigoAdopcion = (int)reader["CodigoAdopcion"];
                    animalxAdoptante.dni = (int)reader["DNI"];
                    animalxAdoptante.tipo = (string)reader["Tipo"];
                    animalxAdoptante.nombre = (string)reader["Nombre"];
                    animalxAdoptante.raza = (string)reader["Raza"];
                    animalxAdoptante.edad = (int)reader["Edad"];
                    animalxAdoptante.sexo = (string)reader["Sexo"];
                    animalxAdoptante.color = (string)reader["Color"];
                    animalxAdoptante.proveniencia = (string)reader["Proveniencia"];
                    animalxAdoptante.estado = (string)reader["Estado"];
                    listaAnimalesxAdoptante.Add(animalxAdoptante);
                }
                reader.Close();
                // Retorna la lista con todos los datos leídos de la base de datos
                return listaAnimalesxAdoptante;
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
        public string Insertar(eAnimalxAdoptante o)
        {
            try
            {
                SqlConnection conn = db.ConectaDb();
                string insert = "sp_animalesXadoptante_insert";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@codigoadopcion", o.codigoAdopcion);
                cmd.Parameters.AddWithValue("@dni", o.dni);
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
        public string Eliminar(int codigoAdopcion)
        {
            try
            {
                SqlConnection conn = db.ConectaDb();
                string delete = "sp_animalesXadoptante_delete";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@codigoadopcion", codigoAdopcion);

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
        public string Actualizar(int dni, int codigoAdopcion)
        {
            try
            {
                SqlConnection conn = db.ConectaDb();
                string update = "sp_animalesXadoptante_update";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@codigoadopcion", codigoAdopcion);

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