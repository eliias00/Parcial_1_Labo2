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
       

        public frm_Agregar_cliente()
        {
            InitializeComponent();
        }

        private void Frm_Agregar_cliente_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cliente_Ing_Click(object sender, EventArgs e)
        {
            int auxDni;
            long auxTel = 1;
            int.TryParse(txtBox_Dni_Ing.Text, out auxDni);
            long.TryParse(txtBox_Dni_Ing.Text, out auxTel);
            Cliente clienteNuevo = new Cliente(txtBox_Usuario_Ing.Text, txtBox_Contraseña_Ing.Text,
                                               auxDni, txtBox_Nombre_Ing.Text, txtBox_Apellido_Ing.Text,
                                              auxTel, txtBox_Email_Ing.Text );

            if (Comercio.AgregarCliente(clienteNuevo) == true)
            {
                MessageBox.Show("alta de cliente exitosamente");
            }
            else
            {
                MessageBox.Show("error en alta de cliente");
            }
        }
    }
}
