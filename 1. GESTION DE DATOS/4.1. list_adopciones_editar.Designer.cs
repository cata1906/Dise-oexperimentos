
namespace TPG401
{
    partial class list_adopciones_editar
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
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.cmbBuscarX = new System.Windows.Forms.ComboBox();
            this.lblBusquedaText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnCerraryMin = new System.Windows.Forms.Panel();
            this.pbAtras = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.BackColor = System.Drawing.Color.White;
            this.cmbBuscar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbBuscar.ForeColor = System.Drawing.Color.Black;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.IntegralHeight = false;
            this.cmbBuscar.ItemHeight = 18;
            this.cmbBuscar.Location = new System.Drawing.Point(300, 119);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(188, 26);
            this.cmbBuscar.TabIndex = 1;
            this.cmbBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbBuscar_SelectedIndexChanged);
            // 
            // cmbBuscarX
            // 
            this.cmbBuscarX.BackColor = System.Drawing.Color.White;
            this.cmbBuscarX.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbBuscarX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarX.Enabled = false;
            this.cmbBuscarX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBuscarX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscarX.ForeColor = System.Drawing.Color.Black;
            this.cmbBuscarX.FormattingEnabled = true;
            this.cmbBuscarX.IntegralHeight = false;
            this.cmbBuscarX.ItemHeight = 18;
            this.cmbBuscarX.Items.AddRange(new object[] {
            "Codigo"});
            this.cmbBuscarX.Location = new System.Drawing.Point(300, 87);
            this.cmbBuscarX.Name = "cmbBuscarX";
            this.cmbBuscarX.Size = new System.Drawing.Size(188, 26);
            this.cmbBuscarX.TabIndex = 0;
            // 
            // lblBusquedaText
            // 
            this.lblBusquedaText.AutoSize = true;
            this.lblBusquedaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblBusquedaText.ForeColor = System.Drawing.Color.White;
            this.lblBusquedaText.Location = new System.Drawing.Point(143, 122);
            this.lblBusquedaText.Name = "lblBusquedaText";
            this.lblBusquedaText.Size = new System.Drawing.Size(127, 18);
            this.lblBusquedaText.TabIndex = 78;
            this.lblBusquedaText.Text = "Ingrese el Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(143, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 77;
            this.label4.Text = "Editar por:";
            // 
            // pnCerraryMin
            // 
            this.pnCerraryMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(46)))), ((int)(((byte)(70)))));
            this.pnCerraryMin.Location = new System.Drawing.Point(69, 0);
            this.pnCerraryMin.Name = "pnCerraryMin";
            this.pnCerraryMin.Size = new System.Drawing.Size(521, 28);
            this.pnCerraryMin.TabIndex = 81;
            this.pnCerraryMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCerraryMin_MouseDown);
            // 
            // pbAtras
            // 
            this.pbAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAtras.Image = global::TPG401.Properties.Resources.back;
            this.pbAtras.Location = new System.Drawing.Point(21, 21);
            this.pbAtras.Name = "pbAtras";
            this.pbAtras.Size = new System.Drawing.Size(42, 42);
            this.pbAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAtras.TabIndex = 82;
            this.pbAtras.TabStop = false;
            this.pbAtras.Click += new System.EventHandler(this.pbAtras_Click);
            this.pbAtras.MouseEnter += new System.EventHandler(this.pbAtras_MouseEnter);
            this.pbAtras.MouseLeave += new System.EventHandler(this.pbAtras_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 84;
            this.label2.Text = "DNI del adoptante:";
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.White;
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDNI.Enabled = false;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtDNI.ForeColor = System.Drawing.Color.Black;
            this.txtDNI.Location = new System.Drawing.Point(255, 186);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(247, 24);
            this.txtDNI.TabIndex = 2;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(83)))), ((int)(((byte)(226)))));
            this.btnRestablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestablecer.FlatAppearance.BorderSize = 0;
            this.btnRestablecer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(63)))), ((int)(((byte)(226)))));
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRestablecer.ForeColor = System.Drawing.Color.Black;
            this.btnRestablecer.Location = new System.Drawing.Point(125, 263);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(162, 36);
            this.btnRestablecer.TabIndex = 4;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(305, 263);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 36);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // list_adopciones_editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(46)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(590, 369);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbAtras);
            this.Controls.Add(this.pnCerraryMin);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.cmbBuscarX);
            this.Controls.Add(this.lblBusquedaText);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "list_adopciones_editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "list_animales_adop_editar";
            ((System.ComponentModel.ISupportInitialize)(this.pbAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.ComboBox cmbBuscarX;
        private System.Windows.Forms.Label lblBusquedaText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnCerraryMin;
        private System.Windows.Forms.PictureBox pbAtras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Button btnEditar;
    }
}