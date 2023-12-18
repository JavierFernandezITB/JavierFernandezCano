

/* Javier Fernández Cano
 *  Email:      javier.fernandez.7e7@itb.cat
 *  Date:       10/10/2023
 *  Version:    1.0.0
 *  
 *  Implementa un programa on l’usuari introdueixi dos valors enters: el valor final i el salt. 
 *  El programa haurà d’escriure tots els números des de l'1 fins al valor final (inclòs), amb una distància del salt indicat.
 *  
*/


/* Notes:
 *  Input:
 *      two values (int)
 *  Output:
 *      from 1 to the specified number (included) with the specified step
*/


// Dependencies.
using System;


namespace DataTypes
{
    class MyDataTypes
    {
        static void Main()
        {
            // Constants.

            const string msgInputEnd = "Introduce el número final: ";
            const string msgInputStep = "Introduze el número de salto: ";
            const string msgError = "El número no puede ser negativo, introduce otro: ";

            // Variables.

            int inputValue;
            int inputStep;

            // Main code.

            Console.Write(msgInputEnd);
            inputValue = Convert.ToInt32(Console.ReadLine());

            while (inputValue <= 1)
            {
                Console.Write(msgError);
                inputValue = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write(msgInputStep);
            inputStep = Convert.ToInt32(Console.ReadLine());

            while (inputStep <= 1)
            {
                Console.Write(msgError);
                inputStep = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i < inputValue+1; i += inputStep)
            {
                Console.Write(i + " ");
            }
        }
    }
}