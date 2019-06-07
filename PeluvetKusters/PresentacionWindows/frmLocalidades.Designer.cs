namespace PresentacionWindows
{
    partial class frmLocalidades
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
            this.txtNombreLoc = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvLocalidades = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAcepotarmod = new System.Windows.Forms.Button();
            this.lblNombreLocMod = new System.Windows.Forms.Label();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.lblIDmod = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreLoc
            // 
            this.txtNombreLoc.Location = new System.Drawing.Point(12, 75);
            this.txtNombreLoc.Name = "txtNombreLoc";
            this.txtNombreLoc.Size = new System.Drawing.Size(150, 20);
            this.txtNombreLoc.TabIndex = 0;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(12, 52);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(107, 13);
            this.lblLocalidad.TabIndex = 1;
            this.lblLocalidad.Text = "Nombre de localidad:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 101);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvLocalidades
            // 
            this.dgvLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalidades.Location = new System.Drawing.Point(232, 12);
            this.dgvLocalidades.Name = "dgvLocalidades";
            this.dgvLocalidades.Size = new System.Drawing.Size(193, 397);
            this.dgvLocalidades.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(175, 24);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Agregar localidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Modificar localidad";
            // 
            // btnAcepotarmod
            // 
            this.btnAcepotarmod.Location = new System.Drawing.Point(15, 322);
            this.btnAcepotarmod.Name = "btnAcepotarmod";
            this.btnAcepotarmod.Size = new System.Drawing.Size(75, 23);
            this.btnAcepotarmod.TabIndex = 8;
            this.btnAcepotarmod.Text = "Aceptar";
            this.btnAcepotarmod.UseVisualStyleBackColor = true;
            this.btnAcepotarmod.Click += new System.EventHandler(this.btnAcepotarmod_Click);
            // 
            // lblNombreLocMod
            // 
            this.lblNombreLocMod.AutoSize = true;
            this.lblNombreLocMod.Location = new System.Drawing.Point(12, 273);
            this.lblNombreLocMod.Name = "lblNombreLocMod";
            this.lblNombreLocMod.Size = new System.Drawing.Size(107, 13);
            this.lblNombreLocMod.TabIndex = 7;
            this.lblNombreLocMod.Text = "Nombre de localidad:";
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Enabled = false;
            this.txtNombreMod.Location = new System.Drawing.Point(15, 296);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(150, 20);
            this.txtNombreMod.TabIndex = 6;
            // 
            // lblIDmod
            // 
            this.lblIDmod.AutoSize = true;
            this.lblIDmod.Location = new System.Drawing.Point(12, 240);
            this.lblIDmod.Name = "lblIDmod";
            this.lblIDmod.Size = new System.Drawing.Size(21, 13);
            this.lblIDmod.TabIndex = 9;
            this.lblIDmod.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(39, 237);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(22, 20);
            this.txtID.TabIndex = 10;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(232, 415);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblIDmod);
            this.Controls.Add(this.btnAcepotarmod);
            this.Controls.Add(this.lblNombreLocMod);
            this.Controls.Add(this.txtNombreMod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvLocalidades);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.txtNombreLoc);
            this.Name = "frmLocalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLocalidades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreLoc;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvLocalidades;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAcepotarmod;
        private System.Windows.Forms.Label lblNombreLocMod;
        private System.Windows.Forms.TextBox txtNombreMod;
        private System.Windows.Forms.Label lblIDmod;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnModificar;
    }
}