// Author: Javier Fernández Cano
// Date: 6 Nov 2023

/*

Fent servir la interpolació i l’operador ternari, implementa un programa que indiqui pels 20 primers nombres (del 1 al 20 inclosos) si és parell o senar (només ha d’indicar per a cada valor “És parell”/”És senar)”.

*/


namespace myWorkspace
{
    class FernandezJaviCode
    {
        static void Main()
        {

            // Constants

            const int rangeStart = 1;
            const int rangeEnd = 20;

            const string par = "par";
            const string impar = "impar";

            // Variables




            // Main code

            for (int i = rangeStart; i < rangeEnd + 1; i++)
            {
                Console.WriteLine("El número {0} es {1}.", i, (i % 2 == 0) ? par : impar);
            }
            
        }
    }
}