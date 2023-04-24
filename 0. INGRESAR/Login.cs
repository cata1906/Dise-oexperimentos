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
    public partial class Login : Form
    {
        // ------------------------------------- [ --- Atributos --- ] -------------------------------------
        private nUser nuser = new nUser();
        private string tabla = "Permisos";
        // ------------------------------------- [ Panel de movimiento 1 ] -------------------------------------
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // ------------------------------------- [ --- Constructor --- ] -------------------------------------
        public Login()
        {
            InitializeComponent();
        }
        // ------------------------------------- [ --- Metodos --- ] -------------------------------------
        public void RestablecerValores()
        {
            this.txtA_Codigo.Text = "Código de albergue";
            Funciones.Register_Enter("Código de albergue", pbA_Codigo, txtA_Codigo, pnA_Codigo);
            Funciones.Register_Leave("Código de albergue", pbA_Codigo, txtA_Codigo, pnA_Codigo);
            this.txtU_Data.Text = "Correo personal o DNI";
            Funciones.Register_Enter("Correo personal o DNI", pbU_Data, txtU_Data, pnU_Data);
            Funciones.Register_Leave("Correo personal o DNI", pbU_Data, txtU_Data, pnU_Data);
            this.txtU_Password.Text = "Contraseña personal";
            Funciones.Register_Enter("Contraseña personal", pbU_Password, txtU_Password, pnU_Password);
            Funciones.Register_Leave("Contraseña personal", pbU_Password, txtU_Password, pnU_Password);
        }
        public bool Buscar(string Codigo, string Correo_o_DNI, string pPass)
        {
            List<eUser> listUsers = new List<eUser>();
            listUsers = nuser.Listar(tabla);
            bool retornar = false;

            foreach (var item in listUsers)
            {
                if (item.cod == Codigo) // Si el Código de albergue existe
                {
                    if (item.correo == Correo_o_DNI || item.dni == Correo_o_DNI) // si el DNI o Correo existe
                    {
                        if (item.pPass == pPass) // Si la contraseña existe
                            retornar = true;
                    }
                }
                // Cambia de color en los errores
                // ------------------------------------- [ Validaciones de error ] -------------------------------------
                if (item.cod != Codigo) // Si el Código de albergue no existe
                {
                    txtA_Codigo.ForeColor = Color.Red;
                    lblError.Visible = true;
                }
                if (item.correo != Correo_o_DNI || item.dni != Correo_o_DNI) // si el DNI o Correo no existe
                {
                    txtU_Data.ForeColor = Color.Red;
                    lblError.Visible = true;
                }
                if (item.pPass != pPass) // Si la contraseña no existe
                {
                    txtU_Password.ForeColor = Color.Red;
                    lblError.Visible = true;
                }
            }
            // Si la lista no tiene elementos
            if (listUsers.Count == 0)
                MessageBox.Show("No hay usuarios registrados"); ; // Deja ingresar sin necesidad de los datos

            return retornar;
        }
        // ------------------------------------- [ --- Eventos Back --- ] -------------------------------------
        private void pnCerraryMin_MouseDown(object sender, MouseEventArgs e)
        {
            // ------------------------------------- [ Panel de movimiento 2 ] -------------------------------------
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
        // ------------------------------------- [ Solicitar informacion ] -------------------------------------
        private void txtA_Codigo_Enter(object sender, EventArgs e)
        {
            Funciones.Login_Enter("Código de albergue", pbA_Codigo, txtA_Codigo, pnA_Codigo);
            lblError.Visible = false;
        }
        private void txtA_Codigo_Leave(object sender, EventArgs e)
        {
            Funciones.Login_Leave("Código de albergue", pbA_Codigo, txtA_Codigo, pnA_Codigo);
        }
        private void txtU_Data_Enter(object sender, EventArgs e)
        {
            Funciones.Login_Enter("Correo personal o DNI", pbU_Data, txtU_Data, pnU_Data);
            lblError.Visible = false;
        }
        private void txtU_Data_Leave(object sender, EventArgs e)
        {
            Funciones.Login_Leave("Correo personal o DNI", pbU_Data, txtU_Data, pnU_Data);
        }
        private void txtU_Password_Enter(object sender, EventArgs e)
        {
            Funciones.Login_Enter("Contraseña personal", pbU_Password, txtU_Password, pnU_Password);
            lblError.Visible = false;
        }
        private void txtU_Password_Leave(object sender, EventArgs e)
        {
            Funciones.Login_Leave("Contraseña personal", pbU_Password, txtU_Password, pnU_Password);
        }
        private void btnLostPassword_MouseEnter(object sender, EventArgs e)
        {
            this.btnLostPassword.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
        }
        private void btnLostPassword_MouseLeave(object sender, EventArgs e)
        {
            this.btnLostPassword.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }
        private void lblRecordar_2_Click(object sender, EventArgs e)
        {
            if (cbRecordar_1.Checked == true)
            {
                cbRecordar_1.Checked = false;
            }
            else if (cbRecordar_1.Checked == false)
            {
                cbRecordar_1.Checked = true;
            }
        }
        // ------------------------------------- [ --- Eventos Front --- ] -------------------------------------
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string Codigo = txtA_Codigo.Text.Trim();
            string Correo_o_DNI = txtU_Data.Text.Trim();
            string pPass = txtU_Password.Text.Trim();

            if (Codigo != "Código de albergue" && Correo_o_DNI != "Correo personal o DNI" && pPass != "Contraseña personal")
            {
                if (Buscar(Codigo, Correo_o_DNI, pPass) == true) // ((correo || dni == true) -> (pPass == true)))
                {
                    FormTipoGestion tipoGestion = new FormTipoGestion();
                    this.Hide();
                    tipoGestion.Show();
                }
                //else
                    //MessageBox.Show("Ese usuario no cuenta con los permisos necesarios!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Debe completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Register solicitar_acceso = new Register();
            this.RestablecerValores();
            this.Hide();
            solicitar_acceso.Show();
        }
        private void btnLostPassword_Click(object sender, EventArgs e)
        {
            this.RestablecerValores();
        }
    }
}
