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
        public partial class frmListaProductos : Form
    {
         
        private List<Producto> listaProdLocal;

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            ProveedorNegocio negocio = new ProveedorNegocio();

            cbxProveedores.DataSource = negocio.cargarComboProv();
            cbxProveedores.DisplayMember = "nombre";
            cbxProveedores.ValueMember = "idproveedor";
            cargarGrilla();
        }

        void Enabletxt()
        {
            txtNombre.Enabled = true;
            txtMarca.Enabled = true;
            txtStock.Enabled = true;
            txtPrecio.Enabled = true;
        }

        void Disabletxt()
        {
            txtNombre.Enabled = false;
            txtMarca.Enabled = false;
            txtStock.Enabled = false;
            txtPrecio.Enabled = false;
        }

        public frmListaProductos()
        {
            InitializeComponent();
        }

        private void cargarGrilla()
        {
            ProductoNegocio negocio = new ProductoNegocio();
            try
            {
                listaProdLocal = negocio.listarProductos();
                dgvListaProd.DataSource = listaProdLocal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }
                  
        private void btnModificar_Click(object sender, EventArgs e)
        {


            if (dgvListaProd.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Debes seleccionar un item de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Producto modificar;

                    modificar = (Producto)dgvListaProd.CurrentRow.DataBoundItem;
                    txtIdProd.Text = modificar.idProducto.ToString();
                    txtNombre.Text = modificar.descripcion;
                    txtMarca.Text = modificar.marca;
                    txtPrecio.Text = modificar.precio.ToString();
                    txtStock.Text = modificar.stock.ToString();
                    Enabletxt();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void btnAceptarAgregar_Click(object sender, EventArgs e)
        {
            Producto agregar = new Producto();
            ProductoNegocio negocio = new ProductoNegocio();
            Proveedor Aux = new Proveedor();
            ProveedorNegocio auxnegocio = new ProveedorNegocio();

            if(txtNombreAgregar.Text == "" || txtMarcaAgregar.Text == "" || txtPrecioAgregar.Text == "" || txtStockAgregar.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int auxint;
                    auxint = negocio.buscar_ultimo_idprod();
                    agregar.descripcion = txtNombreAgregar.Text;
                    agregar.marca = txtMarcaAgregar.Text;
                    agregar.precio = decimal.Parse(txtPrecioAgregar.Text);
                    agregar.stock = int.Parse(txtStockAgregar.Text);
                    Aux= (Proveedor)cbxProveedores.SelectedItem;

                    negocio.Agregarproducto(agregar);
                    auxnegocio.CargarProdXProv(Aux.idProveedor, auxint);                    

                    cargarGrilla();                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }            
            }            
        }

     

        private void btnModAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtMarca.Text == "" || txtStock.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Debe rellenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disabletxt();
            }
            else
            {
                Producto modificado = new Producto();
                ProductoNegocio modificar = new ProductoNegocio();

                try
                {
                    modificado.idProducto = int.Parse(txtIdProd.Text);
                    modificado.descripcion = txtNombre.Text;
                    modificado.marca = txtMarca.Text;
                    modificado.precio = decimal.Parse(txtPrecio.Text);
                    modificado.stock = int.Parse(txtStock.Text);

                    Disabletxt();
                    modificar.ModificarProducto(modificado);
                    cargarGrilla();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void cbxProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }

        private void btnCancelarAgregado_Click(object sender, EventArgs e)
        {
            txtNombreAgregar.Text = "";
            txtMarcaAgregar.Text = "";
            txtPrecioAgregar.Text = "";
            txtStockAgregar.Text = "";            
        }

        private void btnCancelarMod_Click(object sender, EventArgs e)
        {
            txtIdProd.Text = "";
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";

            Disabletxt();
        }
    }
}


