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
    public partial class list_adopciones : UserControl
    {
        // ------------------------------------- [ --- Atributos --- ] -------------------------------------
        private Color colorPrincipal = Funciones.colorDatos();
        private nAnimal obj_nAnimal = new nAnimal();
        private nAnimalxAdoptante obj_nAnimalxAdoptante = new nAnimalxAdoptante();
        private nAdoptante obj_nAdoptante = new nAdoptante();
        private BindingSource bindingSource1 = new BindingSource();
        private list_adopciones_editar editar; // Formulario para editar
        public bool edicionEnCurso; // Verifica si el formulario para editar está activo
        // ------------------------------------- [ --- Constructor --- ] -------------------------------------
        public list_adopciones()
        {
            InitializeComponent();
            edicionEnCurso = false;
            lblListaDeAdopciones.ForeColor = colorPrincipal;
            btnBuscar.BackColor = colorPrincipal;
            dgvLista.BackgroundColor = colorPrincipal;
        }
        // ------------------------------------- [ --- Metodos --- ] -------------------------------------
        public void Mostrar()
        {
            dgvLista.AutoGenerateColumns = true;
            bindingSource1.DataSource = obj_nAnimalxAdoptante.Listar();
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
            List<eAnimalxAdoptante> listaAdopciones = obj_nAnimalxAdoptante.Listar();

            foreach (var item in obj_nAnimalxAdoptante.Listar())
            {
                if (buscarX == "Codigo de adopcion")
                    cmbBuscar.Items.Add(item.codigoAdopcion);
                if (buscarX == "DNI")
                    cmbBuscar.Items.Add(item.dni);
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
        public List<eAnimalxAdoptante> LlenarListBusqueda(string buscarX, string buscar)
        {
            List<eAnimalxAdoptante> listAnimalxAdoptante = new List<eAnimalxAdoptante>();

            if (buscarX == "Codigo de adopcion")
                listAnimalxAdoptante = obj_nAnimalxAdoptante.Listar().FindAll(X => X.codigoAdopcion.ToString() == buscar);
            if (buscarX == "DNI")
                listAnimalxAdoptante = obj_nAnimalxAdoptante.Listar().FindAll(X => X.dni.ToString() == buscar);

            return listAnimalxAdoptante;
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

            if (busqueda == "Codigo de adopcion")
            {
                cmbBuscarX.BackColor = colorPrincipal;
                lblBusquedaText.Text = "Ingrese el codigo:";
                cmbBuscar.Enabled = true;
                LlenarComboBox(busqueda);
            }
            if (busqueda == "DNI")
            {
                cmbBuscarX.BackColor = colorPrincipal;
                lblBusquedaText.Text = "Ingrese el DNI:";
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
            cmbBuscarX.Text = "Codigo de adopcion";
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
            int selectCant = dgvLista.SelectedRows.Count;
            string codigo = "";

            while (selectCant > 0)
            {
                if (!dgvLista.SelectedRows[0].IsNewRow)
                {
                    codigo = dgvLista.SelectedRows[0].Cells[0].Value.ToString(); // Obtiene el CODIGO

                    foreach (var item in obj_nAnimalxAdoptante.Listar())
                    {
                        if (item.codigoAdopcion.ToString() == codigo) // Obtiene el DNI a partir del CODIGO
                            obj_nAdoptante.Eliminar(Convert.ToInt32(item.dni)); // Borra a partir del DNI
                    }

                    obj_nAnimalxAdoptante.Eliminar(Convert.ToInt32(codigo)); // Borra a partir del CODIGO
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
                List<eAnimalxAdoptante> buscarListAnimales;
                buscarListAnimales = LlenarListBusqueda(buscarX, buscar); // Guarda en una lista TODOS los datos de un animal a partir del dato seleccionado

                this.RestablecerValores();
                // Mostrar a partir de la nueva lista
                dgvLista.AutoGenerateColumns = true;
                bindingSource1.DataSource = buscarListAnimales;
                dgvLista.DataSource = bindingSource1;
            }
            else
                MessageBox.Show("Esta accion requiere un tipo de busqueda!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            string buscarX = cmbBuscarX.Text.Trim();
            string buscar = cmbBuscar.Text.Trim();

            if (buscarX == "Codigo de adopcion")
            {
                edicionEnCurso = true;
                editar = new list_adopciones_editar(edicionEnCurso, dgvLista, buscar);
                editar.Show();
            }
            else
                MessageBox.Show("Esta accion requiere un codigo!");
        }
        private void btnRecoger_Click(object sender, EventArgs e)
        {
            string buscarX = cmbBuscarX.Text.Trim();
            string codigo = cmbBuscar.Text.Trim();

            if (buscarX == "Codigo de adopcion")
            {
                foreach (var item in obj_nAnimalxAdoptante.Listar()) // Busca los datos del animal a partir del CODIGO
                {
                    if (item.codigoAdopcion.ToString() == codigo)
                    {
                        obj_nAnimal.Insertar(item.codigoAdopcion, item.tipo, item.nombre, item.raza, item.edad, item.sexo, item.color, item.proveniencia, item.estado);
                        obj_nAnimalxAdoptante.Eliminar(item.codigoAdopcion);
                        obj_nAdoptante.Eliminar(item.dni);
                        RestablecerValores();
                        this.Mostrar();
                    }
                }
            }
            else
                MessageBox.Show("Esta accion requiere un codigo!");
        }
    }
}

