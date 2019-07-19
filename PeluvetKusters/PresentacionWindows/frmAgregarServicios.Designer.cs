namespace PresentacionWindows
{
    partial class frmAgregarServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarServicios));
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.lblNombreAlta = new System.Windows.Forms.Label();
            this.lblPrecioAlta = new System.Windows.Forms.Label();
            this.lblIdMod = new System.Windows.Forms.Label();
            this.lblDescripcionMod = new System.Windows.Forms.Label();
            this.lblPrecioMod = new System.Windows.Forms.Label();
            this.lblTituloMod = new System.Windows.Forms.Label();
            this.txtDescripcionAlta = new System.Windows.Forms.TextBox();
            this.txtPrecioAlta = new System.Windows.Forms.TextBox();
            this.txtIdMod = new System.Windows.Forms.TextBox();
            this.txtDescripcionMod = new System.Windows.Forms.TextBox();
            this.txtPrecioMod = new System.Windows.Forms.TextBox();
            this.lblTituloAlta = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptarMod = new System.Windows.Forms.Button();
            this.btnCancelarMod = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.rdbPeluqueria = new System.Windows.Forms.RadioButton();
            this.rdbVeterinaria = new System.Windows.Forms.RadioButton();
            this.lblrubro = new System.Windows.Forms.Label();
            this.rdbVeterinariaMod = new System.Windows.Forms.RadioButton();
            this.rdbPeluqueriaMod = new System.Windows.Forms.RadioButton();
            this.lblRubroMod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServicios
            // 
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(205, 12);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.Size = new System.Drawing.Size(240, 384);
            this.dgvServicios.TabIndex = 2;
            // 
            // lblNombreAlta
            // 
            this.lblNombreAlta.AutoSize = true;
            this.lblNombreAlta.Location = new System.Drawing.Point(15, 52);
            this.lblNombreAlta.Name = "lblNombreAlta";
            this.lblNombreAlta.Size = new System.Drawing.Size(66, 13);
            this.lblNombreAlta.TabIndex = 3;
            this.lblNombreAlta.Text = "Descripcion:";
            this.lblNombreAlta.Click += new System.EventHandler(this.lblNombreAlta_Click);
            // 
            // lblPrecioAlta
            // 
            this.lblPrecioAlta.AutoSize = true;
            this.lblPrecioAlta.Location = new System.Drawing.Point(41, 84);
            this.lblPrecioAlta.Name = "lblPrecioAlta";
            this.lblPrecioAlta.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioAlta.TabIndex = 4;
            this.lblPrecioAlta.Text = "Precio:";
            // 
            // lblIdMod
            // 
            this.lblIdMod.AutoSize = true;
            this.lblIdMod.Location = new System.Drawing.Point(60, 262);
            this.lblIdMod.Name = "lblIdMod";
            this.lblIdMod.Size = new System.Drawing.Size(21, 13);
            this.lblIdMod.TabIndex = 5;
            this.lblIdMod.Text = "ID:";
            // 
            // lblDescripcionMod
            // 
            this.lblDescripcionMod.AutoSize = true;
            this.lblDescripcionMod.Location = new System.Drawing.Point(15, 292);
            this.lblDescripcionMod.Name = "lblDescripcionMod";
            this.lblDescripcionMod.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionMod.TabIndex = 6;
            this.lblDescripcionMod.Text = "Descripcion:";
            // 
            // lblPrecioMod
            // 
            this.lblPrecioMod.AutoSize = true;
            this.lblPrecioMod.Location = new System.Drawing.Point(41, 318);
            this.lblPrecioMod.Name = "lblPrecioMod";
            this.lblPrecioMod.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioMod.TabIndex = 7;
            this.lblPrecioMod.Text = "Precio:";
            // 
            // lblTituloMod
            // 
            this.lblTituloMod.AutoSize = true;
            this.lblTituloMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMod.Location = new System.Drawing.Point(11, 218);
            this.lblTituloMod.Name = "lblTituloMod";
            this.lblTituloMod.Size = new System.Drawing.Size(176, 24);
            this.lblTituloMod.TabIndex = 8;
            this.lblTituloMod.Text = "Modificar Servicio";
            // 
            // txtDescripcionAlta
            // 
            this.txtDescripcionAlta.Location = new System.Drawing.Point(87, 49);
            this.txtDescripcionAlta.Name = "txtDescripcionAlta";
            this.txtDescripcionAlta.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionAlta.TabIndex = 9;
            // 
            // txtPrecioAlta
            // 
            this.txtPrecioAlta.Location = new System.Drawing.Point(87, 84);
            this.txtPrecioAlta.Name = "txtPrecioAlta";
            this.txtPrecioAlta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioAlta.TabIndex = 10;
            // 
            // txtIdMod
            // 
            this.txtIdMod.Enabled = false;
            this.txtIdMod.Location = new System.Drawing.Point(87, 262);
            this.txtIdMod.Name = "txtIdMod";
            this.txtIdMod.Size = new System.Drawing.Size(100, 20);
            this.txtIdMod.TabIndex = 11;
            // 
            // txtDescripcionMod
            // 
            this.txtDescripcionMod.Enabled = false;
            this.txtDescripcionMod.Location = new System.Drawing.Point(87, 289);
            this.txtDescripcionMod.Name = "txtDescripcionMod";
            this.txtDescripcionMod.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionMod.TabIndex = 12;
            // 
            // txtPrecioMod
            // 
            this.txtPrecioMod.Enabled = false;
            this.txtPrecioMod.Location = new System.Drawing.Point(87, 315);
            this.txtPrecioMod.Name = "txtPrecioMod";
            this.txtPrecioMod.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioMod.TabIndex = 13;
            // 
            // lblTituloAlta
            // 
            this.lblTituloAlta.AutoSize = true;
            this.lblTituloAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAlta.Location = new System.Drawing.Point(12, 9);
            this.lblTituloAlta.Name = "lblTituloAlta";
            this.lblTituloAlta.Size = new System.Drawing.Size(126, 24);
            this.lblTituloAlta.TabIndex = 14;
            this.lblTituloAlta.Text = "Alta Servicio";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(33, 181);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptarMod
            // 
            this.btnAceptarMod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptarMod.BackgroundImage")));
            this.btnAceptarMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarMod.Location = new System.Drawing.Point(33, 414);
            this.btnAceptarMod.Name = "btnAceptarMod";
            this.btnAceptarMod.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarMod.TabIndex = 16;
            this.btnAceptarMod.Text = "Aceptar";
            this.btnAceptarMod.UseVisualStyleBackColor = true;
            this.btnAceptarMod.Click += new System.EventHandler(this.btnAceptarMod_Click);
            // 
            // btnCancelarMod
            // 
            this.btnCancelarMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarMod.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarMod.Image")));
            this.btnCancelarMod.Location = new System.Drawing.Point(115, 414);
            this.btnCancelarMod.Name = "btnCancelarMod";
            this.btnCancelarMod.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMod.TabIndex = 17;
            this.btnCancelarMod.Text = "Cancelar";
            this.btnCancelarMod.UseVisualStyleBackColor = true;
            this.btnCancelarMod.Click += new System.EventHandler(this.btnCancelarMod_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(205, 414);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(286, 414);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // rdbPeluqueria
            // 
            this.rdbPeluqueria.AutoSize = true;
            this.rdbPeluqueria.Location = new System.Drawing.Point(92, 120);
            this.rdbPeluqueria.Name = "rdbPeluqueria";
            this.rdbPeluqueria.Size = new System.Drawing.Size(75, 17);
            this.rdbPeluqueria.TabIndex = 20;
            this.rdbPeluqueria.Text = "Peluqueria";
            this.rdbPeluqueria.UseVisualStyleBackColor = true;
            // 
            // rdbVeterinaria
            // 
            this.rdbVeterinaria.AutoSize = true;
            this.rdbVeterinaria.Location = new System.Drawing.Point(92, 143);
            this.rdbVeterinaria.Name = "rdbVeterinaria";
            this.rdbVeterinaria.Size = new System.Drawing.Size(75, 17);
            this.rdbVeterinaria.TabIndex = 21;
            this.rdbVeterinaria.Text = "Veterinaria";
            this.rdbVeterinaria.UseVisualStyleBackColor = true;
            // 
            // lblrubro
            // 
            this.lblrubro.AutoSize = true;
            this.lblrubro.Location = new System.Drawing.Point(42, 122);
            this.lblrubro.Name = "lblrubro";
            this.lblrubro.Size = new System.Drawing.Size(39, 13);
            this.lblrubro.TabIndex = 22;
            this.lblrubro.Text = "Rubro:";
            // 
            // rdbVeterinariaMod
            // 
            this.rdbVeterinariaMod.AutoSize = true;
            this.rdbVeterinariaMod.Enabled = false;
            this.rdbVeterinariaMod.Location = new System.Drawing.Point(87, 379);
            this.rdbVeterinariaMod.Name = "rdbVeterinariaMod";
            this.rdbVeterinariaMod.Size = new System.Drawing.Size(75, 17);
            this.rdbVeterinariaMod.TabIndex = 24;
            this.rdbVeterinariaMod.Text = "Veterinaria";
            this.rdbVeterinariaMod.UseVisualStyleBackColor = true;
            // 
            // rdbPeluqueriaMod
            // 
            this.rdbPeluqueriaMod.AutoSize = true;
            this.rdbPeluqueriaMod.Checked = true;
            this.rdbPeluqueriaMod.Enabled = false;
            this.rdbPeluqueriaMod.Location = new System.Drawing.Point(87, 356);
            this.rdbPeluqueriaMod.Name = "rdbPeluqueriaMod";
            this.rdbPeluqueriaMod.Size = new System.Drawing.Size(75, 17);
            this.rdbPeluqueriaMod.TabIndex = 23;
            this.rdbPeluqueriaMod.TabStop = true;
            this.rdbPeluqueriaMod.Text = "Peluqueria";
            this.rdbPeluqueriaMod.UseVisualStyleBackColor = true;
            // 
            // lblRubroMod
            // 
            this.lblRubroMod.AutoSize = true;
            this.lblRubroMod.Location = new System.Drawing.Point(44, 350);
            this.lblRubroMod.Name = "lblRubroMod";
            this.lblRubroMod.Size = new System.Drawing.Size(39, 13);
            this.lblRubroMod.TabIndex = 25;
            this.lblRubroMod.Text = "Rubro:";
            // 
            // frmAgregarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(458, 462);
            this.Controls.Add(this.lblRubroMod);
            this.Controls.Add(this.rdbVeterinariaMod);
            this.Controls.Add(this.rdbPeluqueriaMod);
            this.Controls.Add(this.lblrubro);
            this.Controls.Add(this.rdbVeterinaria);
            this.Controls.Add(this.rdbPeluqueria);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelarMod);
            this.Controls.Add(this.btnAceptarMod);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTituloAlta);
            this.Controls.Add(this.txtPrecioMod);
            this.Controls.Add(this.txtDescripcionMod);
            this.Controls.Add(this.txtIdMod);
            this.Controls.Add(this.txtPrecioAlta);
            this.Controls.Add(this.txtDescripcionAlta);
            this.Controls.Add(this.lblTituloMod);
            this.Controls.Add(this.lblPrecioMod);
            this.Controls.Add(this.lblDescripcionMod);
            this.Controls.Add(this.lblIdMod);
            this.Controls.Add(this.lblPrecioAlta);
            this.Controls.Add(this.lblNombreAlta);
            this.Controls.Add(this.dgvServicios);
            this.Name = "frmAgregarServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAgregarServicios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.Label lblNombreAlta;
        private System.Windows.Forms.Label lblPrecioAlta;
        private System.Windows.Forms.Label lblIdMod;
        private System.Windows.Forms.Label lblDescripcionMod;
        private System.Windows.Forms.Label lblPrecioMod;
        private System.Windows.Forms.Label lblTituloMod;
        private System.Windows.Forms.TextBox txtDescripcionAlta;
        private System.Windows.Forms.TextBox txtPrecioAlta;
        private System.Windows.Forms.TextBox txtIdMod;
        private System.Windows.Forms.TextBox txtDescripcionMod;
        private System.Windows.Forms.TextBox txtPrecioMod;
        private System.Windows.Forms.Label lblTituloAlta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAceptarMod;
        private System.Windows.Forms.Button btnCancelarMod;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.RadioButton rdbPeluqueria;
        private System.Windows.Forms.RadioButton rdbVeterinaria;
        private System.Windows.Forms.Label lblrubro;
        private System.Windows.Forms.RadioButton rdbVeterinariaMod;
        private System.Windows.Forms.RadioButton rdbPeluqueriaMod;
        private System.Windows.Forms.Label lblRubroMod;
    }
}