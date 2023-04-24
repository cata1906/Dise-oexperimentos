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
    public partial class dar_animal_adop : UserControl
    {
        // ------------------------------------- [ --- Atributos --- ] -------------------------------------
        // Color principal
        private Color colorPrincipal = Funciones.colorDatos();
        // Atributos principales
        private nAnimal obj_nAnimal = new nAnimal();
        private nAnimalxAdoptante obj_nAnimalXadoptante = new nAnimalxAdoptante();
        private nAdoptante obj_nAdoptante = new nAdoptante();
        private BindingSource bindingSource1 = new BindingSource();
        // ------------------------------------- [ --- Constructor --- ] -------------------------------------
        public dar_animal_adop()
        {
            InitializeComponent();
            lblDarAnimalEnAdopcion.ForeColor = colorPrincipal;
            lblDatosDelAdoptante.ForeColor = colorPrincipal;
            btnDarAdopcion.BackColor = colorPrincipal;
        }
        // ------------------------------------- [ --- Metodos --- ] -------------------------------------
        public void RestablecerValores()
        {
            lblVacio.Visible = false;
            cmbCodigo.SelectedIndex = -1;
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtMotivo.Text = "";
            cmbCodigo.BackColor = Color.White;
            txtDNI.BackColor = Color.White;
            txtNombre.BackColor = Color.White;
            txtApellido.BackColor = Color.White;
            txtTelefono.BackColor = Color.White;
            txtCorreo.BackColor = Color.White;
            txtDireccion.BackColor = Color.White;
            txtMotivo.BackColor = Color.White;

            ActualizarComboBox();
        }
        public void ActualizarComboBox()
        {
            cmbCodigo.Items.Clear();

            foreach (var item in obj_nAnimal.Listar())
            {
                cmbCodigo.Items.Add(item.codigo);
            }

            if (cmbCodigo.Items.Count == 0)
                lblVacio.Visible = true;
            else
                lblVacio.Visible = false;
        }
        // ------------------------------------- [ --- Eventos Back --- ] -------------------------------------
        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigo.BackColor = colorPrincipal;
        }
        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            txtDNI.BackColor = colorPrincipal;
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.BackColor = colorPrincipal;
        }
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            txtApellido.BackColor = colorPrincipal;
        }
        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.BackColor = colorPrincipal;
        }
        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            txtCorreo.BackColor = colorPrincipal;
        }
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            txtDireccion.BackColor = colorPrincipal;
        }
        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {
            txtMotivo.BackColor = colorPrincipal;
        }
        // ------------------------------------- [ --- Eventos Front --- ] -------------------------------------
        private void btnDarAdopcion_Click(object sender, EventArgs e)
        {
            string codigo = cmbCodigo.Text.Trim(); // Codigo del animal
            // Datos del adoptante
            string dni = txtDNI.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string motivo = txtMotivo.Text.Trim();

            if (codigo != "" && dni != "" && nombre != "" && apellido != "" && telefono != "" && correo != "" && direccion != "" && motivo != "")
            {
                // Los datos del animal ya estan en la tabla (dbo.Animales)
                // 1. Guarda los datos del adoptante en una tabla (dbo.Adoptantes)
                obj_nAdoptante.Insertar(Convert.ToInt32(dni), nombre, apellido, Convert.ToInt32(telefono), correo, direccion, motivo);
                // 2. Guarda el dni del adoptante y los datos del animal en una tabla (dbo.AnimalesxAdoptante)
                foreach (var item in obj_nAnimal.Listar())
                {
                    if (item.codigo == Convert.ToInt32(codigo))
                    {
                        obj_nAnimalXadoptante.Insertar(Convert.ToInt32(codigo), Convert.ToInt32(dni), item.tipo, item.nombre, item.raza, item.edad, item.sexo, item.color, item.proveniencia, item.estado);
                    }
                }
                // 3. Elimina al animal de la tabla de animales (dbo.Animales)
                obj_nAnimal.Eliminar(Convert.ToInt32(codigo));
                RestablecerValores();
            }
            else
                MessageBox.Show("Complete todos los cuadros!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            RestablecerValores();
        }

        private void btnAutoComplete_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.Items.Count != 0) // Si hay animales para dar en adopcion
            {
                // Codigo
                cmbCodigo.SelectedIndex = Funciones.GenerarNumeroRandom(0, cmbCodigo.Items.Count);

                // DNI
                txtDNI.Text = Funciones.GenerarNumeroRandom(71111111, 79999999).ToString();
                // Nombre
                string nombre = Funciones.GenerarNombreRandom(Funciones.GenerarNumeroRandom(4, 7));
                txtNombre.Text = nombre;
                // Apellido
                txtApellido.Text = Funciones.GenerarNombreRandom(Funciones.GenerarNumeroRandom(2, 8));
                // Telefono
                txtTelefono.Text = Funciones.GenerarNumeroRandom(900000000, 999999999).ToString();
                // Correo
                txtCorreo.Text = nombre + "@gmail.com";
                // Direccion
                txtDireccion.Text = "Lima";
                // Motivo
                txtMotivo.Text = "Me gustan los animales";
            }
        }
    }
}
