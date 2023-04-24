using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class nMedicamento
    {
        dMedicamento obj_dMedicamento = new dMedicamento();

        public List<eMedicamento> Listar()
        {
            return obj_dMedicamento.Listar();
        }
        public string Insertar(string descripcion, int cantidad, DateTime fechaIngreso, DateTime fechaCaducidad)
        {
            eMedicamento e = new eMedicamento();
            e.descripcion = descripcion;
            e.cantidad = cantidad;
            e.fechaIngreso = fechaIngreso;
            e.fechaCaducidad = fechaCaducidad;

            return obj_dMedicamento.Insertar(e);
        }
        public void Eliminar(int codigo)
        {
            obj_dMedicamento.Eliminar(codigo);
        }
        public string Actualizar(string descripcion, int cantidad, DateTime fechaIngreso, DateTime fechaCaducidad, int codigo)
        {
            eMedicamento e = new eMedicamento();
            e.descripcion = descripcion;
            e.cantidad = cantidad;
            e.fechaIngreso = fechaIngreso;
            e.fechaCaducidad = fechaCaducidad;
            e.codigo = codigo;

            return obj_dMedicamento.Actualizar(e);
        }
    }
}