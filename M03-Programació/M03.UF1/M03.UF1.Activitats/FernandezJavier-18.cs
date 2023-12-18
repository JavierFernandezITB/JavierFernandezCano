namespace myWorkspace
{
    class mainClass
    {
        static void Main(string[] args)
        {
            // Constants.

            const int characterNumber = 4;
            const int healthIndex = 0;
            const int powerIndex = 1;
            const int strengthIndex = 2;

            const string tableSeparator = " | ";
            const string tabulator = "\t";
            const string doubleTab = tabulator + tabulator;
            const string tableLine = tableSeparator + "-------------" + tableSeparator;
            const string alternativeTableLine = "-------------" + tableSeparator;
            const string infoCharacterCreation = "Let's create your character number ";
            const string inputHealthMessage = "Specify the health for the character [1-1000]: ";
            const string inputPowerMessage = "Specify the power for the character [100-500]: ";
            const string inputStrengthMessage = "Specify the strength for the character [20-50]: ";
            const string outputCharacter = "Character";
            const string outputHealth = "Health";
            const string outputPower = "Power";
            const string outputStrength = "Strength";
            const string errorOutOfRange = "Please, specify a number in the range. Try again: ";

            // Variables.

            int[,] characters = new int[characterNumber, 3];

            int[,] statsMinMax = {
                {1, 1000}, // Health
                {100, 500}, // Power
                {20, 50} // Strength
            };


            // Main code.

            for (int i = 0; i < characterNumber; i++)
            {
                Console.WriteLine(infoCharacterCreation + i + ".");

                Console.Write(inputHealthMessage);
                characters[i, healthIndex] = Convert.ToInt32(Console.ReadLine());
                while (characters[i, healthIndex] < statsMinMax[0, 0] || characters[i, healthIndex] > statsMinMax[0, 1])
                {
                    Console.Write(errorOutOfRange);
                    characters[i, healthIndex] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write(inputPowerMessage);
                characters[i, powerIndex] = Convert.ToInt32(Console.ReadLine());
                while (characters[i, powerIndex] < statsMinMax[1, 0] || characters[i, powerIndex] > statsMinMax[1, 1])
                {
                    Console.Write(errorOutOfRange);
                    characters[i, powerIndex] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write(inputStrengthMessage);
                characters[i, strengthIndex] = Convert.ToInt32(Console.ReadLine());
                while (characters[i, strengthIndex] < statsMinMax[2, 0] || characters[i, strengthIndex] > statsMinMax[2, 1])
                {
                    Console.Write(errorOutOfRange);
                    characters[i, strengthIndex] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();

            Console.WriteLine(tableLine + alternativeTableLine + alternativeTableLine + alternativeTableLine);
            Console.WriteLine(tableSeparator + outputCharacter + tabulator + tableSeparator + outputHealth + tabulator + tableSeparator + outputPower + tabulator + tableSeparator + outputStrength + tabulator + tableSeparator);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(tableLine + alternativeTableLine + alternativeTableLine + alternativeTableLine);
                Console.WriteLine(tableSeparator + outputCharacter + " " + i + tabulator + tableSeparator + characters[i, 0] + doubleTab + tableSeparator + characters[i, 1] + doubleTab + tableSeparator + characters[i, 2] + doubleTab + tableSeparator);
            }
            Console.WriteLine(tableLine + alternativeTableLine + alternativeTableLine + alternativeTableLine);
        }
    }
}