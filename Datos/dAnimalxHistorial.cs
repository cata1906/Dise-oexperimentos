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
    public class dAnimalxHistorial
    {
        Database db = new Database();

        public List<eAnimalxHistorial> Listar()
        {
            try
            {
                List<eAnimalxHistorial> listAnimalHistorial = new List<eAnimalxHistorial>();
                eAnimalxHistorial animalHistorial = null;

                SqlConnection conn = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("sp_animalesXhistorial_list", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    animalHistorial = new eAnimalxHistorial();
                    animalHistorial.codigo = (int)reader["Codigo"];
                    animalHistorial.tipo = (string)reader["Tipo"];
                    animalHistorial.nombre = (string)reader["Nombre"];
                    animalHistorial.raza = (string)reader["Raza"];
                    animalHistorial.edad = (int)reader["Edad"];
                    animalHistorial.sexo = (string)reader["Sexo"];
                    animalHistorial.color = (string)reader["Color"];
                    animalHistorial.proveniencia = (string)reader["Proveniencia"];
                    animalHistorial.estado = (string)reader["Estado"];
                    animalHistorial.fechaRegistro = (DateTime)reader["FechaRegistro"];
                    listAnimalHistorial.Add(animalHistorial);
                }
                reader.Close();

                return listAnimalHistorial;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
        public string Insertar(eAnimalxHistorial o)
        {
            try
            {
                SqlConnection conn = db.ConectaDb();
                string insert = "sp_animalesXhistorial_insert";
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
                cmd.Parameters.AddWithValue("@fecharegistro", o.fechaRegistro.ToString("yyyy-MM-dd"));

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
        public string Actualizar(eAnimalxHistorial o)
        {
            try
            {
                SqlConnection conn = db.ConectaDb();
                string update = "sp_animalesXhistorial_update";
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
                cmd.Parameters.AddWithValue("@fecharegistro", o.fechaRegistro.ToString("yyyy-MM-dd"));
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