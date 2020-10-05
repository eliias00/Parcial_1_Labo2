using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660
#pragma warning disable CS0661
    public class Empleado : Persona
    {
        string legajo;
        int id;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Empleado()
        {
        }
        /// <summary>
        /// Constructor de la clase con parametros
        /// </summary>
        /// <param name="auxLegajo"></param>
        /// <param name="auxContraseña"></param>
        /// <param name="auxDni"></param>
        /// <param name="auxNombre"></param>
        /// <param name="auxApellido"></param>
        /// <param name="auxTel"></param>
        /// <param name="auxEmail"></param>
        /// <param name="auxId"></param>
        public Empleado(string auxLegajo, string auxContraseña, int auxDni, string auxNombre,
                       string auxApellido, long auxTel, string auxEmail, int auxId) : base(auxContraseña, auxDni, auxNombre,
                                                                                auxApellido, auxTel, auxEmail)
        {
            this.legajo = auxLegajo;
            this.id = auxId;
        }
        /// <summary>
        /// Propiedad Legajo
        /// </summary>
        public string Legajo
        {
            set { this.legajo = value; }
            get { return this.legajo; }
        }
        /// <summary>
        /// Propiedad Id
        /// </summary>
        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }
        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="listaEmpleados"></param>
        /// <param name="empleados"></param>
        /// <returns></returns>
        public static bool operator +(List<Empleado> listaEmpleados, Empleado empleados)
        {
            bool retorno = false;

            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                if (listaEmpleados[i] != empleados)
                {
                    listaEmpleados.Add(empleados);
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Sobrecarga del operador -
        /// </summary>
        /// <param name="listaEmpleados"></param>
        /// <param name="empleados"></param>
        /// <returns></returns>
        public static bool operator -(List<Empleado> listaEmpleados, Empleado empleados)
        {
            return (listaEmpleados.Remove(empleados));
        }
        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="listaEmpleados"></param>
        /// <param name="empleados"></param>
        /// <returns></returns>
        public static bool operator ==(List<Empleado> listaEmpleados, Empleado empleados)
        {
            bool retorno = false;

            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                if (listaEmpleados[i].legajo == empleados.legajo && listaEmpleados[i].Contraseña == empleados.Contraseña)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="listaEmpleados"></param>
        /// <param name="empleados"></param>
        /// <returns></returns>
        public static bool operator !=(List<Empleado> listaEmpleados, Empleado empleados)
        {
            return !(listaEmpleados == empleados);
        }
        /// <summary>
        /// Hago un override de los datos del empleado
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Los datos del empleado son: \n");
            sb.AppendLine("**************************\n");
            sb.AppendFormat("Legajo: {0}\n", this.legajo);
            sb.AppendFormat("Id: {0}\n", this.id.ToString());
            sb.AppendFormat(base.Mostrar());
            sb.AppendLine("\n--------------------------");

            return sb.ToString();
        }
    }
}