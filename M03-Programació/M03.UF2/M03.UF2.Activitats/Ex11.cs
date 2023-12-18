// Author: Javier Fernández Cano
// Date: 5 Dec 2023

/*

    Implementa un programa que demani un valor per teclat i retorni el seu factorial.    

*/

namespace myWorkspace
{
    public class myClass
    {
        public static void Main(string[] args)
        {
            const string inputMessage = "Introduce un número: ";
            const string outputFactorial = "El número factorial es: {0}";

            int inputValue;

            Console.Write(inputMessage);
            inputValue = Convert.ToInt32(Console.ReadLine());

            Console.Write(outputFactorial, Factorial(inputValue));

        }

        public static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}