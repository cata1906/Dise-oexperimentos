
namespace TPG401
{
    partial class list_animales
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCantAnimales = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbBuscarX = new System.Windows.Forms.ComboBox();
            this.lblBusquedaText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.pbInstrucciones = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstrucciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCantAnimales);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbBuscar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnRestablecer);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.cmbBuscarX);
            this.groupBox1.Controls.Add(this.lblBusquedaText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(96, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 201);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // lblCantAnimales
            // 
            this.lblCantAnimales.AutoSize = true;
            this.lblCantAnimales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCantAnimales.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblCantAnimales.Location = new System.Drawing.Point(444, 162);
            this.lblCantAnimales.Name = "lblCantAnimales";
            this.lblCantAnimales.Size = new System.Drawing.Size(17, 18);
            this.lblCantAnimales.TabIndex = 45;
            this.lblCantAnimales.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(59, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "Número de animales registrados en el último mes:";
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.BackColor = System.Drawing.Color.White;
            this.cmbBuscar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscar.Enabled = false;
            this.cmbBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbBuscar.ForeColor = System.Drawing.Color.Black;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.IntegralHeight = false;
            this.cmbBuscar.ItemHeight = 18;
            this.cmbBuscar.Location = new System.Drawing.Point(270, 68);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(146, 26);
            this.cmbBuscar.TabIndex = 1;
            this.cmbBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbBuscar_SelectedIndexChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(262, 120);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 25);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(156, 120);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 25);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(83)))), ((int)(((byte)(226)))));
            this.btnRestablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestablecer.FlatAppearance.BorderSize = 0;
            this.btnRestablecer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.ForeColor = System.Drawing.Color.Black;
            this.btnRestablecer.Location = new System.Drawing.Point(50, 120);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(100, 25);
            this.btnRestablecer.TabIndex = 3;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(207)))), ((int)(((byte)(122)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(368, 120);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 25);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbBuscarX
            // 
            this.cmbBuscarX.BackColor = System.Drawing.Color.White;
            this.cmbBuscarX.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbBuscarX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBuscarX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbBuscarX.ForeColor = System.Drawing.Color.Black;
            this.cmbBuscarX.FormattingEnabled = true;
            this.cmbBuscarX.IntegralHeight = false;
            this.cmbBuscarX.ItemHeight = 18;
            this.cmbBuscarX.Items.AddRange(new object[] {
            "Codigo",
            "Tipo",
            "Nombre",
            "Raza",
            "Edad",
            "Sexo",
            "Color",
            "Proveniencia",
            "Estado"});
            this.cmbBuscarX.Location = new System.Drawing.Point(226, 36);
            this.cmbBuscarX.Name = "cmbBuscarX";
            this.cmbBuscarX.Size = new System.Drawing.Size(190, 26);
            this.cmbBuscarX.TabIndex = 0;
            this.cmbBuscarX.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarX_SelectedIndexChanged);
            // 
            // lblBusquedaText
            // 
            this.lblBusquedaText.AutoSize = true;
            this.lblBusquedaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblBusquedaText.ForeColor = System.Drawing.Color.White;
            this.lblBusquedaText.Location = new System.Drawing.Point(106, 71);
            this.lblBusquedaText.Name = "lblBusquedaText";
            this.lblBusquedaText.Size = new System.Drawing.Size(62, 18);
            this.lblBusquedaText.TabIndex = 37;
            this.lblBusquedaText.Text = "Valores:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(106, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Buscar por:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Heavy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblTitulo.Location = new System.Drawing.Point(151, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(408, 30);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "LISTA DE ANIMALES DEL ALBERGUE";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AllowUserToResizeRows = false;
            this.dgvLista.BackgroundColor = System.Drawing.Color.MediumSpringGreen;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(16, 295);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(678, 285);
            this.dgvLista.TabIndex = 22;
            this.dgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellClick);
            // 
            // pbInstrucciones
            // 
            this.pbInstrucciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInstrucciones.Image = global::TPG401.Properties.Resources.youtube;
            this.pbInstrucciones.Location = new System.Drawing.Point(11, 5);
            this.pbInstrucciones.Name = "pbInstrucciones";
            this.pbInstrucciones.Size = new System.Drawing.Size(48, 48);
            this.pbInstrucciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInstrucciones.TabIndex = 15;
            this.pbInstrucciones.TabStop = false;
            this.pbInstrucciones.Click += new System.EventHandler(this.pbInstrucciones_Click);
            this.pbInstrucciones.MouseEnter += new System.EventHandler(this.pbInstrucciones_MouseEnter);
            this.pbInstrucciones.MouseLeave += new System.EventHandler(this.pbInstrucciones_MouseLeave);
            // 
            // list_animales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.pbInstrucciones);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox1);
            this.Name = "list_animales";
            this.Size = new System.Drawing.Size(710, 596);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstrucciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.PictureBox pbInstrucciones;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.ComboBox cmbBuscarX;
        private System.Windows.Forms.Label lblBusquedaText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantAnimales;
    }
}
