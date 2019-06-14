namespace PresentacionWindows
{
    partial class frmGanancias
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
            this.dgvGananciasXmes = new System.Windows.Forms.DataGridView();
            this.txtGananciasHoy = new System.Windows.Forms.TextBox();
            this.lblGananciasHoy = new System.Windows.Forms.Label();
            this.lblGananciasXmes = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGananciasXmes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGananciasXmes
            // 
            this.dgvGananciasXmes.AllowUserToAddRows = false;
            this.dgvGananciasXmes.AllowUserToDeleteRows = false;
            this.dgvGananciasXmes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGananciasXmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGananciasXmes.Location = new System.Drawing.Point(186, 34);
            this.dgvGananciasXmes.Name = "dgvGananciasXmes";
            this.dgvGananciasXmes.ReadOnly = true;
            this.dgvGananciasXmes.Size = new System.Drawing.Size(390, 404);
            this.dgvGananciasXmes.TabIndex = 0;
            // 
            // txtGananciasHoy
            // 
            this.txtGananciasHoy.Location = new System.Drawing.Point(12, 46);
            this.txtGananciasHoy.Name = "txtGananciasHoy";
            this.txtGananciasHoy.ReadOnly = true;
            this.txtGananciasHoy.Size = new System.Drawing.Size(142, 20);
            this.txtGananciasHoy.TabIndex = 1;
            // 
            // lblGananciasHoy
            // 
            this.lblGananciasHoy.AutoSize = true;
            this.lblGananciasHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGananciasHoy.Location = new System.Drawing.Point(8, 9);
            this.lblGananciasHoy.Name = "lblGananciasHoy";
            this.lblGananciasHoy.Size = new System.Drawing.Size(162, 24);
            this.lblGananciasHoy.TabIndex = 2;
            this.lblGananciasHoy.Text = "Ganancias de hoy";
            // 
            // lblGananciasXmes
            // 
            this.lblGananciasXmes.AutoSize = true;
            this.lblGananciasXmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGananciasXmes.Location = new System.Drawing.Point(278, 7);
            this.lblGananciasXmes.Name = "lblGananciasXmes";
            this.lblGananciasXmes.Size = new System.Drawing.Size(173, 24);
            this.lblGananciasXmes.TabIndex = 3;
            this.lblGananciasXmes.Text = "Ganancias por mes";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrar.Location = new System.Drawing.Point(42, 103);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 40);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblGananciasXmes);
            this.Controls.Add(this.lblGananciasHoy);
            this.Controls.Add(this.txtGananciasHoy);
            this.Controls.Add(this.dgvGananciasXmes);
            this.Name = "frmGanancias";
            this.Text = "frmGanancias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGananciasXmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGananciasXmes;
        private System.Windows.Forms.TextBox txtGananciasHoy;
        private System.Windows.Forms.Label lblGananciasHoy;
        private System.Windows.Forms.Label lblGananciasXmes;
        private System.Windows.Forms.Button btnCerrar;
    }
}