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
        public frm_Agregar_Producto()
        {
            InitializeComponent();


        }

        private void TxtB_Nombre_Producto_Agre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtB_Id_Producto_Agre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtB_Precio_Producto_Agre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtB_Stock_Producto_Agre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Agregar_Producto_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Agregar_Producto_Click(object sender, EventArgs e)
        {

            string nombre = txtB_Nombre_Producto_Agre.Text;
            int id;
            double precio;
            string Stock = txtB_Stock_Producto_Agre.Text;
            Productos nuevoProducto;
            Productos modificacionProducto = new Productos();

            Int32.TryParse(txtB_Id_Producto_Agre.Text, out id);
            double.TryParse(txtB_Precio_Producto_Agre.Text, out precio);
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

    }
}
