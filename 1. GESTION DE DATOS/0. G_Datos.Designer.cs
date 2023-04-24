using FontAwesome.Sharp;

namespace TPG401
{
    partial class G_Datos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ibtn_list_animales_crit = new FontAwesome.Sharp.IconButton();
            this.ibtnLogout = new FontAwesome.Sharp.IconButton();
            this.ibtn_list_adoptantes = new FontAwesome.Sharp.IconButton();
            this.ibtn_list_animales_adop = new FontAwesome.Sharp.IconButton();
            this.ibtn_list_animales = new FontAwesome.Sharp.IconButton();
            this.ibtn_dar_animal_adop = new FontAwesome.Sharp.IconButton();
            this.ibtn_reg_new_animal = new FontAwesome.Sharp.IconButton();
            this.pn1 = new System.Windows.Forms.Panel();
            this.pn3 = new System.Windows.Forms.Panel();
            this.pn2 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panelMenu.Controls.Add(this.ibtn_list_animales_crit);
            this.panelMenu.Controls.Add(this.ibtnLogout);
            this.panelMenu.Controls.Add(this.ibtn_list_adoptantes);
            this.panelMenu.Controls.Add(this.ibtn_list_animales_adop);
            this.panelMenu.Controls.Add(this.ibtn_list_animales);
            this.panelMenu.Controls.Add(this.ibtn_dar_animal_adop);
            this.panelMenu.Controls.Add(this.ibtn_reg_new_animal);
            this.panelMenu.Controls.Add(this.pn1);
            this.panelMenu.Controls.Add(this.pn3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(354, 601);
            this.panelMenu.TabIndex = 4;
            // 
            // ibtn_list_animales_crit
            // 
            this.ibtn_list_animales_crit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ibtn_list_animales_crit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtn_list_animales_crit.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_list_animales_crit.FlatAppearance.BorderSize = 0;
            this.ibtn_list_animales_crit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_list_animales_crit.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_list_animales_crit.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.ibtn_list_animales_crit.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.ibtn_list_animales_crit.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.ibtn_list_animales_crit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_list_animales_crit.IconSize = 45;
            this.ibtn_list_animales_crit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_list_animales_crit.Location = new System.Drawing.Point(0, 305);
            this.ibtn_list_animales_crit.Name = "ibtn_list_animales_crit";
            this.ibtn_list_animales_crit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_list_animales_crit.Size = new System.Drawing.Size(349, 60);
            this.ibtn_list_animales_crit.TabIndex = 5;
            this.ibtn_list_animales_crit.Text = "Lista de animales en estado crítico";
            this.ibtn_list_animales_crit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_list_animales_crit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_list_animales_crit.UseVisualStyleBackColor = false;
            this.ibtn_list_animales_crit.Click += new System.EventHandler(this.ibtn_list_animales_criticos_Click);
            // 
            // ibtnLogout
            // 
            this.ibtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
            this.ibtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnLogout.FlatAppearance.BorderSize = 0;
            this.ibtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLogout.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(70)))));
            this.ibtnLogout.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.ibtnLogout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(70)))));
            this.ibtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLogout.IconSize = 45;
            this.ibtnLogout.Location = new System.Drawing.Point(0, 541);
            this.ibtnLogout.Name = "ibtnLogout";
            this.ibtnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnLogout.Size = new System.Drawing.Size(349, 60);
            this.ibtnLogout.TabIndex = 6;
            this.ibtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLogout.UseVisualStyleBackColor = false;
            this.ibtnLogout.Click += new System.EventHandler(this.ibtnLogout_Click);
            // 
            // ibtn_list_adoptantes
            // 
            this.ibtn_list_adoptantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ibtn_list_adoptantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtn_list_adoptantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_list_adoptantes.FlatAppearance.BorderSize = 0;
            this.ibtn_list_adoptantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_list_adoptantes.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_list_adoptantes.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.ibtn_list_adoptantes.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt;
            this.ibtn_list_adoptantes.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.ibtn_list_adoptantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_list_adoptantes.IconSize = 45;
            this.ibtn_list_adoptantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_list_adoptantes.Location = new System.Drawing.Point(0, 245);
            this.ibtn_list_adoptantes.Name = "ibtn_list_adoptantes";
            this.ibtn_list_adoptantes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_list_adoptantes.Size = new System.Drawing.Size(349, 60);
            this.ibtn_list_adoptantes.TabIndex = 4;
            this.ibtn_list_adoptantes.Text = "Lista de adoptantes";
            this.ibtn_list_adoptantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_list_adoptantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_list_adoptantes.UseVisualStyleBackColor = false;
            this.ibtn_list_adoptantes.Click += new System.EventHandler(this.ibtn_list_adoptantes_Click);
            // 
            // ibtn_list_animales_adop
            // 
            this.ibtn_list_animales_adop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ibtn_list_animales_adop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtn_list_animales_adop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_list_animales_adop.FlatAppearance.BorderSize = 0;
            this.ibtn_list_animales_adop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_list_animales_adop.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_list_animales_adop.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.ibtn_list_animales_adop.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.ibtn_list_animales_adop.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.ibtn_list_animales_adop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_list_animales_adop.IconSize = 45;
            this.ibtn_list_animales_adop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_list_animales_adop.Location = new System.Drawing.Point(0, 185);
            this.ibtn_list_animales_adop.Name = "ibtn_list_animales_adop";
            this.ibtn_list_animales_adop.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_list_animales_adop.Size = new System.Drawing.Size(349, 60);
            this.ibtn_list_animales_adop.TabIndex = 3;
            this.ibtn_list_animales_adop.Text = "Lista de animales dados en adopción";
            this.ibtn_list_animales_adop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_list_animales_adop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_list_animales_adop.UseVisualStyleBackColor = false;
            this.ibtn_list_animales_adop.Click += new System.EventHandler(this.ibtn_list_animales_adop_Click);
            // 
            // ibtn_list_animales
            // 
            this.ibtn_list_animales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ibtn_list_animales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtn_list_animales.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_list_animales.FlatAppearance.BorderSize = 0;
            this.ibtn_list_animales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_list_animales.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_list_animales.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.ibtn_list_animales.IconChar = FontAwesome.Sharp.IconChar.Cat;
            this.ibtn_list_animales.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.ibtn_list_animales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_list_animales.IconSize = 45;
            this.ibtn_list_animales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_list_animales.Location = new System.Drawing.Point(0, 125);
            this.ibtn_list_animales.Name = "ibtn_list_animales";
            this.ibtn_list_animales.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_list_animales.Size = new System.Drawing.Size(349, 60);
            this.ibtn_list_animales.TabIndex = 2;
            this.ibtn_list_animales.Text = "Lista de animales";
            this.ibtn_list_animales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_list_animales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_list_animales.UseVisualStyleBackColor = false;
            this.ibtn_list_animales.Click += new System.EventHandler(this.ibtn_list_animales_Click);
            // 
            // ibtn_dar_animal_adop
            // 
            this.ibtn_dar_animal_adop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ibtn_dar_animal_adop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtn_dar_animal_adop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_dar_animal_adop.FlatAppearance.BorderSize = 0;
            this.ibtn_dar_animal_adop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_dar_animal_adop.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_dar_animal_adop.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.ibtn_dar_animal_adop.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane;
            this.ibtn_dar_animal_adop.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.ibtn_dar_animal_adop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_dar_animal_adop.IconSize = 45;
            this.ibtn_dar_animal_adop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_dar_animal_adop.Location = new System.Drawing.Point(0, 65);
            this.ibtn_dar_animal_adop.Name = "ibtn_dar_animal_adop";
            this.ibtn_dar_animal_adop.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_dar_animal_adop.Size = new System.Drawing.Size(349, 60);
            this.ibtn_dar_animal_adop.TabIndex = 1;
            this.ibtn_dar_animal_adop.Text = "Dar animal en adopción";
            this.ibtn_dar_animal_adop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_dar_animal_adop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_dar_animal_adop.UseVisualStyleBackColor = false;
            this.ibtn_dar_animal_adop.Click += new System.EventHandler(this.ibtn_dar_animal_adop_Click);
            // 
            // ibtn_reg_new_animal
            // 
            this.ibtn_reg_new_animal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ibtn_reg_new_animal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtn_reg_new_animal.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtn_reg_new_animal.FlatAppearance.BorderSize = 0;
            this.ibtn_reg_new_animal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_reg_new_animal.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_reg_new_animal.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.ibtn_reg_new_animal.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.ibtn_reg_new_animal.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.ibtn_reg_new_animal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_reg_new_animal.IconSize = 45;
            this.ibtn_reg_new_animal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_reg_new_animal.Location = new System.Drawing.Point(0, 5);
            this.ibtn_reg_new_animal.Name = "ibtn_reg_new_animal";
            this.ibtn_reg_new_animal.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_reg_new_animal.Size = new System.Drawing.Size(349, 60);
            this.ibtn_reg_new_animal.TabIndex = 0;
            this.ibtn_reg_new_animal.Text = "Registrar nuevo animal";
            this.ibtn_reg_new_animal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtn_reg_new_animal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtn_reg_new_animal.UseVisualStyleBackColor = false;
            this.ibtn_reg_new_animal.Click += new System.EventHandler(this.ibtn_reg_new_animal_Click);
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn1.Location = new System.Drawing.Point(0, 0);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(349, 5);
            this.pn1.TabIndex = 58;
            // 
            // pn3
            // 
            this.pn3.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pn3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn3.Location = new System.Drawing.Point(349, 0);
            this.pn3.Name = "pn3";
            this.pn3.Size = new System.Drawing.Size(5, 601);
            this.pn3.TabIndex = 21;
            // 
            // pn2
            // 
            this.pn2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn2.Location = new System.Drawing.Point(354, 0);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(710, 5);
            this.pn2.TabIndex = 5;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(354, 5);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(710, 596);
            this.panelContenedor.TabIndex = 7;
            // 
            // G_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.panelMenu);
            this.Name = "G_Datos";
            this.Size = new System.Drawing.Size(1064, 601);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.Panel pn3;
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconButton ibtn_list_animales_adop;
        private FontAwesome.Sharp.IconButton ibtn_list_animales;
        private FontAwesome.Sharp.IconButton ibtn_dar_animal_adop;
        private FontAwesome.Sharp.IconButton ibtn_reg_new_animal;
        private System.Windows.Forms.Panel pn1;
        private FontAwesome.Sharp.IconButton ibtn_list_adoptantes;
        private FontAwesome.Sharp.IconButton ibtnLogout;
        private FontAwesome.Sharp.IconButton ibtn_list_animales_crit;
    }
}
