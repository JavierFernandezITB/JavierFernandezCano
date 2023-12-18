/* Javier Fernández Cano
 *  Email:      javier.fernandez.7e7@itb.cat
 *  Date:       10/10/2023
 *  Version:    1.0.0
 *  
 *  Implementa un programa que imprimeixi tots els nombres enters divisibles per 3 que hi ha entre num1 i num2 (inclosos), ambdós nombres enters introduïts per teclat.
 *  
*/


/* Notes:
 *  Input:
 *      two values (int)
 *  Output:
 *      all the numbers between the two values (included) that can be divided by 3
*/


// Dependencies.

namespace DataTypes
{
    class MyDataTypes
    {
        static void Main()
        {
            // Constants.

            const string msgInputStart = "Introduce el número inicial: ";
            const string msgInputEnd = "Introduze el número de final: ";

            // Variables.

            int inputStart;
            int inputEnd;

            // Main code.

            Console.Write(msgInputStart);
            inputStart = Convert.ToInt32(Console.ReadLine());

            Console.Write(msgInputEnd);
            inputEnd = Convert.ToInt32(Console.ReadLine());

            for (int i = inputStart; i < inputEnd + 1; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}