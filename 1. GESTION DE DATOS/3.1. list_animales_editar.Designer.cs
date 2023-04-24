
namespace TPG401
{
    partial class list_animales_editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list_animales_editar));
            this.pbAtras = new System.Windows.Forms.PictureBox();
            this.pnCerraryMin = new System.Windows.Forms.Panel();
            this.cmbColor3 = new System.Windows.Forms.ComboBox();
            this.cmbColor2 = new System.Windows.Forms.ComboBox();
            this.cmbColor1 = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbProv = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.cmbBuscarX = new System.Windows.Forms.ComboBox();
            this.lblBusquedaText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAtras
            // 
            this.pbAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAtras.Image = global::TPG401.Properties.Resources.back;
            this.pbAtras.Location = new System.Drawing.Point(21, 21);
            this.pbAtras.Name = "pbAtras";
            this.pbAtras.Size = new System.Drawing.Size(42, 42);
            this.pbAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAtras.TabIndex = 46;
            this.pbAtras.TabStop = false;
            this.pbAtras.Click += new System.EventHandler(this.pbAtras_Click);
            this.pbAtras.MouseEnter += new System.EventHandler(this.pbAtras_MouseEnter);
            this.pbAtras.MouseLeave += new System.EventHandler(this.pbAtras_MouseLeave);
            // 
            // pnCerraryMin
            // 
            this.pnCerraryMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(46)))), ((int)(((byte)(70)))));
            this.pnCerraryMin.Location = new System.Drawing.Point(69, 0);
            this.pnCerraryMin.Name = "pnCerraryMin";
            this.pnCerraryMin.Size = new System.Drawing.Size(521, 28);
            this.pnCerraryMin.TabIndex = 51;
            this.pnCerraryMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCerraryMin_MouseDown);
            // 
            // cmbColor3
            // 
            this.cmbColor3.BackColor = System.Drawing.Color.White;
            this.cmbColor3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbColor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor3.Enabled = false;
            this.cmbColor3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbColor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbColor3.ForeColor = System.Drawing.Color.Black;
            this.cmbColor3.FormattingEnabled = true;
            this.cmbColor3.IntegralHeight = false;
            this.cmbColor3.ItemHeight = 18;
            this.cmbColor3.Items.AddRange(new object[] {
            "Blanco",
            "Negro",
            "Gris",
            "Marrón"});
            this.cmbColor3.Location = new System.Drawing.Point(493, 325);
            this.cmbColor3.Name = "cmbColor3";
            this.cmbColor3.Size = new System.Drawing.Size(78, 26);
            this.cmbColor3.TabIndex = 10;
            this.cmbColor3.Visible = false;
            this.cmbColor3.SelectedIndexChanged += new System.EventHandler(this.cmbColor3_SelectedIndexChanged);
            // 
            // cmbColor2
            // 
            this.cmbColor2.BackColor = System.Drawing.Color.White;
            this.cmbColor2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbColor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor2.Enabled = false;
            this.cmbColor2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbColor2.ForeColor = System.Drawing.Color.Black;
            this.cmbColor2.FormattingEnabled = true;
            this.cmbColor2.IntegralHeight = false;
            this.cmbColor2.ItemHeight = 18;
            this.cmbColor2.Items.AddRange(new object[] {
            "Blanco",
            "Negro",
            "Gris",
            "Marrón"});
            this.cmbColor2.Location = new System.Drawing.Point(408, 325);
            this.cmbColor2.Name = "cmbColor2";
            this.cmbColor2.Size = new System.Drawing.Size(79, 26);
            this.cmbColor2.TabIndex = 9;
            this.cmbColor2.Visible = false;
            this.cmbColor2.SelectedIndexChanged += new System.EventHandler(this.cmbColor2_SelectedIndexChanged);
            // 
            // cmbColor1
            // 
            this.cmbColor1.BackColor = System.Drawing.Color.White;
            this.cmbColor1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbColor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor1.Enabled = false;
            this.cmbColor1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbColor1.ForeColor = System.Drawing.Color.Black;
            this.cmbColor1.FormattingEnabled = true;
            this.cmbColor1.IntegralHeight = false;
            this.cmbColor1.ItemHeight = 18;
            this.cmbColor1.Items.AddRange(new object[] {
            "Blanco",
            "Negro",
            "Gris",
            "Marrón"});
            this.cmbColor1.Location = new System.Drawing.Point(324, 325);
            this.cmbColor1.Name = "cmbColor1";
            this.cmbColor1.Size = new System.Drawing.Size(78, 26);
            this.cmbColor1.TabIndex = 8;
            this.cmbColor1.Visible = false;
            this.cmbColor1.SelectedIndexChanged += new System.EventHandler(this.cmbColor1_SelectedIndexChanged);
            // 
            // cmbColor
            // 
            this.cmbColor.BackColor = System.Drawing.Color.White;
            this.cmbColor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Enabled = false;
            this.cmbColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbColor.ForeColor = System.Drawing.Color.Black;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.IntegralHeight = false;
            this.cmbColor.ItemHeight = 18;
            this.cmbColor.Items.AddRange(new object[] {
            "Blanco",
            "Negro",
            "Gris",
            "Marrón",
            "Bicolor",
            "Tricolor"});
            this.cmbColor.Location = new System.Drawing.Point(240, 325);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(78, 26);
            this.cmbColor.TabIndex = 7;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // cmbSexo
            // 
            this.cmbSexo.BackColor = System.Drawing.Color.White;
            this.cmbSexo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.Enabled = false;
            this.cmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbSexo.ForeColor = System.Drawing.Color.Black;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.IntegralHeight = false;
            this.cmbSexo.ItemHeight = 18;
            this.cmbSexo.Items.AddRange(new object[] {
            "Macho",
            "Hembra"});
            this.cmbSexo.Location = new System.Drawing.Point(240, 293);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(247, 26);
            this.cmbSexo.TabIndex = 6;
            // 
            // cmbRaza
            // 
            this.cmbRaza.BackColor = System.Drawing.Color.White;
            this.cmbRaza.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRaza.Enabled = false;
            this.cmbRaza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbRaza.ForeColor = System.Drawing.Color.Black;
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.IntegralHeight = false;
            this.cmbRaza.ItemHeight = 18;
            this.cmbRaza.Location = new System.Drawing.Point(240, 231);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(247, 26);
            this.cmbRaza.TabIndex = 4;
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
            this.btnRestablecer.Location = new System.Drawing.Point(125, 478);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(162, 36);
            this.btnRestablecer.TabIndex = 14;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.White;
            this.cmbEstado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Enabled = false;
            this.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbEstado.ForeColor = System.Drawing.Color.Black;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.IntegralHeight = false;
            this.cmbEstado.ItemHeight = 18;
            this.cmbEstado.Items.AddRange(new object[] {
            "Excelente",
            "Bien",
            "Normal",
            "Mal",
            "Critico"});
            this.cmbEstado.Location = new System.Drawing.Point(240, 389);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(247, 26);
            this.cmbEstado.TabIndex = 12;
            // 
            // cmbProv
            // 
            this.cmbProv.BackColor = System.Drawing.Color.White;
            this.cmbProv.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProv.Enabled = false;
            this.cmbProv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbProv.ForeColor = System.Drawing.Color.Black;
            this.cmbProv.FormattingEnabled = true;
            this.cmbProv.IntegralHeight = false;
            this.cmbProv.ItemHeight = 18;
            this.cmbProv.Items.AddRange(new object[] {
            "Lima",
            "Ancón",
            "Ate Vitarte",
            "Barranco",
            "Breña",
            "Carabayllo",
            "Chaclacayo",
            "Chorrillos",
            "Cieneguilla",
            "Comas",
            "El Agustino",
            "Independencia",
            "Jesús María",
            "La Molina",
            "La Victoria",
            "Lince",
            "Los Olivos",
            "Lurigancho",
            "Lurín",
            "Magdalena del Mar",
            "Miraflores",
            "Pachacamac",
            "Pucusana",
            "Pueblo Libre",
            "Puente Piedra",
            "Punta Hermosa",
            "Punta Negra",
            "Rímac",
            "San Bartolo",
            "San Borja",
            "San Isidro",
            "San Juan de Lurigancho",
            "San Juan de Miraflores",
            "San Luis",
            "San Martín de Porres",
            "San Miguel",
            "Santa Anita",
            "Santa María del Mar",
            "Santa Rosa",
            "Santiago de Surco",
            "Surquillo",
            "Villa El Salvador",
            "Villa María del Triunfo",
            "Otro"});
            this.cmbProv.Location = new System.Drawing.Point(240, 357);
            this.cmbProv.Name = "cmbProv";
            this.cmbProv.Size = new System.Drawing.Size(247, 26);
            this.cmbProv.TabIndex = 11;
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.White;
            this.cmbTipo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Enabled = false;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbTipo.ForeColor = System.Drawing.Color.Black;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.IntegralHeight = false;
            this.cmbTipo.ItemHeight = 18;
            this.cmbTipo.Items.AddRange(new object[] {
            "Perro",
            "Gato"});
            this.cmbTipo.Location = new System.Drawing.Point(240, 169);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(247, 26);
            this.cmbTipo.TabIndex = 2;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(240, 201);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 24);
            this.txtNombre.TabIndex = 3;
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.White;
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdad.Enabled = false;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtEdad.ForeColor = System.Drawing.Color.Black;
            this.txtEdad.Location = new System.Drawing.Point(240, 263);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(247, 24);
            this.txtEdad.TabIndex = 5;
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
            this.btnEditar.Location = new System.Drawing.Point(305, 478);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 36);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.cmbBuscar.Location = new System.Drawing.Point(300, 103);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(165, 26);
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
            this.cmbBuscarX.Location = new System.Drawing.Point(300, 71);
            this.cmbBuscarX.Name = "cmbBuscarX";
            this.cmbBuscarX.Size = new System.Drawing.Size(165, 26);
            this.cmbBuscarX.TabIndex = 0;
            // 
            // lblBusquedaText
            // 
            this.lblBusquedaText.AutoSize = true;
            this.lblBusquedaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblBusquedaText.ForeColor = System.Drawing.Color.White;
            this.lblBusquedaText.Location = new System.Drawing.Point(143, 105);
            this.lblBusquedaText.Name = "lblBusquedaText";
            this.lblBusquedaText.Size = new System.Drawing.Size(127, 18);
            this.lblBusquedaText.TabIndex = 74;
            this.lblBusquedaText.Text = "Ingrese el Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(143, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 73;
            this.label4.Text = "Editar por:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(91, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 18);
            this.label10.TabIndex = 84;
            this.label10.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(91, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 18);
            this.label9.TabIndex = 83;
            this.label9.Text = "Proveniencia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(91, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 82;
            this.label8.Text = "Color:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(91, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 81;
            this.label7.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(91, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 80;
            this.label6.Text = "Edad (años):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(91, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 79;
            this.label5.Text = "Raza:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 78;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = "Tipo de animal:";
            // 
            // list_animales_editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(46)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(590, 585);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.cmbBuscarX);
            this.Controls.Add(this.lblBusquedaText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbColor3);
            this.Controls.Add(this.cmbColor2);
            this.Controls.Add(this.cmbColor1);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.cmbRaza);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbProv);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pnCerraryMin);
            this.Controls.Add(this.pbAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "list_animales_editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar datos de un animal";
            ((System.ComponentModel.ISupportInitialize)(this.pbAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbAtras;
        private System.Windows.Forms.Panel pnCerraryMin;
        private System.Windows.Forms.ComboBox cmbColor3;
        private System.Windows.Forms.ComboBox cmbColor2;
        private System.Windows.Forms.ComboBox cmbColor1;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbProv;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.ComboBox cmbBuscarX;
        private System.Windows.Forms.Label lblBusquedaText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}