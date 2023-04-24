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
    public partial class list_gastos : UserControl
    {
        // ------------------------------------- [ --- Atributos --- ] -------------------------------------
        private Color colorPrincipal = Funciones.colorGastos();
        private nGasto obj_nGasto = new nGasto();
        private BindingSource bindingSource1 = new BindingSource();
        private list_gastos_editar editar; // Formulario para editar
        public bool edicionEnCurso; // Verifica si el formulario para editar está activo
        // ------------------------------------- [ --- Constructor --- ] -------------------------------------
        public list_gastos()
        {
            InitializeComponent();
            edicionEnCurso = false;
            lblTitulo.ForeColor = colorPrincipal;
            btnBuscar.BackColor = colorPrincipal;
            dgvLista.BackgroundColor = colorPrincipal;
        }
        // ------------------------------------- [ --- Metodos --- ] -------------------------------------
        public void Mostrar()
        {
            dgvLista.AutoGenerateColumns = true;
            bindingSource1.DataSource = obj_nGasto.Listar();
            dgvLista.DataSource = bindingSource1;
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
            List<eGasto> listaGastos = obj_nGasto.Listar();

            if (listaGastos != null)
            {
                foreach (var item in listaGastos)
                {
                    if (buscarX == "Codigo")
                        cmbBuscar.Items.Add(item.codigo);
                    if (buscarX == "Tipo")
                        cmbBuscar.Items.Add(item.tipo);
                    if (buscarX == "Descripcion")
                        cmbBuscar.Items.Add(item.descripcion);
                    if (buscarX == "Cantidad")
                        cmbBuscar.Items.Add(item.cantidad);
                    if (buscarX == "Monto unitario")
                        cmbBuscar.Items.Add(item.montoUnitario);
                    if (buscarX == "Monto total")
                        cmbBuscar.Items.Add(item.montoTotal);
                    if (buscarX == "Monto total")
                        cmbBuscar.Items.Add(item.montoTotal);
                    if (buscarX == "Fecha de registro")
                        cmbBuscar.Items.Add(item.fechaRegistro.ToString("dd/MM/yyyy"));
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
        public List<eGasto> LlenarListBusqueda(string buscarX, string buscar)
        {
            List<eGasto> listGastos = new List<eGasto>();

            if (buscarX == "Codigo")
                listGastos = obj_nGasto.Listar().FindAll(X => X.codigo.ToString() == buscar);
            if (buscarX == "Tipo")
                listGastos = obj_nGasto.Listar().FindAll(X => X.tipo == buscar);
            if (buscarX == "Descripcion")
                listGastos = obj_nGasto.Listar().FindAll(X => X.descripcion == buscar);
            if (buscarX == "Cantidad")
                listGastos = obj_nGasto.Listar().FindAll(X => X.cantidad.ToString() == buscar);
            if (buscarX == "Monto unitario")
                listGastos = obj_nGasto.Listar().FindAll(X => X.montoUnitario.ToString() == buscar);
            if (buscarX == "Monto total")
                listGastos = obj_nGasto.Listar().FindAll(X => X.montoTotal.ToString() == buscar);
            if (buscarX == "Fecha de registro")
                listGastos = obj_nGasto.Listar().FindAll(X => X.fechaRegistro.ToString("dd/MM/yyyy") == buscar);

            return listGastos;
        }
        // ------------------------------------- [ --- Eventos Back --- ] -------------------------------------
        private void cmbBuscarX_SelectedIndexChanged(object sender, EventArgs e)
        {
            string busqueda = cmbBuscarX.Text.Trim();
            cmbBuscarX.BackColor = colorPrincipal;
            cmbBuscar.Enabled = true;

            if (busqueda == "Codigo")
            {
                lblBusquedaText.Text = "Código:";
                this.LlenarComboBox(busqueda); // Llena el cmbBuscar dependiendo del dato seleccionado
            }
            if (busqueda == "Tipo")
            {
                lblBusquedaText.Text = "Tipo:";
                this.LlenarComboBox(busqueda);
            }
            if (busqueda == "Descripcion")
            {
                lblBusquedaText.Text = "Descripcion:";
                this.LlenarComboBox(busqueda);
            }
            if (busqueda == "Cantidad")
            {
                lblBusquedaText.Text = "Cantidad:";
                this.LlenarComboBox(busqueda);
            }
            if (busqueda == "Monto unitario")
            {
                lblBusquedaText.Text = "Monto unitario:";
                this.LlenarComboBox(busqueda);
            }
            if (busqueda == "Monto total")
            {
                lblBusquedaText.Text = "Monto total:";
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
        // ------------------------------------- [ --- Eventos Front --- ] -------------------------------------
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
                obj_nGasto.Eliminar(Convert.ToInt32(buscar));
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
                        obj_nGasto.Eliminar(Convert.ToInt32(codigo));
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
                List<eGasto> buscarListGastos;
                buscarListGastos = LlenarListBusqueda(buscarX, buscar); // Guarda en una lista TODOS los datos de un animal a partir del dato seleccionado

                dgvLista.AutoGenerateColumns = true;
                bindingSource1.DataSource = buscarListGastos;
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
                editar = new list_gastos_editar(edicionEnCurso, dgvLista, buscar);
                editar.Show();
            }
            else
                MessageBox.Show("Esta accion requiere un codigo!");
        }
    }
}
