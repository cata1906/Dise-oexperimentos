using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class eMedicamento
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaCaducidad { get; set; }
    }
}