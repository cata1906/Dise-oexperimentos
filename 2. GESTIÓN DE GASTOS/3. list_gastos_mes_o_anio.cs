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
    public partial class list_gastos_mes_o_anio : UserControl
    {
        // ------------------------------------- [ Atributos ] -------------------------------------
        private Color colorPrincipal = Funciones.colorGastos();
        private nGasto obj_nGasto = new nGasto();
        private BindingSource bindingSource1 = new BindingSource();
        private List<eGasto> listLastMes = new List<eGasto>();
        private List<eGasto> listLastAnio = new List<eGasto>();
        // ------------------------------------- [ Constructor ] -------------------------------------
        public list_gastos_mes_o_anio()
        {
            InitializeComponent();
            lblTitulo.ForeColor = colorPrincipal;
            dgvLista.BackgroundColor = colorPrincipal;
        }
        // ------------------------------------- [ Metodos ] -------------------------------------
        public void Mostrar()
        {

            dgvLista.AutoGenerateColumns = true;
            bindingSource1.DataSource = obj_nGasto.Listar();
            dgvLista.DataSource = bindingSource1;
        }
        public void RestablecerValores()
        {
            cmbBuscarX.SelectedIndex = -1;
            dgvLista.Rows.Clear();
        }
        // ------------------------------------- [ Eventos Back ] -------------------------------------
        private void cmbBuscarX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscarX.Text == "Mes")
            {
                dgvLista.Rows.Clear(); // Limpia el DataGridView
                cmbBuscarX.BackColor = colorPrincipal;

                foreach (var item in obj_nGasto.Listar()) // Guarda los registros del ultimo mes
                {
                    if (item.fechaRegistro >= DateTime.Now.AddMonths(-1))
                        listLastMes.Add(item);
                }

                // Muestra
                dgvLista.AutoGenerateColumns = true;
                bindingSource1.DataSource = listLastMes;
                dgvLista.DataSource = bindingSource1;
            }
            else if (cmbBuscarX.Text == "Año")
            {
                dgvLista.Rows.Clear(); // Limpia el DataGridView
                cmbBuscarX.BackColor = colorPrincipal;

                foreach (var item in obj_nGasto.Listar()) // Guarda los registros del ultimo año
                {
                    if (item.fechaRegistro >= DateTime.Now.AddYears(-1))
                        listLastAnio.Add(item);
                }

                // Muestra
                dgvLista.AutoGenerateColumns = true;
                bindingSource1.DataSource = listLastAnio;
                dgvLista.DataSource = bindingSource1;
            }
        }
        // ------------------------------------- [ Eventos Front ] -------------------------------------
        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            RestablecerValores();
        }
        private void btnAscendente_Click(object sender, EventArgs e)
        {
            if (cmbBuscarX.SelectedIndex != -1)
            {
                if (cmbBuscarX.Text == "Mes")
                {
                    List<eGasto> ascendingMes = listLastMes.OrderBy(X => X.fechaRegistro).ToList(); // Ordena
                    
                    // Muestra
                    dgvLista.AutoGenerateColumns = true;
                    bindingSource1.DataSource = ascendingMes;
                    dgvLista.DataSource = bindingSource1;
                }
                else if (cmbBuscarX.Text == "Año")
                {
                    List<eGasto> ascendingAnio = listLastAnio.OrderBy(X => X.fechaRegistro).ToList(); // Ordena

                    // Muestra
                    dgvLista.AutoGenerateColumns = true;
                    bindingSource1.DataSource = ascendingAnio;
                    dgvLista.DataSource = bindingSource1;
                }
            }
            else
                MessageBox.Show("Para ordenar debe seleccionar un mes o un año");
        }
        private void btnDescendente_Click(object sender, EventArgs e)
        {
            if (cmbBuscarX.SelectedIndex != -1)
            {
                if (cmbBuscarX.Text == "Mes")
                {
                    List<eGasto> descendingMes = listLastMes.OrderByDescending(X => X.fechaRegistro).ToList(); // Ordena

                    // Muestra
                    dgvLista.AutoGenerateColumns = true;
                    bindingSource1.DataSource = descendingMes;
                    dgvLista.DataSource = bindingSource1;
                }
                else if (cmbBuscarX.Text == "Año")
                {
                    List<eGasto> descendingAnio = listLastAnio.OrderByDescending(X => X.fechaRegistro).ToList(); // Ordena

                    // Muestra
                    dgvLista.AutoGenerateColumns = true;
                    bindingSource1.DataSource = descendingAnio;
                    dgvLista.DataSource = bindingSource1;
                }
            }
            else
                MessageBox.Show("Para ordenar debe seleccionar un mes o un año");
        }
    }
}
