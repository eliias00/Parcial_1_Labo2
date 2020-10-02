using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {
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
