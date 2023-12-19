// Author: Javier Fernández Cano
// Date: 19 Dec 2023

/*

     Implementa un programa en C# en el qual demani a l'usuari un número de l'1 al 100 i el programa disposarà de 10 intents per a endevinar-lo. El programa haurà de pensar un número aleatori i preguntar si ha encertat. L'usuari només podrà indicar si és major, menor o igual a cada intent.

*/

namespace myWorkspace
{
    public class myClass
    {
        public static void Main(string[] args)
        {
            const string inputSecretNumber = "Introduce un número del 1-100: ";

            int secretNumber = -1;

            while (!IsInRange(secretNumber, 1, 100))
            {
                Console.WriteLine(inputSecretNumber);
                secretNumber = Convert.ToInt32(Console.ReadLine());
            }

            botTurn(secretNumber);
        }

        public static bool IsInRange(int value, int min, int max)
        { 
            return value >= min && value <= max;
        }

        public static void botTurn(int secretNumber)
        { 
            Random rnd = new Random();

            const int maxTries = 10;

            const string botLostMessage = "Vaya, parece que me he quedado sin intentos :(";
            const string botWonGameMessage = ":D";
            const string triesLeft = "Intentos restantes: {0}";
            const string outputGuess = "\nDiría que es el número {0}.";
            const string playersOptions = "\n1. Igual\n" +
                "2. Mayor\n" +
                "3. Menor\n" +
                "\tRespuesta: ";

            bool gameRunning = true;

            int currentTries = 0;
            int higherThan = 1;
            int lowerThan = 100;

            while (currentTries < maxTries && gameRunning) 
            {
                int guessedNumber = rnd.Next(higherThan, lowerThan);
                Console.WriteLine(outputGuess, guessedNumber);
                Console.Write(playersOptions);
                switch (Console.ReadLine().ToLower())
                { 
                    case "igual":
                        gameRunning = false;
                        break;
                    case "mayor":
                        higherThan = guessedNumber;
                        currentTries++;
                        Console.WriteLine(triesLeft, maxTries - currentTries);
                        break;
                    case "menor":
                        lowerThan = guessedNumber;
                        currentTries++;
                        Console.WriteLine(triesLeft, maxTries - currentTries);
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine(currentTries == maxTries ? botLostMessage : botWonGameMessage);
        }
    }
}