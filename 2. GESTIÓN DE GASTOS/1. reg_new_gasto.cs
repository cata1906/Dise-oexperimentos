using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TPG401
{
    public partial class reg_new_gasto : UserControl
    {
        // ------------------------------------- [ --- Atributos --- ] -------------------------------------
        private Color colorPrincipal = Funciones.colorGastos();
        private nGasto obj_nGasto = new nGasto();
        // ------------------------------------- [ --- Constructor --- ] -------------------------------------
        public reg_new_gasto()
        {
            InitializeComponent();
            lblRegistrarNuevoGasto.ForeColor = colorPrincipal;
            btnRegistrar.BackColor = colorPrincipal;
        }
        // ------------------------------------- [ --- Metodos --- ] -------------------------------------
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
            txtMontoUnitario.Enabled = false;
        }
        // ------------------------------------- [ --- Eventos Back --- ] -------------------------------------
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
        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            RestablecerValores();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string tipo = cmbTipo.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            string cantidad = txtCantidad.Text.ToString().Trim();
            string montoUnitario = txtMontoUnitario.Text.Trim();
            string montoTotal = txtMontoTotal.Text.Trim();
            DateTime fechaRegistro = dtpFechaRegistro.Value;


            bool todoCompleto = true;

            if (todoCompleto == true)
            {
                bool searchDescription = false; // True: La descripción ingresada ya existe
                List<eGasto> lista = obj_nGasto.Listar(); // Lista para ver si hay datos en la lista
                eGasto gasto = new eGasto(); // Guarda los datos del item que tenga descripcion igual

                if (lista != null)
                {
                    foreach (var item in obj_nGasto.Listar())
                    {
                        if (item.descripcion == descripcion)
                        {
                            searchDescription = true;
                            gasto.codigo = item.codigo;
                            gasto.tipo = item.tipo;
                            gasto.descripcion = item.descripcion;
                            gasto.cantidad = item.cantidad;
                            gasto.montoUnitario = item.montoUnitario;
                            gasto.montoTotal = item.montoTotal;
                            gasto.fechaRegistro = item.fechaRegistro;
                        }
                    }
                }
                if (searchDescription == false) // NO se encontró una descripcion igual
                {
                    obj_nGasto.Insertar(tipo, descripcion, Convert.ToInt32(cantidad), Convert.ToDecimal(montoUnitario), Convert.ToDecimal(montoTotal), fechaRegistro);
                    this.RestablecerValores();
                }
                else
                {
                    gasto.cantidad = gasto.cantidad + Convert.ToInt32(cantidad);
                    gasto.montoUnitario = gasto.montoUnitario + Convert.ToDecimal(montoUnitario);
                    gasto.montoTotal = gasto.montoTotal + (Convert.ToInt32(cantidad) * Convert.ToDecimal(montoUnitario));
                    obj_nGasto.Actualizar(gasto.codigo, tipo, descripcion, gasto.cantidad, gasto.montoUnitario, gasto.montoTotal, fechaRegistro);
                    this.RestablecerValores();
                }
            }
            else
                MessageBox.Show("Complete todos los campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnAutoComplete_Click(object sender, EventArgs e)
        {

        }
    }
}