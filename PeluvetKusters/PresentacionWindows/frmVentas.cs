using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace PresentacionWindows
{
    public partial class frmVentas : Form
    {

        public frmVentas()
        {
            InitializeComponent();
            txtFecha.Text = DateTime.Now.ToShortDateString();           
            cargarProductos();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cargarProductos()
        {
            ProductoNegocio negocio = new ProductoNegocio();

            cmbProductos.DataSource = negocio.listarProductos();
            cmbProductos.DisplayMember = "descripcion";
            cmbProductos.ValueMember = "idproducto";
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto producto = new Producto();                 

            producto = (Producto)cmbProductos.SelectedItem;       
          
            txtCantidad.Text = 0.ToString();
            txtCosto.Text = (producto.precio * int.Parse(txtCantidad.Text)).ToString();
            txtPrecio.Text = (producto.precioVenta * int.Parse(txtCantidad.Text)).ToString();                
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            producto = (Producto)cmbProductos.SelectedItem;

            if (txtCosto.Text == "" || txtPrecio.Text == "" || txtFecha.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Debe seleccionar un producto e ingresar la cantidad a vender", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (producto.stock == 0)
                {
                    MessageBox.Show("No hay stock disponible para este producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    VentaNegocio negocio = new VentaNegocio();
                    GananciasXMesNegocio ganancias = new GananciasXMesNegocio();
                    Venta nueva = new Venta();

                    nueva.producto = (Producto)cmbProductos.SelectedItem;
                    nueva.Fecha = DateTime.Parse(txtFecha.Text);
                    nueva.cantidad = int.Parse(txtCantidad.Text);
                    nueva.PrecioVenta = decimal.Parse(txtPrecio.Text);
                    nueva.Costo = decimal.Parse(txtCosto.Text);

                    negocio.reducirStock(nueva.producto, int.Parse(txtCantidad.Text));
                    negocio.CargarVenta(nueva);

                    MessageBox.Show("Venta registrada", "MENSAJE", MessageBoxButtons.OK);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCosto_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto = (Producto)cmbProductos.SelectedItem;

            txtCosto.Text = (producto.precio * int.Parse(txtCantidad.Text)).ToString();
            txtPrecio.Text = (producto.precioVenta * int.Parse(txtCantidad.Text)).ToString();
        }
    }
}
