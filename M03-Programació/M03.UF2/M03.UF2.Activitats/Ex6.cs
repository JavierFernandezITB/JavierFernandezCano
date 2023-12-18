// Author: Javier Fernández Cano
// Date: 27 Nov 2023

/*

    Implementa un programa que retorni el valor absolut d'un nombre introduït per teclat, utilitzant un dels mètodes implementats en la API de .Net. 

*/

namespace myWorkspace
{
    public class FernandezJaviCode
    {
        public static void Main(string[] args)
        {
            // Constants

            const string inputMessage = "Introduce un valor: ";
            const string outputMessage = "El valor absoluto es: ";

            // Variables

            int inputValue;

            // Main code

            Console.Write(inputMessage);
            inputValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(outputMessage + Math.Abs(inputValue));
        }
    }
}