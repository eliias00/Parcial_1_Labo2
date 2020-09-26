using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660
#pragma warning disable CS0661
    public class Productos
    {
        string nombre;
        int idProducto;
        double precio;
        string stockActual;


        public Productos()
        {
            this.nombre = "sin nombre";
            this.idProducto = -1;
            this.precio = -1;
            this.stockActual = "-1";

        }
        public Productos(string nombre, int idProducto, string stockActual) : this()
        {
            this.nombre = nombre;
            this.idProducto = idProducto;
            this.stockActual = stockActual;
        }
        public Productos(string nombre, int idProducto, double precio, string stockActual) : this(nombre, idProducto, stockActual)
        {
            this.precio = precio;
        }
        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }
        public int IdProducto
        {
            set { this.idProducto = value; }
            get { return this.idProducto; }
        }
        public double Precio
        {
            set { this.precio = value; }
            get { return this.precio; }
        }

        public string Stock
        {
            set { this.stockActual = value; }
            get { return this.stockActual; }
        }

        public static bool operator +(List<Productos> listaProductos, Productos producto)
        {
            bool retorno = false;

            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i] != producto)
                {
                    listaProductos.Add(producto);
                    retorno = true;
                    break;

                }
            }
            return retorno;
        }
        public static bool operator -(List<Productos> listaProductos, Productos producto)
        {
            return (listaProductos.Remove(producto));
        }

        public static bool operator ==(List<Productos> listaProductos, Productos producto)
        {
            bool retorno = false;

            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].idProducto == producto.idProducto)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(List<Productos> listaProductos, Productos producto)
        {
            return !(listaProductos == producto);
        }
    }
}
