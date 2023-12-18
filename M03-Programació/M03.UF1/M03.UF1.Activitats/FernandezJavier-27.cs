// Author: Javier Fernández Cano
// Date: 6 Nov 2023

/*

Implementa un programa que demani a l’usuari que introdueixi un text i el retorni tot en majúscules, tot en minúscules i la primera lletra de cada paraula en majúscules (per separat).

*/


namespace myWorkspace
{
    class FernandezJaviCode
    {
        static void Main()
        {

            // Constants

            const string inputFirstMessage = "Introduce una frase: ";

            const char space = ' ';

            // Variables

            int asciiValue;

            string inputText;


            // Main code

            Console.Write(inputFirstMessage);
            inputText = Console.ReadLine();

            for (int i = 0; i < inputText.Length; i++)
            {
                asciiValue = Convert.ToInt32(inputText[i]);
                if (asciiValue >= 97 && asciiValue <= 122)
                {
                    // asciiValue is lowercase.
                    Console.Write(Convert.ToChar(asciiValue - 32)); // Convert to uppercase.
                } else {
                    Console.Write(inputText[i]);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < inputText.Length; i++)
            {
                asciiValue = Convert.ToInt32(inputText[i]);
                if (asciiValue >= 65 && asciiValue <= 90)
                {
                    // asciiValue is uppercase.
                    Console.Write(Convert.ToChar(asciiValue + 32)); // Convert to lowercase.
                }
                else
                {
                    Console.Write(inputText[i]);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < inputText.Length; i++)
            {
                if (inputText[i] == space)
                {
                    Console.Write(space);
                    i++; // Skip iteration.
                    asciiValue = Convert.ToInt32(inputText[i]);
                    if (asciiValue >= 97 && asciiValue <= 122)
                    {
                        // asciiValue is lowercase.
                        Console.Write(Convert.ToChar(asciiValue - 32)); // Convert to uppercase.
                    }
                    else
                    {
                        Console.Write(inputText[i]);
                    }
                }
                else
                {
                    if (i == 0) // Turn the first character to uppercase.
                    {
                        asciiValue = Convert.ToInt32(inputText[i]);
                        if (asciiValue >= 97 && asciiValue <= 122)
                        {
                            // asciiValue is lowercase.
                            Console.Write(Convert.ToChar(asciiValue - 32)); // Convert to uppercase.
                        }
                        else
                        {
                            Console.Write(inputText[i]);
                        }
                    }
                    else
                    {
                        asciiValue = Convert.ToInt32(inputText[i]);
                        if (asciiValue >= 65 && asciiValue <= 90)
                        {
                            // asciiValue is uppercase.
                            Console.Write(Convert.ToChar(asciiValue + 32)); // Convert to lowercase.
                        }
                        else
                        {
                            Console.Write(inputText[i]);
                        }
                    }
                }
            }
        }
    }
}