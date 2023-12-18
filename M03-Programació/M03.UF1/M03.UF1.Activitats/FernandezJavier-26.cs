// Author: Javier Fernández Cano
// Date: 6 Nov 2023

/*

Implementa un programa que demani a l’usuari que introdueixi un text i retorni la seva longitud.

*/


namespace myWorkspace
{
    class FernandezJaviCode
    {
        static void Main()
        {

            // Constants

            const string inputFirstMessage = "Introduce una frase: ";

            // Variables

            string inputText;

            // Main code

            Console.Write(inputFirstMessage);
            inputText = Console.ReadLine();

            Console.WriteLine($"La frase que has introducido tiene {inputText.Length} carácteres.");
        }
    }
}