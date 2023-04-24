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
    public partial class FormTipoGestion : Form
    {
        // ------------------------------------- [ --- Atributos --- ] -------------------------------------
        // Color principal
        private Color colorPrincipalDatos = Funciones.colorDatos();
        private Color colorPrincipalGastos = Funciones.colorGastos();
        private Color colorPrincipalInventario = Funciones.colorMedicamentos();
        // Pantallas (controles de usuario)
        G_Datos pantallaG_Datos = new G_Datos();
        G_Gastos pantallaG_Gastos = new G_Gastos();
        G_Inventario pantallaG_Inventario = new G_Inventario();
        IconButton btnSelected;
        Panel btnBorde;
        // ------------------------------------- [ Panel de movimiento 1 ] -------------------------------------
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // ------------------------------------- [ --- CONSTRUCTOR --- ] -------------------------------------
        public FormTipoGestion()
        {
            InitializeComponent();
            btnBorde = new Panel();
            btnBorde.Size = new Size(354, 7);
            panelMenu.Controls.Add(btnBorde);
            ResaltarBoton(ibtn_GDatos, colorPrincipalDatos, Color.FromArgb(34, 36, 80));
            CambiarPantalla(pantallaG_Datos);
        }
        // ------------------------------------- [ --- METODOS --- ] -------------------------------------
        private void ResaltarBoton(object btn, Color colorUno, Color colorTexto)
        {
            if (btn != null)
            {
                DesativarBotonActivo();
                btnSelected = (IconButton)btn;
                btnSelected.Padding = new Padding(10, 20, 20, 10);
                btnSelected.BackColor = Color.FromArgb(34, 36, 80);
                btnSelected.ForeColor = colorUno;
                btnSelected.IconColor = colorUno;
                btnBorde.BackColor = colorUno;
                btnBorde.Location = new Point(btnSelected.Location.X, 0);
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
                btnSelected.ForeColor = Color.FromArgb(244, 244, 244);
                btnSelected.IconColor = Color.FromArgb(244, 244, 244);
                btnBorde.Visible = false;
            }
        }
        private void CambiarPantalla(UserControl nuevaPantalla)
        {
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(nuevaPantalla);
            nuevaPantalla.BringToFront();
        }
        // ------------------------------------- [ --- BACK --- ] -------------------------------------
        private void pnCerraryMin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.Image = TPG401.Properties.Resources.close2;
        }
        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.Image = TPG401.Properties.Resources.close1;
        }
        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pbMinimize_MouseEnter(object sender, EventArgs e)
        {
            pbMinimize.Image = TPG401.Properties.Resources.minimize2;
        }
        private void pbMinimize_MouseLeave(object sender, EventArgs e)
        {
            pbMinimize.Image = TPG401.Properties.Resources.minimize1;
        }
        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // ------------------------------------- [ --- Eventos Front --- ] -------------------------------------
        private void ibtn_GDatos_Click(object sender, EventArgs e)
        {
            ResaltarBoton(sender, colorPrincipalDatos, Color.FromArgb(34, 36, 80));
            CambiarPantalla(pantallaG_Datos);
        }
        private void ibtn_GGastos_Click(object sender, EventArgs e)
        {
            ResaltarBoton(sender, colorPrincipalGastos, Color.FromArgb(34, 36, 80));
            CambiarPantalla(pantallaG_Gastos);
        }
        private void ibtn_GInventario_Click(object sender, EventArgs e)
        {
            ResaltarBoton(sender, colorPrincipalInventario, Color.FromArgb(34, 36, 80));
            CambiarPantalla(pantallaG_Inventario);
        }
    }
}
