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
    public class dAdoptante
    {
        Database db = new Database();

        public List<eAdoptante> Listar()
        {
            try
            {
                // Lista
                List<eAdoptante> listaAdoptantes = new List<eAdoptante>();
                eAdoptante adoptante = null;
                // Genera la conexion y Ejecuta el comando
                SqlConnection conn = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("sp_adoptantes_list", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                // Lectura de datos
                while (reader.Read())
                {
                    adoptante = new eAdoptante();
                    adoptante.dni = (int)reader["DNI"];
                    adoptante.nombre = (string)reader["Nombre"];
                    adoptante.apellido = (string)reader["Apellido"];
                    adoptante.telefono = (int)reader["Telefono"];
                    adoptante.correo = (string)reader["Correo"];
                    adoptante.direccion = (string)reader["Direccion"];
                    adoptante.motivo = (string)reader["Motivo"];
                    listaAdoptantes.Add(adoptante);
                }
                reader.Close();
                // Retorna la lista con todos los datos leídos de la base de datos
                return listaAdoptantes;
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
        public string Insertar(eAdoptante o)
        {
            try
            {
                SqlConnection conn = db.ConectaDb();
                string insert = "sp_adoptantes_insert";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", o.dni);
                cmd.Parameters.AddWithValue("@nombre", o.nombre);
                cmd.Parameters.AddWithValue("@apellido", o.apellido);
                cmd.Parameters.AddWithValue("@telefono", o.telefono);
                cmd.Parameters.AddWithValue("@correo", o.correo);
                cmd.Parameters.AddWithValue("@direccion", o.direccion);
                cmd.Parameters.AddWithValue("@motivo", o.motivo);

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
        public string Eliminar(int dni)
        {
            try
            {
                SqlConnection conn = db.ConectaDb();
                string delete = "sp_adoptantes_delete";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", dni);

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
        public string Actualizar(eAdoptante o, int newDNI)
        {
            try
            {
                SqlConnection conn = db.ConectaDb();
                string update = "sp_adoptantes_update";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@newDNI", newDNI);
                cmd.Parameters.AddWithValue("@nombre", o.nombre);
                cmd.Parameters.AddWithValue("@apellido", o.apellido);
                cmd.Parameters.AddWithValue("@telefono", o.telefono);
                cmd.Parameters.AddWithValue("@correo", o.correo);
                cmd.Parameters.AddWithValue("@direccion", o.direccion);
                cmd.Parameters.AddWithValue("@motivo", o.motivo);
                cmd.Parameters.AddWithValue("@dni", o.dni);

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
        public string ActualizarDNI(int DNI, int oldDNI)
        {
            try
            {
                SqlConnection conn = db.ConectaDb();
                string update = "sp_adoptantes_update_DNI";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", DNI);
                cmd.Parameters.AddWithValue("@oldDNI", oldDNI);

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
