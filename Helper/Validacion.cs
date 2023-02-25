using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class Validacion
    {
        public static bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool soloLetrasYnumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsLetter(caracter) || char.IsDigit(caracter)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
