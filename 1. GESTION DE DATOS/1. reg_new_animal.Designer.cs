    
namespace TPG401
{
    partial class reg_new_animal
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblRegistrarNuevoAnimal = new System.Windows.Forms.Label();
            this.btnGenCod = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbProv = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbColor1 = new System.Windows.Forms.ComboBox();
            this.cmbColor2 = new System.Windows.Forms.ComboBox();
            this.cmbColor3 = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAutoComplete = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(301, 192);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 24);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.Color.White;
            this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCod.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCod.ForeColor = System.Drawing.Color.Black;
            this.txtCod.Location = new System.Drawing.Point(301, 130);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(155, 24);
            this.txtCod.TabIndex = 0;
            this.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            // 
            // lblRegistrarNuevoAnimal
            // 
            this.lblRegistrarNuevoAnimal.AutoSize = true;
            this.lblRegistrarNuevoAnimal.Font = new System.Drawing.Font("Franklin Gothic Heavy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarNuevoAnimal.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblRegistrarNuevoAnimal.Location = new System.Drawing.Point(190, 65);
            this.lblRegistrarNuevoAnimal.Name = "lblRegistrarNuevoAnimal";
            this.lblRegistrarNuevoAnimal.Size = new System.Drawing.Size(320, 30);
            this.lblRegistrarNuevoAnimal.TabIndex = 13;
            this.lblRegistrarNuevoAnimal.Text = "REGISTRAR NUEVO ANIMAL";
            // 
            // btnGenCod
            // 
            this.btnGenCod.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnGenCod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenCod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(207)))), ((int)(((byte)(122)))));
            this.btnGenCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenCod.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenCod.ForeColor = System.Drawing.Color.Black;
            this.btnGenCod.Location = new System.Drawing.Point(460, 130);
            this.btnGenCod.Name = "btnGenCod";
            this.btnGenCod.Size = new System.Drawing.Size(88, 24);
            this.btnGenCod.TabIndex = 0;
            this.btnGenCod.Text = "Generar";
            this.btnGenCod.UseVisualStyleBackColor = false;
            this.btnGenCod.Click += new System.EventHandler(this.btnGenCod_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.White;
            this.cmbTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbTipo.ForeColor = System.Drawing.Color.Black;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.IntegralHeight = false;
            this.cmbTipo.ItemHeight = 18;
            this.cmbTipo.Items.AddRange(new object[] {
            "Perro",
            "Gato"});
            this.cmbTipo.Location = new System.Drawing.Point(301, 160);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(247, 26);
            this.cmbTipo.TabIndex = 1;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // cmbProv
            // 
            this.cmbProv.BackColor = System.Drawing.Color.White;
            this.cmbProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbProv.Location = new System.Drawing.Point(301, 348);
            this.cmbProv.Name = "cmbProv";
            this.cmbProv.Size = new System.Drawing.Size(247, 26);
            this.cmbProv.TabIndex = 10;
            this.cmbProv.SelectedIndexChanged += new System.EventHandler(this.cmbProv_SelectedIndexChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.White;
            this.cmbEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbEstado.Location = new System.Drawing.Point(301, 380);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(247, 26);
            this.cmbEstado.TabIndex = 11;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(152, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(152, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tipo de animal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(152, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(152, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Raza:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(152, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Edad (años):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(152, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Sexo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(152, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Color:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(152, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Proveniencia:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(152, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "Estado:";
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRestablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestablecer.FlatAppearance.BorderSize = 0;
            this.btnRestablecer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(235)))));
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.ForeColor = System.Drawing.Color.Black;
            this.btnRestablecer.Location = new System.Drawing.Point(193, 461);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(150, 36);
            this.btnRestablecer.TabIndex = 13;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // cmbRaza
            // 
            this.cmbRaza.BackColor = System.Drawing.Color.White;
            this.cmbRaza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRaza.Enabled = false;
            this.cmbRaza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbRaza.ForeColor = System.Drawing.Color.Black;
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.IntegralHeight = false;
            this.cmbRaza.ItemHeight = 18;
            this.cmbRaza.Location = new System.Drawing.Point(301, 222);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(247, 26);
            this.cmbRaza.TabIndex = 3;
            this.cmbRaza.SelectedIndexChanged += new System.EventHandler(this.cmbRaza_SelectedIndexChanged);
            // 
            // cmbSexo
            // 
            this.cmbSexo.BackColor = System.Drawing.Color.White;
            this.cmbSexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbSexo.ForeColor = System.Drawing.Color.Black;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.IntegralHeight = false;
            this.cmbSexo.ItemHeight = 18;
            this.cmbSexo.Items.AddRange(new object[] {
            "Macho",
            "Hembra"});
            this.cmbSexo.Location = new System.Drawing.Point(301, 284);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(247, 26);
            this.cmbSexo.TabIndex = 5;
            this.cmbSexo.SelectedIndexChanged += new System.EventHandler(this.cmbSexo_SelectedIndexChanged);
            // 
            // cmbColor
            // 
            this.cmbColor.BackColor = System.Drawing.Color.White;
            this.cmbColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbColor.Location = new System.Drawing.Point(301, 316);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(78, 26);
            this.cmbColor.TabIndex = 6;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // cmbColor1
            // 
            this.cmbColor1.BackColor = System.Drawing.Color.White;
            this.cmbColor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbColor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbColor1.Location = new System.Drawing.Point(385, 316);
            this.cmbColor1.Name = "cmbColor1";
            this.cmbColor1.Size = new System.Drawing.Size(78, 26);
            this.cmbColor1.TabIndex = 7;
            this.cmbColor1.Visible = false;
            this.cmbColor1.SelectedIndexChanged += new System.EventHandler(this.cmbColor1_SelectedIndexChanged);
            // 
            // cmbColor2
            // 
            this.cmbColor2.BackColor = System.Drawing.Color.White;
            this.cmbColor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbColor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbColor2.Location = new System.Drawing.Point(469, 316);
            this.cmbColor2.Name = "cmbColor2";
            this.cmbColor2.Size = new System.Drawing.Size(79, 26);
            this.cmbColor2.TabIndex = 8;
            this.cmbColor2.Visible = false;
            this.cmbColor2.SelectedIndexChanged += new System.EventHandler(this.cmbColor2_SelectedIndexChanged);
            // 
            // cmbColor3
            // 
            this.cmbColor3.BackColor = System.Drawing.Color.White;
            this.cmbColor3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbColor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbColor3.Location = new System.Drawing.Point(554, 316);
            this.cmbColor3.Name = "cmbColor3";
            this.cmbColor3.Size = new System.Drawing.Size(78, 26);
            this.cmbColor3.TabIndex = 9;
            this.cmbColor3.Visible = false;
            this.cmbColor3.SelectedIndexChanged += new System.EventHandler(this.cmbColor3_SelectedIndexChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(207)))), ((int)(((byte)(122)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(361, 461);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(150, 36);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAutoComplete
            // 
            this.btnAutoComplete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAutoComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoComplete.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAutoComplete.Location = new System.Drawing.Point(3, 566);
            this.btnAutoComplete.Name = "btnAutoComplete";
            this.btnAutoComplete.Size = new System.Drawing.Size(80, 27);
            this.btnAutoComplete.TabIndex = 14;
            this.btnAutoComplete.Text = "Automatico";
            this.btnAutoComplete.UseVisualStyleBackColor = false;
            this.btnAutoComplete.Click += new System.EventHandler(this.btnAutoComplete_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.White;
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtEdad.ForeColor = System.Drawing.Color.Black;
            this.txtEdad.Location = new System.Drawing.Point(301, 254);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(247, 24);
            this.txtEdad.TabIndex = 4;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // reg_new_animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.btnAutoComplete);
            this.Controls.Add(this.cmbColor3);
            this.Controls.Add(this.cmbColor2);
            this.Controls.Add(this.cmbColor1);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.cmbRaza);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbProv);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.btnGenCod);
            this.Controls.Add(this.lblRegistrarNuevoAnimal);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "reg_new_animal";
            this.Size = new System.Drawing.Size(710, 596);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblRegistrarNuevoAnimal;
        private System.Windows.Forms.Button btnGenCod;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbProv;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbColor1;
        private System.Windows.Forms.ComboBox cmbColor2;
        private System.Windows.Forms.ComboBox cmbColor3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAutoComplete;
        private System.Windows.Forms.TextBox txtEdad;
    }
}
