
namespace TPG401
{
    partial class FormTipoGestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoGestion));
            this.pnCerraryMin = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ibtn_GInventario = new FontAwesome.Sharp.IconButton();
            this.ibtn_GGastos = new FontAwesome.Sharp.IconButton();
            this.ibtn_GDatos = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pnCerraryMin.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCerraryMin
            // 
            this.pnCerraryMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.pnCerraryMin.Controls.Add(this.pbClose);
            this.pnCerraryMin.Controls.Add(this.pbMinimize);
            this.pnCerraryMin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCerraryMin.Location = new System.Drawing.Point(0, 0);
            this.pnCerraryMin.Name = "pnCerraryMin";
            this.pnCerraryMin.Size = new System.Drawing.Size(1064, 28);
            this.pnCerraryMin.TabIndex = 1;
            this.pnCerraryMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCerraryMin_MouseDown);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelMenu.Controls.Add(this.ibtn_GInventario);
            this.panelMenu.Controls.Add(this.ibtn_GGastos);
            this.panelMenu.Controls.Add(this.ibtn_GDatos);
            this.panelMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 28);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1064, 80);
            this.panelMenu.TabIndex = 2;
            // 
            // ibtn_GInventario
            // 
            this.ibtn_GInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ibtn_GInventario.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibtn_GInventario.FlatAppearance.BorderSize = 0;
            this.ibtn_GInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_GInventario.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold);
            this.ibtn_GInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ibtn_GInventario.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.ibtn_GInventario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ibtn_GInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_GInventario.Location = new System.Drawing.Point(708, 0);
            this.ibtn_GInventario.Name = "ibtn_GInventario";
            this.ibtn_GInventario.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_GInventario.Size = new System.Drawing.Size(356, 80);
            this.ibtn_GInventario.TabIndex = 4;
            this.ibtn_GInventario.Text = "Gestión de Inventario de Medicamentos";
            this.ibtn_GInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtn_GInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ibtn_GInventario.UseVisualStyleBackColor = false;
            this.ibtn_GInventario.Click += new System.EventHandler(this.ibtn_GInventario_Click);
            // 
            // ibtn_GGastos
            // 
            this.ibtn_GGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ibtn_GGastos.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibtn_GGastos.FlatAppearance.BorderSize = 0;
            this.ibtn_GGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_GGastos.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold);
            this.ibtn_GGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ibtn_GGastos.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.ibtn_GGastos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ibtn_GGastos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_GGastos.Location = new System.Drawing.Point(354, 0);
            this.ibtn_GGastos.Name = "ibtn_GGastos";
            this.ibtn_GGastos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_GGastos.Size = new System.Drawing.Size(354, 80);
            this.ibtn_GGastos.TabIndex = 3;
            this.ibtn_GGastos.Text = "Gestión de Gastos";
            this.ibtn_GGastos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtn_GGastos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ibtn_GGastos.UseVisualStyleBackColor = false;
            this.ibtn_GGastos.Click += new System.EventHandler(this.ibtn_GGastos_Click);
            // 
            // ibtn_GDatos
            // 
            this.ibtn_GDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ibtn_GDatos.Dock = System.Windows.Forms.DockStyle.Left;
            this.ibtn_GDatos.FlatAppearance.BorderSize = 0;
            this.ibtn_GDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_GDatos.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtn_GDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ibtn_GDatos.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.ibtn_GDatos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ibtn_GDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_GDatos.Location = new System.Drawing.Point(0, 0);
            this.ibtn_GDatos.Name = "ibtn_GDatos";
            this.ibtn_GDatos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtn_GDatos.Size = new System.Drawing.Size(354, 80);
            this.ibtn_GDatos.TabIndex = 2;
            this.ibtn_GDatos.Text = "Gestión de Datos";
            this.ibtn_GDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtn_GDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ibtn_GDatos.UseVisualStyleBackColor = false;
            this.ibtn_GDatos.Click += new System.EventHandler(this.ibtn_GDatos_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 108);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1064, 600);
            this.panelContenedor.TabIndex = 3;
            // 
            // pbClose
            // 
            this.pbClose.Image = global::TPG401.Properties.Resources.close1;
            this.pbClose.Location = new System.Drawing.Point(1021, 6);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(40, 20);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 4;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            this.pbClose.MouseEnter += new System.EventHandler(this.pbClose_MouseEnter);
            this.pbClose.MouseLeave += new System.EventHandler(this.pbClose_MouseLeave);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Image = global::TPG401.Properties.Resources.minimize1;
            this.pbMinimize.Location = new System.Drawing.Point(987, 6);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(40, 20);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimize.TabIndex = 5;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            this.pbMinimize.MouseEnter += new System.EventHandler(this.pbMinimize_MouseEnter);
            this.pbMinimize.MouseLeave += new System.EventHandler(this.pbMinimize_MouseLeave);
            // 
            // FormTipoGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1064, 708);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.pnCerraryMin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTipoGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Gestion";
            this.pnCerraryMin.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnCerraryMin;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton ibtn_GInventario;
        private FontAwesome.Sharp.IconButton ibtn_GGastos;
        private FontAwesome.Sharp.IconButton ibtn_GDatos;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMinimize;
    }
}