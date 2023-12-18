

/* Javier Fernández Cano
 *  Email:      javier.fernandez.7e7@itb.cat
 *  Date:       9/10/2023
 *  Version:    1.0.0
*/


/* Notes:
 *  Input:
 *      range minimum and maximum values (int)
 *      number to check (int)
 *  Output:
 *      if the number to check is in the specified range (bool)
*/


// Dependencies.
using System;


namespace mainWorkspace
{
    public class mainProgram
    {
        static void Main(string[] args)
        {

            // Constants.

            const string msgInputFirstRange = "Introduzca el primer valor del rango: ";
            const string msgInputSecondRange = "Introduzca el segundo valor del rango: ";
            const string msgInputNumberCheck = "Introduzca el valor a revisar: ";
            const string msgOuputInRange = "El ultimo valor especificado se encuentra dentro del rango.";
            const string msgOuputNotRange = "El ultimo valor especificado no se encuentra dentro del rango.";

            // Variables

            int minRange;
            int maxRange;
            int numberToCheck;

            // Main code.

            Console.Write(msgInputFirstRange);
            minRange = Convert.ToInt32(Console.ReadLine());

            Console.Write(msgInputSecondRange);
            maxRange = Convert.ToInt32(Console.ReadLine());

            Console.Write(msgInputNumberCheck);
            numberToCheck = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numberToCheck > minRange && numberToCheck < maxRange ? msgOuputInRange : msgOuputNotRange);
        }
    }
}