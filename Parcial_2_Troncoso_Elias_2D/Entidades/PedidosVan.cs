using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

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
        /// <summary>
        /// Constructor
        /// </summary>
        public PedidosVan()
        {
            this.numPedido = "Null";
            this.telefono = "Null";
            this.estadoPedido = "Null";
        }
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="numeroPedido"></param>
        /// <param name="domic"></param>
        /// <param name="telef"></param>
        /// <param name="estPedido"></param>
        /// <param name="delivRequerimiento"></param>
        public PedidosVan(EProductos productos, string numeroPedido, EDomicilios domic, string telef, string estPedido, eDelivery delivRequerimiento) : this()
        {
            this.productos = productos;
            this.numPedido = numeroPedido;
            this.domicilio = domic;
            this.telefono = telef;
            this.estadoPedido = estPedido;
            this.delivRequerimiento = delivRequerimiento;
        }
        /// <summary>
        /// Propiedad Productos
        /// </summary>
        public EProductos Productos
        {
            get { return this.productos; }

            set { this.productos = value; }
        }
        /// <summary>
        /// Propiedad NumPedido
        /// </summary>
        public string NumPedido
        {
            get { return this.numPedido; }

            set { this.numPedido = value; }
        }
        /// <summary>
        /// Propiedad Domicilio
        /// </summary>
        public EDomicilios Domicilio
        {
            get { return this.domicilio; }

            set { this.domicilio = value; }
        }
        /// <summary>
        /// Propiedad Telefono
        /// </summary>
        public string Telefono
        {
            get { return this.telefono; }

            set { this.telefono = value; }
        }
        /// <summary>
        /// Propiedad EstadoPedido
        /// </summary>
        public string EstadoPedido
        {
            get { return this.estadoPedido; }

            set { this.estadoPedido = value; }
        }
        /// <summary>
        /// Propiedad DelivRequerimiento
        /// </summary>
        public eDelivery DelivRequerimiento
        {
            get { return this.delivRequerimiento; }

            set { this.delivRequerimiento = value; }
        }
        /// <summary>
        /// Guarda en formato txt el pedido
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        public static bool GeneroComprobanteTXT(PedidosVan pedido)
        {
            try
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
            catch (Exception ex)
            {

                throw new GeneroTxtError(ex);
            }
        }
        /// <summary>
        /// Genera pedido Random
        /// </summary>
        /// <returns></returns>
        public static bool GeneroPedidoRandom()
        {


            bool retorno = false;
            PedidosVan pedidoGenerado;
            Random random = new Random();
            EProductos productos1;
            EDomicilios domicilios1;
            eDelivery deliverys1;
            int telefono = IntExtension.GeneroTelefono();
            string estado = "Haciendose";
            string numeroPedido = DateTime.Now.ToString("ssmmHHyyyyMMdd");
            productos1 = (EProductos)random.Next(0, System.Enum.GetValues(typeof(EProductos)).Length);
            domicilios1 = (EDomicilios)random.Next(0, System.Enum.GetValues(typeof(EDomicilios)).Length);
            deliverys1 = (eDelivery)random.Next(0, System.Enum.GetValues(typeof(eDelivery)).Length);
            pedidoGenerado = new PedidosVan(productos1, numeroPedido, domicilios1, telefono.ToString(), estado, deliverys1);
            Local.PedidosPorHacer.Add(pedidoGenerado);
            if (pedidoGenerado.DelivRequerimiento == PedidosVan.eDelivery.Si)
            {
                GeneroComprobanteTXT(pedidoGenerado);
            }
            if (SqlConexion.Insert(pedidoGenerado))
            {
                retorno = true;
            }
            return retorno;

        }
        /// <summary>
        /// Se fija si el pedido que le dan es para delivery
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        public static bool DeliveryCorre(PedidosVan pedido)
        {
            bool retorno = false;
            if (pedido.delivRequerimiento == PedidosVan.eDelivery.Si)
            {
                pedido.estadoPedido = "Entregado";
                SqlConexion.Update(pedido);
                retorno = true;
            }
            return retorno;
        }
    }
}
