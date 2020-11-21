using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    public class PedidosVan
    {
        public enum EProductos
        {
            Gaseosa,
            Alfajor,
            Fideos,
            Manteca,
            Arroz,
            Mermelada,
            Tostadas,
            JugoEnPolvo,
            Cigarrillos,
            BebidaAlcoholica
        }
        public enum EDomicilios
        {
            Florida1334,
            Brazil34,
            DelValle2472,
            Pavon3000,
            Jamaica2500
        }
        public enum eDelivery
        {
            Si,
            No
        }
        EProductos productos;
        string numPedido;
        EDomicilios domicilio;
        string telefono;
        string estadoPedido;
        eDelivery delivRequerimiento;
        public PedidosVan()
        {
            this.numPedido = "Null";
            this.telefono = "Null";
            this.estadoPedido = "Null";
        }
        public PedidosVan(EProductos productos,string numeroPedido, EDomicilios domic, string telef, string estPedido, eDelivery delivRequerimiento): this()
        {
            this.productos = productos;
            this.numPedido = numeroPedido;
            this.domicilio = domic;
            this.telefono = telef;
            this.estadoPedido = estPedido;
            this.delivRequerimiento = delivRequerimiento;
        }
        public EProductos Productos
        {
            get { return this.productos; }

            set { this.productos = value; }
        }
        public string NumPedido
        {
            get { return this.numPedido; }

            set { this.numPedido = value; }
        }
        public EDomicilios Domicilio
        {
            get { return this.domicilio; }

            set { this.domicilio = value; }
        }
        public string Telefono
        {
            get { return this.telefono; }

            set { this.telefono = value; }
        }
        public string EstadoPedido
        {
            get { return this.estadoPedido; }

            set { this.estadoPedido = value; }
        }
        public eDelivery DelivRequerimiento
        {
            get { return this.delivRequerimiento; }

            set { this.delivRequerimiento = value; }
        }
        public static bool GeneroComprobanteTXT(PedidosVan pedido)
        {
            StringBuilder sb = new StringBuilder();
            string path;
            pedido.numPedido = DateTime.Now.ToString("yyyyMMddHHmmss");
            Texto texto = new Texto();
            path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Ticket." + pedido.numPedido.ToString() + ".txt");
            sb.AppendLine("Hora: " + pedido.numPedido.Substring(8, 2) + ":" + pedido.numPedido.Substring(10, 2) + ":" + pedido.numPedido.Substring(12, 2) +
           "          " + "Fecha: " + pedido.numPedido.Substring(0, 4) + "/" + pedido.numPedido.Substring(4, 2) + "/" + pedido.numPedido.Substring(6, 2));
            sb.AppendFormat("\nProducto: {0}", pedido.Productos);
            sb.AppendFormat("\nDomicilio: {0}", pedido.domicilio);
            sb.AppendFormat("\nTelefono: {0}", pedido.telefono);            
            sb.AppendLine("\n-----------------------------------");
            sb.AppendLine("Muchas Gracias por su compra...!!!");
            sb.AppendLine("------------Pedidos Van------------");
            return texto.Guardar(path, sb.ToString());
        }
        public static bool GeneroPedidoRandom()
        {
            bool retorno = false;
            PedidosVan pedidoGenerado;
            Random random = new Random();
            EProductos productos1;
            EDomicilios domicilios1;
            eDelivery deliverys1;
            int telefono = random.Next(100, 99999999);
            string estado = "Haciendose";
            string numeroPedido = DateTime.Now.ToString("ssmmHHyyyyMMdd");
            productos1 = (EProductos)random.Next(0, System.Enum.GetValues(typeof(EProductos)).Length);
            domicilios1 = (EDomicilios)random.Next(0, System.Enum.GetValues(typeof(EDomicilios)).Length);
            deliverys1 = (eDelivery)random.Next(0, System.Enum.GetValues(typeof(eDelivery)).Length);
            pedidoGenerado = new PedidosVan(productos1, numeroPedido, domicilios1, telefono.ToString(), estado, deliverys1);
            Local.PedidosPorHacer.Add(pedidoGenerado);
            if(pedidoGenerado.DelivRequerimiento == PedidosVan.eDelivery.Si)
            {
                GeneroComprobanteTXT(pedidoGenerado);
            }
            if(SqlConexion.Insert(pedidoGenerado))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
