using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        string contraseña;
        protected string nombre;
        protected string apellido;
        protected int    dni;
        protected long   telefono;
        protected string email;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Persona()
        {
            this.contraseña = "sin contraseña";
            this.nombre = "sin nombre";
            this.apellido = "sin apellido";
            this.dni = -1;
            this.telefono = -1;
            this.email = "sin email";
        }
        /// <summary>
        /// Constructor de la clase con parametros
        /// </summary>
        /// <param name="auxContraseña"></param>
        /// <param name="auxDni"></param>
        /// <param name="auxNombre"></param>
        /// <param name="auxApellido"></param>
        /// <param name="auxTel"></param>
        /// <param name="auxEmail"></param>
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
        /// <summary>
        /// Propiedad Contraseña
        /// </summary>
        public string Contraseña
        {
            set { this.contraseña = value; }
            get { return this.contraseña; }
        }
        /// <summary>
        /// Propiedad Nombre
        /// </summary>
        public string Nombre
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }
        /// <summary>
        /// Propiedad Apellido
        /// </summary>
        public string Apellido
        {
            set { this.apellido = value; }
            get { return this.apellido; }
        }
        /// <summary>
        /// Propiedad Dni
        /// </summary>
        public int Dni
        {
            set { this.dni = value; }
            get { return this.dni; }
        }
        /// <summary>
        /// Propiedad Telefono
        /// </summary>
        public long Telefono
        {
            set { this.telefono = value; }
            get { return this.telefono; }
        }
        /// <summary>
        /// Propiedad Email
        /// </summary>
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
        /// <summary>
        /// Genera un stringBuilder con los datos de persona
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0}\n", this.nombre);
            sb.AppendFormat("Apellido: {0}\n", this.apellido);
            sb.AppendFormat("Contraseña: {0}\n", this.contraseña);
            sb.AppendFormat("Dni: {0}\n", this.dni.ToString());
            sb.AppendFormat("Telefono: {0}\n", this.telefono);
            sb.AppendFormat("Email: {0}", this.email);
                                                                         
            return sb.ToString();
        }
    }
}