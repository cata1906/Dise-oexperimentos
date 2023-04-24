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
    public partial class reg_new_animal : UserControl
    {
        // ------------------------------------- [ --- Atributos --- ] -------------------------------------
        private Color colorPrincipal = Funciones.colorDatos();
        private nAnimal obj_nAnimal = new nAnimal();
        private nAnimalxHistorial obj_nAnimalxHistorial = new nAnimalxHistorial();
        // ------------------------------------- [ --- Constructor --- ] -------------------------------------
        public reg_new_animal()
        {
            InitializeComponent();
            cmbColor.Size = new Size(247, 28);
            lblRegistrarNuevoAnimal.ForeColor = colorPrincipal;
            btnGenCod.BackColor = colorPrincipal;
            btnRegistrar.BackColor = colorPrincipal;
            txtEdad.Text = "";
        }
        // ------------------------------------- [ --- Metodos --- ] -------------------------------------
        public void RestablecerValores()
        {
            txtCod.Text = "";
            cmbTipo.SelectedIndex = -1;
            txtNombre.Text = "";
            cmbRaza.SelectedIndex = -1;
            txtEdad.Text = "";
            cmbSexo.SelectedIndex = -1;
            cmbColor.SelectedIndex = -1;
            cmbProv.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            txtCod.BackColor = Color.White;
            cmbTipo.BackColor = Color.White;
            txtNombre.BackColor = Color.White;
            cmbRaza.BackColor = Color.White;
            txtEdad.BackColor = Color.White;
            cmbSexo.BackColor = Color.White;
            cmbColor.BackColor = Color.White;
            cmbColor1.BackColor = Color.White;
            cmbColor2.BackColor = Color.White;
            cmbColor3.BackColor = Color.White;
            cmbProv.BackColor = Color.White;
            cmbEstado.BackColor = Color.White;
            cmbColor.Size = new Size(247, 28);
            cmbColor1.Visible = false;
            cmbColor2.Visible = false;
            cmbColor3.Visible = false;
        }
        private void ActualizarRazas(string tipo)
        {
            if (tipo == "Perro")
            {
                cmbRaza.Enabled = true;
                cmbRaza.Items.Clear();
                cmbRaza.Items.Add("Desconocido");
                cmbRaza.Items.Add("Pekines");
                cmbRaza.Items.Add("Shih Tzu");
                cmbRaza.Items.Add("Pastor Aleman");
                cmbRaza.Items.Add("Poodle");
                cmbRaza.Items.Add("Golden Retriever");
                cmbRaza.Items.Add("Labrador Retriever");
                cmbRaza.Items.Add("Bullmastiff");
                cmbRaza.Items.Add("Husky Siberiano");
                cmbRaza.Items.Add("Schnauzer");
                cmbRaza.Items.Add("Boxer");
                cmbRaza.Items.Add("Otro");
            }
            else if (tipo == "Gato")
            {
                cmbRaza.Enabled = true;
                cmbRaza.Items.Clear();
                cmbRaza.Items.Add("Grande");
                cmbRaza.Items.Add("Pequeño");
            }
        }
        // ------------------------------------- [ --- Eventos Back --- ] -------------------------------------
        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            txtCod.BackColor = colorPrincipal;
        }
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTipo.BackColor = colorPrincipal;
            ActualizarRazas(cmbTipo.Text);
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.BackColor = colorPrincipal;
        }
        private void cmbRaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRaza.BackColor = colorPrincipal;
        }
        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            txtEdad.BackColor = colorPrincipal;
        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.PermitirSolo(sender, e, "numeros", false, false);
        }
        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSexo.BackColor = colorPrincipal;
        }
        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbColor.BackColor = colorPrincipal;

            if (cmbColor.Text == "Bicolor")
            {
                cmbColor.Size = new Size(78, 28);

                cmbColor1.Size = new Size(78, 28);
                cmbColor2.Size = new Size(78, 28);
                cmbColor1.Visible = true;
                cmbColor2.Visible = true;
            }
            else if (cmbColor.Text == "Tricolor")
            {
                cmbColor.Size = new Size(78, 28);

                cmbColor1.Size = new Size(78, 28);
                cmbColor2.Size = new Size(78, 28);
                cmbColor3.Size = new Size(78, 28);
                cmbColor1.Visible = true;
                cmbColor2.Visible = true;
                cmbColor3.Visible = true;
            }
            else
            {
                cmbColor.Size = new Size(247, 28);
                cmbColor1.Visible = false;
                cmbColor2.Visible = false;
                cmbColor3.Visible = false;
            }
        }
        private void cmbColor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbColor1.BackColor = colorPrincipal;
        }
        private void cmbColor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbColor2.BackColor = colorPrincipal;
        }
        private void cmbColor3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbColor3.BackColor = colorPrincipal;
        }
        private void cmbProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProv.BackColor = colorPrincipal;
        }
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEstado.BackColor = colorPrincipal;
        }
        // ------------------------------------- [ Eventos Front ] -------------------------------------
        private void btnGenCod_Click(object sender, EventArgs e)
        {
            txtCod.Text = Funciones.GenerarNumeroRandom(10000, 99999).ToString(); // Genera un codigo de 5 digitos
            txtCod.BackColor = colorPrincipal;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string codigo = txtCod.Text.Trim();
            string tipo = cmbTipo.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string raza = cmbRaza.Text.Trim();
            string edad = txtEdad.Text.Trim();
            string sexo = cmbSexo.Text.Trim();
            string color = cmbColor.Text.Trim();
            string distrito = cmbProv.Text.Trim();
            string estado = cmbEstado.Text.Trim();

            if (codigo != "" && tipo != "" && nombre != "" && raza != "" && edad != "" && sexo != "" && color != "" && distrito != "" && estado != "")
            {
                if (!obj_nAnimal.Listar().Exists(X => X.codigo.ToString() == codigo))
                {
                    obj_nAnimal.Insertar(Convert.ToInt32(codigo), tipo, nombre, raza, Convert.ToInt32(edad), sexo, color, distrito, estado);
                    obj_nAnimalxHistorial.Insertar(Convert.ToInt32(codigo), tipo, nombre, raza, Convert.ToInt32(edad), sexo, color, distrito, estado, DateTime.Now);
                    RestablecerValores();
                }
            }
            else
                MessageBox.Show("Complete todos los campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            RestablecerValores();
        }
        private void btnAutoComplete_Click(object sender, EventArgs e)
        {
            // Codigo
            txtCod.Text = Funciones.GenerarNumeroRandom(10000, 99999).ToString(); // Genera un codigo de 5 digitos
            // Tipo
            cmbTipo.SelectedIndex = Funciones.GenerarNumeroRandom(0, cmbTipo.Items.Count);
            // Nombre
            txtNombre.Text = Funciones.GenerarNombreRandom(Funciones.GenerarNumeroRandom(3, 7)); // de 3 a 6
            // Raza
            ActualizarRazas(cmbTipo.Text);
            cmbRaza.SelectedIndex = Funciones.GenerarNumeroRandom(0, cmbRaza.Items.Count);
            // Edad
            txtEdad.Text = Funciones.GenerarNumeroRandom(1, 14).ToString();
            // Sexo
            cmbSexo.SelectedIndex = Funciones.GenerarNumeroRandom(0, cmbSexo.Items.Count);
            // Color
            cmbColor.SelectedIndex = Funciones.GenerarNumeroRandom(0, (cmbColor.Items.Count - 2)); // (-2) = -Bicolor y -Tricolor
            // Proveniencia
            cmbProv.SelectedIndex = Funciones.GenerarNumeroRandom(0, cmbProv.Items.Count);
            // Estado
            cmbEstado.SelectedIndex = Funciones.GenerarNumeroRandom(0, cmbEstado.Items.Count);
        }
    }
}