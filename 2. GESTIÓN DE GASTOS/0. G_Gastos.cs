using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace TPG401
{
    public partial class G_Gastos : UserControl
    {
        // ------------------------------------- [ --- Atributos --- ] -------------------------------------
        private Color colorPrincipal = Funciones.colorGastos();
        private reg_new_gasto pantallaRegNewGasto = new reg_new_gasto();
        private list_gastos pantallaListGastos = new list_gastos();
        private list_gastos_mes_o_anio pantallaListGastosMesAnio = new list_gastos_mes_o_anio();
        private IconButton btnSelected;
        private Panel btnBorde;
        // ------------------------------------- [ --- Constructor --- ] -------------------------------------
        public G_Gastos()
        {
            InitializeComponent();
            btnBorde = new Panel();
            btnBorde.Size = new Size(5, ibtn_reg_new_gasto.Size.Height);
            panelMenu.Controls.Add(btnBorde);
            // ------------------------------------- [ Colores ] -------------------------------------
            pn1.BackColor = colorPrincipal;
            pn2.BackColor = colorPrincipal;
            pn3.BackColor = colorPrincipal;
            // ---> Button 1
            ibtn_reg_new_gasto.ForeColor = colorPrincipal;
            ibtn_reg_new_gasto.IconColor = colorPrincipal;
            // ---> Button 2
            ibtn_list_gastos.ForeColor = colorPrincipal;
            ibtn_list_gastos.IconColor = colorPrincipal;
            // Metodos inicializados
            ResaltarBoton(ibtn_reg_new_gasto, colorPrincipal, Color.FromArgb(34, 36, 80));
            CambiarPantalla(pantallaRegNewGasto);
        }
        // ------------------------------------- [ --- Metodos --- ] -------------------------------------
        private void ResaltarBoton(object btn, Color colorBorde, Color colorRelleno)
        {
            if (btn != null)
            {
                DesativarBotonActivo(); // Desselecciona el ultimo boton seleccionado
                btnSelected = (IconButton)btn; // Toma todos los valores del boton que se quiere seleccionar (x, y, etc.)
                btnSelected.BackColor = colorRelleno;
                btnSelected.ForeColor = colorBorde;
                btnSelected.Padding = new Padding(30, 0, 20, 0);
                btnSelected.IconColor = colorBorde;
                // Resalta el borde izquierdo del boton
                btnBorde.BackColor = colorBorde;
                btnBorde.Location = new Point(btnSelected.Location.X, btnSelected.Location.Y);
                btnBorde.Visible = true;
                btnBorde.BringToFront();
            }
        }
        private void DesativarBotonActivo()
        {
            if (btnSelected != null)
            {
                btnSelected.Padding = new Padding(10, 0, 20, 0);
                btnSelected.BackColor = Color.FromArgb(34, 36, 60);
                btnSelected.ForeColor = colorPrincipal;
                btnSelected.IconColor = colorPrincipal;
                btnBorde.Visible = false;
            }
        }
        private void CambiarPantalla(UserControl nuevaPantalla)
        {
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(nuevaPantalla);
            nuevaPantalla.BringToFront();
        }
        // ------------------------------------- [ --- Eventos Front --- ] -------------------------------------
        private void ibtn_reg_new_gasto_Click(object sender, EventArgs e)
        {
            ResaltarBoton(sender, colorPrincipal, Color.FromArgb(34, 36, 80));
            CambiarPantalla(pantallaRegNewGasto);
            pantallaRegNewGasto.RestablecerValores();
        }
        private void ibtn_list_gastos_Click(object sender, EventArgs e)
        {
            ResaltarBoton(sender, colorPrincipal, Color.FromArgb(34, 36, 80));
            CambiarPantalla(pantallaListGastos);
            pantallaListGastos.Mostrar();
            pantallaListGastos.RestablecerValores();
        }
        private void ibtn_list_gastos_mes_o_anio_Click(object sender, EventArgs e)
        {
            ResaltarBoton(sender, colorPrincipal, Color.FromArgb(34, 36, 80));
            CambiarPantalla(pantallaListGastosMesAnio);
            pantallaListGastosMesAnio.RestablecerValores();
        }
        private void ibtnLogout_Click(object sender, EventArgs e)
        {
            foreach (var form in Application.OpenForms.OfType<FormTipoGestion>().ToList())
            {
                form.Close();
            }
            Funciones.LoginForm.Show();
        }
    }
}
