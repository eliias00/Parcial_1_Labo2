using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Archivos;
using Entidades;

namespace Entidades
{
    public static class Local
    {
        static List<PedidosVan> pedidosPorHacer;
        static List<PedidosVan> pedidosHechos;
        static Local()
        {
            pedidosPorHacer = new List<PedidosVan>();
            pedidosHechos = new List<PedidosVan>();
        }
        public static List<PedidosVan> PedidosPorHacer
        {
            get { return pedidosPorHacer; }
        }
        public static List<PedidosVan> PedidosHechos
        {
            get { return pedidosHechos; }
        }
        public static List<PedidosVan> Leer()
        {
            List<PedidosVan> pedidos = new List<PedidosVan>();
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Pedidos.xml");
            Xml<List<PedidosVan>> auxPedidos = new Xml<List<PedidosVan>>();
            auxPedidos.Leer(path, out pedidos);

            return pedidos;
        }
        //public static List<PedidosVan> LevantoPedidosDeXml()
        public static void LevantoPedidosDeXml()
        {
            List<PedidosVan> pedidos = Leer();

            foreach (PedidosVan item in pedidos)
            {
                pedidosPorHacer.Add(item);
            }
            //   return pedidosPorHacer;
        }
        public static bool GuardarPedidosXml(List<PedidosVan> pedidos)
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Pedidos.xml");
            Xml<List<PedidosVan>> auxPedidos = new Xml<List<PedidosVan>>();

            pedidos.Add(new PedidosVan(PedidosVan.EProductos.Alfajor, "1", PedidosVan.EDomicilios.Brazil34, "11111111", "Preparando",PedidosVan.eDelivery.No));
            pedidos.Add(new PedidosVan(PedidosVan.EProductos.Arroz, "2", PedidosVan.EDomicilios.DelValle2472, "22222222", "Preparando", PedidosVan.eDelivery.No));
            pedidos.Add(new PedidosVan(PedidosVan.EProductos.BebidaAlcoholica, "3", PedidosVan.EDomicilios.Florida1334, "33333333", "Preparando", PedidosVan.eDelivery.No));
            pedidos.Add(new PedidosVan(PedidosVan.EProductos.Cigarrillos, "4", PedidosVan.EDomicilios.Jamaica2500, "44444444", "Preparando", PedidosVan.eDelivery.No));
            pedidos.Add(new PedidosVan(PedidosVan.EProductos.Fideos, "5", PedidosVan.EDomicilios.Pavon3000, "55555555", "Preparando", PedidosVan.eDelivery.No));
            pedidos.Add(new PedidosVan(PedidosVan.EProductos.Gaseosa, "6", PedidosVan.EDomicilios.Brazil34, "66666666", "Preparando", PedidosVan.eDelivery.Si));
            pedidos.Add(new PedidosVan(PedidosVan.EProductos.JugoEnPolvo, "7", PedidosVan.EDomicilios.DelValle2472, "7777777", "Preparando", PedidosVan.eDelivery.Si));
            pedidos.Add(new PedidosVan(PedidosVan.EProductos.Manteca, "8", PedidosVan.EDomicilios.Florida1334, "88888888", "Preparando", PedidosVan.eDelivery.Si));
            pedidos.Add(new PedidosVan(PedidosVan.EProductos.Mermelada, "9", PedidosVan.EDomicilios.Jamaica2500, "999999999", "Preparando", PedidosVan.eDelivery.Si));
            pedidos.Add(new PedidosVan(PedidosVan.EProductos.Tostadas, "10", PedidosVan.EDomicilios.Pavon3000, "987654321", "Preparando", PedidosVan.eDelivery.Si));

            return auxPedidos.Guardar(path, pedidos);
        }
    }
}
