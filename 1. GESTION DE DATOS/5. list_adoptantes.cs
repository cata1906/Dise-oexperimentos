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
    public partial class list_adoptantes : UserControl
    {
        // ------------------------------------- [ Atributos ] -------------------------------------
        private Color colorPrincipal = Funciones.colorDatos();
        private nAdoptante obj_nAdoptante = new nAdoptante();
        private BindingSource bindingSource1 = new BindingSource();
        private list_adoptantes_editar editar; // Formulario para editar
        public bool edicionEnCurso; // Verifica si el formulario para editar está activo
        // ------------------------------------- [ Constructor ] -------------------------------------
        public list_adoptantes()
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
            bindingSource1.DataSource = obj_nAdoptante.Listar();
            dgvLista.DataSource = bindingSource1;
        }
        public void RestablecerValores()
        {
            cmbBuscarX.SelectedIndex = -1;
            cmbBuscar.SelectedIndex = -1;
            lblBusquedaText.Text = "Valores:";
            cmbBuscarX.BackColor = Color.White;
            cmbBuscar.BackColor = Color.White;
        }
        public void LlenarComboBox(string buscarX)
        {
            cmbBuscar.Items.Clear();
            List<eAdoptante> listaAdoptantes = obj_nAdoptante.Listar();

            if (listaAdoptantes != null)
            {
                foreach (var item in listaAdoptantes)
                {
                    if (buscarX == "DNI")
                        cmbBuscar.Items.Add(item.dni.ToString());
                    if (buscarX == "Apellido")
                        cmbBuscar.Items.Add(item.apellido);
                }
            }

            // Borra los items repetidos del combobox
            List<string> list = new List<string>();
            foreach (var item in cmbBuscar.Items)
            {
                if (!list.Contains(item))
                {
                    list.Add(item.ToString());
                }
            }
            cmbBuscar.Items.Clear();
            cmbBuscar.Items.AddRange(list.ToArray());
        }
        public List<eAdoptante> LlenarListBusqueda(string buscarX, string buscar)
        {
            List<eAdoptante> listAdoptantes = new List<eAdoptante>();

            if (buscarX == "Codigo de Adopción")
                listAdoptantes = obj_nAdoptante.Listar().FindAll(X => X.dni.ToString() == buscar);
            if (buscarX == "DNI")
                listAdoptantes = obj_nAdoptante.Listar().FindAll(X => X.apellido == buscar);

            return listAdoptantes;
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

            if (busqueda == "DNI")
            {
                cmbBuscarX.BackColor = colorPrincipal;
                lblBusquedaText.Text = "Ingrese el DNI:";
                cmbBuscar.Enabled = true;
                LlenarComboBox(busqueda);
            }
            if (busqueda == "Apellido")
            {
                cmbBuscarX.BackColor = colorPrincipal;
                lblBusquedaText.Text = "Ingrese el apellido:";
                cmbBuscar.Enabled = true;
                LlenarComboBox(busqueda);
            }
        }
        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBuscar.BackColor = colorPrincipal;
        }
        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbBuscarX.Text = "DNI";
            cmbBuscar.BackColor = colorPrincipal;

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
            RestablecerValores();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int selectCant = dgvLista.SelectedRows.Count;
            string dni = "";

            while (selectCant > 0)
            {
                if (!dgvLista.SelectedRows[0].IsNewRow)
                {
                    dni = dgvLista.SelectedRows[0].Cells[0].Value.ToString(); // Obtiene el CODIGO

                    foreach (var item in obj_nAdoptante.Listar())
                    {
                        if (item.dni.ToString() == dni) // Obtiene el DNI a partir del CODIGO
                            obj_nAdoptante.Eliminar(Convert.ToInt32(item.dni)); // Borra a partir del DNI
                    }

                    dgvLista.Rows.RemoveAt(dgvLista.SelectedRows[0].Index);
                    RestablecerValores();
                    Mostrar();
                }
                selectCant--;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscarX = cmbBuscarX.Text.Trim();
            string buscar = cmbBuscar.Text.Trim();

            if (buscarX != "" && buscar != "")
            {
                List<eAdoptante> buscarListAdoptantes;
                buscarListAdoptantes = LlenarListBusqueda(buscarX, buscar); // Guarda en una lista TODOS los datos de un animal a partir del dato seleccionado

                this.RestablecerValores();
                // Mostrar a partir de la nueva lista
                dgvLista.AutoGenerateColumns = true;
                bindingSource1.DataSource = buscarListAdoptantes;
                dgvLista.DataSource = bindingSource1;
            }
            else
                MessageBox.Show("Esta accion requiere un tipo de busqueda!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            string buscarX = cmbBuscarX.Text.Trim();
            string buscar = cmbBuscar.Text.Trim();

            if (buscarX == "DNI")
            {
                edicionEnCurso = true;
                editar = new list_adoptantes_editar(edicionEnCurso, dgvLista, buscar);
                editar.Show();
            }
            else
                MessageBox.Show("Esta accion requiere un DNI!");
        }
    }
}
