// Author: Javier Fernández Cano
// Date: 27 Nov 2023

/*

    Crea un programa que demani dos nombres per teclat i validi si aquests són naturals. Un cop validats, haurà d’indicar quin dels dos nombres és més gran o si tots dos són iguals.

*/


namespace myWorkspace
{
    public class FernandezJaviCode
    {
        public static void Main(string[] args)
        {

            // Constants

            const string inputMessage = "Introduce un valor: ";
            const string notNatural = "Uno de los números introducidos no es natural.";
            const string isBigger = "{0} es mayor que {1}";
            const string isEquals = "Los dos números son iguales.";

            // Variables

            int inputValue;
            int secondInputValue;

            // Main code

            Console.Write(inputMessage);
            inputValue = Convert.ToInt32(Console.ReadLine());

            Console.Write(inputMessage);
            secondInputValue = Convert.ToInt32(Console.ReadLine());

            if (IsNatural(inputValue) && IsNatural(secondInputValue))
            {
                int result = IsBiggerOrEquals(inputValue, secondInputValue);
                if (result != -1)
                {
                    Console.WriteLine(isBigger, result, (result == inputValue ? secondInputValue : inputValue));
                }
                else
                {
                    Console.WriteLine(isEquals);
                }
            }
            else
            {
                Console.WriteLine(notNatural);
            }

        }

        public static bool IsNatural(int number)
        {
            return number > -1;
        }

        public static int IsBiggerOrEquals(int first, int second)
        {
            if (first == second)
            {
                return -1;
            }
            return (first > second ? first : second);
        }
    }
}