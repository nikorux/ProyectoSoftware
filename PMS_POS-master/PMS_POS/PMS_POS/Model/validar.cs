using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PMS_POS.Model
{
    class validar
    {
        public static void soloNumeros(KeyPressEventArgs tecla, TextBox text)
        {
            if (char.IsDigit(tecla.KeyChar))
            {
                tecla.Handled = false;
            }
            else if (char.IsControl(tecla.KeyChar))
            {
                tecla.Handled = false;
            }
            else
            {
                tecla.Handled = true;
            }
        }

        public static void soloLetras(KeyPressEventArgs tecla, TextBox text)
        {
            if (char.IsLetter(tecla.KeyChar))
            {
                tecla.Handled = false;
            }
            else if (char.IsControl(tecla.KeyChar))
            {
                tecla.Handled = false;
            }
            else if (char.IsSeparator(tecla.KeyChar))
            {
                tecla.Handled = false;
            }
            else
            {
                tecla.Handled = true;
            }
        }
        public static void soloNumerosPunto(KeyPressEventArgs tecla, TextBox text)
        { //función para validar que lo que venga en un txtbox sean numeros y un solo punto decimal y que
            //NO sea al principio

            //booleano para indicar si es un número
            bool isNumber = false;

            // string s para meter el contenido de la textbox dentro
            string s = text.Text;

            //si la tecla es un backspace o cualquier tipo de tecla de control que permita escribir
            if (char.IsControl(tecla.KeyChar))
            {
                tecla.Handled = false;
            }
            else
            {   //si la tecla NO es un numero 
                if (!char.IsDigit(tecla.KeyChar))
                {
                    //que NO permita escribir
                    tecla.Handled = true;
                }
                else
                {
                    tecla.Handled = false;
                    // digo que la tecla pulsada sí es un numero
                    isNumber = true;
                }
                // lo que pasa cuando isNumber == false
                if (!isNumber)
                {  
                    //si la tecla pulsada es un punto
                    if(tecla.KeyChar.ToString() == ".")
                    {   
                        //si el textbox esta vacío
                        if (s.Length == 0)
                        {
                            //que no permita que el primer caracter sea un punto
                            tecla.Handled = true;
                        }
                        // si no está vacío y no hay un punto previamente
                        else if (s.IndexOf(".") == -1)
                        {
                            // que permita escribir el punto
                            tecla.Handled = false;
                        }
                    }
                }
            }
            
        }
        public static void soloNumerosMsk(KeyPressEventArgs tecla, MaskedTextBox text)
        {
            if (char.IsDigit(tecla.KeyChar))
            {
                tecla.Handled = false;
            }
            else if (tecla.KeyChar == '\b')
            {
                tecla.Handled = false;
            }
            else
            {
                tecla.Handled = true;
            }
        }
        
        public static bool validarEmail(string email)
        {
            string regEmail = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(email, regEmail))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
