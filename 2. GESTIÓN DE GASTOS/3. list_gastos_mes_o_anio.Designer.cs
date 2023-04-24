
namespace TPG401
{
    partial class list_gastos_mes_o_anio
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAscendente = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnDescendente = new System.Windows.Forms.Button();
            this.cmbBuscarX = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Heavy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitulo.Location = new System.Drawing.Point(111, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(498, 30);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "LISTA DE GASTOS EN EL ULTIMO MES O AÑO";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AllowUserToResizeRows = false;
            this.dgvLista.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(16, 221);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(678, 355);
            this.dgvLista.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAscendente);
            this.groupBox1.Controls.Add(this.btnRestablecer);
            this.groupBox1.Controls.Add(this.btnDescendente);
            this.groupBox1.Controls.Add(this.cmbBuscarX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(153, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 136);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // btnAscendente
            // 
            this.btnAscendente.BackColor = System.Drawing.Color.Violet;
            this.btnAscendente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAscendente.FlatAppearance.BorderSize = 0;
            this.btnAscendente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnAscendente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAscendente.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAscendente.ForeColor = System.Drawing.Color.Black;
            this.btnAscendente.Location = new System.Drawing.Point(156, 86);
            this.btnAscendente.Name = "btnAscendente";
            this.btnAscendente.Size = new System.Drawing.Size(100, 25);
            this.btnAscendente.TabIndex = 2;
            this.btnAscendente.Text = "Ascendente";
            this.btnAscendente.UseVisualStyleBackColor = false;
            this.btnAscendente.Click += new System.EventHandler(this.btnAscendente_Click);
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
            this.btnRestablecer.Location = new System.Drawing.Point(50, 86);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(100, 25);
            this.btnRestablecer.TabIndex = 3;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // btnDescendente
            // 
            this.btnDescendente.BackColor = System.Drawing.Color.Violet;
            this.btnDescendente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescendente.FlatAppearance.BorderSize = 0;
            this.btnDescendente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnDescendente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescendente.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDescendente.ForeColor = System.Drawing.Color.Black;
            this.btnDescendente.Location = new System.Drawing.Point(262, 86);
            this.btnDescendente.Name = "btnDescendente";
            this.btnDescendente.Size = new System.Drawing.Size(100, 25);
            this.btnDescendente.TabIndex = 1;
            this.btnDescendente.Text = "Descendente";
            this.btnDescendente.UseVisualStyleBackColor = false;
            this.btnDescendente.Click += new System.EventHandler(this.btnDescendente_Click);
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
            "Mes",
            "Año"});
            this.cmbBuscarX.Location = new System.Drawing.Point(172, 36);
            this.cmbBuscarX.Name = "cmbBuscarX";
            this.cmbBuscarX.Size = new System.Drawing.Size(190, 26);
            this.cmbBuscarX.TabIndex = 0;
            this.cmbBuscarX.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarX_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Ultimo:";
            // 
            // list_gastos_mes_o_anio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "list_gastos_mes_o_anio";
            this.Size = new System.Drawing.Size(710, 596);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAscendente;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Button btnDescendente;
        private System.Windows.Forms.ComboBox cmbBuscarX;
        private System.Windows.Forms.Label label4;
    }
}
