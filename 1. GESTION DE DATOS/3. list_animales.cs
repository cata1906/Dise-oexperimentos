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
    public partial class list_animales : UserControl
    {
        // ------------------------------------- [ Atributos ] -------------------------------------
        private Color colorPrincipal = Funciones.colorDatos();
        private nAnimal obj_nAnimal = new nAnimal();
        private nAnimalxHistorial obj_nAnimalxHistorial = new nAnimalxHistorial();
        private BindingSource bindingSource1 = new BindingSource();
        private list_animales_editar editar; // Formulario para editar
        public bool edicionEnCurso; // Verifica si el formulario para editar está activo
        // ------------------------------------- [ Constructor ] -------------------------------------
        public list_animales()
        {
            InitializeComponent();
            edicionEnCurso = false;
            lblTitulo.ForeColor = colorPrincipal;
            btnBuscar.BackColor = colorPrincipal;
            dgvLista.BackgroundColor = colorPrincipal;
        }
        // ------------------------------------- [ Metodos ] -------------------------------------
        public void Mostrar()
        {
            dgvLista.AutoGenerateColumns = true;
            bindingSource1.DataSource = obj_nAnimal.Listar();
            dgvLista.DataSource = bindingSource1;

            int cont = 0;
            foreach (var item in obj_nAnimalxHistorial.Listar())
            {
                if (item.fechaRegistro > DateTime.Now.AddMonths(-1)) // Cantidad de animales registra2 en el ultimo mes
                    cont++;
            }
            lblCantAnimales.Text = cont.ToString();
        }
        public void RestablecerValores()
        {
            cmbBuscarX.Text = "";
            cmbBuscarX.SelectedIndex = -1;
            cmbBuscar.Text = "";
            cmbBuscar.SelectedIndex = -1;
            lblBusquedaText.Text = "Valores:";
            cmbBuscarX.BackColor = Color.White;
            cmbBuscar.BackColor = Color.White;
        }
        public void LlenarComboBox(string buscarX)
        {
            cmbBuscar.Items.Clear();
            List<eAnimal> listaAnimales = obj_nAnimal.Listar();

            if (listaAnimales != null)
            {
                foreach (var item in obj_nAnimal.Listar())
                {
                    if (buscarX == "Codigo")
                        cmbBuscar.Items.Add(item.codigo);
                    if (buscarX == "Tipo")
                        cmbBuscar.Items.Add(item.tipo);
                    if (buscarX == "Nombre")
                        cmbBuscar.Items.Add(item.nombre);
                    if (buscarX == "Raza")
                        cmbBuscar.Items.Add(item.raza);
                    if (buscarX == "Edad")
                        cmbBuscar.Items.Add(item.edad);
                    if (buscarX == "Sexo")
                        cmbBuscar.Items.Add(item.sexo);
                    if (buscarX == "Color")
                        cmbBuscar.Items.Add(item.color);
                    if (buscarX == "Proveniencia")
                        cmbBuscar.Items.Add(item.proveniencia);
                    if (buscarX == "Estado")
                        cmbBuscar.Items.Add(item.estado);
                }
            }

            // Borra los items repetidos del combobox
            List<object> list = new List<object>();
            foreach (object o in cmbBuscar.Items)
            {
                if (!list.Contains(o))
                {
                    list.Add(o);
                }
            }
            cmbBuscar.Items.Clear();
            cmbBuscar.Items.AddRange(list.ToArray());
        }
        public List<eAnimal> LlenarListBusqueda(string buscarX, string buscar)
        {
            List<eAnimal> listAnimales = new List<eAnimal>();

            if (buscarX == "Codigo")
                listAnimales = obj_nAnimal.Listar().FindAll(X => X.codigo.ToString() == buscar);
            if (buscarX == "Tipo")
                listAnimales = obj_nAnimal.Listar().FindAll(X => X.tipo == buscar);
            if (buscarX == "Nombre")
                listAnimales = obj_nAnimal.Listar().FindAll(X => X.nombre == buscar);
            if (buscarX == "Raza")
                listAnimales = obj_nAnimal.Listar().FindAll(X => X.raza == buscar);
            if (buscarX == "Edad")
                listAnimales = obj_nAnimal.Listar().FindAll(X => X.edad.ToString() == buscar);
            if (buscarX == "Sexo")
                listAnimales = obj_nAnimal.Listar().FindAll(X => X.sexo == buscar);
            if (buscarX == "Color")
                listAnimales = obj_nAnimal.Listar().FindAll(X => X.color == buscar);
            if (buscarX == "Proveniencia")
                listAnimales = obj_nAnimal.Listar().FindAll(X => X.proveniencia == buscar);
            if (buscarX == "Estado")
                listAnimales = obj_nAnimal.Listar().FindAll(X => X.estado == buscar);

            return listAnimales;
        }
        // ------------------------------------- [ Eventos Back ] -------------------------------------
        private void pbInstrucciones_MouseEnter(object sender, EventArgs e)
        {
            pbInstrucciones.Image = TPG401.Properties.Resources.youtube1;
        }
        private void pbInstrucciones_MouseLeave(object sender, EventArgs e)
        {
            pbInstrucciones.Image = TPG401.Properties.Resources.youtube;
        }
        private void cmbBuscarX_SelectedIndexChanged(object sender, EventArgs e)
        {
            string busqueda = cmbBuscarX.Text.Trim();
            cmbBuscarX.BackColor = colorPrincipal;
            cmbBuscar.Enabled = true;

            if (busqueda == "Codigo")
            {
                lblBusquedaText.Text = "Ingrese el código:";
                this.LlenarComboBox(busqueda); // Llena el cmbBuscar dependiendo del dato seleccionado
            }
            if (busqueda == "Tipo")
            {
                lblBusquedaText.Text = "Ingrese el tipo:";
                this.LlenarComboBox(busqueda);
            }
            if (busqueda == "Nombre")
            {
                lblBusquedaText.Text = "Ingrese el nombre:";
                this.LlenarComboBox(busqueda);
            }
            if (busqueda == "Raza")
            {
                lblBusquedaText.Text = "Ingrese la raza:";
                this.LlenarComboBox(busqueda);
            }
            if (busqueda == "Edad")
            {
                lblBusquedaText.Text = "Ingrese al edad:";
                this.LlenarComboBox(busqueda);
            }
            if (busqueda == "Sexo")
            {
                lblBusquedaText.Text = "Ingrese el sexo:";
                this.LlenarComboBox(busqueda);
            }
            if (busqueda == "Color")
            {
                lblBusquedaText.Text = "Ingrese el color:";
                this.LlenarComboBox(busqueda);
            }
            if (busqueda == "Proveniencia")
            {
                lblBusquedaText.Text = "Ingrese la proveniencia:";
                this.LlenarComboBox(busqueda);
            }
            if (busqueda == "Estado")
            {
                lblBusquedaText.Text = "Ingrese el estado:";
                this.LlenarComboBox(busqueda);
            }
        }
        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBuscar.BackColor = colorPrincipal;
        }
        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbBuscarX.Text = "Codigo";
            cmbBuscarX.BackColor = colorPrincipal;

            string cellValue = dgvLista.SelectedCells[0].Value.ToString(); // Obtiene el codigo de la fila seleccionada
            cmbBuscar.Text = cellValue;
            cmbBuscar.BackColor = colorPrincipal;

            if (edicionEnCurso == true)
            {
                editar.RellenarCuadros(cellValue); // Rellena los cuadros de edicion con todos los datos del animal a partir de su codigo
            }
        }
        // ------------------------------------- [ Eventos Front ] -------------------------------------
        private void pbInstrucciones_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }
        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            this.RestablecerValores();
            this.Mostrar();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string buscar = cmbBuscar.Text.Trim();

            if (buscar != "")
            {
                obj_nAnimal.Eliminar(Convert.ToInt32(buscar));
                this.RestablecerValores();
                this.Mostrar();
            }
            else
            {
                int selectCant = dgvLista.SelectedRows.Count;
                string codigo = "";

                while (selectCant > 0)
                {
                    if (!dgvLista.SelectedRows[0].IsNewRow)
                    {
                        codigo = dgvLista.SelectedRows[0].Cells[0].Value.ToString();
                        obj_nAnimal.Eliminar(Convert.ToInt32(codigo));
                        dgvLista.Rows.RemoveAt(dgvLista.SelectedRows[0].Index);
                        this.RestablecerValores();
                        this.Mostrar();
                    }
                    selectCant--;
                }
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscarX = cmbBuscarX.Text.Trim();
            string buscar = cmbBuscar.Text.Trim();

            if (buscarX != "" && buscar != "")
            {
                List<eAnimal> buscarListAnimales;
                buscarListAnimales = LlenarListBusqueda(buscarX, buscar); // Guarda en una lista TODOS los datos de un animal a partir del dato seleccionado

                dgvLista.AutoGenerateColumns = true;
                bindingSource1.DataSource = buscarListAnimales;
                dgvLista.DataSource = bindingSource1;
                this.RestablecerValores();
            }
            else
                MessageBox.Show("Esta accion requiere un tipo de busqueda!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            string buscarX = cmbBuscarX.Text.Trim();
            string buscar = cmbBuscar.Text.Trim();

            if (buscarX == "Codigo")
            {
                edicionEnCurso = true;
                editar = new list_animales_editar(edicionEnCurso, dgvLista, buscar);
                editar.Show();
            }
            else
                MessageBox.Show("Esta accion requiere un codigo!");
        }
    }
}