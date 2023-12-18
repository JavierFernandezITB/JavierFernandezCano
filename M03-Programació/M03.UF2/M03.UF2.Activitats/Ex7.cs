// Author: Javier Fernández Cano
// Date: 27 Nov 2023

/*

    Implementa un programa que retorni el la potència d'un nombre introduït per teclat, utilitzant un dels mètodes implementats en la API de .Net. 

*/

namespace myWorkspace
{
    public class FernandezJaviCode
    {
        public static void Main(string[] args)
        {
            // Constants

            const string inputBase = "Introduce la base: ";
            const string inputExp = "Introduce el exponente: ";
            const string outputMessage = "El resultado es: ";

            // Variables

            int baseValue, expValue;

            // Main code

            Console.Write(inputBase);
            baseValue = Convert.ToInt32(Console.ReadLine());
            Console.Write(inputExp);
            expValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(outputMessage + Math.Pow(baseValue, expValue));
        }
    }
}