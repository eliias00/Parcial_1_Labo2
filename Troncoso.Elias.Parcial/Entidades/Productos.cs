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
        int stockActual;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Productos()
        {
            this.nombre = "sin nombre";
            this.idProducto = -1;
            this.precio = -1;
            this.stockActual = -1;
        }
        /// <summary>
        /// Constructor de la clase, sobrecarga
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="idProducto"></param>
        /// <param name="stockActual"></param>
        public Productos(string nombre, int idProducto, int stockActual) : this()
        {
            this.nombre = nombre;
            this.idProducto = idProducto;
            this.stockActual = stockActual;
        }
        /// <summary>
        /// Constructor de la clase, Sobrecarga el de arriba 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="idProducto"></param>
        /// <param name="precio"></param>
        /// <param name="stockActual"></param>
        public Productos(string nombre, int idProducto, double precio, int stockActual) : this(nombre, idProducto, stockActual)
        {
            this.precio = precio;
        }
        /// <summary>
        /// Propiedad Nombre
        /// </summary>
        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }
        /// <summary>
        /// Propiedad Id de producto
        /// </summary>
        public int IdProducto
        {
            set { this.idProducto = value; }
            get { return this.idProducto; }
        }
        /// <summary>
        /// Propiedad Precio
        /// </summary>
        public double Precio
        {
            set { this.precio = value; }
            get { return this.precio; }
        }
        /// <summary>
        /// Propiedad Stock
        /// </summary>
        public int Stock
        {
            set { this.stockActual = value; }
            get { return this.stockActual; }
        }
        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Sobrecarga del operador -
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator -(List<Productos> listaProductos, Productos producto)
        {
            return (listaProductos.Remove(producto));
        }
        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator !=(List<Productos> listaProductos, Productos producto)
        {
            return !(listaProductos == producto);
        }
    }
}