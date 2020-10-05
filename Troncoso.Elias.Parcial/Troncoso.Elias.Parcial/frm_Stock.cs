using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Microsoft.VisualBasic;

namespace Troncoso.Elias.Parcial
{
    public partial class frm_Stock : Form
    {
        List<Productos> nuevosProductos;
        Productos ProductoAComparar;
        /// <summary>
        /// Inicializa el form
        /// </summary>
        public frm_Stock()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Carga informacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Stock_Load(object sender, EventArgs e)
        {
            Comercio.CargaDeDatos();
            ArmoDatagrid();
        }
        /// <summary>
        /// Elimina producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IBtn_Remove_Click(object sender, EventArgs e)
        {
            ProductoAComparar = new Productos();
            int idComparoBaja;
            bool retorno = false;
            string idBaja = Interaction.InputBox("Ingrese el ID del producto a buscar");
            Int32.TryParse(idBaja, out idComparoBaja);
            ProductoAComparar.IdProducto = idComparoBaja;

            for (int i = 0; i < nuevosProductos.Count; i++)
            {
                if (nuevosProductos[i].IdProducto == ProductoAComparar.IdProducto)
                {
                    nuevosProductos[i].Precio = -1;
                    nuevosProductos[i].Stock = -1;
                    nuevosProductos[i].Nombre = nuevosProductos[i].Nombre + " (discontinuado)";
                    retorno = true;
                    break;
                }
            }
            if (retorno == true)
            {
                MessageBox.Show("se hizo la baja exitosamente");
            }
            else
            {
                MessageBox.Show("no se pudo realizar la baja");
            }
        }
        /// <summary>
        /// Cierra form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Stock_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formLogin.Show();
        }
        /// <summary>
        /// Llamo al form para agregar un producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IBtn_Stock_Click(object sender, EventArgs e)
        {
            frm_Agregar_Producto formProductos = new frm_Agregar_Producto();
            formProductos.Show();
        }
        /// <summary>
        /// Modifico producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IBtn_Modif_Prod_Click(object sender, EventArgs e)
        {
            ProductoAComparar = new Productos();
            double precioCasteado;
            int idAComparar;
            string nuevoStockStr;
            int nuevoStock;
            string nuevoPrecio;
            bool retorno = false;
            string idModificacion = Interaction.InputBox("Ingrese el ID del producto a buscar");
            Int32.TryParse(idModificacion, out idAComparar);
            ProductoAComparar.IdProducto = idAComparar;

            for (int i = 0; i < nuevosProductos.Count; i++)
            {
                if (nuevosProductos[i].IdProducto == ProductoAComparar.IdProducto)
                {
                    nuevoStockStr = Interaction.InputBox("Ingrese el nuevo stock del producto");
                    int.TryParse(nuevoStockStr, out nuevoStock);
                    nuevoPrecio = Interaction.InputBox("Ingrese el nuevo precio del producto");
                    double.TryParse(nuevoPrecio, out precioCasteado);
                    if (Validaciones.ValidoNumeroInt(nuevoStock) || Validaciones.ValidoNumeroDouble(precioCasteado))
                    {
                        retorno = true;
                        nuevosProductos[i].Precio = precioCasteado;
                        nuevosProductos[i].Stock = nuevoStock;
                        break;
                    }
                }
            }
            if (retorno == true)
            {
                MessageBox.Show("se modifico su producto exitosamente");
            }
            else
            {
                MessageBox.Show("no se pudo realizar la modificacion");
            }
        }
        /// <summary>
        /// Llamo a form para agregar empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IBtn_Cliente_Agregar_Click(object sender, EventArgs e)
        {
            frm_Agregar_Empleado form_Agrego_Empleado = new frm_Agregar_Empleado();
            form_Agrego_Empleado.Show();
        }
        /// <summary>
        /// Actualizo la informacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IBtn_Refrescar_Click(object sender, EventArgs e)
        {
            ArmoDatagrid();
        }
        /// <summary>
        /// Armo dataGrid
        /// </summary>
        private void ArmoDatagrid()
        {
            nuevosProductos = Comercio.RetornaLista();
            dGViewStock.ReadOnly = true;
            this.dGViewStock.DataSource = null;
            this.dGViewStock.DataSource = nuevosProductos;
            this.dGViewStock.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        /// <summary>
        /// Llamo a form de listados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IBtn_Info_Listados_Click(object sender, EventArgs e)
        {
            frm_Listados formListados = new frm_Listados();
            formListados.Show();
        }
    }
}