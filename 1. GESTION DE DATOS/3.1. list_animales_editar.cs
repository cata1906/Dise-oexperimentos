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
    public partial class list_animales_editar : Form
    {
        // ------------------------------------- [ Atributos ] -------------------------------------
        private Color colorPrincipal = Color.FromArgb(255, 230, 20);
        private nAnimal obj_nAnimal = new nAnimal();
        private nAnimalxHistorial obj_nAnimalxHistorial = new nAnimalxHistorial();
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
        public list_animales_editar(bool sendEdicionEnCurso, DataGridView sendDgvLista, string codigo)
        {
            InitializeComponent();
            edicionEnCurso = sendEdicionEnCurso;
            dgvLista = sendDgvLista;
            cmbColor.Size = new Size(247, 28);
            LlenarComboBox(); // con codigos

            if (codigo != "") // si se envio un codigo desde el formulario
            {
                RellenarCuadros(codigo); // Rellenar los cuadros con esos datos
            }
        }
        // ------------------------------------- [ Metodos ] -------------------------------------
        public void Mostrar()
        {
            dgvLista.AutoGenerateColumns = true;
            bindingSource1.DataSource = obj_nAnimal.Listar();
            dgvLista.DataSource = bindingSource1;
        }
        public void RestablecerValores()
        {
            cmbBuscar.Text = "";
            cmbBuscar.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            cmbTipo.Text = "";
            txtNombre.Text = "";
            cmbRaza.SelectedIndex = -1;
            cmbRaza.Text = "";
            txtEdad.Text = "";
            cmbSexo.SelectedIndex = -1;
            cmbSexo.Text = "";
            cmbColor.SelectedIndex = -1;
            cmbColor.Text = "";
            cmbProv.SelectedIndex = -1;
            cmbProv.Text = "";
            cmbEstado.SelectedIndex = -1;
            cmbEstado.Text = "";
            cmbBuscarX.BackColor = Color.White;
            cmbBuscar.BackColor = Color.White;
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
        public void ActualizarRaza(string tipoAnimal)
        {
            cmbRaza.BackColor = colorPrincipal;

            if (tipoAnimal == "Perro")
            {
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
            else if (tipoAnimal == "Gato")
            {
                cmbRaza.Items.Clear();
                cmbRaza.Items.Add("Grande");
                cmbRaza.Items.Add("Pequeño");
            }
        }
        public void LlenarComboBox()
        {
            cmbBuscar.Items.Clear();
            foreach (var item in obj_nAnimal.Listar())
            {
                cmbBuscar.Items.Add(item.codigo);
            }
        }
        public void RellenarCuadros(string codigo)
        {
            cmbBuscarX.BackColor = colorPrincipal;
            cmbBuscar.BackColor = colorPrincipal;
            cmbBuscar.Text = codigo;

            foreach (var item in obj_nAnimal.Listar())
            {
                if (item.codigo.ToString() == codigo)
                {
                    cmbTipo.Text = item.tipo;
                    txtNombre.Text = item.nombre;
                    cmbRaza.Text = item.raza;
                    txtEdad.Text = item.edad.ToString();
                    cmbSexo.Text = item.sexo;
                    cmbColor.Text = item.color;
                    cmbProv.Text = item.proveniencia;
                    cmbEstado.Text = item.estado;
                }
            }
            cmbTipo.Enabled = true;
            txtNombre.Enabled = true;
            cmbRaza.Enabled = true;
            txtEdad.Enabled = true;
            cmbSexo.Enabled = true;
            cmbColor.Enabled = true;
            cmbColor1.Enabled = true;
            cmbColor2.Enabled = true;
            cmbColor3.Enabled = true;
            cmbProv.Enabled = true;
            cmbEstado.Enabled = true;
            cmbTipo.BackColor = colorPrincipal;
            txtNombre.BackColor = colorPrincipal;
            cmbRaza.BackColor = colorPrincipal;
            txtEdad.BackColor = colorPrincipal;
            cmbSexo.BackColor = colorPrincipal;
            cmbColor.BackColor = colorPrincipal;
            cmbColor1.BackColor = colorPrincipal;
            cmbColor2.BackColor = colorPrincipal;
            cmbColor3.BackColor = colorPrincipal;
            cmbProv.BackColor = colorPrincipal;
            cmbEstado.BackColor = colorPrincipal;
        }
        // ------------------------------------- [ Eventos Back ] -------------------------------------
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
            string buscar = cmbBuscar.Text.Trim(); // codigo
            this.RellenarCuadros(buscar); // Rellena todos los cuadros a partir de un codigo
        }
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbTipo.Text.Trim();
            this.ActualizarRaza(tipo); // Actualiza las razas dependiendo del tipo de animal (Perro - Gato)
            cmbRaza.Text = "";
        }
        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        // ------------------------------------- [ Eventos Front ] -------------------------------------
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
            string nombre = txtNombre.Text.Trim();
            string raza = cmbRaza.Text.Trim();
            string edad = txtEdad.Text.Trim();
            string sexo = cmbSexo.Text.Trim();
            string color = cmbColor.Text.Trim();
            string prov = cmbProv.Text.Trim();
            string estado = cmbEstado.Text.Trim();

            if (cod != "" && tipo != "" && nombre != "" && raza != "" && edad != "" && sexo != "" && color != "" && prov != "" && estado != "")
            {
                obj_nAnimal.Actualizar(Convert.ToInt32(cod), tipo, nombre, raza, Convert.ToInt32(edad), sexo, color, prov, estado);
                obj_nAnimalxHistorial.Actualizar(Convert.ToInt32(cod), tipo, nombre, raza, Convert.ToInt32(edad), sexo, color, prov, estado, DateTime.Now);
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