using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {
        /// <summary>
        /// Valido en formato string numeros
        /// </summary>
        /// <param name="auxString"></param>
        /// <returns></returns>
        public static bool ValidoCelda(string auxString)
        {
            bool retorno = true;
            for (int i = 0; i < auxString.Length; i++)
            {
                if (auxString[i] > '9' || auxString[i] < '0')
                {
                    retorno = false;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Valido string
        /// </summary>
        /// <param name="auxString"></param>
        /// <returns></returns>
        public static bool ValidoString(string auxString)
        {
            if (String.IsNullOrEmpty(auxString))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Valido int
        /// </summary>
        /// <param name="auxNumero"></param>
        /// <returns></returns>
        public static bool ValidoNumeroInt(int auxNumero)
        {
            if (auxNumero <= 0 && auxNumero.ToString() == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Valido double
        /// </summary>
        /// <param name="auxNumero"></param>
        /// <returns></returns>
        public static bool ValidoNumeroDouble(double auxNumero)
        {
            if (auxNumero <= 0 && auxNumero.ToString() == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Valido Long
        /// </summary>
        /// <param name="auxNumero"></param>
        /// <returns></returns>
        public static bool ValidoNumeroLong(long auxNumero)
        {
            if (auxNumero <= 0 && auxNumero.ToString() == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}