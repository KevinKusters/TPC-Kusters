namespace PresentacionWindows
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTituloMod = new System.Windows.Forms.Label();
            this.lblNombreAgr = new System.Windows.Forms.Label();
            this.lblApellidoAgr = new System.Windows.Forms.Label();
            this.lblContactoAgr = new System.Windows.Forms.Label();
            this.lblPuestoAgr = new System.Windows.Forms.Label();
            this.lblNombreMod = new System.Windows.Forms.Label();
            this.lblApellidoMod = new System.Windows.Forms.Label();
            this.lblContactoMod = new System.Windows.Forms.Label();
            this.lblPuestoMod = new System.Windows.Forms.Label();
            this.txtNombreAgr = new System.Windows.Forms.TextBox();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.txtContactoAgr = new System.Windows.Forms.TextBox();
            this.txtApellidoAgr = new System.Windows.Forms.TextBox();
            this.cmbPuestosAgr = new System.Windows.Forms.ComboBox();
            this.txtApellidoMod = new System.Windows.Forms.TextBox();
            this.txtContactoMod = new System.Windows.Forms.TextBox();
            this.cmbPuestoMod = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTituloLista = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.rdbPeluqueria = new System.Windows.Forms.RadioButton();
            this.rdbVeterinaria = new System.Windows.Forms.RadioButton();
            this.lblRubro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbVeterinariaMod = new System.Windows.Forms.RadioButton();
            this.rdbPeluqueriaMod = new System.Windows.Forms.RadioButton();
            this.txtIDMod = new System.Windows.Forms.TextBox();
            this.lblIdMod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(230, 30);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(371, 435);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(171, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Cargar empleado";
            // 
            // lblTituloMod
            // 
            this.lblTituloMod.AutoSize = true;
            this.lblTituloMod.BackColor = System.Drawing.SystemColors.Control;
            this.lblTituloMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMod.Location = new System.Drawing.Point(10, 238);
            this.lblTituloMod.Name = "lblTituloMod";
            this.lblTituloMod.Size = new System.Drawing.Size(194, 24);
            this.lblTituloMod.TabIndex = 2;
            this.lblTituloMod.Text = "Modificar empleado";
            // 
            // lblNombreAgr
            // 
            this.lblNombreAgr.AutoSize = true;
            this.lblNombreAgr.Location = new System.Drawing.Point(11, 55);
            this.lblNombreAgr.Name = "lblNombreAgr";
            this.lblNombreAgr.Size = new System.Drawing.Size(47, 13);
            this.lblNombreAgr.TabIndex = 3;
            this.lblNombreAgr.Text = "Nombre:";
            // 
            // lblApellidoAgr
            // 
            this.lblApellidoAgr.AutoSize = true;
            this.lblApellidoAgr.Location = new System.Drawing.Point(16, 81);
            this.lblApellidoAgr.Name = "lblApellidoAgr";
            this.lblApellidoAgr.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoAgr.TabIndex = 4;
            this.lblApellidoAgr.Text = "Apellido:";
            // 
            // lblContactoAgr
            // 
            this.lblContactoAgr.AutoSize = true;
            this.lblContactoAgr.Location = new System.Drawing.Point(12, 110);
            this.lblContactoAgr.Name = "lblContactoAgr";
            this.lblContactoAgr.Size = new System.Drawing.Size(53, 13);
            this.lblContactoAgr.TabIndex = 5;
            this.lblContactoAgr.Text = "Contacto:";
            // 
            // lblPuestoAgr
            // 
            this.lblPuestoAgr.AutoSize = true;
            this.lblPuestoAgr.Location = new System.Drawing.Point(20, 136);
            this.lblPuestoAgr.Name = "lblPuestoAgr";
            this.lblPuestoAgr.Size = new System.Drawing.Size(43, 13);
            this.lblPuestoAgr.TabIndex = 6;
            this.lblPuestoAgr.Text = "Puesto:";
            // 
            // lblNombreMod
            // 
            this.lblNombreMod.AutoSize = true;
            this.lblNombreMod.Location = new System.Drawing.Point(11, 305);
            this.lblNombreMod.Name = "lblNombreMod";
            this.lblNombreMod.Size = new System.Drawing.Size(47, 13);
            this.lblNombreMod.TabIndex = 7;
            this.lblNombreMod.Text = "Nombre:";
            // 
            // lblApellidoMod
            // 
            this.lblApellidoMod.AutoSize = true;
            this.lblApellidoMod.Location = new System.Drawing.Point(11, 331);
            this.lblApellidoMod.Name = "lblApellidoMod";
            this.lblApellidoMod.Size = new System.Drawing.Size(50, 13);
            this.lblApellidoMod.TabIndex = 8;
            this.lblApellidoMod.Text = "Apellido: ";
            // 
            // lblContactoMod
            // 
            this.lblContactoMod.AutoSize = true;
            this.lblContactoMod.Location = new System.Drawing.Point(11, 357);
            this.lblContactoMod.Name = "lblContactoMod";
            this.lblContactoMod.Size = new System.Drawing.Size(53, 13);
            this.lblContactoMod.TabIndex = 9;
            this.lblContactoMod.Text = "Contacto:";
            // 
            // lblPuestoMod
            // 
            this.lblPuestoMod.AutoSize = true;
            this.lblPuestoMod.Location = new System.Drawing.Point(15, 383);
            this.lblPuestoMod.Name = "lblPuestoMod";
            this.lblPuestoMod.Size = new System.Drawing.Size(43, 13);
            this.lblPuestoMod.TabIndex = 10;
            this.lblPuestoMod.Text = "Puesto:";
            // 
            // txtNombreAgr
            // 
            this.txtNombreAgr.Location = new System.Drawing.Point(80, 52);
            this.txtNombreAgr.Name = "txtNombreAgr";
            this.txtNombreAgr.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAgr.TabIndex = 11;
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Enabled = false;
            this.txtNombreMod.Location = new System.Drawing.Point(79, 302);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMod.TabIndex = 12;
            // 
            // txtContactoAgr
            // 
            this.txtContactoAgr.Location = new System.Drawing.Point(80, 103);
            this.txtContactoAgr.Name = "txtContactoAgr";
            this.txtContactoAgr.Size = new System.Drawing.Size(100, 20);
            this.txtContactoAgr.TabIndex = 14;
            // 
            // txtApellidoAgr
            // 
            this.txtApellidoAgr.Location = new System.Drawing.Point(80, 78);
            this.txtApellidoAgr.Name = "txtApellidoAgr";
            this.txtApellidoAgr.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoAgr.TabIndex = 15;
            // 
            // cmbPuestosAgr
            // 
            this.cmbPuestosAgr.FormattingEnabled = true;
            this.cmbPuestosAgr.Location = new System.Drawing.Point(78, 133);
            this.cmbPuestosAgr.Name = "cmbPuestosAgr";
            this.cmbPuestosAgr.Size = new System.Drawing.Size(121, 21);
            this.cmbPuestosAgr.TabIndex = 16;
            // 
            // txtApellidoMod
            // 
            this.txtApellidoMod.Enabled = false;
            this.txtApellidoMod.Location = new System.Drawing.Point(79, 328);
            this.txtApellidoMod.Name = "txtApellidoMod";
            this.txtApellidoMod.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoMod.TabIndex = 17;
            // 
            // txtContactoMod
            // 
            this.txtContactoMod.Enabled = false;
            this.txtContactoMod.Location = new System.Drawing.Point(79, 354);
            this.txtContactoMod.Name = "txtContactoMod";
            this.txtContactoMod.Size = new System.Drawing.Size(100, 20);
            this.txtContactoMod.TabIndex = 18;
            // 
            // cmbPuestoMod
            // 
            this.cmbPuestoMod.Enabled = false;
            this.cmbPuestoMod.FormattingEnabled = true;
            this.cmbPuestoMod.Location = new System.Drawing.Point(79, 380);
            this.cmbPuestoMod.Name = "cmbPuestoMod";
            this.cmbPuestoMod.Size = new System.Drawing.Size(121, 21);
            this.cmbPuestoMod.TabIndex = 19;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(19, 212);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 23);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(33, 471);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 23);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(119, 471);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTituloLista
            // 
            this.lblTituloLista.AutoSize = true;
            this.lblTituloLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLista.Location = new System.Drawing.Point(226, 7);
            this.lblTituloLista.Name = "lblTituloLista";
            this.lblTituloLista.Size = new System.Drawing.Size(161, 24);
            this.lblTituloLista.TabIndex = 23;
            this.lblTituloLista.Text = "Lista empleados";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(230, 471);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 23);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(316, 471);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 23);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // rdbPeluqueria
            // 
            this.rdbPeluqueria.AutoSize = true;
            this.rdbPeluqueria.Checked = true;
            this.rdbPeluqueria.Location = new System.Drawing.Point(79, 166);
            this.rdbPeluqueria.Name = "rdbPeluqueria";
            this.rdbPeluqueria.Size = new System.Drawing.Size(75, 17);
            this.rdbPeluqueria.TabIndex = 26;
            this.rdbPeluqueria.TabStop = true;
            this.rdbPeluqueria.Text = "Peluqueria";
            this.rdbPeluqueria.UseVisualStyleBackColor = true;
            // 
            // rdbVeterinaria
            // 
            this.rdbVeterinaria.AutoSize = true;
            this.rdbVeterinaria.Location = new System.Drawing.Point(78, 189);
            this.rdbVeterinaria.Name = "rdbVeterinaria";
            this.rdbVeterinaria.Size = new System.Drawing.Size(75, 17);
            this.rdbVeterinaria.TabIndex = 27;
            this.rdbVeterinaria.Text = "Veterinaria";
            this.rdbVeterinaria.UseVisualStyleBackColor = true;
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(24, 166);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(39, 13);
            this.lblRubro.TabIndex = 28;
            this.lblRubro.Text = "Rubro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Rubro:";
            // 
            // rdbVeterinariaMod
            // 
            this.rdbVeterinariaMod.AutoSize = true;
            this.rdbVeterinariaMod.Enabled = false;
            this.rdbVeterinariaMod.Location = new System.Drawing.Point(77, 430);
            this.rdbVeterinariaMod.Name = "rdbVeterinariaMod";
            this.rdbVeterinariaMod.Size = new System.Drawing.Size(75, 17);
            this.rdbVeterinariaMod.TabIndex = 30;
            this.rdbVeterinariaMod.Text = "Veterinaria";
            this.rdbVeterinariaMod.UseVisualStyleBackColor = true;
            // 
            // rdbPeluqueriaMod
            // 
            this.rdbPeluqueriaMod.AutoSize = true;
            this.rdbPeluqueriaMod.Checked = true;
            this.rdbPeluqueriaMod.Enabled = false;
            this.rdbPeluqueriaMod.Location = new System.Drawing.Point(78, 407);
            this.rdbPeluqueriaMod.Name = "rdbPeluqueriaMod";
            this.rdbPeluqueriaMod.Size = new System.Drawing.Size(75, 17);
            this.rdbPeluqueriaMod.TabIndex = 29;
            this.rdbPeluqueriaMod.TabStop = true;
            this.rdbPeluqueriaMod.Text = "Peluqueria";
            this.rdbPeluqueriaMod.UseVisualStyleBackColor = true;
            // 
            // txtIDMod
            // 
            this.txtIDMod.Enabled = false;
            this.txtIDMod.Location = new System.Drawing.Point(79, 276);
            this.txtIDMod.Name = "txtIDMod";
            this.txtIDMod.ReadOnly = true;
            this.txtIDMod.Size = new System.Drawing.Size(24, 20);
            this.txtIDMod.TabIndex = 33;
            // 
            // lblIdMod
            // 
            this.lblIdMod.AutoSize = true;
            this.lblIdMod.Location = new System.Drawing.Point(34, 279);
            this.lblIdMod.Name = "lblIdMod";
            this.lblIdMod.Size = new System.Drawing.Size(21, 13);
            this.lblIdMod.TabIndex = 32;
            this.lblIdMod.Text = "ID:";
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(613, 506);
            this.Controls.Add(this.txtIDMod);
            this.Controls.Add(this.lblIdMod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbVeterinariaMod);
            this.Controls.Add(this.rdbPeluqueriaMod);
            this.Controls.Add(this.lblRubro);
            this.Controls.Add(this.rdbVeterinaria);
            this.Controls.Add(this.rdbPeluqueria);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblTituloLista);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbPuestoMod);
            this.Controls.Add(this.txtContactoMod);
            this.Controls.Add(this.txtApellidoMod);
            this.Controls.Add(this.cmbPuestosAgr);
            this.Controls.Add(this.txtApellidoAgr);
            this.Controls.Add(this.txtContactoAgr);
            this.Controls.Add(this.txtNombreMod);
            this.Controls.Add(this.txtNombreAgr);
            this.Controls.Add(this.lblPuestoMod);
            this.Controls.Add(this.lblContactoMod);
            this.Controls.Add(this.lblApellidoMod);
            this.Controls.Add(this.lblNombreMod);
            this.Controls.Add(this.lblPuestoAgr);
            this.Controls.Add(this.lblContactoAgr);
            this.Controls.Add(this.lblApellidoAgr);
            this.Controls.Add(this.lblNombreAgr);
            this.Controls.Add(this.lblTituloMod);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTituloMod;
        private System.Windows.Forms.Label lblNombreAgr;
        private System.Windows.Forms.Label lblApellidoAgr;
        private System.Windows.Forms.Label lblContactoAgr;
        private System.Windows.Forms.Label lblPuestoAgr;
        private System.Windows.Forms.Label lblNombreMod;
        private System.Windows.Forms.Label lblApellidoMod;
        private System.Windows.Forms.Label lblContactoMod;
        private System.Windows.Forms.Label lblPuestoMod;
        private System.Windows.Forms.TextBox txtNombreAgr;
        private System.Windows.Forms.TextBox txtNombreMod;
        private System.Windows.Forms.TextBox txtContactoAgr;
        private System.Windows.Forms.TextBox txtApellidoAgr;
        private System.Windows.Forms.ComboBox cmbPuestosAgr;
        private System.Windows.Forms.TextBox txtApellidoMod;
        private System.Windows.Forms.TextBox txtContactoMod;
        private System.Windows.Forms.ComboBox cmbPuestoMod;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTituloLista;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.RadioButton rdbPeluqueria;
        private System.Windows.Forms.RadioButton rdbVeterinaria;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbVeterinariaMod;
        private System.Windows.Forms.RadioButton rdbPeluqueriaMod;
        private System.Windows.Forms.TextBox txtIDMod;
        private System.Windows.Forms.Label lblIdMod;
    }
}