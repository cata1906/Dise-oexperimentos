using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace TPG401
{
    public partial class list_animales_crit : UserControl
    {
        // ------------------------------------- [ Atributos ] -------------------------------------
        private Color colorPrincipal = Funciones.colorDatos();
        private nAnimal obj_nAnimal = new nAnimal();
        private BindingSource bindingSource1 = new BindingSource();
        // ------------------------------------- [ Constructor ] -------------------------------------
        public list_animales_crit()
        {
            InitializeComponent();
        }
        // ------------------------------------- [ Metodos ] -------------------------------------
        public void Mostrar()
        {
            List<eAnimal> listAnimalesCriticos = new List<eAnimal>(); // Animales en estado critico

            foreach (var item in obj_nAnimal.Listar())
            {
                if (item.estado == "Critico")
                {
                    eAnimal animal = new eAnimal();

                    animal.codigo = item.codigo;
                    animal.tipo = item.tipo;
                    animal.nombre = item.nombre;
                    animal.raza = item.raza;
                    animal.edad = item.edad;
                    animal.sexo = item.sexo;
                    animal.color = item.color;
                    animal.proveniencia = item.proveniencia;
                    animal.estado = item.estado;

                    listAnimalesCriticos.Add(animal);
                }
            }

            dgvLista.AutoGenerateColumns = true;
            bindingSource1.DataSource = listAnimalesCriticos;
            dgvLista.DataSource = bindingSource1;
        }
    }
}
