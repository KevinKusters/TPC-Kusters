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
            ((System.ComponentModel.ISupportInitialize)(this.dgbAgregarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbAgregarCliente
            // 
            this.dgbAgregarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbAgregarCliente.Location = new System.Drawing.Point(268, 14);
            this.dgbAgregarCliente.Name = "dgbAgregarCliente";
            this.dgbAgregarCliente.Size = new System.Drawing.Size(445, 397);
            this.dgbAgregarCliente.TabIndex = 81;
            this.dgbAgregarCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbAgregarCliente_CellContentClick);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(514, 421);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(93, 23);
            this.btnmodificar.TabIndex = 72;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
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
            this.btnAgregarMascota.Location = new System.Drawing.Point(613, 421);
            this.btnAgregarMascota.Name = "btnAgregarMascota";
            this.btnAgregarMascota.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarMascota.TabIndex = 84;
            this.btnAgregarMascota.Text = "Agregar mascota";
            this.btnAgregarMascota.UseVisualStyleBackColor = true;
            this.btnAgregarMascota.Click += new System.EventHandler(this.btnAgregarMascota_Click);
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(733, 464);
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
    }
}