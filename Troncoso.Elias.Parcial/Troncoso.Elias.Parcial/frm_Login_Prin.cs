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
            txtBox_Usuario.Text = "Leg00001";
            txtBox_Contraseña.Text = "ApupA";
           

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
            SoundPlayer sonido;
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
                     
                        formStock.Visible = true;
                        this.Visible = false;
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
        private void Lbl_login_Click(object sender, EventArgs e)
        {
            frm_Agregar_cliente frmNuevoCliente = new frm_Agregar_cliente();
            frmNuevoCliente.Show();
           


        }

        private void Frm_Login_Prin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void RadioButton_Contraseña_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

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
