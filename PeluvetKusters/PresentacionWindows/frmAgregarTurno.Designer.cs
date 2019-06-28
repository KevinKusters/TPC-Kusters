namespace PresentacionWindows
{
    partial class frmAgregarTurno
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
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblMascota = new System.Windows.Forms.Label();
            this.lblservicio = new System.Windows.Forms.Label();
            this.lblfechaturn = new System.Windows.Forms.Label();
            this.lblraza = new System.Windows.Forms.Label();
            this.lblapellidomasc = new System.Windows.Forms.Label();
            this.lblnombremasc = new System.Windows.Forms.Label();
            this.lblapellidocli = new System.Windows.Forms.Label();
            this.txtraza = new System.Windows.Forms.TextBox();
            this.lblnombrecli = new System.Windows.Forms.Label();
            this.cbmservicio = new System.Windows.Forms.ComboBox();
            this.txtapellidomasc = new System.Windows.Forms.TextBox();
            this.txtnombremasc = new System.Windows.Forms.TextBox();
            this.txtapellidocli = new System.Windows.Forms.TextBox();
            this.txtnombrecli = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblIDcliente = new System.Windows.Forms.Label();
            this.txtIDcliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.lblEspecia = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtFechaTurno = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.dgvempleados = new System.Windows.Forms.DataGridView();
            this.rdbPeluqueria = new System.Windows.Forms.RadioButton();
            this.rdbVeterinaria = new System.Windows.Forms.RadioButton();
            this.lblIDAnimal = new System.Windows.Forms.Label();
            this.txtIDmascota = new System.Windows.Forms.TextBox();
            this.lblRubro = new System.Windows.Forms.Label();
            this.txtHoraFinalizacionTurno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(177, 454);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(65, 20);
            this.txtCosto.TabIndex = 67;
            this.txtCosto.TextChanged += new System.EventHandler(this.txtCosto_TextChanged);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(136, 457);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(43, 13);
            this.lblCosto.TabIndex = 66;
            this.lblCosto.Text = "Precio: ";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(11, 92);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(79, 25);
            this.lblCliente.TabIndex = 63;
            this.lblCliente.Text = "Cliente";
            // 
            // lblMascota
            // 
            this.lblMascota.AutoSize = true;
            this.lblMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascota.Location = new System.Drawing.Point(11, 226);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(94, 25);
            this.lblMascota.TabIndex = 62;
            this.lblMascota.Text = "Mascota";
            // 
            // lblservicio
            // 
            this.lblservicio.AutoSize = true;
            this.lblservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservicio.Location = new System.Drawing.Point(11, 399);
            this.lblservicio.Name = "lblservicio";
            this.lblservicio.Size = new System.Drawing.Size(95, 25);
            this.lblservicio.TabIndex = 61;
            this.lblservicio.Text = "Servicio ";
            // 
            // lblfechaturn
            // 
            this.lblfechaturn.AutoSize = true;
            this.lblfechaturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechaturn.Location = new System.Drawing.Point(277, 16);
            this.lblfechaturn.Name = "lblfechaturn";
            this.lblfechaturn.Size = new System.Drawing.Size(72, 25);
            this.lblfechaturn.TabIndex = 60;
            this.lblfechaturn.Text = "Fecha";
            // 
            // lblraza
            // 
            this.lblraza.AutoSize = true;
            this.lblraza.Location = new System.Drawing.Point(36, 358);
            this.lblraza.Name = "lblraza";
            this.lblraza.Size = new System.Drawing.Size(38, 13);
            this.lblraza.TabIndex = 59;
            this.lblraza.Text = "Raza: ";
            // 
            // lblapellidomasc
            // 
            this.lblapellidomasc.AutoSize = true;
            this.lblapellidomasc.Location = new System.Drawing.Point(26, 314);
            this.lblapellidomasc.Name = "lblapellidomasc";
            this.lblapellidomasc.Size = new System.Drawing.Size(50, 13);
            this.lblapellidomasc.TabIndex = 58;
            this.lblapellidomasc.Text = "Apellido: ";
            // 
            // lblnombremasc
            // 
            this.lblnombremasc.AutoSize = true;
            this.lblnombremasc.Location = new System.Drawing.Point(26, 291);
            this.lblnombremasc.Name = "lblnombremasc";
            this.lblnombremasc.Size = new System.Drawing.Size(50, 13);
            this.lblnombremasc.TabIndex = 57;
            this.lblnombremasc.Text = "Nombre: ";
            // 
            // lblapellidocli
            // 
            this.lblapellidocli.AutoSize = true;
            this.lblapellidocli.Location = new System.Drawing.Point(26, 179);
            this.lblapellidocli.Name = "lblapellidocli";
            this.lblapellidocli.Size = new System.Drawing.Size(50, 13);
            this.lblapellidocli.TabIndex = 56;
            this.lblapellidocli.Text = "Apellido: ";
            // 
            // txtraza
            // 
            this.txtraza.Location = new System.Drawing.Point(94, 355);
            this.txtraza.Name = "txtraza";
            this.txtraza.ReadOnly = true;
            this.txtraza.Size = new System.Drawing.Size(146, 20);
            this.txtraza.TabIndex = 55;
            // 
            // lblnombrecli
            // 
            this.lblnombrecli.AutoSize = true;
            this.lblnombrecli.Location = new System.Drawing.Point(28, 153);
            this.lblnombrecli.Name = "lblnombrecli";
            this.lblnombrecli.Size = new System.Drawing.Size(50, 13);
            this.lblnombrecli.TabIndex = 54;
            this.lblnombrecli.Text = "Nombre: ";
            // 
            // cbmservicio
            // 
            this.cbmservicio.FormattingEnabled = true;
            this.cbmservicio.Location = new System.Drawing.Point(43, 427);
            this.cbmservicio.Name = "cbmservicio";
            this.cbmservicio.Size = new System.Drawing.Size(199, 21);
            this.cbmservicio.TabIndex = 53;
            this.cbmservicio.SelectedIndexChanged += new System.EventHandler(this.cbmservicio_SelectedIndexChanged);
            // 
            // txtapellidomasc
            // 
            this.txtapellidomasc.Location = new System.Drawing.Point(94, 311);
            this.txtapellidomasc.Name = "txtapellidomasc";
            this.txtapellidomasc.ReadOnly = true;
            this.txtapellidomasc.Size = new System.Drawing.Size(146, 20);
            this.txtapellidomasc.TabIndex = 51;
            // 
            // txtnombremasc
            // 
            this.txtnombremasc.Location = new System.Drawing.Point(94, 288);
            this.txtnombremasc.Name = "txtnombremasc";
            this.txtnombremasc.ReadOnly = true;
            this.txtnombremasc.Size = new System.Drawing.Size(146, 20);
            this.txtnombremasc.TabIndex = 50;
            // 
            // txtapellidocli
            // 
            this.txtapellidocli.Location = new System.Drawing.Point(96, 176);
            this.txtapellidocli.Name = "txtapellidocli";
            this.txtapellidocli.ReadOnly = true;
            this.txtapellidocli.Size = new System.Drawing.Size(146, 20);
            this.txtapellidocli.TabIndex = 49;
            // 
            // txtnombrecli
            // 
            this.txtnombrecli.Location = new System.Drawing.Point(96, 150);
            this.txtnombrecli.Name = "txtnombrecli";
            this.txtnombrecli.ReadOnly = true;
            this.txtnombrecli.Size = new System.Drawing.Size(146, 20);
            this.txtnombrecli.TabIndex = 48;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(434, 454);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Location = new System.Drawing.Point(326, 454);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 23);
            this.btnAgregar.TabIndex = 46;
            this.btnAgregar.Text = "Agregar turno";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblIDcliente
            // 
            this.lblIDcliente.AutoSize = true;
            this.lblIDcliente.Location = new System.Drawing.Point(28, 129);
            this.lblIDcliente.Name = "lblIDcliente";
            this.lblIDcliente.Size = new System.Drawing.Size(55, 13);
            this.lblIDcliente.TabIndex = 77;
            this.lblIDcliente.Text = "ID cliente:";
            // 
            // txtIDcliente
            // 
            this.txtIDcliente.Location = new System.Drawing.Point(96, 126);
            this.txtIDcliente.Name = "txtIDcliente";
            this.txtIDcliente.ReadOnly = true;
            this.txtIDcliente.Size = new System.Drawing.Size(40, 20);
            this.txtIDcliente.TabIndex = 78;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 79;
            this.button1.Text = "Buscar en lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 80;
            this.button2.Text = "Buscar en lista";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(94, 333);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.ReadOnly = true;
            this.txtEspecie.Size = new System.Drawing.Size(146, 20);
            this.txtEspecie.TabIndex = 81;
            // 
            // lblEspecia
            // 
            this.lblEspecia.AutoSize = true;
            this.lblEspecia.Location = new System.Drawing.Point(26, 336);
            this.lblEspecia.Name = "lblEspecia";
            this.lblEspecia.Size = new System.Drawing.Size(48, 13);
            this.lblEspecia.TabIndex = 82;
            this.lblEspecia.Text = "Especie:";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(282, 50);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(200, 20);
            this.DtpFecha.TabIndex = 83;
            this.DtpFecha.ValueChanged += new System.EventHandler(this.DtpFecha_ValueChanged);
            // 
            // txtFechaTurno
            // 
            this.txtFechaTurno.Location = new System.Drawing.Point(282, 76);
            this.txtFechaTurno.Name = "txtFechaTurno";
            this.txtFechaTurno.ReadOnly = true;
            this.txtFechaTurno.Size = new System.Drawing.Size(102, 20);
            this.txtFechaTurno.TabIndex = 84;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAviso.Location = new System.Drawing.Point(278, 122);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(214, 20);
            this.lblAviso.TabIndex = 88;
            this.lblAviso.Text = "*La hora ya esta ocupada";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(384, 76);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(98, 20);
            this.txtHora.TabIndex = 89;
            this.txtHora.TextChanged += new System.EventHandler(this.txtHora_TextChanged);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(278, 227);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(115, 24);
            this.lblEmpleado.TabIndex = 90;
            this.lblEmpleado.Text = "Empleados";
            // 
            // dgvempleados
            // 
            this.dgvempleados.AllowUserToAddRows = false;
            this.dgvempleados.AllowUserToDeleteRows = false;
            this.dgvempleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleados.Location = new System.Drawing.Point(272, 265);
            this.dgvempleados.Name = "dgvempleados";
            this.dgvempleados.ReadOnly = true;
            this.dgvempleados.Size = new System.Drawing.Size(245, 174);
            this.dgvempleados.TabIndex = 91;
            // 
            // rdbPeluqueria
            // 
            this.rdbPeluqueria.AutoSize = true;
            this.rdbPeluqueria.Checked = true;
            this.rdbPeluqueria.Location = new System.Drawing.Point(25, 51);
            this.rdbPeluqueria.Name = "rdbPeluqueria";
            this.rdbPeluqueria.Size = new System.Drawing.Size(75, 17);
            this.rdbPeluqueria.TabIndex = 92;
            this.rdbPeluqueria.TabStop = true;
            this.rdbPeluqueria.Text = "Peluqueria";
            this.rdbPeluqueria.UseVisualStyleBackColor = true;
            this.rdbPeluqueria.CheckedChanged += new System.EventHandler(this.rdbPeluqueria_CheckedChanged);
            // 
            // rdbVeterinaria
            // 
            this.rdbVeterinaria.AutoSize = true;
            this.rdbVeterinaria.Location = new System.Drawing.Point(127, 53);
            this.rdbVeterinaria.Name = "rdbVeterinaria";
            this.rdbVeterinaria.Size = new System.Drawing.Size(75, 17);
            this.rdbVeterinaria.TabIndex = 93;
            this.rdbVeterinaria.Text = "Veterinaria";
            this.rdbVeterinaria.UseVisualStyleBackColor = true;
            this.rdbVeterinaria.CheckedChanged += new System.EventHandler(this.rdbVeterinaria_CheckedChanged);
            // 
            // lblIDAnimal
            // 
            this.lblIDAnimal.AutoSize = true;
            this.lblIDAnimal.Location = new System.Drawing.Point(13, 268);
            this.lblIDAnimal.Name = "lblIDAnimal";
            this.lblIDAnimal.Size = new System.Drawing.Size(64, 13);
            this.lblIDAnimal.TabIndex = 95;
            this.lblIDAnimal.Text = "ID mascota:";
            // 
            // txtIDmascota
            // 
            this.txtIDmascota.Location = new System.Drawing.Point(94, 265);
            this.txtIDmascota.Name = "txtIDmascota";
            this.txtIDmascota.ReadOnly = true;
            this.txtIDmascota.Size = new System.Drawing.Size(24, 20);
            this.txtIDmascota.TabIndex = 94;
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubro.Location = new System.Drawing.Point(16, 16);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(62, 24);
            this.lblRubro.TabIndex = 96;
            this.lblRubro.Text = "Rubro";
            // 
            // txtHoraFinalizacionTurno
            // 
            this.txtHoraFinalizacionTurno.Location = new System.Drawing.Point(384, 97);
            this.txtHoraFinalizacionTurno.Name = "txtHoraFinalizacionTurno";
            this.txtHoraFinalizacionTurno.ReadOnly = true;
            this.txtHoraFinalizacionTurno.Size = new System.Drawing.Size(98, 20);
            this.txtHoraFinalizacionTurno.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Hora Finalizacion:";
            // 
            // frmAgregarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoraFinalizacionTurno);
            this.Controls.Add(this.lblRubro);
            this.Controls.Add(this.lblIDAnimal);
            this.Controls.Add(this.txtIDmascota);
            this.Controls.Add(this.rdbVeterinaria);
            this.Controls.Add(this.rdbPeluqueria);
            this.Controls.Add(this.dgvempleados);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtFechaTurno);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.lblEspecia);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIDcliente);
            this.Controls.Add(this.lblIDcliente);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblMascota);
            this.Controls.Add(this.lblservicio);
            this.Controls.Add(this.lblfechaturn);
            this.Controls.Add(this.lblraza);
            this.Controls.Add(this.lblapellidomasc);
            this.Controls.Add(this.lblnombremasc);
            this.Controls.Add(this.lblapellidocli);
            this.Controls.Add(this.txtraza);
            this.Controls.Add(this.lblnombrecli);
            this.Controls.Add(this.cbmservicio);
            this.Controls.Add(this.txtapellidomasc);
            this.Controls.Add(this.txtnombremasc);
            this.Controls.Add(this.txtapellidocli);
            this.Controls.Add(this.txtnombrecli);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmAgregarTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAgregarTurno";
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblMascota;
        private System.Windows.Forms.Label lblservicio;
        private System.Windows.Forms.Label lblfechaturn;
        private System.Windows.Forms.Label lblraza;
        private System.Windows.Forms.Label lblapellidomasc;
        private System.Windows.Forms.Label lblnombremasc;
        private System.Windows.Forms.Label lblapellidocli;
        private System.Windows.Forms.Label lblnombrecli;
        private System.Windows.Forms.ComboBox cbmservicio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblIDcliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtraza;
        public System.Windows.Forms.TextBox txtapellidomasc;
        public System.Windows.Forms.TextBox txtnombremasc;
        public System.Windows.Forms.TextBox txtapellidocli;
        public System.Windows.Forms.TextBox txtnombrecli;
        public System.Windows.Forms.TextBox txtIDcliente;
        public System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label lblEspecia;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.TextBox txtFechaTurno;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.DataGridView dgvempleados;
        private System.Windows.Forms.RadioButton rdbPeluqueria;
        private System.Windows.Forms.RadioButton rdbVeterinaria;
        private System.Windows.Forms.Label lblIDAnimal;
        public System.Windows.Forms.TextBox txtIDmascota;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.TextBox txtHoraFinalizacionTurno;
        private System.Windows.Forms.Label label1;
    }
}