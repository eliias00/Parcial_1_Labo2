using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class IntExtension
    {
        /// <summary>
        /// Genera Telefono
        /// </summary>
        /// <returns></returns>
        public static int GeneroTelefono()
        {
            Random random = new Random();
            int telefono = random.Next(100, 99999999);
            return telefono;
        }
    }
}
