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

namespace Troncoso.Elias.Parcial
{
    public partial class frm_Agregar_Empleado : Form
    {
            Empleado nuevoEmplado;
        public frm_Agregar_Empleado()
        {
            InitializeComponent();
        }

        private void Btn_Emplado_Ing_Click(object sender, EventArgs e)
        {
            int auxId;
            long auxTelefono;
           
            Int32.TryParse(txtBox_Dni_Emp.Text, out auxId);
            long.TryParse(txtBox_Telefono_Emp.Text, out auxTelefono);
            nuevoEmplado = new Empleado(txtBox_Legajo_Emp.Text, txtBox_Contraseña_Emp.Text, auxId,
                                        txtBox_Nombre_Emp.Text, txtBox_Apellido_Emp.Text, auxTelefono,
                                        txtBox_Email_Emp.Text);
            
            if (Comercio.AgregarEmpleado(nuevoEmplado) == true)
            {
                MessageBox.Show("alta de empleado exitosamente");
            }
            else
            {
                MessageBox.Show("error en alta de empleado");
            }
        }
    }
}