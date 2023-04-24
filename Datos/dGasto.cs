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
    public class dGasto
    {
        Database db = new Database();

        public List<eGasto> Listar()
        {
            try
            {
                List<eGasto> listTests = new List<eGasto>();
                eGasto test = null;
                SqlConnection conn = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("sp_gastos_list", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    test = new eGasto();
                    test.codigo = (int)reader["Codigo"];
                    test.tipo = (string)reader["Tipo"];
                    test.descripcion = (string)reader["Descripcion"];
                    test.cantidad = (int)reader["Cantidad"];
                    test.montoUnitario = (decimal)reader["MontoUnitario"];
                    test.montoTotal = (decimal)reader["MontoTotal"];
                    test.fechaRegistro = (DateTime)reader["FechaRegistro"];
                    listTests.Add(test);
                }
                reader.Close();
                return listTests;
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
        public string Insertar(eGasto o)
        {
            try
            {
                SqlConnection conn = db.ConectaDb();
                string insert = "sp_gastos_insert";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@tipo", o.tipo);
                cmd.Parameters.AddWithValue("@descripcion", o.descripcion);
                cmd.Parameters.AddWithValue("@cantidad", o.cantidad);
                cmd.Parameters.AddWithValue("@montounitario", o.montoUnitario);
                cmd.Parameters.AddWithValue("@montototal", o.montoTotal);
                cmd.Parameters.AddWithValue("@fecharegistro", o.fechaRegistro);

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
                string delete = "sp_gastos_delete";
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
        public string Actualizar(eGasto o, int codigo)
        {
            try
            {
                SqlConnection conn = db.ConectaDb();
                string update = "sp_gastos_update";
                SqlCommand cmd = new SqlCommand(update, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@tipo", o.tipo);
                cmd.Parameters.AddWithValue("@descripcion", o.descripcion);
                cmd.Parameters.AddWithValue("@cantidad", o.cantidad);
                cmd.Parameters.AddWithValue("@montounitario", o.montoUnitario);
                cmd.Parameters.AddWithValue("@montototal", o.montoTotal);
                cmd.Parameters.AddWithValue("@fecharegistro", o.fechaRegistro);
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
    }
}