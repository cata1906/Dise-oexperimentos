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
    public partial class reg_new_medicamento : UserControl
    {
        // ------------------------------------- [ Atributos ] -------------------------------------
        private Color colorPrincipal = Funciones.colorMedicamentos();
        private nMedicamento obj_nMedicamento = new nMedicamento();
        // ------------------------------------- [ Constructor ] -------------------------------------
        public reg_new_medicamento()
        {
            InitializeComponent();
            dtpFechaCaducidad.Value = DateTime.Now;
        }
        // ------------------------------------- [ Metodos ] -------------------------------------
        public void RestablecerValores()
        {
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            dtpFechaCaducidad.Value = DateTime.Now;
            txtDescripcion.BackColor = Color.White;
            txtCantidad.BackColor = Color.White;
        }
        // ------------------------------------- [ Eventos Back ] -------------------------------------
        private void timerFecha_Tick(object sender, EventArgs e)
        {
            dtpFechaIngreso.Value = DateTime.Now;
        }
        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.BackColor = colorPrincipal;
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            txtCantidad.BackColor = colorPrincipal;
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.PermitirSolo(sender, e, "numeros", false, false);
        }
        // ------------------------------------- [ Eventos Front ] -------------------------------------
        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            RestablecerValores();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            DateTime fechaIngreso = dtpFechaIngreso.Value;
            DateTime fechaCaducidad = dtpFechaCaducidad.Value;

            if (txtDescripcion.TextLength > 0 && txtCantidad.TextLength > 0)
            {
                obj_nMedicamento.Insertar(descripcion, cantidad, fechaIngreso, fechaCaducidad);
                RestablecerValores();
            }
        }
    }
}