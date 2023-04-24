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
    public class dMedicamento
    {
        Database db = new Database();

        public List<eMedicamento> Listar()
        {
            try
            {
                List<eMedicamento> listMedicamentos = new List<eMedicamento>();

                SqlConnection conn = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("sp_medicamentos_list", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    eMedicamento medicamento = new eMedicamento();
                    medicamento.codigo = (int)reader["Codigo"];
                    medicamento.descripcion = (string)reader["Descripcion"];
                    medicamento.cantidad = (int)reader["Cantidad"];
                    medicamento.fechaIngreso = (DateTime)reader["FechaIngreso"];
                    medicamento.fechaCaducidad = (DateTime)reader["FechaCaducidad"];

                    listMedicamentos.Add(medicamento);
                }
                reader.Close();

                return listMedicamentos;
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
        public string Insertar(eMedicamento o)
        {
            try
            {
                SqlConnection conn = db.ConectaDb();
                string insert = "sp_medicamentos_insert";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@descripcion", o.descripcion);
                cmd.Parameters.AddWithValue("@cantidad", o.cantidad);
                cmd.Parameters.AddWithValue("@fechaingreso", o.fechaIngreso);
                cmd.Parameters.AddWithValue("@fechacaducidad", o.fechaCaducidad);

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
                string delete = "sp_medicamentos_delete";
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
        public string Actualizar(eMedicamento o)
        {
            try
            {
                SqlConnection conn = db.ConectaDb();
                string update = "sp_medicamentos_update";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@descripcion", o.cantidad);
                cmd.Parameters.AddWithValue("@fechaingreso", o.fechaIngreso);
                cmd.Parameters.AddWithValue("@fechacaducidad", o.fechaCaducidad);
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