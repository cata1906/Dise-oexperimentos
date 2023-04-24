using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class eGasto
    {
        public int codigo { get; set; }
        public string tipo { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public decimal montoUnitario { get; set; }
        public decimal montoTotal { get; set; }
        public DateTime fechaRegistro { get; set; }
    }
}