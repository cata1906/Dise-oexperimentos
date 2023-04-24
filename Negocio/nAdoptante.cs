using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class nAdoptante
    {
        dAdoptante obj_dAdoptante = new dAdoptante();

        public List<eAdoptante> Listar()
        {
            return obj_dAdoptante.Listar();
        }
        public string Insertar(int dni, string nombre, string apellido, int telefono, string correo, string direccion, string motivo)
        {
            eAdoptante e = new eAdoptante();
            e.dni = dni;
            e.nombre = nombre;
            e.apellido = apellido;
            e.telefono = telefono;
            e.correo = correo;
            e.direccion = direccion;
            e.motivo = motivo;

            return obj_dAdoptante.Insertar(e);
        }
        public string Eliminar(int dni)
        {
            return obj_dAdoptante.Eliminar(dni);
        }
        public string Actualizar(int dni, string nombre, string apellido, int telefono, string correo, string direccion, string motivo, int newDNI)
        {
            eAdoptante e = new eAdoptante();
            e.dni = dni;
            e.nombre = nombre;
            e.apellido = apellido;
            e.telefono = telefono;
            e.correo = correo;
            e.direccion = direccion;
            e.motivo = motivo;

            return obj_dAdoptante.Actualizar(e, newDNI);
        }
        public string ActualizarDNI(int DNI, int oldDNI)
        {
            return obj_dAdoptante.ActualizarDNI(DNI, oldDNI);
        }
    }
}