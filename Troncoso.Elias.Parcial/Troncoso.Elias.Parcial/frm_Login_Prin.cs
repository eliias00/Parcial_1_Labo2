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
using System.Media;

namespace Troncoso.Elias.Parcial
{
    public partial class frm_Login_Prin : Form
    {
        Empleado nuevoEmpleado;
        Cliente nuevoCliente;
        /// <summary>
        /// Inicializa el form
        /// </summary>
        public frm_Login_Prin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Cargo Informacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Login_Prin_Load(object sender, EventArgs e)
        {
            lbl_login.Parent = pBox_Login;
            //   txtBox_Usuario.Text = "Ingrese Usuario";
            //  txtBox_Contraseña.Text = "Ingrese Contraseña";
            // PRUEBA
            txtBox_Usuario.Text = "Leg00000";
            txtBox_Contraseña.Text = "ApupA";
            Comercio.CargaDeClientes();
            Comercio.CargaDeEmpleados();
            Comercio.CargaDeCompras();
        }
        /// <summary>
        /// Genera login a la app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Login_Ingre_Click(object sender, EventArgs e)
        {
            nuevoEmpleado = new Empleado();
            nuevoCliente = new Cliente();
            string usuario = txtBox_Usuario.Text;
            string contraseña = txtBox_Contraseña.Text;
            frm_Stock formStock = new frm_Stock();
            frm_Compras formCompras = new frm_Compras();

            nuevoEmpleado.Legajo = usuario;
            nuevoEmpleado.Contraseña = contraseña;
            nuevoCliente.Usuario = usuario;
            nuevoCliente.Contraseña = contraseña;

            Comercio.guardoUsuarioYContraseña(usuario, contraseña); 
            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(contraseña) && 
                usuario != "Ingrese Usuario" && contraseña != "Ingrese Contraseña" && 
                Validaciones.ValidoString(usuario) && Validaciones.ValidoString(contraseña))
            {
                if (usuario.Substring(0, 3) == "Leg")
                {
                    if (Comercio.buscoEmpleado(nuevoEmpleado) == true) 
                    {
                        formStock.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El empleado no existe");
                    }
                }
                else if (usuario.Substring(0, 3) == "Use")
                {
                    if (Comercio.buscoCliente(nuevoCliente) == true)
                    {
                        formCompras.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El cliente no existe");
                    }
                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña INCORRECTOS");
            }
        }
        /// <summary>
        /// Llamo a form para agregar cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lbl_login_Click(object sender, EventArgs e)
        {
            frm_Agregar_cliente frmNuevoCliente = new frm_Agregar_cliente();
            frmNuevoCliente.Show();
            this.Hide();
        }
        /// <summary>
        /// Cierro el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Login_Prin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Configuro la forma de ver la contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox_Contraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Contraseña.Checked == true)
            {
                if(txtBox_Contraseña.PasswordChar == '*')
                {
                    txtBox_Contraseña.PasswordChar = '\0';
                }
            }
            else
            {
                txtBox_Contraseña.PasswordChar = '*';
            }
        }
    }
}