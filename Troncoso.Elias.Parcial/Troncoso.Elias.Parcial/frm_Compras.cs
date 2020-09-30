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

namespace Troncoso.Elias.Parcial
{
    public partial class frm_Compras : Form
    {
        Compra nuevaCompra;
        Cliente clienteCompra;
        Empleado empleadoCompra;

        List<Productos> nuevosProductos;
        List<Empleado> nuevosEmpleados;
        public frm_Compras()
        {
            empleadoCompra = new Empleado();
            clienteCompra = new Cliente();
            InitializeComponent();
        }
        private void Frm_Compras_Load(object sender, EventArgs e)
        {
            this.dGV_Prod_Comp.AllowDrop = true;
            nuevosEmpleados = Comercio.RetornaListaEmpleados();
            string nombreAleatorio = Comercio.EmpleadoAleatorio(nuevosEmpleados);
            Comercio.CargaDeDatos();
            nuevosProductos = Comercio.RetornaLista();

            foreach (Productos productos in nuevosProductos)
            {
                this.dGV_Stock_Prod_Comp.Rows.Add(productos.Nombre, productos.IdProducto, productos.Precio, productos.Stock);
                this.dGV_Prod_Comp.Rows.Add();
            }
            lbl_Nombre_Empleado.Text = nombreAleatorio;

        }

        private void DGV_Stock_Prod_Comp_MouseDown(object sender, MouseEventArgs e)
        {
            int fila;
            fila = dGV_Stock_Prod_Comp.HitTest(e.X, e.Y).RowIndex;
            dGV_Stock_Prod_Comp.DoDragDrop(fila, DragDropEffects.Copy);
        }

        private void DGV_Prod_Comp_DragDrop(object sender, DragEventArgs e)
        {
            int destRow;
            int destCol;
            int fila = Convert.ToInt32(e.Data.GetData(Type.GetType("System.Int32")));
            Point productos = dGV_Prod_Comp.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo hit = dGV_Prod_Comp.HitTest(productos.X, productos.Y);
            if (hit.Type == DataGridViewHitTestType.Cell)
            {
                destRow = hit.RowIndex;
                destCol = hit.ColumnIndex;
                dGV_Prod_Comp.Rows[destRow].Cells[destCol].Value = dGV_Stock_Prod_Comp.Rows[fila].Cells[0].Value;
            }
        }

        private void DGV_Prod_Comp_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void DGV_Prod_Comp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_Stock_Prod_Comp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Comprar_Click_1(object sender, EventArgs e)
        {
            double suma = 0;
            double numeroCelda = 0;
            string productoCelda;
            double sumaSimpson = 0;

            string[] arreglo;
            string[] usuarioConectado = new string[2];

            frm_Login_Prin formLogin = new frm_Login_Prin();

            string[] nombreProducto = new string[nuevosProductos.Count];
            int[] unidadesProducto = new int[nuevosProductos.Count];


            for (int i = 0; i < dGV_Prod_Comp.RowCount - 1; i++)
            {
                if (dGV_Prod_Comp.Rows[i].Cells[1].Value != null && dGV_Prod_Comp.Rows[i].Cells[0].Value != null)
                {
                    double.TryParse(dGV_Prod_Comp.Rows[i].Cells[1].Value.ToString(), out numeroCelda);
                    productoCelda = dGV_Prod_Comp.Rows[i].Cells[0].Value.ToString();

                    for (int j = 0; j < nuevosProductos.Count; j++)
                    {
                        if (productoCelda == nuevosProductos[j].Nombre)
                        {
                            nombreProducto[j] = nuevosProductos[j].Nombre;
                            unidadesProducto[j] = (int)numeroCelda;
                            numeroCelda = numeroCelda * nuevosProductos[j].Precio;
                            suma = suma + numeroCelda;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            usuarioConectado = Comercio.retornoUsuarioYContraseña();
            for (int i = 0; i < usuarioConectado.Length; i++)
            {
                if (i == 0)
                {
                    clienteCompra.Usuario = usuarioConectado[0];
                }
                else if (i == 1)
                {
                    clienteCompra.Contraseña = usuarioConectado[1];
                    break;
                }
            }
            clienteCompra = Comercio.buscoClienteYLoretorno(clienteCompra);

            arreglo = lbl_Nombre_Empleado.Text.Split();
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (i == 0)
                {
                    empleadoCompra.Nombre = arreglo[0];
                }
                else if (i == 1)
                {
                    empleadoCompra.Apellido = arreglo[1];
                    break;
                }
            }
            empleadoCompra = Comercio.buscoEmpleadoYLoretorno(empleadoCompra);
            if (clienteCompra.Apellido == "simpson")
            {
                sumaSimpson = Comercio.descuentoSimpson(suma);
                nuevaCompra = new Compra(empleadoCompra, clienteCompra, sumaSimpson);
            }
            
            nuevaCompra = new Compra(empleadoCompra, clienteCompra, suma);

            for (int i = 0; i < nuevosProductos.Count; i++)
            {
                if(nombreProducto[i] == nuevosProductos[i].Nombre )
                {

                    nuevosProductos[i].Stock = nuevosProductos[i].Stock - unidadesProducto[i];
                 //   MessageBox.Show(nuevosProductos[i].Stock.ToString());
                }
            }

        }
    }
}
