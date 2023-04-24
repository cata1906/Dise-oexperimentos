using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Negocio
{
    public class nGasto
    {
        dGasto obj_dGasto = new dGasto();

        public List<eGasto> Listar()
        {
            return obj_dGasto.Listar();
        }
        public string Insertar(string tipo, string descripcion, int cantidad, decimal montoUnitario, decimal montoTotal, DateTime fechaRegistro)
        {
            eGasto e = new eGasto();
            e.tipo = tipo;
            e.descripcion = descripcion;
            e.cantidad = cantidad;
            e.montoUnitario = montoUnitario;
            e.montoTotal = montoTotal;
            e.fechaRegistro = fechaRegistro;

            return obj_dGasto.Insertar(e);
        }
        public void Eliminar(int codigo)
        {
            obj_dGasto.Eliminar(codigo);
        }
        public string Actualizar(int codigo, string tipo, string descripcion, int cantidad, decimal montoUnitario, decimal montoTotal, DateTime fechaRegistro)
        {
            eGasto e = new eGasto();
            e.tipo = tipo;
            e.descripcion = descripcion;
            e.cantidad = cantidad;
            e.montoUnitario = montoUnitario;
            e.montoTotal = montoTotal;
            e.fechaRegistro = fechaRegistro;

            return obj_dGasto.Actualizar(e, codigo);
        }
    }
}