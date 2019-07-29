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
        //commit
        //commit 2
        //commit 3
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
        
        public static bool ValidarEmail(string email)
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
            //* Método o función para validar una cédula dominicana*
            public static bool ValidarCedula(string cedula)
            {
                //Declaración de variables a nivel de método o función.
                int verificador = 0;
                int digito = 0;
                int digitoVerificador = 0;
                int digitoImpar = 0;
                int sumaPar = 0;
                int sumaImpar = 0;
                int longitud = Convert.ToInt32(cedula.Length);
                /*Control de errores en el código*/
                try
                {
                    //verificamos que la longitud del parametro sea igual a 11
                    if (longitud == 11)
                    {
                        digitoVerificador = Convert.ToInt32(cedula.Substring(10, 1));
                        //recorremos en un ciclo for cada dígito de la cédula
                        for (int i = 9; i >= 0; i--)
                      {
                //si el digito no es par multiplicamos por 2
                digito = Convert.ToInt32(cedula.Substring(i, 1));
                if ((i % 2) != 0)
                {
                    digitoImpar = digito * 2;
                    //si el digito obtenido es mayor a 10, restamos 9
                    if (digitoImpar >= 10)
                    {
                        digitoImpar = digitoImpar - 9;
                    }
                    sumaImpar = sumaImpar + digitoImpar;
                }
                /*En los demás casos sumamos el dígito y lo aculamos 
                 en la variable */
                else
                {
                    sumaPar = sumaPar + digito;
                }
            }
            /*Obtenemos el verificador restandole a 10 el modulo 10 
            de la suma total de los dígitos*/
            verificador = 10 - ((sumaPar + sumaImpar) % 10);
            /*si el verificador es igual a 10 y el dígito verificador
              es igual a cero o el verificador y el dígito verificador 
              son iguales retorna verdadero*/
            if (((verificador == 10) && (digitoVerificador == 0))
                      || (verificador == digitoVerificador))
                      {
                return true;
            }
        }
                  else
                 {
                  Console.WriteLine("La cédula debe contener once(11) digitos");
                }
}
             catch
              {
                Console.WriteLine("No se pudo validar la cédula");
             }
              return false;
         }
        public static void ValidarPasaporte(KeyPressEventArgs tecla, TextBox text)
        {
            if (char.IsLetter(tecla.KeyChar))
            {
                tecla.Handled = false;
            }
            else if (char.IsControl(tecla.KeyChar))
            {
                tecla.Handled = false;
            }
            else if (char.IsDigit(tecla.KeyChar))
            {
                tecla.Handled = false;
            }
            else
            {
                tecla.Handled = true;
            }
        }
        
    }
}
