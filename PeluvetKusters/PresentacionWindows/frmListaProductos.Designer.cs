﻿namespace PresentacionWindows
{
    partial class frmListaProductos
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
            this.dgvListaProd = new System.Windows.Forms.DataGridView();
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnCancelarMod = new System.Windows.Forms.Button();
            this.btnModAceptar = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelarAgregado = new System.Windows.Forms.Button();
            this.txtMarcaAgregar = new System.Windows.Forms.TextBox();
            this.txtNombreAgregar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAgregarProd = new System.Windows.Forms.Label();
            this.lblModProd = new System.Windows.Forms.Label();
            this.btnAceptarAgregar = new System.Windows.Forms.Button();
            this.txtStockAgregar = new System.Windows.Forms.TextBox();
            this.txtPrecioAgregar = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cbxProveedores = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProd
            // 
            this.dgvListaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProd.Location = new System.Drawing.Point(244, 12);
            this.dgvListaProd.Name = "dgvListaProd";
            this.dgvListaProd.Size = new System.Drawing.Size(435, 492);
            this.dgvListaProd.TabIndex = 0;
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.Location = new System.Drawing.Point(244, 525);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(84, 23);
            this.btnListarTodos.TabIndex = 1;
            this.btnListarTodos.Text = "Refrescar lista";
            this.btnListarTodos.UseVisualStyleBackColor = true;
            this.btnListarTodos.Click += new System.EventHandler(this.btnListarTodos_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(334, 525);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(103, 484);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(114, 20);
            this.txtStock.TabIndex = 38;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(103, 447);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(114, 20);
            this.txtPrecio.TabIndex = 37;
            // 
            // txtIdProd
            // 
            this.txtIdProd.Enabled = false;
            this.txtIdProd.Location = new System.Drawing.Point(103, 333);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(114, 20);
            this.txtIdProd.TabIndex = 36;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(17, 336);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(83, 13);
            this.lblID.TabIndex = 35;
            this.lblID.Text = "ID del producto:";
            // 
            // btnCancelarMod
            // 
            this.btnCancelarMod.Location = new System.Drawing.Point(142, 523);
            this.btnCancelarMod.Name = "btnCancelarMod";
            this.btnCancelarMod.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMod.TabIndex = 34;
            this.btnCancelarMod.Text = "Cancelar";
            this.btnCancelarMod.UseVisualStyleBackColor = true;
            this.btnCancelarMod.Click += new System.EventHandler(this.btnCancelarMod_Click);
            // 
            // btnModAceptar
            // 
            this.btnModAceptar.Location = new System.Drawing.Point(47, 523);
            this.btnModAceptar.Name = "btnModAceptar";
            this.btnModAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnModAceptar.TabIndex = 33;
            this.btnModAceptar.Text = "Aceptar";
            this.btnModAceptar.UseVisualStyleBackColor = true;
            this.btnModAceptar.Click += new System.EventHandler(this.btnModAceptar_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(103, 415);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(114, 20);
            this.txtMarca.TabIndex = 32;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(103, 384);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(114, 20);
            this.txtNombre.TabIndex = 31;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(43, 450);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 30;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(43, 487);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 29;
            this.lblStock.Text = "Stock:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(43, 418);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 28;
            this.lblMarca.Text = "Marca:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(43, 387);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnCancelarAgregado
            // 
            this.btnCancelarAgregado.Location = new System.Drawing.Point(142, 237);
            this.btnCancelarAgregado.Name = "btnCancelarAgregado";
            this.btnCancelarAgregado.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAgregado.TabIndex = 46;
            this.btnCancelarAgregado.Text = "Cancelar";
            this.btnCancelarAgregado.UseVisualStyleBackColor = true;
            this.btnCancelarAgregado.Click += new System.EventHandler(this.btnCancelarAgregado_Click);
            // 
            // txtMarcaAgregar
            // 
            this.txtMarcaAgregar.Location = new System.Drawing.Point(96, 86);
            this.txtMarcaAgregar.Name = "txtMarcaAgregar";
            this.txtMarcaAgregar.Size = new System.Drawing.Size(121, 20);
            this.txtMarcaAgregar.TabIndex = 44;
            // 
            // txtNombreAgregar
            // 
            this.txtNombreAgregar.Location = new System.Drawing.Point(96, 55);
            this.txtNombreAgregar.Name = "txtNombreAgregar";
            this.txtNombreAgregar.Size = new System.Drawing.Size(121, 20);
            this.txtNombreAgregar.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Nombre:";
            // 
            // lblAgregarProd
            // 
            this.lblAgregarProd.AutoSize = true;
            this.lblAgregarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProd.Location = new System.Drawing.Point(12, 12);
            this.lblAgregarProd.Name = "lblAgregarProd";
            this.lblAgregarProd.Size = new System.Drawing.Size(175, 24);
            this.lblAgregarProd.TabIndex = 49;
            this.lblAgregarProd.Text = "Agregar Producto";
            // 
            // lblModProd
            // 
            this.lblModProd.AutoSize = true;
            this.lblModProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModProd.Location = new System.Drawing.Point(12, 304);
            this.lblModProd.Name = "lblModProd";
            this.lblModProd.Size = new System.Drawing.Size(185, 24);
            this.lblModProd.TabIndex = 50;
            this.lblModProd.Text = "Modificar Producto";
            // 
            // btnAceptarAgregar
            // 
            this.btnAceptarAgregar.Location = new System.Drawing.Point(47, 237);
            this.btnAceptarAgregar.Name = "btnAceptarAgregar";
            this.btnAceptarAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarAgregar.TabIndex = 51;
            this.btnAceptarAgregar.Text = "Aceptar";
            this.btnAceptarAgregar.UseVisualStyleBackColor = true;
            this.btnAceptarAgregar.Click += new System.EventHandler(this.btnAceptarAgregar_Click);
            // 
            // txtStockAgregar
            // 
            this.txtStockAgregar.Location = new System.Drawing.Point(96, 158);
            this.txtStockAgregar.Name = "txtStockAgregar";
            this.txtStockAgregar.Size = new System.Drawing.Size(121, 20);
            this.txtStockAgregar.TabIndex = 52;
            // 
            // txtPrecioAgregar
            // 
            this.txtPrecioAgregar.Location = new System.Drawing.Point(96, 121);
            this.txtPrecioAgregar.Name = "txtPrecioAgregar";
            this.txtPrecioAgregar.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioAgregar.TabIndex = 53;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(17, 195);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(59, 13);
            this.lblProveedor.TabIndex = 55;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // cbxProveedores
            // 
            this.cbxProveedores.FormattingEnabled = true;
            this.cbxProveedores.Location = new System.Drawing.Point(96, 192);
            this.cbxProveedores.Name = "cbxProveedores";
            this.cbxProveedores.Size = new System.Drawing.Size(121, 21);
            this.cbxProveedores.TabIndex = 56;
            this.cbxProveedores.SelectedIndexChanged += new System.EventHandler(this.cbxProveedores_SelectedIndexChanged);
            // 
            // frmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 560);
            this.Controls.Add(this.cbxProveedores);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.txtPrecioAgregar);
            this.Controls.Add(this.txtStockAgregar);
            this.Controls.Add(this.btnAceptarAgregar);
            this.Controls.Add(this.lblModProd);
            this.Controls.Add(this.lblAgregarProd);
            this.Controls.Add(this.btnCancelarAgregado);
            this.Controls.Add(this.txtMarcaAgregar);
            this.Controls.Add(this.txtNombreAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancelarMod);
            this.Controls.Add(this.btnModAceptar);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnListarTodos);
            this.Controls.Add(this.dgvListaProd);
            this.Name = "frmListaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaProductos";
            this.Load += new System.EventHandler(this.frmListaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProd;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnCancelarMod;
        private System.Windows.Forms.Button btnModAceptar;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelarAgregado;
        private System.Windows.Forms.TextBox txtMarcaAgregar;
        private System.Windows.Forms.TextBox txtNombreAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAgregarProd;
        private System.Windows.Forms.Label lblModProd;
        private System.Windows.Forms.Button btnAceptarAgregar;
        private System.Windows.Forms.TextBox txtStockAgregar;
        private System.Windows.Forms.TextBox txtPrecioAgregar;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cbxProveedores;
    }
}