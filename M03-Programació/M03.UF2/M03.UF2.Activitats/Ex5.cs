// Author: Javier Fernández Cano
// Date: 27 Nov 2023

/*

    Demanar un nombre per teclat i indicar per pantalla si aquest nombre és positiu i menor que 100.

*/


namespace myWorkspace
{
    public class FernandezJaviCode
    {
        public static void Main(string[] args)
        {

            // Constants

            const string inputMessage = "Introduce un valor: ";
            const string outputMessage = "El número es positivo y menor que 100.";
            const string notPositive = "El número introducido no es positivo o es menor que 100.";

            // Variables

            int inputValue;

            // Main code

            Console.Write(inputMessage);
            inputValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(isPositiveAndLower(inputValue) ? outputMessage : notPositive);
        }

        public static bool IsPositive(int number)
        {
            return (number > 0);
        }

        public static bool IsLowerThan(int number, int lowerThan)
        {
            return (number < lowerThan);
        }

        public static bool isPositiveAndLower(int number)
        {
            return (IsPositive(number) && IsLowerThan(number, 100));
        }
    }
}