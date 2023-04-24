using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class nAnimalxHistorial
    {
        dAnimalxHistorial obj_nAnimalxHistorial = new dAnimalxHistorial();
        public List<eAnimalxHistorial> Listar()
        {
            return obj_nAnimalxHistorial.Listar();
        }
        public string Insertar(int codigo, string tipo, string nombre, string raza, int edad, string sexo, string color, string proveniencia, string estado, DateTime fechaRegistro)
        {
            eAnimalxHistorial e = new eAnimalxHistorial();
            e.codigo = codigo;
            e.tipo = tipo;
            e.nombre = nombre;
            e.raza = raza;
            e.edad = edad;
            e.sexo = sexo;
            e.color = color;
            e.proveniencia = proveniencia;
            e.estado = estado;
            e.fechaRegistro = fechaRegistro;

            return obj_nAnimalxHistorial.Insertar(e);
        }
        public string Actualizar(int codigo, string tipo, string nombre, string raza, int edad, string sexo, string color, string proveniencia, string estado, DateTime fechaRegistro)
        {
            eAnimalxHistorial e = new eAnimalxHistorial();
            e.codigo = codigo;
            e.tipo = tipo;
            e.nombre = nombre;
            e.raza = raza;
            e.edad = edad;
            e.sexo = sexo;
            e.color = color;
            e.proveniencia = proveniencia;
            e.estado = estado;
            e.fechaRegistro = fechaRegistro;

            return obj_nAnimalxHistorial.Actualizar(e);
        }
    }
}