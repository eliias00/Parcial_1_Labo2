using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {

        protected string contraseña;
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected long telefono;
        protected string email;

        public Persona()
        {
            this.contraseña = "sin contraseña";
            this.nombre = "sin nombre";
            this.apellido = "sin apellido";
            this.dni = -1;
            this.telefono = -1;
            this.email = "sin email";
        }

        public Persona(string auxContraseña, int auxDni, string auxNombre,
                       string auxApellido, long auxTel, string auxEmail) : this()
        {
            this.contraseña = auxContraseña;
            this.nombre = auxNombre;
            this.apellido = auxApellido;
            this.dni = auxDni;
            this.telefono = auxTel;
            this.email = auxEmail;
        }

        public string Contraseña
        {
            get { return this.contraseña; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        public string Apellido
        {
            get { return this.apellido; }
        }
        public int Dni
        {
            get { return this.dni; }
        }
        public long Telefono
        {
            get { return this.telefono; }
        }
        public string Email
        {
            get { return this.email; }
        }
    }
}
