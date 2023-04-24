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
    public partial class list_adopciones_editar : Form
    {
        // ------------------------------------- [ --- ATRIBUTOS --- ] -------------------------------------
        private Color colorPrincipal = Color.FromArgb(255, 230, 20);
        private nAnimalxAdoptante obj_nAnimalxAdoptante = new nAnimalxAdoptante();
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
        // ------------------------------------- [ --- CONSTRUCTOR --- ] -------------------------------------
        public list_adopciones_editar(bool sendEdicionEnCurso, DataGridView sendDgvLista, string codigo)
        {
            InitializeComponent();
            edicionEnCurso = sendEdicionEnCurso;
            dgvLista = sendDgvLista;
            LlenarComboBox(); // Con CODIGOS

            if (codigo != "") // Si se envió un CÓDIGO
                RellenarCuadros(codigo); // Rellenar los cuadros con esos CODIGOS

            oldDNI = Convert.ToInt32(txtDNI.Text);
        }
        // ------------------------------------- [ --- METODOS --- ] -------------------------------------
        public void Mostrar()
        {
            dgvLista.AutoGenerateColumns = true;
            bindingSource1.DataSource = obj_nAnimalxAdoptante.Listar();
            dgvLista.DataSource = bindingSource1;
        }
        public void RestablecerValores()
        {
            cmbBuscar.Text = "";
            cmbBuscar.SelectedIndex = -1;
            cmbBuscarX.BackColor = Color.White;
            cmbBuscar.BackColor = Color.White;
            txtDNI.BackColor = Color.White;
        }
        public void LlenarComboBox()
        {
            cmbBuscar.Items.Clear();
            foreach (var item in obj_nAnimalxAdoptante.Listar())
            {
                cmbBuscar.Items.Add(item.codigoAdopcion);
            }
        }
        public void RellenarCuadros(string codigoAdopcion)
        {
            cmbBuscarX.BackColor = colorPrincipal;
            cmbBuscar.BackColor = colorPrincipal;
            cmbBuscar.Text = codigoAdopcion;

            foreach (var item in obj_nAnimalxAdoptante.Listar())
            {
                if (item.codigoAdopcion.ToString() == codigoAdopcion)
                {
                    txtDNI.Text = item.dni.ToString();
                }
            }
            txtDNI.Enabled = true;
            txtDNI.BackColor = colorPrincipal;
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
        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar = cmbBuscar.Text.Trim(); // codigo
            this.RellenarCuadros(buscar); // Rellena todos los cuadros a partir de un codigo
        }
        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            txtDNI.BackColor = colorPrincipal;
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
            string codAdopcion = cmbBuscar.Text.Trim();
            string dni = txtDNI.Text.Trim();

            if (codAdopcion != "" && dni != "")
            {
                obj_nAnimalxAdoptante.Actualizar(Convert.ToInt32(dni), Convert.ToInt32(codAdopcion));
                obj_nAdoptante.ActualizarDNI(Convert.ToInt32(dni), Convert.ToInt32(oldDNI));
                this.RestablecerValores();

                int indice = dgvLista.CurrentRow.Index; // Guarda el indice de la fila seleccionada
                this.Mostrar(); // Al mostrar se cambia el indice
                dgvLista.Rows[0].Selected = false; // Quita la seleccion de la primera fila que genera this.Mostrar();
                dgvLista.Rows[indice].Selected = true; // Coloca la seleccion de la fila en el indice guardado

                this.Close();
                edicionEnCurso = false;
            }
            else
                MessageBox.Show("Complete todos los campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}