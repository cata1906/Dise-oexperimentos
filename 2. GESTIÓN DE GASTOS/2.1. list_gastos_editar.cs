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
    public partial class list_gastos_editar : Form
    {
        // ------------------------------------- [ Atributos ] -------------------------------------
        private Color colorPrincipal = Color.FromArgb(255, 230, 20);
        private nGasto obj_nGasto = new nGasto();
        private BindingSource bindingSource1 = new BindingSource();
        private DataGridView dgvLista = new DataGridView();
        public bool edicionEnCurso;
        // ------------------------------------- [ Panel de movimiento 1 ] -------------------------------------
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // ------------------------------------- [ Constructor ] -------------------------------------
        public list_gastos_editar(bool sendEdicionEnCurso, DataGridView sendDgvLista, string codigo)
        {
            InitializeComponent();
            edicionEnCurso = sendEdicionEnCurso;
            dgvLista = sendDgvLista;
            LlenarComboBox(); // con codigos

            if (codigo != "") // si se envio un codigo desde el formulario
            {
                RellenarCuadros(codigo); // Rellenar los cuadros con esos datos
            }
        }
        // ------------------------------------- [ --- METODOS --- ] -------------------------------------
        public void Mostrar()
        {
            dgvLista.AutoGenerateColumns = true;
            bindingSource1.DataSource = obj_nGasto.Listar();
            dgvLista.DataSource = bindingSource1;
        }
        public void RestablecerValores()
        {
            cmbTipo.SelectedIndex = -1;
            cmbTipo.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtMontoUnitario.Text = "";
            txtMontoTotal.Text = "";
            cmbTipo.BackColor = Color.White;
            txtDescripcion.BackColor = Color.White;
            txtCantidad.BackColor = Color.White;
            txtMontoUnitario.BackColor = Color.White;
            txtMontoTotal.BackColor = Color.White;
            txtMontoUnitario.Enabled = false;
        }
        public void LlenarComboBox()
        {
            cmbBuscar.Items.Clear();
            foreach (var item in obj_nGasto.Listar())
            {
                cmbBuscar.Items.Add(item.codigo);
            }
        }
        public void RellenarCuadros(string codigo)
        {
            cmbBuscarX.BackColor = colorPrincipal;
            cmbBuscar.BackColor = colorPrincipal;
            cmbBuscar.Text = codigo;

            foreach (var item in obj_nGasto.Listar())
            {
                if (item.codigo.ToString() == codigo)
                {
                    cmbTipo.Text = item.tipo;
                    txtDescripcion.Text = item.descripcion;
                    txtCantidad.Text = item.cantidad.ToString();
                    txtMontoUnitario.Text = item.montoUnitario.ToString();
                    txtMontoTotal.Text = item.montoTotal.ToString();
                }
            }
            cmbTipo.Enabled = true;
            txtDescripcion.Enabled = true;
            txtCantidad.Enabled = true;
            cmbTipo.BackColor = colorPrincipal;
            txtDescripcion.BackColor = colorPrincipal;
            txtCantidad.BackColor = colorPrincipal;
            txtMontoUnitario.BackColor = colorPrincipal;
            txtMontoTotal.BackColor = colorPrincipal;
        }
        // ------------------------------------- [ --- Eventos Back --- ] -------------------------------------
        private void pnCerraryMin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void pbAtras_MouseEnter(object sender, EventArgs e)
        {
            pbAtras.Image = TPG401.Properties.Resources.back1;
        }
        private void pbAtras_MouseLeave(object sender, EventArgs e)
        {
            pbAtras.Image = TPG401.Properties.Resources.back;
        }
        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RellenarCuadros(cmbBuscar.Text.Trim()); // Rellena la informacion a partir de un CODIGO
        }
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTipo.BackColor = colorPrincipal;
        }
        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.BackColor = colorPrincipal;
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            txtCantidad.BackColor = colorPrincipal;
            txtMontoUnitario.Enabled = true;

            if (txtCantidad.TextLength > 0 && txtMontoUnitario.TextLength > 0)
                txtMontoTotal.Text = (Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtMontoUnitario.Text)).ToString();
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.PermitirSolo(sender, e, "numeros", false, false);
        }
        private void txtMontoUnitario_TextChanged(object sender, EventArgs e)
        {
            txtMontoUnitario.BackColor = colorPrincipal;
            txtMontoTotal.BackColor = colorPrincipal;

            if (txtCantidad.Text != "" && txtMontoUnitario.TextLength > 0)
                txtMontoTotal.Text = (Convert.ToDecimal(txtMontoUnitario.Text) * Convert.ToInt32(txtCantidad.Text)).ToString();
        }
        private void txtMontoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.PermitirSolo(sender, e, "numeros", false, true);
        }
        private void timerFecha_Tick(object sender, EventArgs e)
        {
            dtpFechaRegistro.Value = DateTime.Now;
        }
        // ------------------------------------- [ --- Eventos Front --- ] -------------------------------------
        private void pbAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            this.RestablecerValores();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            string cod = cmbBuscar.Text.Trim();

            string tipo = cmbTipo.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            int cantidad = Convert.ToInt32(txtCantidad.Text.Trim());
            string montoUnitario = txtMontoUnitario.Text.Trim();
            string montoTotal = txtMontoTotal.Text.Trim();
            DateTime fechaRegistro = dtpFechaRegistro.Value;

            if (cod != "" && tipo != "" && descripcion != "" && cantidad > 0 && montoUnitario != "" && montoTotal != "")
            {
                obj_nGasto.Actualizar(Convert.ToInt32(cod), tipo, descripcion, cantidad, Convert.ToDecimal(montoUnitario), Convert.ToDecimal(montoTotal), fechaRegistro);
                this.RestablecerValores();
                int indice = dgvLista.CurrentRow.Index; // Guarda el indice de la columna seleccionada
                this.Mostrar();
                dgvLista.Rows[0].Selected = false; // Quita la seleccion de la primera fila
                dgvLista.Rows[indice].Selected = true; // Coloca la seleccion en el indice de la columna
                this.Close();
                edicionEnCurso = false;
            }
            else
                MessageBox.Show("Complete todos los campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
