using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public static class Comercio
    {
        static string[] usuarioYContraseña;
        static List<Productos> nuevosProductos;
        static List<Empleado> nuevosEmpleados;
        static List<Cliente> nuevosClientes;
        static List<Compra> nuevasCompras;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        static Comercio()
        {
            usuarioYContraseña = new string[2];
            nuevosProductos = new List<Productos>();
            nuevosEmpleados = new List<Empleado>();
            nuevosClientes = new List<Cliente>();
            nuevasCompras = new List<Compra>();
        }
        /// <summary>
        /// Harcodeo de productos
        /// </summary>
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
        /// <summary>
        /// Harcodeo de empleados
        /// </summary>
        public static void CargaDeEmpleados()
        {
            nuevosEmpleados.Add(new Empleado("Leg00000", "ApupA", 1234567, "Apu", "Nahasapeemapetilon", 11334455, "apuATR@gmail.com", 0));
            nuevosEmpleados.Add(new Empleado("Leg00001", "1235", 1234566, "jose", "jeje", 22443311, "jaja@gmail.com", 1));
        }
        /// <summary>
        /// Harcodeo de clientes
        /// </summary>
        public static void CargaDeClientes()
        {
            nuevosClientes.Add(new Cliente("User0000", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"));
            nuevosClientes.Add(new Cliente("User0001", "1236", 1234566, "cliente2", "perez", 77777777, "123456789@gmail.com"));
        }
        /// <summary>
        /// Harcodeo de compras
        /// </summary>
        public static void CargaDeCompras()
        {
            Empleado[] arrayEmpleados = new Empleado[50]
            {
                new Empleado("Leg00003", "Contra1235", 1234567, "jose", "perez", 22443311, "jose@gmail.com", 2),new Empleado("Leg00004", "Contra1245", 1230566, "pepe", "lopez", 42443311, "lelo@gmail.com", 27),
                new Empleado("Leg00003", "Contra1235", 1234567, "juan", "perez", 22443312, "jose@gmail.com", 3),new Empleado("Leg00006", "Contra1245", 1230566, "pepe", "lopez", 42443311, "lelo@gmail.com", 28),
                new Empleado("Leg00007", "Contra1235", 1234567, "jose", "perez", 22443313, "jose@gmail.com", 4),new Empleado("Leg00008", "Contra1245", 1230566, "pepe", "lopez", 42443311, "lelo@gmail.com", 29),
                new Empleado("Leg00009", "Contra1235", 1234567, "juan", "perez", 22443314, "jose@gmail.com", 5),new Empleado("Leg00010", "Contra1245", 1230566, "pepe", "lopez", 42443311, "lelo@gmail.com", 30),
                new Empleado("Leg00011", "Contra1235", 1234567, "juan", "perez", 22443315, "jose@gmail.com", 6),new Empleado("Leg00012", "Contra1245", 1230566, "pepe", "lopez", 42443311, "lelo@gmail.com", 31),
                new Empleado("Leg00013", "Contra1235", 1234567, "juan", "perez", 22443316, "jose@gmail.com", 7),new Empleado("Leg00014", "Contra1245", 1230566, "pepe", "lopez", 42443311, "lelo@gmail.com", 32),
                new Empleado("Leg00015", "Contra1235", 1234567, "juan", "perez", 22443317, "jose@gmail.com", 8),new Empleado("Leg00016", "Contra1245", 1230566, "pepe", "lopez", 42443311, "lelo@gmail.com", 33),
                new Empleado("Leg00017", "Contra1235", 1234567, "juan", "perez", 22443318, "jose@gmail.com", 9),new Empleado("Leg00018", "Contra1245", 1230566, "pepe", "lopez", 42443311, "lelo@gmail.com", 34),
                new Empleado("Leg00019", "Contra1235", 1234567, "juan", "perez", 22443319, "jose@gmail.com", 10),new Empleado("Leg00020", "Contra1245", 1304566, "lolo", "lopez", 42443311, "lelo@gmail.com",35),
                new Empleado("Leg00021", "Contra1235", 1234567, "laura", "quiroga", 22443321, "lale@gmail.com", 11),new Empleado("Leg00022", "Contra2235", 123216, "lolo", "ramirez", 82443311, "queque@gmail.co26m", 36),
                new Empleado("Leg00023", "Contra1235", 1234567, "laura", "quiroga", 22443322, "lale@gmail.com", 12),new Empleado("Leg00024", "Contra2235", 123216, "lolo", "ramirez", 82443311, "queque@gmail.com", 37),
                new Empleado("Leg00025", "Contra1234", 1234567, "laura", "quiroga", 22443323, "lale@gmail.com", 13),new Empleado("Leg00026", "Contra2235", 123216, "lolo", "ramirez", 82443311, "queque@gmail.com", 38),
                new Empleado("Leg00027", "Contra1234", 1234567, "laura", "quiroga", 22443324, "lale@gmail.com", 14),new Empleado("Leg00028", "Contra2235", 123216, "lolo", "ramirez", 82443311, "queque@gmail.com", 39),
                new Empleado("Leg00029", "Contra1234", 1234567, "laura", "quiroga", 22443325, "lale@gmail.com", 15),new Empleado("Leg00030", "Contra2235", 123216, "lolo", "ramirez", 82443311, "queque@gmail.com", 40),
                new Empleado("Leg00031", "Contra1234", 1234566, "laura", "quiroga", 22443326, "lale@gmail.com", 16),new Empleado("Leg00032", "Contra2235", 123216, "lolo", "ramirez", 82443311, "queque@gmail.com", 41),
                new Empleado("Leg00033", "Contra1234", 1234566, "lorena", "gonzalez", 22443331, "lilolu@gmail.com", 17),new Empleado("Leg00034", "Contra3235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 42),
                new Empleado("Leg00035", "Contra1234", 1234566, "lorena", "gonzalez", 22443332, "lilolu@gmail.com", 18),new Empleado("Leg00036", "Contra3235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 43),
                new Empleado("Leg00037", "Contra1234", 1234566, "lorena", "gonzalez", 22443333, "lilolu@gmail.com", 19),new Empleado("Leg00038", "Contra3235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 44),
                new Empleado("Leg00039", "Contra1234", 1234566, "lorena", "gonzalez", 22443334, "lilolu@gmail.com", 20),new Empleado("Leg00040", "Contra3235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 45),
                new Empleado("Leg00041", "Contra1234", 1234566, "lorena", "gonzalez", 22443335, "lilolu@gmail.com", 21),new Empleado("Leg00042", "Contra3235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 46),
                new Empleado("Leg00043", "Contra1234", 1234566, "lorena", "gonzalez", 22443336, "lilolu@gmail.com", 22),new Empleado("Leg00044", "Contra3235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 47),
                new Empleado("Leg00045", "Contra1234", 1234566, "lorena", "gonzalez", 22443337, "lilolu@gmail.com", 23),new Empleado("Leg00046", "Contra4235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 48),
                new Empleado("Leg00047", "Contra1234", 1234566, "lorena", "gonzalez", 22443338, "lilolu@gmail.com", 24),new Empleado("Leg00048", "Contra4235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 49),
                new Empleado("Leg00049", "Contra1234", 1234566, "lorena", "gonzalez", 22443339, "lilolu@gmail.com", 25),new Empleado("Leg00050", "Contra4235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 50),
                new Empleado("Leg00051", "Contra1234", 1234566, "lorena", "gonzalez", 22443331, "lilolu@gmail.com", 26),new Empleado("Leg00052", "Contra4235", 7234566, "coco", "rojas", 12443311, "loro@gmail.com", 51)
            };

            Cliente[] arrayClientes = new Cliente[50]
            {
                new Cliente("User0001", "Contra1231", 1234564, "cliente1", "lopez", 66646666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0003", "Contra1231", 1234564, "cliente2", "lopez", 66646666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0005", "Contra1231", 1234564, "cliente3", "lopez", 66646666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0007", "Contra1231", 1234564, "cliente4", "lopez", 66646666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0009", "Contra1231", 1234564, "cliente5", "lopez", 66646666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0011", "Contra1231", 1234564, "cliente6", "lopez", 66646666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0013", "Contra1231", 1234564, "cliente7", "lopez", 66646666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0015", "Contra1231", 1234564, "cliente8", "lopez", 66646666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0017", "Contra1232", 1234564, "cliente9", "lopez", 66666566, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0019", "Contra1232", 1234564, "cliente10", "lopez", 66665666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0021", "Contra1232", 1234564, "cliente11", "lopez", 66665666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0023", "Contra1232", 1234564, "cliente12", "lopez", 66665666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0025", "Contra1232", 1234564, "cliente13", "lopez", 66665666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0027", "Contra1232", 1234564, "cliente14", "lopez", 66665666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0029", "Contra1232", 1234563, "cliente15", "lopez", 66665666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0031", "Contra1232", 1234563, "cliente16", "lopez", 66466666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0033", "Contra1233", 1234563, "cliente17", "lopez", 66466666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0035", "Contra1233", 1234563, "cliente18", "lopez", 66466666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0037", "Contra1233", 1234563, "cliente19", "lopez", 66466666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0039", "Contra1233", 1234567, "cliente20", "lopez", 66466666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0041", "Contra1233", 1234567, "cliente21", "lopez", 66466666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0043", "Contra1233", 1234567, "cliente22", "lopez", 66466666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0045", "Contra1233", 1234567, "cliente23", "lopez", 66466666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0047", "Contra1233", 1234567, "cliente24", "lopez", 66466666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com"),
                new Cliente("User0049", "Contra1233", 1234567, "cliente25", "lopez", 66666666, "lalelilolu@gmail.com"),new Cliente("User0001", "1234", 1234567, "cliente1", "lopez", 66666666, "lalelilolu@gmail.com")
            };
            string[] descripcionProductos = new string[50]{ "Cerveza Duff", "Rosquillas","Playera", "Calcetines", "Malteada de Frutilla",
                "Malteada de Naranja","Malteada de Uva","Malteada de Manzana","Malteada de Coco","Malteada de Pera","Hot Dog","Pizza",
                "Langosta","Kruty Burger", "Kruty Snacks","boligrafo","Helado Tricolor", "Chuletas", "Pretzels","Pescado y Maricos",
                "Ensalada","Taza de Cafe", "Taza de Te","Chocolate","Tocino","Patatas Fritas","Tomato","Caramelo","Plankton","Pastel",
                "papas1","papas2","papas3","papas4","papas5","papas6","papas7","papas8","papas9","papas10",
                "papas11","papas12","papas13","papas14","papas15","papas16","papas17","papas18","papas19","papas20"
            };
            double[] arrayPrecios = new double[50]
            { 11, 54, 66, 170, 68, 130, 335, 43, 131, 138, 50, 197, 110, 81, 150, 28, 132,
            123, 315, 51, 67, 172, 48, 53, 68, 48, 11, 325, 144, 90, 79, 51, 65, 120, 63,
            130, 335, 43, 135, 128, 150, 197,114, 88, 132, 78, 139,123, 111, 51 };

            for (int i = 0; i < 50; i++)
            {
                List<string> auxLista = new List<string>();
                auxLista.Add(descripcionProductos[i]);
                nuevasCompras.Add(new Compra(arrayEmpleados[i], arrayClientes[i], arrayPrecios[i], auxLista));
            }
        }
        /// <summary>
        /// Retorno lista de productos
        /// </summary>
        /// <returns></returns>
        public static List<Productos> RetornaLista()
        {
            return nuevosProductos;
        }
        /// <summary>
        /// Retorno lista de empleados
        /// </summary>
        /// <returns></returns>
        public static List<Empleado> RetornaListaEmpleados()
        {
            return nuevosEmpleados;
        }
        /// <summary>
        /// Retorno lista de compras
        /// </summary>
        /// <returns></returns>
        public static List<Compra> RetornaListaCompras()
        {
            return nuevasCompras;
        }
        /// <summary>
        /// Agrego producto a lista
        /// </summary>
        /// <param name="nuevoProducto"></param>
        /// <returns></returns>
        public static bool AgregarProducto(Productos nuevoProducto)
        {
            bool retorno = false;
            if (nuevosProductos + nuevoProducto)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Agrego empleado a la lista
        /// </summary>
        /// <param name="nuevoEmpleado"></param>
        /// <returns></returns>
        public static bool AgregarEmpleado(Empleado nuevoEmpleado)
        {
            bool retorno = false;
            if (nuevosEmpleados + nuevoEmpleado)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Busco empleado en la lista
        /// </summary>
        /// <param name="nuevoEmpleado"></param>
        /// <returns></returns>
        public static bool buscoEmpleado(Empleado nuevoEmpleado)
        {
            bool retorno = false;
            if (nuevosEmpleados == nuevoEmpleado)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Busco cliente en la lista 
        /// </summary>
        /// <param name="nuevoCliente"></param>
        /// <returns></returns>
        public static bool buscoCliente(Cliente nuevoCliente)
        {
            bool retorno = false;
            if (nuevosClientes == nuevoCliente)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Agrego cliente a la lista
        /// </summary>
        /// <param name="nuevoCliente"></param>
        /// <returns></returns>
        public static bool AgregarCliente(Cliente nuevoCliente)
        {
            bool retorno = false;
            if (nuevosClientes + nuevoCliente)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Genero un empleado para la compra
        /// </summary>
        /// <param name="empleados"></param>
        /// <returns></returns>
        public static string EmpleadoAleatorio(List<Empleado> empleados)
        {
            Random empleadoAle = new Random();
            int idAleatorio;
            int count = empleados.Count;
            idAleatorio = empleadoAle.Next(count);
            string nombre = "";
            string apellido = "";
            string legajo = "";
            foreach (Empleado empleado in empleados)
            {
                if (empleado.Id == idAleatorio)
                {
                    nombre = empleado.Nombre;
                    apellido = empleado.Apellido;
                    legajo = empleado.Legajo;
                }
            }
            return nombre + " " + apellido + "\n" + legajo;
        }
        /// <summary>
        /// Genero id para empleado
        /// </summary>
        /// <param name="empleados"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Guardo credenciales
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>
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
        }
        /// <summary>
        /// Retorno credenciales
        /// </summary>
        /// <returns></returns>
        public static string[] retornoUsuarioYContraseña()
        {
            return usuarioYContraseña;
        }
        /// <summary>
        /// Busco cliente en la lista y lo retorno 
        /// </summary>
        /// <param name="nuevoCliente"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Busco empleado en la lista y lo retorno 
        /// </summary>
        /// <param name="nuevoEmpleado"></param>
        /// <returns></returns>
        public static Empleado buscoEmpleadoYLoretorno(Empleado nuevoEmpleado)
        {
            for (int i = 0; i < nuevosEmpleados.Count; i++)
            {
                if (nuevosEmpleados[i].Legajo == nuevoEmpleado.Legajo)
                {
                    nuevoEmpleado.Id = nuevosEmpleados[i].Id;
                    nuevoEmpleado.Legajo = nuevosEmpleados[i].Legajo;
                    nuevoEmpleado.Dni = nuevosEmpleados[i].Dni;
                    nuevoEmpleado.Telefono = nuevosEmpleados[i].Telefono;
                    nuevoEmpleado.Email = nuevosEmpleados[i].Email;
                    nuevoEmpleado.Email = nuevosEmpleados[i].Email;
                }
            }
            return nuevoEmpleado;
        }
        /// <summary>
        /// Retorno las compras del empleado
        /// </summary>
        /// <param name="auxlegajo"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Retorno los productos con menos de 10 unidades
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Retorno el valos de la compra con descuento Simpson
        /// </summary>
        /// <param name="auxSuma"></param>
        /// <returns></returns>
        public static double descuentoSimpson(double auxSuma)
        {
            double precioTotal;
            double descuento;
            descuento = 0.13 * auxSuma;
            precioTotal = auxSuma - descuento;
            return precioTotal;
        }
        /// <summary>
        /// Genero legajo para empleado nuevo
        /// </summary>
        /// <returns></returns>
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

            if (legajoNumerico.ToString().Length == 1)
            {
                legajoNuevo = "Leg0000";
                if (legajoNumerico == 9)
                {
                    legajoNuevo = "Leg000";
                }
            }
            else if (legajoNumerico.ToString().Length == 2)
            {
                legajoNuevo = "Leg000";
                if (legajoNumerico == 99)
                {
                    legajoNuevo = "Leg00";
                }
            }
            else if (legajoNumerico.ToString().Length == 3)
            {
                legajoNuevo = "Leg00";
                if (legajoNumerico == 999)
                {
                    legajoNuevo = "Leg0";
                }
            }
            else if (legajoNumerico.ToString().Length == 4)
            {
                legajoNuevo = "Leg0";
            }
            legajoNumerico++;

            return legajoNuevo + legajoNumerico.ToString();
        }
        /// <summary>
        /// Valido si se pueden comprar dichas unidades de un producto
        /// </summary>
        /// <param name="auxProducto"></param>
        /// <param name="auxUnidades"></param>
        /// <returns></returns>
        public static bool ValidoUnidadesComprar(string auxProducto, double auxUnidades)
        {
            bool retorno = false;
            for (int i = 0; i < nuevosProductos.Count; i++)
            {
                if (auxProducto == nuevosProductos[i].Nombre)
                {
                    if ((nuevosProductos[i].Stock - (int)auxUnidades) < 0)
                    {
                        retorno = false;
                    }
                    else
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
    }
}