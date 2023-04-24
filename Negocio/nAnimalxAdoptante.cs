using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class nAnimalxAdoptante
    {
        dAnimalxAdoptante obj_dAnimalxAdoptante = new dAnimalxAdoptante();

        public List<eAnimalxAdoptante> Listar()
        {
            return obj_dAnimalxAdoptante.Listar();
        }
        public string Insertar(int codigoAdopcion, int dni, string tipo, string nombre, string raza, int edad, string sexo, string color, string proveniencia, string estado)
        {
            eAnimalxAdoptante e = new eAnimalxAdoptante();
            e.codigoAdopcion = codigoAdopcion;
            e.dni = dni;
            e.tipo = tipo;
            e.nombre = nombre;
            e.raza = raza;
            e.edad = edad;
            e.sexo = sexo;
            e.color = color;
            e.proveniencia = proveniencia;
            e.estado = estado;

            return obj_dAnimalxAdoptante.Insertar(e);
        }
        public string Eliminar(int codigoAdopcion)
        {
            return obj_dAnimalxAdoptante.Eliminar(codigoAdopcion);
        }
        public string Actualizar(int dni, int codigoAdopcion)
        {
            return obj_dAnimalxAdoptante.Actualizar(dni, codigoAdopcion);
        }
    }
}
