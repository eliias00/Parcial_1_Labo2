using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public static class Comercio
    {
        static List<Productos> nuevosProductos;
        static List<Empleado> nuevosEmpleados;
        static List<Cliente> nuevosClientes;

        static Comercio()
        {
            nuevosProductos = new List<Productos>();
            nuevosEmpleados = new List<Empleado>();
            nuevosClientes= new List<Cliente>();
        }



        public static void CargaDeDatos()
        {

            nuevosProductos.Add(new Productos("Cerveza Duff", 1, 25, "50"));
            nuevosProductos.Add(new Productos("Rosquillas", 2, 30, "55"));
            nuevosProductos.Add(new Productos("Playera", 3, 20, "10"));
            nuevosProductos.Add(new Productos("Calcetines", 4, 10, "8"));
            nuevosProductos.Add(new Productos("Malteada de Frutilla", 5, 6, "50"));
            nuevosProductos.Add(new Productos("Malteada de Naranja", 6, 6, "50"));
            nuevosProductos.Add(new Productos("Malteada de Uva", 7, 6, "50"));
            nuevosProductos.Add(new Productos("Malteada de Manzana", 8, 6, "50"));
            nuevosProductos.Add(new Productos("Malteada de Coco", 9, 6, "50"));
            nuevosProductos.Add(new Productos("Malteada de Pera", 10, 6, "50"));
            nuevosProductos.Add(new Productos("Hot Dog", 11, 15, "40"));
            nuevosProductos.Add(new Productos("Pizza", 12, 20, "32"));
            nuevosProductos.Add(new Productos("Langosta", 13, 60, "10"));
            nuevosProductos.Add(new Productos("Kruty Burger", 14, 25, "20"));
            nuevosProductos.Add(new Productos("Kruty Snacks", 15, 18, "50"));
            nuevosProductos.Add(new Productos("boligrafo", 16, 6, "60"));
            nuevosProductos.Add(new Productos("Helado Tricolor", 17, 40, "50"));
            nuevosProductos.Add(new Productos("Chuletas", 18, 20, "40"));
            nuevosProductos.Add(new Productos("Pretzels", 19, 10, "30"));
            nuevosProductos.Add(new Productos("Pescado y Maricos", 20, 100, "25"));
            nuevosProductos.Add(new Productos("Ensalada", 21, 15, "2"));
            nuevosProductos.Add(new Productos("Taza de Cafe", 22, 8, "5"));
            nuevosProductos.Add(new Productos("Taza de Te", 23, 5, "5"));
            nuevosProductos.Add(new Productos("Chocolate", 24, 20, "500"));
            nuevosProductos.Add(new Productos("Tocino", 25, 15, "55"));
            nuevosProductos.Add(new Productos("Patatas Fritas", 26, 10, "48"));
            nuevosProductos.Add(new Productos("Tomato", 27, 7, "20"));
            nuevosProductos.Add(new Productos("Caramelo", 28, 2, "240"));
            nuevosProductos.Add(new Productos("Plankton", 29, 10, "30"));
            nuevosProductos.Add(new Productos("Pastel", 30, 35, "30"));
        }
        public static void CargaDeEmpleados()
        {
            nuevosEmpleados.Add(new Empleado("leg00001", "ApupA", 1234567, "Apu", "Nahasapeemapetilon",11334455, "apuATR@gmail.com"));
            nuevosEmpleados.Add(new Empleado("leg00002", "1235",1234566, "jose", "jeje", 22443311, "jaja@gmail.com"));
        }
        public static void CargaDeClientes()
        {
            nuevosClientes.Add(new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"));
            nuevosClientes.Add(new Cliente("user0002", "1236", 1234566, "cliente2", "perez", 77777777, "123456789@gmail.com"));
        }

        public static List<Productos> RetornaLista()
        {
            return nuevosProductos;
        }

        public static bool AgregarProducto(Productos nuevoProducto)
        {
            bool retorno = false;
            if (nuevosProductos + nuevoProducto)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool AgregarEmpleado(Empleado nuevoEmpleado)
        {
            bool retorno = false;
            if (nuevosEmpleados + nuevoEmpleado)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool buscoEmpleado(Empleado nuevoEmpleado)
        {
            bool retorno = false;
            if (nuevosEmpleados == nuevoEmpleado)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool AgregarCliente(Cliente nuevoCliente)
        {
            bool retorno = false;
            if (nuevosClientes + nuevoCliente)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
