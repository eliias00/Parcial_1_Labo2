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
    public partial class frm_Login_Prin : Form
    {
        Empleado nuevoEmpleado;
        Cliente nuevoCliente;
        public frm_Login_Prin()
        {

            InitializeComponent();
        }

        private void Frm_Login_Prin_Load(object sender, EventArgs e)
        {
            lbl_login.Parent = pBox_Login;
            //   txtBox_Usuario.Text = "Ingrese Usuario";
            //  txtBox_Contraseña.Text = "Ingrese Contraseña";
            // PRUEBA
            txtBox_Usuario.Text = "leg00001";
            txtBox_Contraseña.Text = "Ingresea";

            Comercio.CargaDeClientes();
            Comercio.CargaDeEmpleados();
            Comercio.CargaDeCompras();

        }

        private void FileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void PBox_Login_Click(object sender, EventArgs e)
        {

        }

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

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(contraseña) && usuario != "Ingrese Usuario" && contraseña != "Ingrese Contraseña")
            {
                if (usuario.Substring(0, 3) == "leg")
                {
                    if (Comercio.buscoEmpleado(nuevoEmpleado) == true)
                    {
                        formStock.Show();
                    }
                    else
                    {
                        MessageBox.Show("El empleado no existe");
                    }

                }
                else if (usuario.Substring(0, 3) == "use")
                {

                    if (Comercio.buscoCliente(nuevoCliente) == true)
                    {
                        formCompras.Show();
                    }
                    else
                    {
                        MessageBox.Show("El cliente no existe");
                    }

                }
            }
            else
            {
                MessageBox.Show("debe llenar los campos");
            }
        }
        private void Lbl_login_Click(object sender, EventArgs e)
        {
            frm_Agregar_cliente frmNuevoCliente = new frm_Agregar_cliente();
            frmNuevoCliente.Show();
           // this.Hide();


        }

        private void Frm_Login_Prin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
