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
    public partial class Register : Form
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
        public Register()
        {
            InitializeComponent();
        }
        // ------------------------------------- [ --- Metodos --- ] -------------------------------------
        public void Cerrar()
        {
            RestablecerValores();
            this.Close();
            Funciones.LoginForm.Show();
        }
        public void RestablecerValores()
        {
            this.txtU_DNI.Text = "DNI";
            Funciones.Register_Enter("DNI", pbU_DNI, txtU_DNI, pnU_DNI);
            Funciones.Register_Leave("DNI", pbU_DNI, txtU_DNI, pnU_DNI);
            this.txtU_Email.Text = "Correo personal";
            Funciones.Register_Enter("Correo personal", pbU_Email, txtU_Email, pnU_Email);
            Funciones.Register_Leave("Correo personal", pbU_Email, txtU_Email, pnU_Email);
            this.txtU_Password.Text = "Contraseña personal";
            Funciones.Register_Enter("Contraseña personal", pbU_Password, txtU_Password, pnU_Password);
            Funciones.Register_Leave("Contraseña personal", pbU_Password, txtU_Password, pnU_Password);
            this.txtA_Codigo.Text = "Código de albergue";
            Funciones.Register_Enter("Código de albergue", pbA_Codigo, txtA_Codigo, pnA_Codigo);
            Funciones.Register_Leave("Código de albergue", pbA_Codigo, txtA_Codigo, pnA_Codigo);
            this.txtA_Password.Text = "Contraseña de albergue";
            Funciones.Register_Enter("Contraseña de albergue", pbA_Password, txtA_Password, pnA_Password);
            Funciones.Register_Leave("Contraseña de albergue", pbA_Password, txtA_Password, pnA_Password);
        }
        public bool BuscarDNI(List<eUser> listUsers, string DNI)
        {
            bool retornar = false;

            foreach (var item in listUsers)
            {
                if (item.dni == DNI)
                    retornar = true; // si el DNI existe
            }

            return retornar;
        }
        public bool BuscarCorreo(List<eUser> listUsers, string Correo)
        {
            bool retornar = false;

            foreach (var item in listUsers)
            {
                if (item.dni == Correo) // si el DNI o Correo existe
                    retornar = true;
            }

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
        private void txtU_DNI_Enter(object sender, EventArgs e)
        {
            Funciones.Register_Enter("DNI", pbU_DNI, txtU_DNI, pnU_DNI);
        }
        private void txtU_DNI_Leave(object sender, EventArgs e)
        {
            Funciones.Register_Leave("DNI", pbU_DNI, txtU_DNI, pnU_DNI);
        }
        private void txtU_Email_Enter(object sender, EventArgs e)
        {
            Funciones.Register_Enter("Correo personal", pbU_Email, txtU_Email, pnU_Email);
        }
        private void txtU_Email_Leave(object sender, EventArgs e)
        {
            Funciones.Register_Leave("Correo personal", pbU_Email, txtU_Email, pnU_Email);
        }
        private void txtU_Password_Enter(object sender, EventArgs e)
        {
            Funciones.Register_Enter("Contraseña personal", pbU_Password, txtU_Password, pnU_Password);
        }
        private void txtU_Password_Leave(object sender, EventArgs e)
        {
            Funciones.Register_Leave("Contraseña personal", pbU_Password, txtU_Password, pnU_Password);
        }
        private void txtA_Codigo_Enter(object sender, EventArgs e)
        {
            Funciones.Register_Enter("Código de albergue", pbA_Codigo, txtA_Codigo, pnA_Codigo);
        }
        private void txtA_Codigo_Leave(object sender, EventArgs e)
        {
            Funciones.Register_Leave("Código de albergue", pbA_Codigo, txtA_Codigo, pnA_Codigo);
        }
        private void txtA_Password_Enter(object sender, EventArgs e)
        {
            Funciones.Register_Enter("Contraseña de albergue", pbA_Password, txtA_Password, pnA_Password);
        }
        private void txtA_Password_Leave(object sender, EventArgs e)
        {
            Funciones.Register_Leave("Contraseña de albergue", pbA_Password, txtA_Password, pnA_Password);
        }
        private void btnInformation_MouseEnter(object sender, EventArgs e)
        {
            this.btnInformation.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
        }
        private void btnInformation_MouseLeave(object sender, EventArgs e)
        {
            this.btnInformation.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }
        // ------------------------------------- [ --- Eventos Front --- ] -------------------------------------
        private void btnSolicitePerms_Click(object sender, EventArgs e)
        {
            string dni = txtU_DNI.Text.Trim();
            string correo = txtU_Email.Text.Trim();
            string pPass = txtU_Password.Text.Trim();
            string codigo = txtA_Codigo.Text.Trim();
            string aPass = txtA_Password.Text.Trim();

            if (dni != "DNI" && correo != "Correo personal" && pPass != "Contraseña personal" && codigo != "Código de albergue" && aPass != "Contraseña de albergue")
            {
                List<eUser> listUsers = new List<eUser>();
                listUsers = nuser.Listar(tabla);

                if (BuscarDNI(listUsers, dni) == false) // Si el DNI ingresado no está registrado
                {
                    if (BuscarCorreo(listUsers, correo) == false) // Si el Correo ingresado no está registrado
                    {
                        nuser.Insertar(tabla, dni, correo, pPass, codigo, aPass);
                        MessageBox.Show("Has solicitado permisos de administrador correctamente!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RestablecerValores();
                    }
                    else
                    {
                        MessageBox.Show("El Correo ingresado ya tiene permisos en un albergue!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cerrar();
                    }
                }
                else
                {
                    MessageBox.Show("El DNI ingresado ya tiene permisos en un albergue!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cerrar();
                }
            }
            else
                MessageBox.Show("Debe completar todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
    }
}