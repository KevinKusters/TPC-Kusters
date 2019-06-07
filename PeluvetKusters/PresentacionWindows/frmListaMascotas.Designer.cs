namespace PresentacionWindows
{
    partial class frmListaMascotas
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblMascotas = new System.Windows.Forms.Label();
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(11, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 13);
            this.lblID.TabIndex = 126;
            this.lblID.Text = "ID cliente:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(82, 22);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(27, 20);
            this.txtID.TabIndex = 125;
            // 
            // lblMascotas
            // 
            this.lblMascotas.AutoSize = true;
            this.lblMascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascotas.Location = new System.Drawing.Point(-1, 61);
            this.lblMascotas.Name = "lblMascotas";
            this.lblMascotas.Size = new System.Drawing.Size(124, 13);
            this.lblMascotas.TabIndex = 124;
            this.lblMascotas.Text = "Mascotas del cliente";
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Location = new System.Drawing.Point(2, 77);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.Size = new System.Drawing.Size(564, 292);
            this.dgvMascotas.TabIndex = 123;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(428, 22);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.ReadOnly = true;
            this.txtapellido.Size = new System.Drawing.Size(127, 20);
            this.txtapellido.TabIndex = 122;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(366, 25);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 13);
            this.lblApellido.TabIndex = 121;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(232, 22);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.ReadOnly = true;
            this.txtnombre.Size = new System.Drawing.Size(128, 20);
            this.txtnombre.TabIndex = 120;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(130, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(96, 13);
            this.lblNombre.TabIndex = 119;
            this.lblNombre.Text = "Nombre cliente:";
            // 
            // frmListaMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 372);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblMascotas);
            this.Controls.Add(this.dgvMascotas);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmListaMascotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmListaMascotas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblMascotas;
        private System.Windows.Forms.DataGridView dgvMascotas;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblNombre;
    }
}