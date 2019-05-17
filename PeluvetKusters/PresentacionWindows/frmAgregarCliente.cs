﻿using System;
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
    public partial class frmAgregarCliente : Form
    {
        public frmAgregarCliente()
        {
            InitializeComponent();
        }


        void cargarGrilla()
        {
            ClienteNegocio negocio = new ClienteNegocio();

            dgbAgregarCliente.DataSource = negocio.ListarClientes();

        }

        private void dgbAgregarCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
    }
}
