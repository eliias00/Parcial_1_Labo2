using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660
#pragma warning disable CS0661
    public class Cliente :Persona
    {
        string usuario;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Cliente()
        {
        }
        /// <summary>
        /// Constructor de la clase, con los parametros a la clase padre
        /// </summary>
        /// <param name="auxUsuario"></param>
        /// <param name="auxContraseña"></param>
        /// <param name="auxDni"></param>
        /// <param name="auxNombre"></param>
        /// <param name="auxApellido"></param>
        /// <param name="auxTel"></param>
        /// <param name="auxEmail"></param>
        public Cliente(string auxUsuario, string auxContraseña, int auxDni, string auxNombre,
                       string auxApellido, long auxTel, string auxEmail) :base( auxContraseña,  auxDni,  auxNombre,
                                                                                auxApellido,  auxTel,  auxEmail)
        {
             this.usuario = auxUsuario;
        }
        /// <summary>
        /// Propiedad de Usuario
        /// </summary>
        public string Usuario
        {
            set { this.usuario = value; }
            get { return this.usuario; }
        }
        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="listaClientes"></param>
        /// <param name="clientes"></param>
        /// <returns></returns>
        public static bool operator +(List<Cliente> listaClientes, Cliente clientes)
        {
            bool retorno = false;
            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i] != clientes)
                {
                    listaClientes.Add(clientes);
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Sobrecarga del operador -
        /// </summary>
        /// <param name="listaClientes"></param>
        /// <param name="clientes"></param>
        /// <returns></returns>
        public static bool operator -(List<Cliente> listaClientes, Cliente clientes)
        {
            return (listaClientes.Remove(clientes));
        }
        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="listaClientes"></param>
        /// <param name="clientes"></param>
        /// <returns></returns>
        public static bool operator ==(List<Cliente> listaClientes, Cliente clientes)
        {
            bool retorno = false;
            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].usuario == clientes.usuario)
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
        /// <param name="listaClientes"></param>
        /// <param name="clientes"></param>
        /// <returns></returns>
        public static bool operator !=(List<Cliente> listaClientes, Cliente clientes)
        {
            return !(listaClientes == clientes);
        }
        /// <summary>
        /// Hago un override de los datos del cliente
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Los datos del cliente son: \n" );
            sb.AppendLine("**************************\n");
            sb.AppendFormat("Usuario: {0}\n", this.usuario); 
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("--------------------------");

            return sb.ToString();
        }
    }
}