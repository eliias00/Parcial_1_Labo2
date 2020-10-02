﻿using System;
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

        private void Frm_Agregar_Producto_FormClosing(object sender, FormClosingEventArgs e)
        {
        


        }

        private void Lbl_Precio_Producto_Agre_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Id_Producto_Agre_Click(object sender, EventArgs e)
        {

        }
    }
}
