// Author: Javier Fernández Cano
// Date: 27 Nov 2023

/*

    Implementa un programa que retorni el valor absolut d'un nombre introduït per teclat.

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

            int inputValue = 0;

            // Main code

            Console.Write(inputMessage);
            inputValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(outputMessage + ToABS(inputValue));
        }

        public static int ToABS(int number)
        {
            return (number >= 0 ? number : -number);
        }
    }
}