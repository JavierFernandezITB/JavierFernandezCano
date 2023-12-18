/* Javier Fernández Cano
 *  Email:      javier.fernandez.7e7@itb.cat
 *  Date:       9/10/2023
 *  Version:    1.0.0
 *  
 *  Implementa un programa que demani l’any i aquest retorni si és un any de traspàs. NO es poden fer servir funcions pròpies de C#.
*/


/* Notes:
 *  Input:
 *      value (int)
 *  Output:
 *      number of difits of the value
 *      the sum of the even digits
 *      the sum of the odd digits
*/


// Dependencies.

namespace mainWorkspace
{
    public class mainProgram
    {
        static void Main(string[] args)
        {
            // Constants.

            const string msgInput = "Especifica un valor: ";
            const string msgOutputTrue = "El año especificado es bisiesto.";
            const string msgOutputFalse = "El año especificado no es bisiesto.";

            // Variables.

            int inputValue;

            // Main code.

            Console.Write(msgInput);
            inputValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(inputValue % 4 == 0 && inputValue % 100 != 0 || inputValue % 400 == 0 ? msgOutputTrue : msgOutputFalse);
        }
    }
}