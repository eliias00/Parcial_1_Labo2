﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Microsoft.VisualBasic;

namespace Troncoso.Elias.Parcial
{
    public partial class frm_Listados : Form
    {
        List<Compra> listaCompras;
        List<Productos> listaProductos;
        public frm_Listados()
        {
            
            InitializeComponent();
        }

        private void Frm_Listados_Load(object sender, EventArgs e)
        {

            string legajoABuscar = Interaction.InputBox("Ingrese el ID del producto a buscar");
            listaProductos = Comercio.stock10Unidades();
            ArmoDatagrStock10U(listaProductos);
            listaCompras = Comercio.VentasPorEmpleado(legajoABuscar);
            ArmoDatagrLegajoCompras(listaCompras);

        }
        private void ArmoDatagrLegajoCompras(List<Compra> listaDeCompras)
        {
            this.dGView_Listados.ReadOnly = true;
            this.dGView_Listados.DataSource = null;
            this.dGView_Listados.DataSource = listaDeCompras;
            this.dGView_Listados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void ArmoDatagrStock10U(List<Productos> listaDeProductos)
        {
            this.dGView_Stock_10U.ReadOnly = true;
            this.dGView_Stock_10U.DataSource = null;
            this.dGView_Stock_10U.DataSource = listaDeProductos;
            this.dGView_Stock_10U.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
