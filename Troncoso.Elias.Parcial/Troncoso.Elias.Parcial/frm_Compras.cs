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
using System.IO;
using System.Media;

namespace Troncoso.Elias.Parcial
{
    public partial class frm_Compras : Form
    {
        Compra nuevaCompra;
        Cliente clienteCompra;
        Empleado empleadoCompra;
        List<string> nombresProductos;
        List<Productos> nuevosProductos;
        List<Empleado> nuevosEmpleados;
        /// <summary>
        /// Instancia objetos y inicializa el form
        /// </summary>
        public frm_Compras()
        {
            nombresProductos = new List<string>();
            empleadoCompra = new Empleado();
            clienteCompra = new Cliente();
            InitializeComponent();
        }
        /// <summary>
        /// Cargo informacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Compras_Load(object sender, EventArgs e)
        {
            this.iBtn_Descarga_Arch.Visible = false;
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
        /// <summary>
        /// Uso el Drag Drop con las filas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_Stock_Prod_Comp_MouseDown(object sender, MouseEventArgs e)
        {
            int fila;
            fila = dGV_Stock_Prod_Comp.HitTest(e.X, e.Y).RowIndex;
            dGV_Stock_Prod_Comp.DoDragDrop(fila, DragDropEffects.Copy);
        }
        /// <summary>
        /// Muevo el producto de un dataGrid a otro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Copia el origen del dato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_Prod_Comp_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        /// <summary>
        /// Hace la compra del producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Comprar_Click_1(object sender, EventArgs e)
        {
            double suma = 0;
            double numeroCelda = 0;
            string productoCelda;
            double sumaSimpson = 0;
            string[] arreglo;
            string[] usuarioConectado = new string[2];
            frm_Login_Prin formLogin = new frm_Login_Prin();
            bool retorno = false;
            SoundPlayer sonido;
            string[] nombreProducto = new string[nuevosProductos.Count];
            int[] unidadesProducto = new int[nuevosProductos.Count];

            for (int i = 0; i < dGV_Prod_Comp.RowCount - 1; i++)
            {
                if (dGV_Prod_Comp.Rows[i].Cells[1].Value != null && dGV_Prod_Comp.Rows[i].Cells[0].Value != null 
                    && Validaciones.ValidoCelda(dGV_Prod_Comp.Rows[i].Cells[1].Value.ToString()))
                {
                    double.TryParse(dGV_Prod_Comp.Rows[i].Cells[1].Value.ToString(), out numeroCelda);
                    productoCelda = dGV_Prod_Comp.Rows[i].Cells[0].Value.ToString();
                    for (int j = 0; j < nuevosProductos.Count; j++)
                    {
                        if (productoCelda == nuevosProductos[j].Nombre)
                        {
                            if (Comercio.ValidoUnidadesComprar(productoCelda, numeroCelda))
                            {
                                nombresProductos.Add(nuevosProductos[j].Nombre);
                                nombreProducto[j] = nuevosProductos[j].Nombre;
                                unidadesProducto[j] = (int)numeroCelda;
                                numeroCelda = numeroCelda * nuevosProductos[j].Precio;
                                suma = suma + numeroCelda;
                                retorno = true;
                            }
                            else
                            {
                                MessageBox.Show("supera las unidades en stock");
                            }
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            if (retorno == true)
            {
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
                    else if (i == 2)
                    {
                        empleadoCompra.Legajo = arreglo[2];
                        break;
                    }
                }
                empleadoCompra = Comercio.buscoEmpleadoYLoretorno(empleadoCompra);
                if (clienteCompra.Apellido == "simpson")
                {
                    sumaSimpson = Comercio.descuentoSimpson(suma);
                    nuevaCompra = new Compra(empleadoCompra, clienteCompra, sumaSimpson, nombresProductos);
                    sonido = new SoundPlayer(Application.StartupPath + @"\musica\compraSimpson.wav");
                    sonido.Play();
                }
                else
                {
                    nuevaCompra = new Compra(empleadoCompra, clienteCompra, suma, nombresProductos);
                    sonido = new SoundPlayer(Application.StartupPath + @"\musica\graciasVuelva.wav");
                    sonido.Play();
                    MessageBox.Show("Graciass!!! Vuelva Prontosss");
                }
                for (int i = 0; i < nuevosProductos.Count; i++)
                {
                    if (nombreProducto[i] == nuevosProductos[i].Nombre)
                    {
                        nuevosProductos[i].Stock = nuevosProductos[i].Stock - unidadesProducto[i];
                    }
                }
                this.iBtn_Descarga_Arch.Visible = true;
            }
            else
            {
                MessageBox.Show("Hubo un error al hacer la compra.\nREINTENTE");
            }
        }
        /// <summary>
        /// Cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Compras_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formLogin.Show();
        }
        /// <summary>
        /// Genero archivo tipo ticket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IBtn_Descarga_Arch_Click(object sender, EventArgs e)
        {
            string hora = DateTime.Now.ToString("hhmmss");
            string fecha = DateTime.Now.ToString("yyyyMMdd");
            StreamWriter ticket = new StreamWriter(Application.StartupPath + @"\Ticket_Compra_" + fecha + "_" + hora + ".txt");

            ticket.WriteLine("#--------------------- Kwik E Mart ---------------------#");
            ticket.WriteLine(hora.Substring(0, 2) + ":" + hora.Substring(2, 2) + ":" + hora.Substring(4, 2) +
            "  " + fecha.Substring(0, 4) + "/" + fecha.Substring(4, 2) + "/" + fecha.Substring(4, 2) + "             " +
            "Empleado: " + empleadoCompra.Nombre + " " + empleadoCompra.Apellido + "\n");
            ticket.WriteLine("Productos: \n----------");
            for (int i = 0; i < nombresProductos.Count; i++)
            {
                ticket.WriteLine(nombresProductos[i]);
            }
            ticket.WriteLine("--------------------------------------------------------");
            ticket.WriteLine("Total: $" + nuevaCompra.Total);
            ticket.WriteLine("                 Graciass!!! Vuelva Prontosss                 ");
            ticket.WriteLine("                                       Elias Troncoso 2D      ");
            ticket.Close();
        }
    }
}