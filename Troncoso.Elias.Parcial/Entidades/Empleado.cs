using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660
#pragma warning disable CS0661
    public class Empleado:Persona
    {
        string legajo;
        int id;

        public Empleado()
        {

        }
        public Empleado(string auxLegajo, string auxContraseña, int auxDni, string auxNombre,
                       string auxApellido, long auxTel, string auxEmail,int auxId) : base(auxContraseña, auxDni, auxNombre,
                                                                                auxApellido, auxTel, auxEmail)
        {
            this.legajo = auxLegajo;
            this.id = auxId;
        }
        public string Legajo
        {
            set { this.legajo = value; }
            get { return this.legajo; }
        }
        public int Id
        {
            set { this.id= value; }
            get { return this.id; }
        }
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
        public static bool operator -(List<Empleado> listaEmpleados, Empleado empleados)
        {
            return (listaEmpleados.Remove(empleados));
        }

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
        public static bool operator !=(List<Empleado> listaEmpleados, Empleado empleados)
        {
            return !(listaEmpleados == empleados);
        }
    }
}
