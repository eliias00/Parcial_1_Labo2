using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {

         string contraseña;
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
            set { this.contraseña = value; }
            get { return this.contraseña; }
        }
        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }
        public string Apellido
        {
            set { this.apellido = value; }
            get { return this.apellido; }
        }
        public int Dni
        {
            set { this.dni = value; }
            get { return this.dni; }
        }
        public long Telefono
        {
            set { this.telefono = value; }
            get { return this.telefono; }
        }
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
      /*  public int Id
        {
            get { return this.id; }
        }*/
    }
}
