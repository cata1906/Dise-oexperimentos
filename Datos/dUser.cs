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
    public class dUser
    {
        Database db = new Database();

        public List<eUser> ListarUsuarios(string tabla)
        {
            try
            {
                List<eUser> listUser = new List<eUser>();
                eUser user = null;
                SqlConnection conn = db.ConectaDb();
                SqlCommand cmd = new SqlCommand("select * from " + tabla, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new eUser();
                    user.dni = (string)reader["DNI"];
                    user.correo = (string)reader["Correo"];
                    user.pPass = (string)reader["pPassword"];
                    user.cod = (string)reader["Codigo"];
                    user.aPass = (string)reader["aPassword"];
                    listUser.Add(user);
                }
                reader.Close();
                return listUser;
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
        public void InsertarUsuario(string tabla, eUser o)
        {
            try
            {
                SqlConnection conn = db.ConectaDb();
                string insert = string.Format("insert into " + tabla + "(DNI, Correo, pPassword, Codigo, aPassword) values ('{0}', '{1}', '{2}', '{3}', '{4}')", o.dni, o.correo, o.pPass, o.cod, o.aPass);
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                db.DesconectaDb();
            }
        }
    }
}