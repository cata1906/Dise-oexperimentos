using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class nUser
    {
        dUser obj_dUser = new dUser();

        public List<eUser> Listar(string tabla)
        {
            return obj_dUser.ListarUsuarios(tabla);
        }
        public void Insertar(string tabla, string dni, string correo, string pPass, string cod, string aPass)
        {
            eUser e = new eUser();
            e.dni = dni;
            e.correo = correo;
            e.pPass = pPass;
            e.cod = cod;
            e.aPass = aPass;

            obj_dUser.InsertarUsuario(tabla, e);
        }
    }
}