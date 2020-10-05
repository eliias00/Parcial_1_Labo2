using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compra
    {
        Cliente cliente;
        Empleado empleado;
        double precioTotal;
        List<string> nombreProductos;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Compra()
        {
            nombreProductos = new List<string>();
            this.precioTotal = -1;
        }
        /// <summary>
        /// Constructor de la clase con parametros
        /// </summary>
        /// <param name="auxEmpleado"></param>
        /// <param name="auxComprador"></param>
        /// <param name="auxPrecioTotal"></param>
        /// <param name="auxProductos"></param>
        public Compra(Empleado auxEmpleado, Cliente auxComprador, double auxPrecioTotal, List<string> auxProductos) : this()
        {
            this.nombreProductos = auxProductos;
            this.cliente = auxComprador;
            this.empleado = auxEmpleado;
            this.precioTotal = auxPrecioTotal;
        }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public double Total
        {
            get { return precioTotal; }
        }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public string ApellidoEmpleado
        {
            get { return empleado.Apellido; }
        }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public string NombreEmpleado
        {
            get { return empleado.Nombre; }
        }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public string LegajoEmpleado
        {
            get { return empleado.Legajo; }
        }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public string ApellidoCliente
        {
            get { return cliente.Apellido; }
        }
        /// <summary>
        /// Propiedad de lectura
        /// </summary>
        public string NombreCliente
        {
            get { return cliente.Nombre; }
        }
    }
}