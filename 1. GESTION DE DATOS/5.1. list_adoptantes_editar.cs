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
    public partial class list_adoptantes_editar : Form
    {
        // ------------------------------------- [ Atributos ] -------------------------------------
        private Color colorPrincipal = Color.FromArgb(255, 230, 20);
        private nAdoptante obj_nAdoptante = new nAdoptante();
        private BindingSource bindingSource1 = new BindingSource();
        private DataGridView dgvLista = new DataGridView();
        public bool edicionEnCurso;
        public int oldDNI;
        // ------------------------------------- [ Panel de movimiento 1 ] -------------------------------------
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // ------------------------------------- [ Constructor ] -------------------------------------
        public list_adoptantes_editar(bool sendEdicionEnCurso, DataGridView sendDgvLista, string dni)
        {
            InitializeComponent();
            edicionEnCurso = sendEdicionEnCurso;
            dgvLista = sendDgvLista;
            LlenarComboBox(); // con DNI's

            if (dni != "") // Si se envió un DNI
                RellenarCuadros(dni); // Rellenar los cuadros con esos DNI'S

            oldDNI = Convert.ToInt32(txtDNI.Text);
        }
        // ------------------------------------- [ --- METODOS --- ] -------------------------------------
        public void Mostrar()
        {
            dgvLista.AutoGenerateColumns = true;
            bindingSource1.DataSource = obj_nAdoptante.Listar();
            dgvLista.DataSource = bindingSource1;
        }
        public void RestablecerValores()
        {
            cmbBuscar.Text = "";
            cmbBuscar.SelectedIndex = -1;
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtMotivo.Text = "";
            cmbBuscarX.BackColor = Color.White;
            cmbBuscar.BackColor = Color.White;
            txtDNI.BackColor = Color.White;
            txtNombre.BackColor = Color.White;
            txtApellido.BackColor = Color.White;
            txtTelefono.BackColor = Color.White;
            txtCorreo.BackColor = Color.White;
            txtDireccion.BackColor = Color.White;
            txtMotivo.BackColor = Color.White;

            txtDNI.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            txtDireccion.Enabled = true;
            txtMotivo.Enabled = true;
            txtDNI.BackColor = colorPrincipal;
            txtNombre.BackColor = colorPrincipal;
            txtApellido.BackColor = colorPrincipal;
            txtTelefono.BackColor = colorPrincipal;
            txtCorreo.BackColor = colorPrincipal;
            txtDireccion.BackColor = colorPrincipal;
            txtMotivo.BackColor = colorPrincipal;
        }
        public void LlenarComboBox()
        {
            cmbBuscar.Items.Clear();
            foreach (var item in obj_nAdoptante.Listar())
            {
                cmbBuscar.Items.Add(item.dni);
            }
        }
        public void RellenarCuadros(string dni)
        {
            cmbBuscarX.BackColor = colorPrincipal;
            cmbBuscar.BackColor = colorPrincipal;
            cmbBuscar.Text = dni;

            foreach (var item in obj_nAdoptante.Listar())
            {
                if (item.dni.ToString() == dni)
                {
                    txtDNI.Text = item.dni.ToString();
                    txtNombre.Text = item.nombre.ToString();
                    txtApellido.Text = item.apellido.ToString();
                    txtTelefono.Text = item.telefono.ToString();
                    txtCorreo.Text = item.correo.ToString();
                    txtDireccion.Text = item.direccion.ToString();
                    txtMotivo.Text = item.motivo.ToString();
                }
            }
            txtDNI.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            txtDireccion.Enabled = true;
            txtMotivo.Enabled = true;
            txtDNI.BackColor = colorPrincipal;
            txtNombre.BackColor = colorPrincipal;
            txtApellido.BackColor = colorPrincipal;
            txtTelefono.BackColor = colorPrincipal;
            txtCorreo.BackColor = colorPrincipal;
            txtDireccion.BackColor = colorPrincipal;
            txtMotivo.BackColor = colorPrincipal;
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
        private void pbAtras_MouseEnter(object sender, EventArgs e)
        {
            pbAtras.Image = TPG401.Properties.Resources.back1;
        }
        private void pbAtras_MouseLeave(object sender, EventArgs e)
        {
            pbAtras.Image = TPG401.Properties.Resources.back;
        }
        // ------------------------------------- [ --- FRONT --- ] -------------------------------------
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
            string dni = cmbBuscar.Text.Trim();

            string newDNI = txtDNI.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string motivo = txtMotivo.Text.Trim();

            if (newDNI != "" && dni != "" && nombre != "" && apellido != "" && telefono != "" && correo != "" && direccion != "" && motivo != "")
            {
                obj_nAdoptante.Actualizar(Convert.ToInt32(dni), nombre, apellido, Convert.ToInt32(telefono), correo, direccion, motivo, Convert.ToInt32(newDNI));
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
