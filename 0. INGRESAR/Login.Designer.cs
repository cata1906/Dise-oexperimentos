
namespace TPG401
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblRecordar_2 = new System.Windows.Forms.Label();
            this.cbRecordar_1 = new System.Windows.Forms.CheckBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnLostPassword = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.pnU_Password = new System.Windows.Forms.Panel();
            this.txtU_Password = new System.Windows.Forms.TextBox();
            this.pnU_Data = new System.Windows.Forms.Panel();
            this.pbU_Password = new System.Windows.Forms.PictureBox();
            this.txtU_Data = new System.Windows.Forms.TextBox();
            this.pbU_Data = new System.Windows.Forms.PictureBox();
            this.pnA_Codigo = new System.Windows.Forms.Panel();
            this.txtA_Codigo = new System.Windows.Forms.TextBox();
            this.pbA_Codigo = new System.Windows.Forms.PictureBox();
            this.pnCerraryMin = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbU_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbU_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA_Codigo)).BeginInit();
            this.pnCerraryMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedor.Controls.Add(this.lblError);
            this.panelContenedor.Controls.Add(this.pbLogo);
            this.panelContenedor.Controls.Add(this.lblRecordar_2);
            this.panelContenedor.Controls.Add(this.cbRecordar_1);
            this.panelContenedor.Controls.Add(this.btnCreateAccount);
            this.panelContenedor.Controls.Add(this.btnLostPassword);
            this.panelContenedor.Controls.Add(this.panel4);
            this.panelContenedor.Controls.Add(this.btnSignIn);
            this.panelContenedor.Controls.Add(this.pnU_Password);
            this.panelContenedor.Controls.Add(this.txtU_Password);
            this.panelContenedor.Controls.Add(this.pnU_Data);
            this.panelContenedor.Controls.Add(this.pbU_Password);
            this.panelContenedor.Controls.Add(this.txtU_Data);
            this.panelContenedor.Controls.Add(this.pbU_Data);
            this.panelContenedor.Controls.Add(this.pnA_Codigo);
            this.panelContenedor.Controls.Add(this.txtA_Codigo);
            this.panelContenedor.Controls.Add(this.pbA_Codigo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 28);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(425, 607);
            this.panelContenedor.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(56, 564);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(321, 16);
            this.lblError.TabIndex = 50;
            this.lblError.Text = "¡Ese usuario no cuenta con los permisos necesarios!";
            this.lblError.Visible = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::TPG401.Properties.Resources.siga_icon;
            this.pbLogo.Location = new System.Drawing.Point(171, 37);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(96, 96);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 49;
            this.pbLogo.TabStop = false;
            // 
            // lblRecordar_2
            // 
            this.lblRecordar_2.AutoSize = true;
            this.lblRecordar_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordar_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(175)))), ((int)(((byte)(206)))));
            this.lblRecordar_2.Location = new System.Drawing.Point(79, 351);
            this.lblRecordar_2.Name = "lblRecordar_2";
            this.lblRecordar_2.Size = new System.Drawing.Size(58, 15);
            this.lblRecordar_2.TabIndex = 48;
            this.lblRecordar_2.Text = "Recordar";
            this.lblRecordar_2.Click += new System.EventHandler(this.lblRecordar_2_Click);
            // 
            // cbRecordar_1
            // 
            this.cbRecordar_1.AutoSize = true;
            this.cbRecordar_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cbRecordar_1.FlatAppearance.BorderSize = 0;
            this.cbRecordar_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRecordar_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRecordar_1.ForeColor = System.Drawing.Color.White;
            this.cbRecordar_1.Location = new System.Drawing.Point(60, 354);
            this.cbRecordar_1.Name = "cbRecordar_1";
            this.cbRecordar_1.Size = new System.Drawing.Size(12, 11);
            this.cbRecordar_1.TabIndex = 4;
            this.cbRecordar_1.UseVisualStyleBackColor = false;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(140)))), ((int)(((byte)(206)))));
            this.btnCreateAccount.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnCreateAccount.Location = new System.Drawing.Point(126, 500);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(180, 40);
            this.btnCreateAccount.TabIndex = 7;
            this.btnCreateAccount.Text = "Solicitar acceso";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnLostPassword
            // 
            this.btnLostPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnLostPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLostPassword.FlatAppearance.BorderSize = 0;
            this.btnLostPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLostPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLostPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLostPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLostPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(175)))), ((int)(((byte)(206)))));
            this.btnLostPassword.Location = new System.Drawing.Point(145, 430);
            this.btnLostPassword.Name = "btnLostPassword";
            this.btnLostPassword.Size = new System.Drawing.Size(142, 23);
            this.btnLostPassword.TabIndex = 6;
            this.btnLostPassword.Text = "¿Olvidaste tu contraseña?";
            this.btnLostPassword.UseVisualStyleBackColor = false;
            this.btnLostPassword.Click += new System.EventHandler(this.btnLostPassword_Click);
            this.btnLostPassword.MouseEnter += new System.EventHandler(this.btnLostPassword_MouseEnter);
            this.btnLostPassword.MouseLeave += new System.EventHandler(this.btnLostPassword_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(66, 480);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 1);
            this.panel4.TabIndex = 44;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(175)))), ((int)(((byte)(206)))));
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSignIn.Location = new System.Drawing.Point(66, 384);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(300, 40);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Iniciar sesión";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // pnU_Password
            // 
            this.pnU_Password.BackColor = System.Drawing.Color.White;
            this.pnU_Password.Location = new System.Drawing.Point(66, 333);
            this.pnU_Password.Name = "pnU_Password";
            this.pnU_Password.Size = new System.Drawing.Size(300, 1);
            this.pnU_Password.TabIndex = 42;
            // 
            // txtU_Password
            // 
            this.txtU_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtU_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtU_Password.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtU_Password.ForeColor = System.Drawing.Color.DarkGray;
            this.txtU_Password.Location = new System.Drawing.Point(96, 309);
            this.txtU_Password.Name = "txtU_Password";
            this.txtU_Password.Size = new System.Drawing.Size(270, 18);
            this.txtU_Password.TabIndex = 3;
            this.txtU_Password.Text = "Contraseña personal";
            this.txtU_Password.Enter += new System.EventHandler(this.txtU_Password_Enter);
            this.txtU_Password.Leave += new System.EventHandler(this.txtU_Password_Leave);
            // 
            // pnU_Data
            // 
            this.pnU_Data.BackColor = System.Drawing.Color.White;
            this.pnU_Data.Location = new System.Drawing.Point(66, 273);
            this.pnU_Data.Name = "pnU_Data";
            this.pnU_Data.Size = new System.Drawing.Size(300, 1);
            this.pnU_Data.TabIndex = 39;
            // 
            // pbU_Password
            // 
            this.pbU_Password.Image = ((System.Drawing.Image)(resources.GetObject("pbU_Password.Image")));
            this.pbU_Password.Location = new System.Drawing.Point(66, 303);
            this.pbU_Password.Name = "pbU_Password";
            this.pbU_Password.Size = new System.Drawing.Size(24, 24);
            this.pbU_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbU_Password.TabIndex = 40;
            this.pbU_Password.TabStop = false;
            // 
            // txtU_Data
            // 
            this.txtU_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtU_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtU_Data.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtU_Data.ForeColor = System.Drawing.Color.DarkGray;
            this.txtU_Data.Location = new System.Drawing.Point(96, 249);
            this.txtU_Data.Name = "txtU_Data";
            this.txtU_Data.Size = new System.Drawing.Size(270, 18);
            this.txtU_Data.TabIndex = 2;
            this.txtU_Data.Text = "Correo personal o DNI";
            this.txtU_Data.Enter += new System.EventHandler(this.txtU_Data_Enter);
            this.txtU_Data.Leave += new System.EventHandler(this.txtU_Data_Leave);
            // 
            // pbU_Data
            // 
            this.pbU_Data.Image = global::TPG401.Properties.Resources.account_data1;
            this.pbU_Data.Location = new System.Drawing.Point(66, 243);
            this.pbU_Data.Name = "pbU_Data";
            this.pbU_Data.Size = new System.Drawing.Size(24, 24);
            this.pbU_Data.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbU_Data.TabIndex = 37;
            this.pbU_Data.TabStop = false;
            // 
            // pnA_Codigo
            // 
            this.pnA_Codigo.BackColor = System.Drawing.Color.White;
            this.pnA_Codigo.Location = new System.Drawing.Point(66, 213);
            this.pnA_Codigo.Name = "pnA_Codigo";
            this.pnA_Codigo.Size = new System.Drawing.Size(300, 1);
            this.pnA_Codigo.TabIndex = 36;
            // 
            // txtA_Codigo
            // 
            this.txtA_Codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtA_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtA_Codigo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA_Codigo.ForeColor = System.Drawing.Color.DarkGray;
            this.txtA_Codigo.Location = new System.Drawing.Point(96, 189);
            this.txtA_Codigo.Name = "txtA_Codigo";
            this.txtA_Codigo.Size = new System.Drawing.Size(270, 18);
            this.txtA_Codigo.TabIndex = 1;
            this.txtA_Codigo.Text = "Código de albergue";
            this.txtA_Codigo.Enter += new System.EventHandler(this.txtA_Codigo_Enter);
            this.txtA_Codigo.Leave += new System.EventHandler(this.txtA_Codigo_Leave);
            // 
            // pbA_Codigo
            // 
            this.pbA_Codigo.Image = ((System.Drawing.Image)(resources.GetObject("pbA_Codigo.Image")));
            this.pbA_Codigo.Location = new System.Drawing.Point(66, 183);
            this.pbA_Codigo.Name = "pbA_Codigo";
            this.pbA_Codigo.Size = new System.Drawing.Size(24, 24);
            this.pbA_Codigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbA_Codigo.TabIndex = 34;
            this.pbA_Codigo.TabStop = false;
            // 
            // pnCerraryMin
            // 
            this.pnCerraryMin.BackColor = System.Drawing.Color.Transparent;
            this.pnCerraryMin.Controls.Add(this.pbClose);
            this.pnCerraryMin.Controls.Add(this.pbMinimize);
            this.pnCerraryMin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCerraryMin.Location = new System.Drawing.Point(0, 0);
            this.pnCerraryMin.Name = "pnCerraryMin";
            this.pnCerraryMin.Size = new System.Drawing.Size(425, 28);
            this.pnCerraryMin.TabIndex = 3;
            this.pnCerraryMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCerraryMin_MouseDown);
            // 
            // pbClose
            // 
            this.pbClose.Image = global::TPG401.Properties.Resources.close1;
            this.pbClose.Location = new System.Drawing.Point(382, 6);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(40, 20);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 2;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            this.pbClose.MouseEnter += new System.EventHandler(this.pbClose_MouseEnter);
            this.pbClose.MouseLeave += new System.EventHandler(this.pbClose_MouseLeave);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Image = global::TPG401.Properties.Resources.minimize1;
            this.pbMinimize.Location = new System.Drawing.Point(348, 6);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(40, 20);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimize.TabIndex = 3;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            this.pbMinimize.MouseEnter += new System.EventHandler(this.pbMinimize_MouseEnter);
            this.pbMinimize.MouseLeave += new System.EventHandler(this.pbMinimize_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(425, 635);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.pnCerraryMin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGA";
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbU_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbU_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbA_Codigo)).EndInit();
            this.pnCerraryMin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblRecordar_2;
        private System.Windows.Forms.CheckBox cbRecordar_1;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnLostPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Panel pnU_Password;
        private System.Windows.Forms.TextBox txtU_Password;
        private System.Windows.Forms.Panel pnU_Data;
        private System.Windows.Forms.PictureBox pbU_Password;
        private System.Windows.Forms.TextBox txtU_Data;
        private System.Windows.Forms.PictureBox pbU_Data;
        private System.Windows.Forms.Panel pnA_Codigo;
        private System.Windows.Forms.TextBox txtA_Codigo;
        private System.Windows.Forms.PictureBox pbA_Codigo;
        private System.Windows.Forms.Panel pnCerraryMin;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.Label lblError;
    }
}