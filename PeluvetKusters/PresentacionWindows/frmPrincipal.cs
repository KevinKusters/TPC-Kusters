﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWindows
{
    public partial class frmPrincipal : Form
    {
        frmAgregarCliente agregarCliente;
        frmAgregarTurno agregarTurno;
        frmListarCliente listarCliente;
        frmListarTurno listarTurno;
        frmListaRazas listaraza;
        frmListaProductos listaprod;
        frmProveedores proveedores;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void agregarTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (agregarTurno == null)
            {
                agregarTurno = new frmAgregarTurno();
                agregarTurno.MdiParent = this;
                agregarTurno.FormClosed += new FormClosedEventHandler(turn_FormClosed);
                agregarTurno.Show();

            }
        }

        void turn_FormClosed(object sender, EventArgs e)
        {
            agregarTurno = null;
        }

        private void verTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listarTurno == null)
            {
                listarTurno = new frmListarTurno();
                listarTurno.MdiParent = this;
                listarTurno.FormClosed += new FormClosedEventHandler(listar_Formclosed);
                listarTurno.Show();
            }
        }

        void listar_Formclosed(object sender, EventArgs e)
        {
            listarTurno = null;
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (agregarCliente == null)
            {
                agregarCliente = new frmAgregarCliente();
                agregarCliente.MdiParent = this;
                agregarCliente.FormClosed += new FormClosedEventHandler(cliente_FormClosed);
                agregarCliente.Show();
            }
        }

        void cliente_FormClosed(object sender, EventArgs e)
        {
            agregarCliente = null;
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listarCliente == null)
            {
                listarCliente = new frmListarCliente();
                listarCliente.MdiParent = this;
                listarCliente.FormClosed += new FormClosedEventHandler(lsitarcli_FormClosed);
                listarCliente.Show();
            }
        }

        void lsitarcli_FormClosed(object sender, EventArgs e)
        {
            listarCliente = null;
        }

        private void listaDeRazasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listaraza == null)
            {
                listaraza = new frmListaRazas();
                listaraza.MdiParent = this;
                listaraza.FormClosed += new FormClosedEventHandler(listaRaza_FormClosed);
                listaraza.Show();
            }
        }

        private void razasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listaraza == null)
            {
                listaraza = new frmListaRazas();
                listaraza.MdiParent = this;
                listaraza.FormClosed += new FormClosedEventHandler(listaRaza_FormClosed);
                listaraza.Show();
            }
        }
        void listaRaza_FormClosed(object sender, EventArgs e)
        {
            listaraza = null;
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listaprod == null)
            {
                listaprod = new frmListaProductos();
                listaprod.MdiParent = this;
                listaprod.FormClosed += new FormClosedEventHandler(ListaProd_FormClosed);
                listaprod.Show();
            }
        }

        void ListaProd_FormClosed(object sender, EventArgs e)
        {
            listaprod = null;
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proveedores == null)
            {
                proveedores = new frmProveedores();
                proveedores.MdiParent = this;
                proveedores.FormClosed += new FormClosedEventHandler(proveedoresFormclsoed);
                proveedores.Show();
            }
        }

        void proveedoresFormclsoed(object sender, EventArgs e)
        {
            proveedores = null;
        }

    }
}