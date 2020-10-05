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
    public partial class frm_Agregar_Empleado : Form
    {
        Empleado nuevoEmplado;
        List<Empleado> empleados;
        /// <summary>
        /// Inicializa el form
        /// </summary>
        public frm_Agregar_Empleado()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Crea empleado y lo agrega a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Emplado_Ing_Click(object sender, EventArgs e)
        {
            int auxDni;
            long auxTelefono;
            string legajo = Comercio.generoLegajoEmpleadoNuevo();
            empleados = Comercio.RetornaListaEmpleados();
            lbl_Legajo_Emp.Text = legajo;
            Int32.TryParse(txtBox_Dni_Emp.Text, out auxDni);
            long.TryParse(txtBox_Telefono_Emp.Text, out auxTelefono);
            if (Validaciones.ValidoString(txtBox_Contraseña_Emp.Text) && Validaciones.ValidoNumeroInt(auxDni) &&
               Validaciones.ValidoString(txtBox_Nombre_Emp.Text) && Validaciones.ValidoString(txtBox_Apellido_Emp.Text) &&
               Validaciones.ValidoNumeroLong(auxTelefono) && Validaciones.ValidoString(txtBox_Email_Emp.Text))
            {
                nuevoEmplado = new Empleado(legajo, txtBox_Contraseña_Emp.Text, auxDni,
                                            txtBox_Nombre_Emp.Text, txtBox_Apellido_Emp.Text, auxTelefono,
                                            txtBox_Email_Emp.Text, Comercio.GenerarIdEmpleado(empleados));

                if (Comercio.AgregarEmpleado(nuevoEmplado) == true)
                {
                    MessageBox.Show(nuevoEmplado.Mostrar());
                    MessageBox.Show("alta de empleado exitosamente");
                }
                else
                {
                    MessageBox.Show("error en alta de empleado");
                }
            }
            else
            {
                MessageBox.Show("le falta llenar algun campo");
            }
        }
        /// <summary>
        /// Muestra legajo en el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Agregar_Empleado_Load(object sender, EventArgs e)
        {
            string legajo = Comercio.generoLegajoEmpleadoNuevo();
            lbl_Legajo_Emp.Text = legajo;
        }
    }
}