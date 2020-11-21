﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Entidades;

namespace Parcial_2_Troncoso_Elias_2D
{
    public delegate bool delegadoCambioEstado(PedidosVan pedido);
    public partial class frmPedidos : Form
    {
        List<PedidosVan> pedidos;
        Thread Actualizo;
        Thread hiloAgregaNuevoPedido;
        public event delegadoCambioEstado delCamEstado;
        public frmPedidos()
        {
            pedidos = new List<PedidosVan>();
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            hiloAgregaNuevoPedido = new Thread(IniciarCiclo);
            Actualizo = new Thread(BuscoPedidosNuevosParAgregar);

        }
        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            Local.LevantoPedidosDeXml();
            BuscoPedidosNuevosParAgregar();
            hiloAgregaNuevoPedido.Start();
            delCamEstado += SqlConexion.Update;
        }
        private void BtnAgregarPedido_Click(object sender, EventArgs e)
        {
            if (PedidosVan.GeneroPedidoRandom())
            {
                MessageBox.Show("Se Agrego a la base de datos");
            }

        }
        private void FrmPedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            hiloAgregaNuevoPedido.Abort();
        }
        private void BuscoPedidosNuevosParAgregar()
        {
            if (this.lViewPedidosLevantados.InvokeRequired)
            {
                this.lViewPedidosLevantados.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.lViewPedidosLevantados.Items.Clear();
                    foreach (PedidosVan item in Local.PedidosPorHacer)
                    {
                        lViewPedidosLevantados.Items.Add(item.NumPedido);
                    }
                });
            }
            else
            {
                foreach (PedidosVan item in Local.PedidosPorHacer)
                {
                    lViewPedidosLevantados.Items.Add(item.NumPedido);
                }
            }
        }
        public void IniciarCiclo()
        {
            int i = 1;
            while (i == 1)
            {
                while (Local.PedidosPorHacer.Count > 0)
                {
                    TerminoPedido(Local.PedidosPorHacer[0]);
                    Local.PedidosPorHacer.Remove(Local.PedidosPorHacer[0]);
                    Thread.Sleep(4000);
                    this.BuscoPedidosNuevosParAgregar();
                    Thread.Sleep(2000);
                }
            }
        }
        private void TerminoPedido(PedidosVan pedidoTerminado)
        {
            lViewPedidosHechos.Items.Add(pedidoTerminado.NumPedido);
            Local.PedidosHechos.Add(pedidoTerminado);
            pedidoTerminado.EstadoPedido = "Hecho";
            delCamEstado.Invoke(pedidoTerminado);
        }
    }
}