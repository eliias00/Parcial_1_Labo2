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
    public partial class frm_Agregar_cliente : Form
    {
        /// <summary>
        /// Inicializa el form
        /// </summary>
        public frm_Agregar_cliente()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Crea cliente y lo agrega a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Cliente_Ing_Click(object sender, EventArgs e)
        {
            int auxDni;
            long auxTel = 1;
            int.TryParse(txtBox_Dni_Ing.Text, out auxDni);
            long.TryParse(txtBox_Dni_Ing.Text, out auxTel);
            if (Validaciones.ValidoString(txtBox_Usuario_Ing.Text) && Validaciones.ValidoString(txtBox_Contraseña_Ing.Text) &&
                Validaciones.ValidoNumeroInt(auxDni) && Validaciones.ValidoString(txtBox_Nombre_Ing.Text) &&
                Validaciones.ValidoString(txtBox_Apellido_Ing.Text) && Validaciones.ValidoNumeroLong(auxTel) &&
                Validaciones.ValidoString(txtBox_Email_Ing.Text))
            {
                Cliente clienteNuevo = new Cliente(txtBox_Usuario_Ing.Text, txtBox_Contraseña_Ing.Text,
                                                   auxDni, txtBox_Nombre_Ing.Text, txtBox_Apellido_Ing.Text,
                                                  auxTel, txtBox_Email_Ing.Text);

                if (Comercio.AgregarCliente(clienteNuevo) == true)
                {
                    MessageBox.Show(clienteNuevo.Mostrar());
                    MessageBox.Show("alta de cliente exitosamente");
                }
                else
                {
                    MessageBox.Show("error en alta de cliente");
                }
            }
            else
            {
                    MessageBox.Show("Complete todos los campos");
            }
        }
        /// <summary>
        /// Cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Agregar_cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formLogin.Show();
        }
    }
}