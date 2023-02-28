using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                if (!(char.IsLetter(caracter) || char.IsDigit(caracter) || char.IsSeparator(caracter)))
                {
                    return false;
                }
            }
            return true;
        }
        public static void UnaComa(KeyPressEventArgs e,String cadena)
        {
            bool validar = true; 
            int contador = 0;
            string caracter = "";
            for (int i = 0; i < cadena.Length; i++)
            {
                caracter = cadena.Substring(i, 1);
                if(caracter == ",")
                {
                    contador++;
                }
            }

            if(contador == 0)
            {
                validar = true;
                if(e.KeyChar == ',' && validar)
                {
                    validar = false;
                    e.Handled = false;
                }
                else if(Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if(Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            else
            {
                validar = false;
                e.Handled = true;
                
                
                 if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
        }

        
    }
}
