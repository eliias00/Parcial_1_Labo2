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
        public Compra()
        {
            this.precioTotal = -1;
        }
        public Compra(Empleado auxEmpleado, Cliente auxComprador, double auxPrecioTotal) : this()
        {
            this.cliente = auxComprador;
            this.empleado = auxEmpleado;
            this.precioTotal = auxPrecioTotal;
        }
        public double Total
        {
            
            get { return precioTotal; }
        }
        public string ApellidoEmpleado
        {
            
            get { return empleado.Apellido; }
        }
        public string NombreEmpleado
        {
           
            get { return empleado.Nombre; }
        }
        public string LegajoEmpleado
        {
           
            get { return empleado.Legajo; }
        }
        public string ApellidoCliente
        {
            get { return cliente.Apellido; }
        }
        public string NombreCliente
        {
            get { return cliente.Nombre; }
        }
    }
}
