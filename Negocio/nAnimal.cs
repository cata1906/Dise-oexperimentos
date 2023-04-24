using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class nAnimal
    {
        dAnimal obj_dAnimal = new dAnimal();

        public List<eAnimal> Listar()
        {
            return obj_dAnimal.Listar();
        }
        public string Insertar(int codigo, string tipo, string nombre, string raza, int edad, string sexo, string color, string proveniencia, string estado)
        {
            eAnimal e = new eAnimal();
            e.codigo = codigo;
            e.tipo = tipo;
            e.nombre = nombre;
            e.raza = raza;
            e.edad = edad;
            e.sexo = sexo;
            e.color = color;
            e.proveniencia = proveniencia;
            e.estado = estado;

            return obj_dAnimal.Insertar(e);
        }
        public void Eliminar(int codigo)
        {
            obj_dAnimal.Eliminar(codigo);
        }
        public string Actualizar(int codigo, string tipo, string nombre, string raza, int edad, string sexo, string color, string proveniencia, string estado)
        {
            eAnimal e = new eAnimal();
            e.codigo = codigo;
            e.tipo = tipo;
            e.nombre = nombre;
            e.raza = raza;
            e.edad = edad;
            e.sexo = sexo;
            e.color = color;
            e.proveniencia = proveniencia;
            e.estado = estado;

            return obj_dAnimal.Actualizar(e);
        }
    }
}
