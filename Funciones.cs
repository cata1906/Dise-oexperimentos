using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TPG401
{
    public class Funciones
    {
        // ------------------------------------- [ --- Atributos --- ] -------------------------------------
        // Colores principales
        public static Color colorDatos() { return Color.MediumSpringGreen; }
        public static Color colorGastos() { return Color.DeepSkyBlue; }
        public static Color colorMedicamentos() { return Color.FromArgb(244, 255, 88); }
        // Atributos principales
        private static Login _mainMenu;
        // ------------------------------------- [ --- Constructor --- ] -------------------------------------
        public static Login LoginForm
        {
            get
            {
                if (_mainMenu == null)
                {
                    _mainMenu = new Login();
                }
                return _mainMenu;
            }
        }
        // ------------------------------------- [ --- Metodos --- ] -------------------------------------
        // ------------------------------------- [ Generales ] -------------------------------------
        public static void PermitirSolo(object sender, KeyPressEventArgs e, string numeros_o_letras, bool negativos, bool decimales)
        {
            if (numeros_o_letras == "numeros")
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)); // Permite SOLO NUMEROS
            else if (numeros_o_letras == "letras")
                e.Handled = (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)); // PERMITE SOLO LETRAS
            else if (numeros_o_letras == "numeros_y_letras")
                e.Handled = (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)); // Permite NUMEROS y LETRAS
            
            if (negativos == true) // Permite negativos
            {
                string texto = ((Control)sender).Text; // Obtiene si el caracter ingresado es "." o "-"
                if (e.KeyChar == '-' && texto.Length == 0)
                {
                    e.Handled = false;
                    return;
                }
            }
            
            if (decimales == true) // Permite decimales
            {
                string text = ((Control)sender).Text; // Obtiene si el caracter ingresado es "." o "-"
                if (e.KeyChar == ',' && text.Length > 0 && !text.Contains(","))
                {
                    e.Handled = false;
                    return;
                }
            }
        }
        public static string GenerarNombreRandom(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];

            // b dice cuántas veces se ha agregado una nueva letra. Son 2 en este momento porque las dos primeras letras ya están en el nombre.
            int b = 2;
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;
        }
        public static int GenerarNumeroRandom(int minTam, int maxTam)
        {
            Random random = new Random();
            int numero = random.Next(minTam, maxTam);

            return numero;
        }
        // ------------------------------------- [ Login ] -------------------------------------
        public static void Login_Enter(string placeholder, PictureBox pictureBox, TextBox textBox, Panel panel)
        {
            // Cambia: 1
            if (placeholder == "Código de albergue")
                pictureBox.Image = TPG401.Properties.Resources.account_house2;
            else if (placeholder == "Correo personal o DNI")
                pictureBox.Image = TPG401.Properties.Resources.account_data2;
            else if (placeholder == "Contraseña personal")
            {
                textBox.UseSystemPasswordChar = true;
                pictureBox.Image = TPG401.Properties.Resources.account_pass2;
            }

            // Cambia: siempre
            textBox.ForeColor = Color.White;
            panel.BackColor = Color.FromArgb(66, 175, 206);

            // Cambia: con condicion
            if (textBox.Text == placeholder)
                textBox.Text = string.Empty;
        }
        public static void Login_Leave(string placeholder, PictureBox pictureBox, TextBox textBox, Panel panel)
        {
            // Cambia: 1
            if (placeholder == "Código de albergue")
                pictureBox.Image = TPG401.Properties.Resources.account_house1;
            else if (placeholder == "Correo personal o DNI")
                pictureBox.Image = TPG401.Properties.Resources.account_data1;
            else if (placeholder == "Contraseña personal")
                pictureBox.Image = TPG401.Properties.Resources.account_pass1;

            // Cambia: siempre
            panel.BackColor = Color.White;

            // Cambia: con condicion
            if (textBox.Text == string.Empty)
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.DarkGray;
                if (placeholder == "Contraseña personal")
                    textBox.UseSystemPasswordChar = false;
            }
            else
                textBox.ForeColor = Color.White;
        }
        // ------------------------------------- [ Register ] -------------------------------------
        public static void Register_Enter(string placeholder, PictureBox pictureBox, TextBox textBox, Panel panel)
        {
            // Cambia: 1
            if (placeholder == "DNI")
                pictureBox.Image = TPG401.Properties.Resources.account_user2;
            else if (placeholder == "Correo personal")
                pictureBox.Image = TPG401.Properties.Resources.account_email2;
            else if (placeholder == "Contraseña personal")
            {
                textBox.UseSystemPasswordChar = true;
                pictureBox.Image = TPG401.Properties.Resources.account_pass2;
            }
            else if (placeholder == "Código de albergue")
                pictureBox.Image = TPG401.Properties.Resources.account_house2;
            else if (placeholder == "Contraseña de albergue")
            {
                textBox.UseSystemPasswordChar = true;
                pictureBox.Image = TPG401.Properties.Resources.account_lock2;
            }
            // Cambia: siempre
            textBox.ForeColor = Color.White;
            panel.BackColor = Color.FromArgb(66, 175, 206);
            // Cambia: con condicion
            if (textBox.Text == placeholder)
                textBox.Text = string.Empty;
        }
        public static void Register_Leave(string placeholder, PictureBox pictureBox, TextBox textBox, Panel panel)
        {
            // Cambia: 1
            if (placeholder == "DNI")
                pictureBox.Image = TPG401.Properties.Resources.account_user1;
            else if (placeholder == "Correo personal")
                pictureBox.Image = TPG401.Properties.Resources.account_email1;
            else if (placeholder == "Contraseña personal")
                pictureBox.Image = TPG401.Properties.Resources.account_pass1;
            else if (placeholder == "Código de albergue")
                pictureBox.Image = TPG401.Properties.Resources.account_house1;
            else if (placeholder == "Contraseña de albergue")
                pictureBox.Image = TPG401.Properties.Resources.account_lock1;
            // Cambia: siempre
            panel.BackColor = Color.White;
            // Cambia: con condicion
            if (textBox.Text == string.Empty)
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.DarkGray;
                if (placeholder == "Contraseña personal")
                    textBox.UseSystemPasswordChar = false;
                else if (placeholder == "Contraseña de albergue")
                    textBox.UseSystemPasswordChar = false;
            }
            else
                textBox.ForeColor = Color.White;
        }
    }
}
