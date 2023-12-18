// Author: Javier Fernández Cano
// Date: 4 Dec 2023


// SIN ACABAR !!!!!

namespace Refactoring
{
    public class FirstRefactoringExercise
    {
        public static void Main(string[] args)
        {
            const string inputQuantityMessage = "Indica quants valors vols introduir: ";

            int quantity, minRange = 5, maxRange = 150, maxTries = 3;
            int[][] capturedOutput;

            quantity = AskForNumber(inputQuantityMessage);

            capturedOutput = AskForNumbers(quantity, minRange, maxRange, maxTries);

            if (ErrorCheck(capturedOutput[0][0], maxTries))
            {
                Console.WriteLine("Has superat el total d'intents.");
            }
            else
            {
                OutputResults(capturedOutput[1]);
            }
        }

        public static int AskForNumber(string message)
        {
            Console.Write(message);
            return (Convert.ToInt32(Console.ReadLine()));
        }

        public static void OutputResults(int[] numbers)
        {
            int answer = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                answer = answer * numbers[i];
            }
            Console.WriteLine(answer);
        }

        public static int[][] AskForNumbers(int quantity, int minRange, int maxRange, int maxTries)
        {
            int input;
            int[][] outputResult = {
                new int[] { 0 }, // Errors.
                new int[quantity] // Numbers.
            };
            for (int i = 0; i < outputResult[1].Length; i++)
            {
                if (!ErrorCheck(outputResult[0][0], maxTries))
                {
                    Console.Write("introdueix un valor entre el {0} i el {1} (inclosos). Tens {2} intents com a màxim. ", minRange, maxRange, maxTries);
                    input = Convert.ToInt32(Console.ReadLine());
                    if (IsInRange(input, minRange, maxRange))
                    {
                        outputResult[1][i] = input;
                    }
                    else
                    {
                        Console.WriteLine("El valor introduït no és vàlid.");
                        outputResult[0][0]++;
                        i--;
                    }
                }
            }
            return outputResult;
        }

        public static bool IsInRange(int value, int minRange, int maxRange)
        {
            return (value > minRange && value < maxRange);
        }

        public static bool ErrorCheck(int errors, int maxErrors)
        {
            return (errors >= maxErrors);
        }
    }
}