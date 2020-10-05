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
    public partial class frm_Agregar_Producto : Form
    {
        /// <summary>
        /// Inicializa el form
        /// </summary>
        public frm_Agregar_Producto()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Crea producto y lo agrega a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Agregar_Producto_Click(object sender, EventArgs e)
        {
            string nombre = txtB_Nombre_Producto_Agre.Text;
            int id;
            double precio;
            int Stock;
            Productos nuevoProducto;
            Productos modificacionProducto = new Productos();

            Int32.TryParse(txtB_Id_Producto_Agre.Text, out id);
            Int32.TryParse(txtB_Stock_Producto_Agre.Text, out Stock);
            double.TryParse(txtB_Precio_Producto_Agre.Text, out precio);
            if (Validaciones.ValidoString(nombre) && Validaciones.ValidoNumeroInt(id) &&
               Validaciones.ValidoNumeroInt(Stock) && Validaciones.ValidoNumeroDouble(precio))
            {
                nuevoProducto = new Productos(nombre, id, precio, Stock);
                if (Comercio.AgregarProducto(nuevoProducto) == true)
                {
                    MessageBox.Show("Su producto se dio de alta");
                }
                else
                {
                    MessageBox.Show("Su producto no se dio de alta");
                }
            }
            else
            {
                MessageBox.Show("Le falta completar un campo");
            }
        }
    }
}