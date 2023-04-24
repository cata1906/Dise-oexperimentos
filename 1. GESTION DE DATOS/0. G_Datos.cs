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
    public partial class G_Datos : UserControl
    {
        // ------------------------------------- [ --- Atributos --- ] -------------------------------------
        // Color principal
        private Color colorPrincipal = Funciones.colorDatos();
        // Pantallas (controles de usuario)
        private reg_new_animal pantalla_RegNewAnimal = new reg_new_animal();
        private dar_animal_adop pantalla_DarAnimalAdop = new dar_animal_adop();
        private list_animales pantalla_ListAnimales = new list_animales();
        private list_adopciones pantalla_ListAnimalesAdop = new list_adopciones();
        private list_adoptantes pantalla_ListAdoptantes = new list_adoptantes();
        private list_animales_crit pantalla_ListAnimalesCrit = new list_animales_crit();
        // Boton seleccionado
        private IconButton btnSelected;
        private Panel btnBorde;
        // ------------------------------------- [ --- Constructor --- ] -------------------------------------
        public G_Datos()
        {
            // Atributos inicializados
            InitializeComponent();
            btnBorde = new Panel();
            btnBorde.Size = new Size(5, ibtn_reg_new_animal.Size.Height);
            panelMenu.Controls.Add(btnBorde);
            // ------------------------------------- [ Colores ] -------------------------------------
            pn1.BackColor = colorPrincipal;
            pn2.BackColor = colorPrincipal;
            pn3.BackColor = colorPrincipal;
            // ---> Button 1
            ibtn_reg_new_animal.ForeColor = colorPrincipal;
            ibtn_reg_new_animal.IconColor = colorPrincipal;
            // ---> Button 2
            ibtn_dar_animal_adop.ForeColor = colorPrincipal;
            ibtn_dar_animal_adop.IconColor = colorPrincipal;
            // ---> Button 3
            ibtn_list_animales.ForeColor = colorPrincipal;
            ibtn_list_animales.IconColor = colorPrincipal;
            // ---> Button 4
            ibtn_list_animales_adop.ForeColor = colorPrincipal;
            ibtn_list_animales_adop.IconColor = colorPrincipal;
            // ---> Button 5
            ibtn_list_adoptantes.ForeColor = colorPrincipal;
            ibtn_list_adoptantes.IconColor = colorPrincipal;
            // ---> Button 6
            ibtn_list_animales_crit.ForeColor = colorPrincipal;
            ibtn_list_animales_crit.IconColor = colorPrincipal;
            // Metodos inicializados
            ResaltarBoton(ibtn_reg_new_animal, colorPrincipal, Color.FromArgb(34, 36, 80));
            CambiarPantalla(pantalla_RegNewAnimal);
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
                // Resalta el borde del boton
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
        private void ibtn_reg_new_animal_Click(object sender, EventArgs e)
        {
            ResaltarBoton(sender, colorPrincipal, Color.FromArgb(34, 36, 80));
            CambiarPantalla(pantalla_RegNewAnimal);
            pantalla_RegNewAnimal.RestablecerValores();
        }
        public void ibtn_dar_animal_adop_Click(object sender, EventArgs e)
        {
            ResaltarBoton(sender, colorPrincipal, Color.FromArgb(34, 36, 80));
            CambiarPantalla(pantalla_DarAnimalAdop);
            pantalla_DarAnimalAdop.ActualizarComboBox();
            pantalla_DarAnimalAdop.RestablecerValores();
        }
        private void ibtn_list_animales_Click(object sender, EventArgs e)
        {
            ResaltarBoton(sender, colorPrincipal, Color.FromArgb(34, 36, 80));
            CambiarPantalla(pantalla_ListAnimales);
            pantalla_ListAnimales.Mostrar();
            pantalla_ListAnimales.RestablecerValores();
        }
        private void ibtn_list_animales_adop_Click(object sender, EventArgs e)
        {
            ResaltarBoton(sender, colorPrincipal, Color.FromArgb(34, 36, 80));
            CambiarPantalla(pantalla_ListAnimalesAdop);
            pantalla_ListAnimalesAdop.Mostrar();
            pantalla_ListAnimalesAdop.RestablecerValores();
        }
        private void ibtn_list_adoptantes_Click(object sender, EventArgs e)
        {
            ResaltarBoton(sender, colorPrincipal, Color.FromArgb(34, 36, 80));
            CambiarPantalla(pantalla_ListAdoptantes);
            pantalla_ListAdoptantes.Mostrar();
            pantalla_ListAdoptantes.RestablecerValores();
        }
        private void ibtn_list_animales_criticos_Click(object sender, EventArgs e)
        {
            ResaltarBoton(sender, colorPrincipal, Color.FromArgb(34, 36, 80));
            CambiarPantalla(pantalla_ListAnimalesCrit);
            pantalla_ListAnimalesCrit.Mostrar();
        }
        private void ibtnLogout_Click(object sender, EventArgs e)
        {
            foreach (var form in Application.OpenForms.OfType<FormTipoGestion>().ToList()) // Busca el formulario FormTipoGestion en las aplicaciones abuertas
            {
                form.Close(); // Cierra el formulario FormTipoGestion
            }
            Funciones.LoginForm.Show(); // Muestra el form de Login
        }
    }
}