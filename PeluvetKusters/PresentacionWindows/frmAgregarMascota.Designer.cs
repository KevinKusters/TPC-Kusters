namespace PresentacionWindows
{
    partial class frmAgregarMascota
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
            this.lblOtro = new System.Windows.Forms.Label();
            this.txtOtro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbOtro = new System.Windows.Forms.RadioButton();
            this.rbtGato = new System.Windows.Forms.RadioButton();
            this.rbtPerro = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRazas = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMasc = new System.Windows.Forms.Label();
            this.lblNombreMasc = new System.Windows.Forms.Label();
            this.txtNombreMasc = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.lblMascotas = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnAgregarMascota = new System.Windows.Forms.Button();
            this.lblTituloMod = new System.Windows.Forms.Label();
            this.btnAceptarMod = new System.Windows.Forms.Button();
            this.lblOtroMod = new System.Windows.Forms.Label();
            this.txtOtroMod = new System.Windows.Forms.TextBox();
            this.lblEspecieMod = new System.Windows.Forms.Label();
            this.rdbOtroMod = new System.Windows.Forms.RadioButton();
            this.rdbGatoMod = new System.Windows.Forms.RadioButton();
            this.rdbPerroMod = new System.Windows.Forms.RadioButton();
            this.lblRazaMod = new System.Windows.Forms.Label();
            this.cmbrazaMod = new System.Windows.Forms.ComboBox();
            this.btnCancelarMod = new System.Windows.Forms.Button();
            this.lblNombreMod = new System.Windows.Forms.Label();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblIDMod = new System.Windows.Forms.Label();
            this.txtIdMod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOtro
            // 
            this.lblOtro.AutoSize = true;
            this.lblOtro.Location = new System.Drawing.Point(47, 188);
            this.lblOtro.Name = "lblOtro";
            this.lblOtro.Size = new System.Drawing.Size(33, 13);
            this.lblOtro.TabIndex = 96;
            this.lblOtro.Text = "Otro: ";
            // 
            // txtOtro
            // 
            this.txtOtro.Enabled = false;
            this.txtOtro.Location = new System.Drawing.Point(90, 185);
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.Size = new System.Drawing.Size(154, 20);
            this.txtOtro.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "Especie: ";
            // 
            // rdbOtro
            // 
            this.rdbOtro.AutoSize = true;
            this.rdbOtro.Location = new System.Drawing.Point(201, 155);
            this.rdbOtro.Name = "rdbOtro";
            this.rdbOtro.Size = new System.Drawing.Size(45, 17);
            this.rdbOtro.TabIndex = 93;
            this.rdbOtro.Text = "Otro";
            this.rdbOtro.UseVisualStyleBackColor = true;
            this.rdbOtro.CheckedChanged += new System.EventHandler(this.rdbOtro_CheckedChanged);
            // 
            // rbtGato
            // 
            this.rbtGato.AutoSize = true;
            this.rbtGato.Location = new System.Drawing.Point(147, 155);
            this.rbtGato.Name = "rbtGato";
            this.rbtGato.Size = new System.Drawing.Size(48, 17);
            this.rbtGato.TabIndex = 92;
            this.rbtGato.Text = "Gato";
            this.rbtGato.UseVisualStyleBackColor = true;
            this.rbtGato.CheckedChanged += new System.EventHandler(this.rbtGato_CheckedChanged);
            // 
            // rbtPerro
            // 
            this.rbtPerro.AutoSize = true;
            this.rbtPerro.Checked = true;
            this.rbtPerro.Location = new System.Drawing.Point(91, 155);
            this.rbtPerro.Name = "rbtPerro";
            this.rbtPerro.Size = new System.Drawing.Size(50, 17);
            this.rbtPerro.TabIndex = 91;
            this.rbtPerro.TabStop = true;
            this.rbtPerro.Text = "Perro";
            this.rbtPerro.UseVisualStyleBackColor = true;
            this.rbtPerro.CheckedChanged += new System.EventHandler(this.rbtPerro_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Raza: ";
            // 
            // cmbRazas
            // 
            this.cmbRazas.FormattingEnabled = true;
            this.cmbRazas.Location = new System.Drawing.Point(91, 246);
            this.cmbRazas.Name = "cmbRazas";
            this.cmbRazas.Size = new System.Drawing.Size(156, 21);
            this.cmbRazas.TabIndex = 89;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Location = new System.Drawing.Point(144, 282);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 23);
            this.btnCancelar.TabIndex = 88;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMasc
            // 
            this.lblMasc.AutoSize = true;
            this.lblMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasc.Location = new System.Drawing.Point(0, 111);
            this.lblMasc.Name = "lblMasc";
            this.lblMasc.Size = new System.Drawing.Size(94, 25);
            this.lblMasc.TabIndex = 85;
            this.lblMasc.Text = "Mascota";
            // 
            // lblNombreMasc
            // 
            this.lblNombreMasc.AutoSize = true;
            this.lblNombreMasc.Location = new System.Drawing.Point(37, 217);
            this.lblNombreMasc.Name = "lblNombreMasc";
            this.lblNombreMasc.Size = new System.Drawing.Size(50, 13);
            this.lblNombreMasc.TabIndex = 83;
            this.lblNombreMasc.Text = "Nombre: ";
            // 
            // txtNombreMasc
            // 
            this.txtNombreMasc.Location = new System.Drawing.Point(90, 214);
            this.txtNombreMasc.Name = "txtNombreMasc";
            this.txtNombreMasc.Size = new System.Drawing.Size(156, 20);
            this.txtNombreMasc.TabIndex = 82;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(11, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(96, 13);
            this.lblNombre.TabIndex = 97;
            this.lblNombre.Text = "Nombre cliente:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(113, 43);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.ReadOnly = true;
            this.txtnombre.Size = new System.Drawing.Size(128, 20);
            this.txtnombre.TabIndex = 98;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(50, 72);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 13);
            this.lblApellido.TabIndex = 99;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(112, 69);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.ReadOnly = true;
            this.txtapellido.Size = new System.Drawing.Size(127, 20);
            this.txtapellido.TabIndex = 100;
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Location = new System.Drawing.Point(264, 25);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.Size = new System.Drawing.Size(428, 461);
            this.dgvMascotas.TabIndex = 101;
            // 
            // lblMascotas
            // 
            this.lblMascotas.AutoSize = true;
            this.lblMascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascotas.Location = new System.Drawing.Point(261, 9);
            this.lblMascotas.Name = "lblMascotas";
            this.lblMascotas.Size = new System.Drawing.Size(124, 13);
            this.lblMascotas.TabIndex = 102;
            this.lblMascotas.Text = "Mascotas del cliente";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(111, 17);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(27, 20);
            this.txtID.TabIndex = 104;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(40, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 13);
            this.lblID.TabIndex = 105;
            this.lblID.Text = "ID cliente:";
            // 
            // btnAgregarMascota
            // 
            this.btnAgregarMascota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarMascota.Location = new System.Drawing.Point(38, 282);
            this.btnAgregarMascota.Name = "btnAgregarMascota";
            this.btnAgregarMascota.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarMascota.TabIndex = 106;
            this.btnAgregarMascota.Text = "Agregar Mascota";
            this.btnAgregarMascota.UseVisualStyleBackColor = true;
            this.btnAgregarMascota.Click += new System.EventHandler(this.btnAgregarMascota_Click);
            // 
            // lblTituloMod
            // 
            this.lblTituloMod.AutoSize = true;
            this.lblTituloMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMod.Location = new System.Drawing.Point(1, 319);
            this.lblTituloMod.Name = "lblTituloMod";
            this.lblTituloMod.Size = new System.Drawing.Size(86, 24);
            this.lblTituloMod.TabIndex = 107;
            this.lblTituloMod.Text = "Modificar";
            // 
            // btnAceptarMod
            // 
            this.btnAceptarMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAceptarMod.Location = new System.Drawing.Point(35, 498);
            this.btnAceptarMod.Name = "btnAceptarMod";
            this.btnAceptarMod.Size = new System.Drawing.Size(100, 23);
            this.btnAceptarMod.TabIndex = 119;
            this.btnAceptarMod.Text = "Aceptar";
            this.btnAceptarMod.UseVisualStyleBackColor = true;
            this.btnAceptarMod.Click += new System.EventHandler(this.btnAceptarMod_Click);
            // 
            // lblOtroMod
            // 
            this.lblOtroMod.AutoSize = true;
            this.lblOtroMod.Location = new System.Drawing.Point(44, 404);
            this.lblOtroMod.Name = "lblOtroMod";
            this.lblOtroMod.Size = new System.Drawing.Size(33, 13);
            this.lblOtroMod.TabIndex = 118;
            this.lblOtroMod.Text = "Otro: ";
            // 
            // txtOtroMod
            // 
            this.txtOtroMod.Enabled = false;
            this.txtOtroMod.Location = new System.Drawing.Point(87, 401);
            this.txtOtroMod.Name = "txtOtroMod";
            this.txtOtroMod.Size = new System.Drawing.Size(154, 20);
            this.txtOtroMod.TabIndex = 117;
            // 
            // lblEspecieMod
            // 
            this.lblEspecieMod.AutoSize = true;
            this.lblEspecieMod.Location = new System.Drawing.Point(24, 380);
            this.lblEspecieMod.Name = "lblEspecieMod";
            this.lblEspecieMod.Size = new System.Drawing.Size(51, 13);
            this.lblEspecieMod.TabIndex = 116;
            this.lblEspecieMod.Text = "Especie: ";
            // 
            // rdbOtroMod
            // 
            this.rdbOtroMod.AutoSize = true;
            this.rdbOtroMod.Location = new System.Drawing.Point(196, 378);
            this.rdbOtroMod.Name = "rdbOtroMod";
            this.rdbOtroMod.Size = new System.Drawing.Size(45, 17);
            this.rdbOtroMod.TabIndex = 115;
            this.rdbOtroMod.Text = "Otro";
            this.rdbOtroMod.UseVisualStyleBackColor = true;
            this.rdbOtroMod.CheckedChanged += new System.EventHandler(this.rdbOtroMod_CheckedChanged);
            // 
            // rdbGatoMod
            // 
            this.rdbGatoMod.AutoSize = true;
            this.rdbGatoMod.Location = new System.Drawing.Point(142, 378);
            this.rdbGatoMod.Name = "rdbGatoMod";
            this.rdbGatoMod.Size = new System.Drawing.Size(48, 17);
            this.rdbGatoMod.TabIndex = 114;
            this.rdbGatoMod.Text = "Gato";
            this.rdbGatoMod.UseVisualStyleBackColor = true;
            this.rdbGatoMod.CheckedChanged += new System.EventHandler(this.rdbGatoMod_CheckedChanged);
            // 
            // rdbPerroMod
            // 
            this.rdbPerroMod.AutoSize = true;
            this.rdbPerroMod.Checked = true;
            this.rdbPerroMod.Location = new System.Drawing.Point(86, 378);
            this.rdbPerroMod.Name = "rdbPerroMod";
            this.rdbPerroMod.Size = new System.Drawing.Size(50, 17);
            this.rdbPerroMod.TabIndex = 113;
            this.rdbPerroMod.TabStop = true;
            this.rdbPerroMod.Text = "Perro";
            this.rdbPerroMod.UseVisualStyleBackColor = true;
            this.rdbPerroMod.CheckedChanged += new System.EventHandler(this.rdbPerroMod_CheckedChanged);
            // 
            // lblRazaMod
            // 
            this.lblRazaMod.AutoSize = true;
            this.lblRazaMod.Location = new System.Drawing.Point(42, 468);
            this.lblRazaMod.Name = "lblRazaMod";
            this.lblRazaMod.Size = new System.Drawing.Size(38, 13);
            this.lblRazaMod.TabIndex = 112;
            this.lblRazaMod.Text = "Raza: ";
            // 
            // cmbrazaMod
            // 
            this.cmbrazaMod.FormattingEnabled = true;
            this.cmbrazaMod.Location = new System.Drawing.Point(88, 462);
            this.cmbrazaMod.Name = "cmbrazaMod";
            this.cmbrazaMod.Size = new System.Drawing.Size(156, 21);
            this.cmbrazaMod.TabIndex = 111;
            // 
            // btnCancelarMod
            // 
            this.btnCancelarMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarMod.Location = new System.Drawing.Point(141, 498);
            this.btnCancelarMod.Name = "btnCancelarMod";
            this.btnCancelarMod.Size = new System.Drawing.Size(103, 23);
            this.btnCancelarMod.TabIndex = 110;
            this.btnCancelarMod.Text = "Cancelar";
            this.btnCancelarMod.UseVisualStyleBackColor = true;
            this.btnCancelarMod.Click += new System.EventHandler(this.btnCancelarMod_Click);
            // 
            // lblNombreMod
            // 
            this.lblNombreMod.AutoSize = true;
            this.lblNombreMod.Location = new System.Drawing.Point(34, 433);
            this.lblNombreMod.Name = "lblNombreMod";
            this.lblNombreMod.Size = new System.Drawing.Size(50, 13);
            this.lblNombreMod.TabIndex = 109;
            this.lblNombreMod.Text = "Nombre: ";
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Enabled = false;
            this.txtNombreMod.Location = new System.Drawing.Point(87, 430);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(156, 20);
            this.txtNombreMod.TabIndex = 108;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(264, 498);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 23);
            this.btnModificar.TabIndex = 120;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(373, 498);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 23);
            this.btnEliminar.TabIndex = 121;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblIDMod
            // 
            this.lblIDMod.AutoSize = true;
            this.lblIDMod.Location = new System.Drawing.Point(50, 354);
            this.lblIDMod.Name = "lblIDMod";
            this.lblIDMod.Size = new System.Drawing.Size(21, 13);
            this.lblIDMod.TabIndex = 122;
            this.lblIDMod.Text = "ID:";
            // 
            // txtIdMod
            // 
            this.txtIdMod.Enabled = false;
            this.txtIdMod.Location = new System.Drawing.Point(91, 350);
            this.txtIdMod.Name = "txtIdMod";
            this.txtIdMod.ReadOnly = true;
            this.txtIdMod.Size = new System.Drawing.Size(34, 20);
            this.txtIdMod.TabIndex = 123;
            // 
            // frmAgregarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 539);
            this.Controls.Add(this.txtIdMod);
            this.Controls.Add(this.lblIDMod);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAceptarMod);
            this.Controls.Add(this.lblOtroMod);
            this.Controls.Add(this.txtOtroMod);
            this.Controls.Add(this.lblEspecieMod);
            this.Controls.Add(this.rdbOtroMod);
            this.Controls.Add(this.rdbGatoMod);
            this.Controls.Add(this.rdbPerroMod);
            this.Controls.Add(this.lblRazaMod);
            this.Controls.Add(this.cmbrazaMod);
            this.Controls.Add(this.btnCancelarMod);
            this.Controls.Add(this.lblNombreMod);
            this.Controls.Add(this.txtNombreMod);
            this.Controls.Add(this.lblTituloMod);
            this.Controls.Add(this.btnAgregarMascota);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblMascotas);
            this.Controls.Add(this.dgvMascotas);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblOtro);
            this.Controls.Add(this.txtOtro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbOtro);
            this.Controls.Add(this.rbtGato);
            this.Controls.Add(this.rbtPerro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRazas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblMasc);
            this.Controls.Add(this.lblNombreMasc);
            this.Controls.Add(this.txtNombreMasc);
            this.Name = "frmAgregarMascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAgregarMascota";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOtro;
        private System.Windows.Forms.TextBox txtOtro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbOtro;
        private System.Windows.Forms.RadioButton rbtGato;
        private System.Windows.Forms.RadioButton rbtPerro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRazas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMasc;
        private System.Windows.Forms.Label lblNombreMasc;
        private System.Windows.Forms.TextBox txtNombreMasc;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.DataGridView dgvMascotas;
        private System.Windows.Forms.Label lblMascotas;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnAgregarMascota;
        private System.Windows.Forms.Label lblTituloMod;
        private System.Windows.Forms.Button btnAceptarMod;
        private System.Windows.Forms.Label lblOtroMod;
        private System.Windows.Forms.TextBox txtOtroMod;
        private System.Windows.Forms.Label lblEspecieMod;
        private System.Windows.Forms.RadioButton rdbOtroMod;
        private System.Windows.Forms.RadioButton rdbGatoMod;
        private System.Windows.Forms.RadioButton rdbPerroMod;
        private System.Windows.Forms.Label lblRazaMod;
        private System.Windows.Forms.ComboBox cmbrazaMod;
        private System.Windows.Forms.Button btnCancelarMod;
        private System.Windows.Forms.Label lblNombreMod;
        private System.Windows.Forms.TextBox txtNombreMod;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblIDMod;
        private System.Windows.Forms.TextBox txtIdMod;
    }
}