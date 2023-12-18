// Author: Javier Fernández Cano
// Date: 27 Nov 2023

/*

    Crea un programa que demani per teclat un la base i l’exponent i retorni la potència.

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

            int baseValue;
            int expValue;

            // Main code

            Console.Write(inputBase);
            baseValue = Convert.ToInt32(Console.ReadLine());
            Console.Write(inputExp);
            expValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(outputMessage + mathPower(baseValue, expValue));
        }

        public static int mathPower(int basen, int exp)
        {
            int temp = 1;
            for (int i = 0; i < exp; i++)
            {
                temp *= basen;
            }
            return (temp);
        }
    }
}