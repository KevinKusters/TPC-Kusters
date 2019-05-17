namespace PresentacionWindows
{
    partial class frmListaRazas
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
            this.dgvListaRazas = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtNombreAgr = new System.Windows.Forms.TextBox();
            this.lblAgregarRaza = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblMod = new System.Windows.Forms.Label();
            this.txtnombreMod = new System.Windows.Forms.TextBox();
            this.lblNombreMod = new System.Windows.Forms.Label();
            this.btnModificarSelect = new System.Windows.Forms.Button();
            this.btnaceptarMod = new System.Windows.Forms.Button();
            this.lblIdRaza = new System.Windows.Forms.Label();
            this.txtIdRaza = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRazas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaRazas
            // 
            this.dgvListaRazas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaRazas.Location = new System.Drawing.Point(267, 12);
            this.dgvListaRazas.Name = "dgvListaRazas";
            this.dgvListaRazas.Size = new System.Drawing.Size(234, 340);
            this.dgvListaRazas.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(16, 273);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(245, 27);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar todas";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtNombreAgr
            // 
            this.txtNombreAgr.Location = new System.Drawing.Point(123, 50);
            this.txtNombreAgr.Name = "txtNombreAgr";
            this.txtNombreAgr.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAgr.TabIndex = 2;
            // 
            // lblAgregarRaza
            // 
            this.lblAgregarRaza.AutoSize = true;
            this.lblAgregarRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarRaza.Location = new System.Drawing.Point(12, 12);
            this.lblAgregarRaza.Name = "lblAgregarRaza";
            this.lblAgregarRaza.Size = new System.Drawing.Size(120, 20);
            this.lblAgregarRaza.TabIndex = 3;
            this.lblAgregarRaza.Text = "Agregar Raza";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre de raza:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(133, 76);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMod.Location = new System.Drawing.Point(12, 144);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(129, 20);
            this.lblMod.TabIndex = 7;
            this.lblMod.Text = "Modificar Raza";
            // 
            // txtnombreMod
            // 
            this.txtnombreMod.Location = new System.Drawing.Point(123, 198);
            this.txtnombreMod.Name = "txtnombreMod";
            this.txtnombreMod.Size = new System.Drawing.Size(100, 20);
            this.txtnombreMod.TabIndex = 8;
            // 
            // lblNombreMod
            // 
            this.lblNombreMod.AutoSize = true;
            this.lblNombreMod.Location = new System.Drawing.Point(32, 201);
            this.lblNombreMod.Name = "lblNombreMod";
            this.lblNombreMod.Size = new System.Drawing.Size(85, 13);
            this.lblNombreMod.TabIndex = 9;
            this.lblNombreMod.Text = "Nombre de raza:";
            // 
            // btnModificarSelect
            // 
            this.btnModificarSelect.Location = new System.Drawing.Point(16, 306);
            this.btnModificarSelect.Name = "btnModificarSelect";
            this.btnModificarSelect.Size = new System.Drawing.Size(245, 27);
            this.btnModificarSelect.TabIndex = 10;
            this.btnModificarSelect.Text = "Modificar";
            this.btnModificarSelect.UseVisualStyleBackColor = true;
            this.btnModificarSelect.Click += new System.EventHandler(this.btnModificarSelect_Click);
            // 
            // btnaceptarMod
            // 
            this.btnaceptarMod.Location = new System.Drawing.Point(133, 224);
            this.btnaceptarMod.Name = "btnaceptarMod";
            this.btnaceptarMod.Size = new System.Drawing.Size(90, 23);
            this.btnaceptarMod.TabIndex = 11;
            this.btnaceptarMod.Text = "Aceptar";
            this.btnaceptarMod.UseVisualStyleBackColor = true;
            this.btnaceptarMod.Click += new System.EventHandler(this.btnaceptarMod_Click);
            // 
            // lblIdRaza
            // 
            this.lblIdRaza.AutoSize = true;
            this.lblIdRaza.Location = new System.Drawing.Point(58, 175);
            this.lblIdRaza.Name = "lblIdRaza";
            this.lblIdRaza.Size = new System.Drawing.Size(59, 13);
            this.lblIdRaza.TabIndex = 12;
            this.lblIdRaza.Text = "ID de raza:";
            // 
            // txtIdRaza
            // 
            this.txtIdRaza.Enabled = false;
            this.txtIdRaza.Location = new System.Drawing.Point(123, 172);
            this.txtIdRaza.Name = "txtIdRaza";
            this.txtIdRaza.Size = new System.Drawing.Size(100, 20);
            this.txtIdRaza.TabIndex = 13;
            // 
            // frmListaRazas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 364);
            this.Controls.Add(this.txtIdRaza);
            this.Controls.Add(this.lblIdRaza);
            this.Controls.Add(this.btnaceptarMod);
            this.Controls.Add(this.btnModificarSelect);
            this.Controls.Add(this.lblNombreMod);
            this.Controls.Add(this.txtnombreMod);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAgregarRaza);
            this.Controls.Add(this.txtNombreAgr);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvListaRazas);
            this.Name = "frmListaRazas";
            this.Text = "frmListaRazas";
            this.Load += new System.EventHandler(this.frmListaRazas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRazas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaRazas;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtNombreAgr;
        private System.Windows.Forms.Label lblAgregarRaza;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.TextBox txtnombreMod;
        private System.Windows.Forms.Label lblNombreMod;
        private System.Windows.Forms.Button btnModificarSelect;
        private System.Windows.Forms.Button btnaceptarMod;
        private System.Windows.Forms.Label lblIdRaza;
        private System.Windows.Forms.TextBox txtIdRaza;
    }
}