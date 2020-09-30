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

        public Cliente()
        {

        }
        public Cliente(string auxUsuario, string auxContraseña, int auxDni, string auxNombre,
                       string auxApellido, long auxTel, string auxEmail) :base( auxContraseña,  auxDni,  auxNombre,
                                                                                auxApellido,  auxTel,  auxEmail)
        {
             this.usuario = auxUsuario;
        }
        public string Usuario
        {
            set { this.usuario = value; }
            get { return this.usuario; }
        }
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
        public static bool operator -(List<Cliente> listaClientes, Cliente clientes)
        {
            return (listaClientes.Remove(clientes));
        }

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
        public static bool operator !=(List<Cliente> listaClientes, Cliente clientes)
        {
            return !(listaClientes == clientes);
        }
    }
}
