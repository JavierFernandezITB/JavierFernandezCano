// Author: Javier Fernández Cano
// Date: 27 Nov 2023

/*

    Implementa un mètode que retorni 10 nombres al·leatoris entre 0 i 256.

*/

namespace myWorkspace
{
    public class FernandezJaviCode
    {
        public static void Main(string[] args)
        {
            // Constants

            Random rnd = new Random();

            const int times = 10;

            const string outputMessage = "Número {0}: {1}";

            // Variables



            // Main code

            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(outputMessage, i+1, rnd.Next(0,257));
            }
        }
    }
}