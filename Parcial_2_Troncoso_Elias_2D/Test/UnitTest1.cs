using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Controla que las listas de Local no sean null
        /// </summary>
        [TestMethod]
        public void ValidaAtributoNull()
        {
            Assert.IsNotNull(Local.PedidosHechos);
            Assert.IsNotNull(Local.PedidosPorHacer);
        }
        /// <summary>
        /// Controla que el valor String sea el esperado
        /// </summary>
        [TestMethod]
        public void ValidaString()
        {
            string hola = "Hola";
            PedidosVan pedidos = new PedidosVan(PedidosVan.EProductos.Arroz,"1",PedidosVan.EDomicilios.DelValle2472,"22","Hola",PedidosVan.eDelivery.No);
            Assert.AreEqual(hola, pedidos.EstadoPedido);
        }
    }
}
