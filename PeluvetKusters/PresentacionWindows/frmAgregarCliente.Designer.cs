namespace PresentacionWindows
{
    partial class frmAgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarCliente));
            this.dgbAgregarCliente = new System.Windows.Forms.DataGridView();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCli = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblApellidoCli = new System.Windows.Forms.Label();
            this.lblNombreCli = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.txtApellidoCli = new System.Windows.Forms.TextBox();
            this.txtNombreCli = new System.Windows.Forms.TextBox();
            this.cmbLocalidades = new System.Windows.Forms.ComboBox();
            this.btnAgregarMascota = new System.Windows.Forms.Button();
            this.btnAceptarMod = new System.Windows.Forms.Button();
            this.btnCancelarMod = new System.Windows.Forms.Button();
            this.cmbLocalidadMod = new System.Windows.Forms.ComboBox();
            this.lblContactoMod = new System.Windows.Forms.Label();
            this.lblLocalidadMod = new System.Windows.Forms.Label();
            this.lblApellidoMod = new System.Windows.Forms.Label();
            this.lblNombreMod = new System.Windows.Forms.Label();
            this.txtContactoMod = new System.Windows.Forms.TextBox();
            this.txtApellidoMod = new System.Windows.Forms.TextBox();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.lblModificar = new System.Windows.Forms.Label();
            this.txtIdMod = new System.Windows.Forms.TextBox();
            this.lblIDMod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgbAgregarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbAgregarCliente
            // 
            this.dgbAgregarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgbAgregarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbAgregarCliente.Location = new System.Drawing.Point(268, 14);
            this.dgbAgregarCliente.Name = "dgbAgregarCliente";
            this.dgbAgregarCliente.Size = new System.Drawing.Size(445, 401);
            this.dgbAgregarCliente.TabIndex = 81;
            this.dgbAgregarCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbAgregarCliente_CellContentClick);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodificar.Location = new System.Drawing.Point(514, 439);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(93, 23);
            this.btnmodificar.TabIndex = 72;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(143, 183);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 23);
            this.btnCancelar.TabIndex = 71;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(46, 183);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 23);
            this.btnAgregar.TabIndex = 70;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCli
            // 
            this.lblCli.AutoSize = true;
            this.lblCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCli.Location = new System.Drawing.Point(12, 9);
            this.lblCli.Name = "lblCli";
            this.lblCli.Size = new System.Drawing.Size(79, 25);
            this.lblCli.TabIndex = 67;
            this.lblCli.Text = "Cliente";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(18, 111);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(56, 13);
            this.lblContacto.TabIndex = 64;
            this.lblContacto.Text = "Contacto: ";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(17, 139);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(59, 13);
            this.lblLocalidad.TabIndex = 63;
            this.lblLocalidad.Text = "Localidad: ";
            // 
            // lblApellidoCli
            // 
            this.lblApellidoCli.AutoSize = true;
            this.lblApellidoCli.Location = new System.Drawing.Point(18, 85);
            this.lblApellidoCli.Name = "lblApellidoCli";
            this.lblApellidoCli.Size = new System.Drawing.Size(50, 13);
            this.lblApellidoCli.TabIndex = 62;
            this.lblApellidoCli.Text = "Apellido: ";
            // 
            // lblNombreCli
            // 
            this.lblNombreCli.AutoSize = true;
            this.lblNombreCli.Location = new System.Drawing.Point(18, 55);
            this.lblNombreCli.Name = "lblNombreCli";
            this.lblNombreCli.Size = new System.Drawing.Size(50, 13);
            this.lblNombreCli.TabIndex = 61;
            this.lblNombreCli.Text = "Nombre: ";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(78, 104);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(156, 20);
            this.txtContacto.TabIndex = 58;
            // 
            // txtApellidoCli
            // 
            this.txtApellidoCli.Location = new System.Drawing.Point(78, 78);
            this.txtApellidoCli.Name = "txtApellidoCli";
            this.txtApellidoCli.Size = new System.Drawing.Size(156, 20);
            this.txtApellidoCli.TabIndex = 56;
            // 
            // txtNombreCli
            // 
            this.txtNombreCli.Location = new System.Drawing.Point(78, 52);
            this.txtNombreCli.Name = "txtNombreCli";
            this.txtNombreCli.Size = new System.Drawing.Size(156, 20);
            this.txtNombreCli.TabIndex = 55;
            // 
            // cmbLocalidades
            // 
            this.cmbLocalidades.FormattingEnabled = true;
            this.cmbLocalidades.Location = new System.Drawing.Point(78, 136);
            this.cmbLocalidades.Name = "cmbLocalidades";
            this.cmbLocalidades.Size = new System.Drawing.Size(156, 21);
            this.cmbLocalidades.TabIndex = 83;
            this.cmbLocalidades.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidades_SelectedIndexChanged);
            // 
            // btnAgregarMascota
            // 
            this.btnAgregarMascota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarMascota.Location = new System.Drawing.Point(613, 439);
            this.btnAgregarMascota.Name = "btnAgregarMascota";
            this.btnAgregarMascota.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarMascota.TabIndex = 84;
            this.btnAgregarMascota.Text = "Agregar mascota";
            this.btnAgregarMascota.UseVisualStyleBackColor = true;
            this.btnAgregarMascota.Click += new System.EventHandler(this.btnAgregarMascota_Click);
            // 
            // btnAceptarMod
            // 
            this.btnAceptarMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAceptarMod.Location = new System.Drawing.Point(46, 439);
            this.btnAceptarMod.Name = "btnAceptarMod";
            this.btnAceptarMod.Size = new System.Drawing.Size(91, 23);
            this.btnAceptarMod.TabIndex = 85;
            this.btnAceptarMod.Text = "Aceptar";
            this.btnAceptarMod.UseVisualStyleBackColor = true;
            this.btnAceptarMod.Click += new System.EventHandler(this.btnAceptarMod_Click);
            // 
            // btnCancelarMod
            // 
            this.btnCancelarMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarMod.Location = new System.Drawing.Point(143, 439);
            this.btnCancelarMod.Name = "btnCancelarMod";
            this.btnCancelarMod.Size = new System.Drawing.Size(91, 23);
            this.btnCancelarMod.TabIndex = 86;
            this.btnCancelarMod.Text = "Cancelar";
            this.btnCancelarMod.UseVisualStyleBackColor = true;
            this.btnCancelarMod.Click += new System.EventHandler(this.btnCancelarMod_Click);
            // 
            // cmbLocalidadMod
            // 
            this.cmbLocalidadMod.Enabled = false;
            this.cmbLocalidadMod.FormattingEnabled = true;
            this.cmbLocalidadMod.Location = new System.Drawing.Point(78, 403);
            this.cmbLocalidadMod.Name = "cmbLocalidadMod";
            this.cmbLocalidadMod.Size = new System.Drawing.Size(156, 21);
            this.cmbLocalidadMod.TabIndex = 94;
            // 
            // lblContactoMod
            // 
            this.lblContactoMod.AutoSize = true;
            this.lblContactoMod.Location = new System.Drawing.Point(18, 378);
            this.lblContactoMod.Name = "lblContactoMod";
            this.lblContactoMod.Size = new System.Drawing.Size(56, 13);
            this.lblContactoMod.TabIndex = 93;
            this.lblContactoMod.Text = "Contacto: ";
            // 
            // lblLocalidadMod
            // 
            this.lblLocalidadMod.AutoSize = true;
            this.lblLocalidadMod.Location = new System.Drawing.Point(17, 406);
            this.lblLocalidadMod.Name = "lblLocalidadMod";
            this.lblLocalidadMod.Size = new System.Drawing.Size(59, 13);
            this.lblLocalidadMod.TabIndex = 92;
            this.lblLocalidadMod.Text = "Localidad: ";
            // 
            // lblApellidoMod
            // 
            this.lblApellidoMod.AutoSize = true;
            this.lblApellidoMod.Location = new System.Drawing.Point(18, 352);
            this.lblApellidoMod.Name = "lblApellidoMod";
            this.lblApellidoMod.Size = new System.Drawing.Size(50, 13);
            this.lblApellidoMod.TabIndex = 91;
            this.lblApellidoMod.Text = "Apellido: ";
            // 
            // lblNombreMod
            // 
            this.lblNombreMod.AutoSize = true;
            this.lblNombreMod.Location = new System.Drawing.Point(18, 322);
            this.lblNombreMod.Name = "lblNombreMod";
            this.lblNombreMod.Size = new System.Drawing.Size(50, 13);
            this.lblNombreMod.TabIndex = 90;
            this.lblNombreMod.Text = "Nombre: ";
            // 
            // txtContactoMod
            // 
            this.txtContactoMod.Enabled = false;
            this.txtContactoMod.Location = new System.Drawing.Point(78, 371);
            this.txtContactoMod.Name = "txtContactoMod";
            this.txtContactoMod.Size = new System.Drawing.Size(156, 20);
            this.txtContactoMod.TabIndex = 89;
            // 
            // txtApellidoMod
            // 
            this.txtApellidoMod.Enabled = false;
            this.txtApellidoMod.Location = new System.Drawing.Point(78, 345);
            this.txtApellidoMod.Name = "txtApellidoMod";
            this.txtApellidoMod.Size = new System.Drawing.Size(156, 20);
            this.txtApellidoMod.TabIndex = 88;
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Enabled = false;
            this.txtNombreMod.Location = new System.Drawing.Point(78, 319);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(156, 20);
            this.txtNombreMod.TabIndex = 87;
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.Location = new System.Drawing.Point(16, 260);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(100, 25);
            this.lblModificar.TabIndex = 95;
            this.lblModificar.Text = "Modificar";
            // 
            // txtIdMod
            // 
            this.txtIdMod.Enabled = false;
            this.txtIdMod.Location = new System.Drawing.Point(78, 293);
            this.txtIdMod.Name = "txtIdMod";
            this.txtIdMod.ReadOnly = true;
            this.txtIdMod.Size = new System.Drawing.Size(34, 20);
            this.txtIdMod.TabIndex = 125;
            // 
            // lblIDMod
            // 
            this.lblIDMod.AutoSize = true;
            this.lblIDMod.Location = new System.Drawing.Point(41, 297);
            this.lblIDMod.Name = "lblIDMod";
            this.lblIDMod.Size = new System.Drawing.Size(21, 13);
            this.lblIDMod.TabIndex = 124;
            this.lblIDMod.Text = "ID:";
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(733, 473);
            this.Controls.Add(this.txtIdMod);
            this.Controls.Add(this.lblIDMod);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.cmbLocalidadMod);
            this.Controls.Add(this.lblContactoMod);
            this.Controls.Add(this.lblLocalidadMod);
            this.Controls.Add(this.lblApellidoMod);
            this.Controls.Add(this.lblNombreMod);
            this.Controls.Add(this.txtContactoMod);
            this.Controls.Add(this.txtApellidoMod);
            this.Controls.Add(this.txtNombreMod);
            this.Controls.Add(this.btnCancelarMod);
            this.Controls.Add(this.btnAceptarMod);
            this.Controls.Add(this.btnAgregarMascota);
            this.Controls.Add(this.cmbLocalidades);
            this.Controls.Add(this.dgbAgregarCliente);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCli);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblApellidoCli);
            this.Controls.Add(this.lblNombreCli);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtApellidoCli);
            this.Controls.Add(this.txtNombreCli);
            this.Name = "frmAgregarCliente";
            this.Text = "frmAgregarCliente";
            this.Load += new System.EventHandler(this.frmAgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbAgregarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbAgregarCliente;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCli;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblApellidoCli;
        private System.Windows.Forms.Label lblNombreCli;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.TextBox txtApellidoCli;
        private System.Windows.Forms.TextBox txtNombreCli;
        private System.Windows.Forms.ComboBox cmbLocalidades;
        private System.Windows.Forms.Button btnAgregarMascota;
        private System.Windows.Forms.Button btnAceptarMod;
        private System.Windows.Forms.Button btnCancelarMod;
        private System.Windows.Forms.ComboBox cmbLocalidadMod;
        private System.Windows.Forms.Label lblContactoMod;
        private System.Windows.Forms.Label lblLocalidadMod;
        private System.Windows.Forms.Label lblApellidoMod;
        private System.Windows.Forms.Label lblNombreMod;
        private System.Windows.Forms.TextBox txtContactoMod;
        private System.Windows.Forms.TextBox txtApellidoMod;
        private System.Windows.Forms.TextBox txtNombreMod;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.TextBox txtIdMod;
        private System.Windows.Forms.Label lblIDMod;
    }
}