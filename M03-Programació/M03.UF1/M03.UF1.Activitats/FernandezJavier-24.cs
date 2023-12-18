// Author: Javier Fernández Cano
// Date: 6 Nov 2023

/*

Fent servir la interpolació, implementa un programa en el que es demani a l’usuari el seu nom, cognoms i edat i retorni un missatge informatiu, com a l’exemple:

*/


namespace myWorkspace
{
    class FernandezJaviCode
    {
        static void Main()
        {

            // Constants

            const string inputFirstMessage = "Introduce tu nombre: ";
            const string inputSecondMessage = "Introduce tu apellido: ";
            const string inputThirdMessage = "Introduce tu edad: ";
            const string inputErrorAge = "No creo que tengas una edad negativa. Inténtalo de nuevo: ";

            // Variables

            string name;
            string surname;
            int age;

            // Main code

            Console.Write(inputFirstMessage);
            name = Console.ReadLine();

            Console.Write(inputSecondMessage);
            surname = Console.ReadLine();

            Console.Write(inputThirdMessage);
            age = Convert.ToInt32(Console.ReadLine());
            while (age < 0)
            {
                Console.Write(inputErrorAge);
                age = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"El usuario {name} {surname} tiene {age} años.");
        }
    }
}