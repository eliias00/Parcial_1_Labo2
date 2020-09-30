using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public static class Comercio
    {
        static Cliente nuevoCliente;
        static string[] usuarioYContraseña;
        static List<Productos> nuevosProductos;
        static List<Empleado> nuevosEmpleados;
        static List<Cliente> nuevosClientes;
        static List<Compra> nuevasCompras;

        static Comercio()
        {
            usuarioYContraseña = new string[2];
            nuevosProductos = new List<Productos>();
            nuevosEmpleados = new List<Empleado>();
            nuevosClientes = new List<Cliente>();
            nuevasCompras = new List<Compra>();
        }



        public static void CargaDeDatos()
        {

            nuevosProductos.Add(new Productos("Cerveza Duff", 1, 25, 50));
            nuevosProductos.Add(new Productos("Rosquillas", 2, 30, 55));
            nuevosProductos.Add(new Productos("Playera", 3, 20, 10));
            nuevosProductos.Add(new Productos("Calcetines", 4, 10, 8));
            nuevosProductos.Add(new Productos("Malteada de Frutilla", 5, 6, 50));
            nuevosProductos.Add(new Productos("Malteada de Naranja", 6, 6, 50));
            nuevosProductos.Add(new Productos("Malteada de Uva", 7, 6, 50));
            nuevosProductos.Add(new Productos("Malteada de Manzana", 8, 6, 50));
            nuevosProductos.Add(new Productos("Malteada de Coco", 9, 6, 50));
            nuevosProductos.Add(new Productos("Malteada de Pera", 10, 6, 50));
            nuevosProductos.Add(new Productos("Hot Dog", 11, 15, 40));
            nuevosProductos.Add(new Productos("Pizza", 12, 20, 32));
            nuevosProductos.Add(new Productos("Langosta", 13, 60, 10));
            nuevosProductos.Add(new Productos("Kruty Burger", 14, 25, 20));
            nuevosProductos.Add(new Productos("Kruty Snacks", 15, 18, 50));
            nuevosProductos.Add(new Productos("boligrafo", 16, 6, 60));
            nuevosProductos.Add(new Productos("Helado Tricolor", 17, 40, 50));
            nuevosProductos.Add(new Productos("Chuletas", 18, 20, 40));
            nuevosProductos.Add(new Productos("Pretzels", 19, 10, 30));
            nuevosProductos.Add(new Productos("Pescado y Maricos", 20, 100, 25));
            nuevosProductos.Add(new Productos("Ensalada", 21, 15, 2));
            nuevosProductos.Add(new Productos("Taza de Cafe", 22, 8, 5));
            nuevosProductos.Add(new Productos("Taza de Te", 23, 5, 5));
            nuevosProductos.Add(new Productos("Chocolate", 24, 20, 500));
            nuevosProductos.Add(new Productos("Tocino", 25, 15, 55));
            nuevosProductos.Add(new Productos("Patatas Fritas", 26, 10, 48));
            nuevosProductos.Add(new Productos("Tomato", 27, 7, 20));
            nuevosProductos.Add(new Productos("Caramelo", 28, 2, 240));
            nuevosProductos.Add(new Productos("Plankton", 29, 10, 30));
            nuevosProductos.Add(new Productos("Pastel", 30, 35, 30));
        }
        public static void CargaDeEmpleados()
        {
            nuevosEmpleados.Add(new Empleado("leg00001", "ApupA", 1234567, "Apu", "Nahasapeemapetilon", 11334455, "apuATR@gmail.com", 0));
            nuevosEmpleados.Add(new Empleado("leg00002", "1235", 1234566, "jose", "jeje", 22443311, "jaja@gmail.com", 1));
        }
        public static void CargaDeClientes()
        {
            nuevosClientes.Add(new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"));
            nuevosClientes.Add(new Cliente("user0002", "1236", 1234566, "cliente2", "perez", 77777777, "123456789@gmail.com"));
        }
        public static void CargaDeCompras()
        {
            Empleado[] arrayEmpleados = new Empleado[50]
            {
                new Empleado("leg00003", "Contra1235", 1234567, "jose", "perez", 22443311, "jose@gmail.com", 2),new Empleado("leg00004", "Contra1245", 1230566, "pepe", "lopez", 42443311, "lelo@gmail.com", 27),
                new Empleado("leg00003", "Contra1235", 1234567, "juan", "perez", 22443312, "jose@gmail.com", 3),new Empleado("leg00006", "Contra1245", 1230566, "pepe", "lopez", 42443311, "lelo@gmail.com", 28),
                new Empleado("leg00007", "Contra1235", 1234567, "jose", "perez", 22443313, "jose@gmail.com", 4),new Empleado("leg00008", "Contra1245", 1230566, "pepe", "lopez", 42443311, "lelo@gmail.com", 29),
                new Empleado("leg00009", "Contra1235", 1234567, "juan", "perez", 22443314, "jose@gmail.com", 5),new Empleado("leg00010", "Contra1245", 1230566, "pepe", "lopez", 42443311, "lelo@gmail.com", 30),
                new Empleado("leg00011", "Contra1235", 1234567, "juan", "perez", 22443315, "jose@gmail.com", 6),new Empleado("leg00012", "Contra1245", 1230566, "pepe", "lopez", 42443311, "lelo@gmail.com", 31),
                new Empleado("leg00013", "Contra1235", 1234567, "juan", "perez", 22443316, "jose@gmail.com", 7),new Empleado("leg00014", "Contra1245", 1230566, "pepe", "lopez", 42443311, "lelo@gmail.com", 32),
                new Empleado("leg00015", "Contra1235", 1234567, "juan", "perez", 22443317, "jose@gmail.com", 8),new Empleado("leg00016", "Contra1245", 1230566, "pepe", "lopez", 42443311, "lelo@gmail.com", 33),
                new Empleado("leg00017", "Contra1235", 1234567, "juan", "perez", 22443318, "jose@gmail.com", 9),new Empleado("leg00018", "Contra1245", 1230566, "pepe", "lopez", 42443311, "lelo@gmail.com", 34),
                new Empleado("leg00019", "Contra1235", 1234567, "juan", "perez", 22443319, "jose@gmail.com", 10),new Empleado("leg00020", "Contra1245", 1304566, "lolo", "lopez", 42443311, "lelo@gmail.com",35),
                new Empleado("leg00021", "Contra1235", 1234567, "laura", "quiroga", 22443321, "lale@gmail.com", 11),new Empleado("leg00022", "Contra2235", 123216, "lolo", "ramirez", 82443311, "queque@gmail.co26m", 36),
                new Empleado("leg00023", "Contra1235", 1234567, "laura", "quiroga", 22443322, "lale@gmail.com", 12),new Empleado("leg00024", "Contra2235", 123216, "lolo", "ramirez", 82443311, "queque@gmail.com", 37),
                new Empleado("leg00025", "Contra1234", 1234567, "laura", "quiroga", 22443323, "lale@gmail.com", 13),new Empleado("leg00026", "Contra2235", 123216, "lolo", "ramirez", 82443311, "queque@gmail.com", 38),
                new Empleado("leg00027", "Contra1234", 1234567, "laura", "quiroga", 22443324, "lale@gmail.com", 14),new Empleado("leg00028", "Contra2235", 123216, "lolo", "ramirez", 82443311, "queque@gmail.com", 39),
                new Empleado("leg00029", "Contra1234", 1234567, "laura", "quiroga", 22443325, "lale@gmail.com", 15),new Empleado("leg00030", "Contra2235", 123216, "lolo", "ramirez", 82443311, "queque@gmail.com", 40),
                new Empleado("leg00031", "Contra1234", 1234566, "laura", "quiroga", 22443326, "lale@gmail.com", 16),new Empleado("leg00032", "Contra2235", 123216, "lolo", "ramirez", 82443311, "queque@gmail.com", 41),
                new Empleado("leg00033", "Contra1234", 1234566, "lorena", "gonzalez", 22443331, "lilolu@gmail.com", 17),new Empleado("leg00034", "Contra3235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 42),
                new Empleado("leg00035", "Contra1234", 1234566, "lorena", "gonzalez", 22443332, "lilolu@gmail.com", 18),new Empleado("leg00036", "Contra3235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 43),
                new Empleado("leg00037", "Contra1234", 1234566, "lorena", "gonzalez", 22443333, "lilolu@gmail.com", 19),new Empleado("leg00038", "Contra3235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 44),
                new Empleado("leg00039", "Contra1234", 1234566, "lorena", "gonzalez", 22443334, "lilolu@gmail.com", 20),new Empleado("leg00040", "Contra3235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 45),
                new Empleado("leg00041", "Contra1234", 1234566, "lorena", "gonzalez", 22443335, "lilolu@gmail.com", 21),new Empleado("leg00042", "Contra3235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 46),
                new Empleado("leg00043", "Contra1234", 1234566, "lorena", "gonzalez", 22443336, "lilolu@gmail.com", 22),new Empleado("leg00044", "Contra3235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 47),
                new Empleado("leg00045", "Contra1234", 1234566, "lorena", "gonzalez", 22443337, "lilolu@gmail.com", 23),new Empleado("leg00046", "Contra4235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 48),
                new Empleado("leg00047", "Contra1234", 1234566, "lorena", "gonzalez", 22443338, "lilolu@gmail.com", 24),new Empleado("leg00048", "Contra4235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 49),
                new Empleado("leg00049", "Contra1234", 1234566, "lorena", "gonzalez", 22443339, "lilolu@gmail.com", 25),new Empleado("leg00050", "Contra4235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 50),
                new Empleado("leg00051", "Contra1234", 1234566, "lorena", "gonzalez", 22443331, "lilolu@gmail.com", 26),new Empleado("leg00052", "Contra4235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 51)
            };

            Cliente[] arrayClientes = new Cliente[50]
            {
                new Cliente("user0001", "Contra1231", 1234564, "cliente1", "lopez", 66646666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0003", "Contra1231", 1234564, "cliente2", "lopez", 66646666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0005", "Contra1231", 1234564, "cliente3", "lopez", 66646666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0007", "Contra1231", 1234564, "cliente4", "lopez", 66646666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0009", "Contra1231", 1234564, "cliente5", "lopez", 66646666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0011", "Contra1231", 1234564, "cliente6", "lopez", 66646666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0013", "Contra1231", 1234564, "cliente7", "lopez", 66646666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0015", "Contra1231", 1234564, "cliente8", "lopez", 66646666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0017", "Contra1232", 1234564, "cliente9", "lopez", 66666566, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0019", "Contra1232", 1234564, "cliente10", "lopez", 66665666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0021", "Contra1232", 1234564, "cliente11", "lopez", 66665666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0023", "Contra1232", 1234564, "cliente12", "lopez", 66665666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0025", "Contra1232", 1234564, "cliente13", "lopez", 66665666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0027", "Contra1232", 1234564, "cliente14", "lopez", 66665666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0029", "Contra1232", 1234563, "cliente15", "lopez", 66665666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0031", "Contra1232", 1234563, "cliente16", "lopez", 66466666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0033", "Contra1233", 1234563, "cliente17", "lopez", 66466666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0035", "Contra1233", 1234563, "cliente18", "lopez", 66466666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0037", "Contra1233", 1234563, "cliente19", "lopez", 66466666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0039", "Contra1233", 1234567, "cliente20", "lopez", 66466666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0041", "Contra1233", 1234567, "cliente21", "lopez", 66466666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0043", "Contra1233", 1234567, "cliente22", "lopez", 66466666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0045", "Contra1233", 1234567, "cliente23", "lopez", 66466666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0047", "Contra1233", 1234567, "cliente24", "lopez", 66466666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("user0049", "Contra1233", 1234567, "cliente25", "lopez", 66666666, "lalelilolu@gmail.com"),new Cliente("user0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com")
            };



            double[] arrayPrecios = new double[50]
            { 11, 54, 66, 170, 68, 130, 335, 43, 131, 138, 50, 197, 110, 81, 150, 28, 132,
            123, 315, 51, 67, 172, 48, 53, 68, 48, 11, 325, 144, 90, 79, 51, 65, 120, 63,
            130, 335, 43, 135, 128, 150, 197,114, 88, 132, 78, 139,123, 111, 51 };

            for (int i = 0; i < 50; i++)
            {

                nuevasCompras.Add(new Compra(arrayEmpleados[i], arrayClientes[i], arrayPrecios[i]));
            }
        }

        public static List<Productos> RetornaLista()
        {
            return nuevosProductos;
        }
        public static List<Empleado> RetornaListaEmpleados()
        {
            return nuevosEmpleados;
        }
        public static List<Compra> RetornaListaCompras()
        {
            return nuevasCompras;
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
        public static bool buscoCliente(Cliente nuevoCliente)
        {
            bool retorno = false;
            if (nuevosClientes == nuevoCliente)
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
        public static string EmpleadoAleatorio(List<Empleado> empleados)
        {

            Random empleadoAle = new Random();
            int idAleatorio;
            int count = empleados.Count;
            idAleatorio = empleadoAle.Next(count);
            string nombre = "";
            string apellido = "";
            foreach (Empleado empleado in empleados)
            {
                if (empleado.Id == idAleatorio)
                {
                    nombre = empleado.Nombre;
                    apellido = empleado.Apellido;
                }
            }
            return nombre + " " + apellido;
        }
        public static int GenerarIdEmpleado(List<Empleado> empleados)
        {
            int id = 0;
            bool flag = true;

            for (int i = 0; i < empleados.Count; i++)
            {
                if (flag == true || id < empleados[i].Id)
                {
                    flag = false;
                    id = empleados[i].Id;
                }
            }
            id++;

            return id;
        }
        public static void guardoUsuarioYContraseña(string usuario, string contraseña)
        {
            for (int i = 0; i < usuarioYContraseña.Length; i++)
            {
                if (i == 0)
                {
                    usuarioYContraseña[0] = usuario;
                }
                else if (i == 1)
                {
                    usuarioYContraseña[1] = contraseña;
                    break;
                }
            }
            //  return usuarioYContraseña;
        }
        public static string[] retornoUsuarioYContraseña()
        {
            return usuarioYContraseña;
        }
        public static Cliente buscoClienteYLoretorno(Cliente nuevoCliente)
        {
            for (int i = 0; i < nuevosClientes.Count; i++)
            {
                if (nuevosClientes[i].Usuario == nuevoCliente.Usuario)
                {
                    nuevoCliente.Nombre = nuevosClientes[i].Nombre;
                    nuevoCliente.Apellido = nuevosClientes[i].Apellido;
                    nuevoCliente.Dni = nuevosClientes[i].Dni;
                    nuevoCliente.Telefono = nuevosClientes[i].Telefono;
                    nuevoCliente.Email = nuevosClientes[i].Email;
                }
            }
            return nuevoCliente;
        }
        public static Empleado buscoEmpleadoYLoretorno(Empleado nuevoEmpleado)
        {
            for (int i = 0; i < nuevosEmpleados.Count; i++)
            {
                if (nuevosEmpleados[i].Apellido == nuevoEmpleado.Apellido)
                {
                    if (nuevosEmpleados[i].Nombre == nuevoEmpleado.Nombre)
                    {
                        nuevoEmpleado.Id = nuevosEmpleados[i].Id;
                        nuevoEmpleado.Legajo = nuevosEmpleados[i].Legajo;
                        nuevoEmpleado.Dni = nuevosEmpleados[i].Dni;
                        nuevoEmpleado.Telefono = nuevosEmpleados[i].Telefono;
                        nuevoEmpleado.Email = nuevosEmpleados[i].Email;
                    }
                }
            }
            return nuevoEmpleado;
        }
        public static List<Compra> VentasPorEmpleado(string auxlegajo)
        {
            List<Compra> auxListaCompras = new List<Compra>();
            foreach (Compra item in nuevasCompras)
            {
                if (item.LegajoEmpleado == auxlegajo)
                {
                    auxListaCompras.Add(item);
                }
            }
            return auxListaCompras;
        }
        public static List<Productos> stock10Unidades()
        {
            List<Productos> auxListaProductos = new List<Productos>();
            foreach (Productos item in nuevosProductos)
            {
                if (Convert.ToInt32(item.Stock) < 10)
                {
                    auxListaProductos.Add(item);
                }
            }
            return auxListaProductos;
        }
        public static double descuentoSimpson(double auxSuma)
        {
            double precioTotal;
            double descuento;
            descuento = 0.13 * auxSuma;
            precioTotal = auxSuma - descuento;
            return precioTotal;
        }
        public static string generoLegajoEmpleadoNuevo()
        {
            string parteDeLegajoStr = "";
            string legajoNuevo = "";
            int parteDeLegajo;
            int legajoNumerico = 0;
            bool flag = true;
            
            for (int i = 0; i < nuevosEmpleados.Count; i++)
            {
                parteDeLegajoStr = nuevosEmpleados[i].Legajo.Substring(3, 5);
                int.TryParse(parteDeLegajoStr, out parteDeLegajo);

                if (flag == true || legajoNumerico < parteDeLegajo)
                {
                    flag = false;
                    legajoNumerico = parteDeLegajo;
                }
            }         
            if(legajoNumerico.ToString().Length == 1)
            {
                legajoNuevo = "Leg0000";
            }
            else if(legajoNumerico.ToString().Length == 2)
            {
                legajoNuevo = "Leg000";
            }
            else if (legajoNumerico.ToString().Length == 3)
            {
                legajoNuevo = "Leg00";
            }
            else if (legajoNumerico.ToString().Length == 4)
            {
                legajoNuevo = "Leg0";
            }
            legajoNumerico++;
          
            return legajoNuevo + legajoNumerico.ToString();
        }
    }
}