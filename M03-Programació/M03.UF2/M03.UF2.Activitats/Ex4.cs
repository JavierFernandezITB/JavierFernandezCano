// Author: Javier Fernández Cano
// Date: 27 Nov 2023

/*

    Implementa un mètode que rebi un text i el retorni a majúscules o a minúscules (segons el cas).

*/


namespace myWorkspace
{
    public class FernandezJaviCode
    {
        public static void Main(string[] args)
        {

            // Constants

            const string inputMessage = "Introduce una frase: ";

            // Variables

            string inputValue;

            // Main code

            Console.Write(inputMessage);
            inputValue = Console.ReadLine();

            Console.WriteLine(SwitchUpperLower(inputValue));
        }

        public static string SwitchUpperLower(string text)
        {
            return (text.ToUpper() == text ? text.ToLower() : text.ToUpper());
        }
    }
}