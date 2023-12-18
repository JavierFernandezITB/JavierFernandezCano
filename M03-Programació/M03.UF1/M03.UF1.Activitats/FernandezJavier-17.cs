namespace myWorkspace
{
    class mainClass
    {
        static void Main(string[] args)
        {
            // Constants.


            const string inputMessage = "Specify the number of values: ";
            const string inputErrorMessage = "You may specify something bigger than 0. Try again: ";
            const string inputSecondMessage = "Insert a value: ";
            const string inputSecondErrorMessage = "You must insert a natural number. Try again: ";
            const string outOfRetriesError = "You inserted too many wrong values.";
            const string outputTotal = "Total of numbers inserted: ";
            const string outputSmaller = "Total of numbers that were smaller than 15: ";
            const string outputBigger = "Total of numbers that were bigger than 30: ";


            // Variables.


            int numberOfValues;
            int temporaryValue;
            int smallerThan15 = 0;
            int biggerThan30 = 0;

            bool outOfTries = false;


            // Main code.


            Console.Write(inputMessage);
            numberOfValues = Convert.ToInt32(Console.ReadLine());
            while (numberOfValues < 1)
            {
                Console.Write(inputErrorMessage);
                numberOfValues = Convert.ToInt32(Console.ReadLine());
            }

            int[] valueList = new int[numberOfValues];

            for (int i = 0; i < numberOfValues; i++)
            {
                if (!outOfTries)
                {
                    int maxRetries = 3;
                    int currentTries = 0;
                    Console.Write(inputSecondMessage);
                    temporaryValue = Convert.ToInt32(Console.ReadLine());
                    while (temporaryValue < 0 && currentTries < maxRetries)
                    {
                        currentTries++;
                        if (currentTries >= maxRetries)
                        {
                            outOfTries = true;
                        }
                        else
                        {
                            Console.Write(inputSecondErrorMessage);
                            temporaryValue = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    if (!outOfTries)
                    {
                        valueList[i] = temporaryValue;
                    }
                }
            }

            if (outOfTries)
            {
                Console.WriteLine(outOfRetriesError);
            }
            else 
            {
                for (int i = 0; i < numberOfValues; i++)
                {
                    if (valueList[i] > 30)
                    {
                        biggerThan30++;
                    }
                    else if (valueList[i] < 15)
                    {
                        smallerThan15++;
                    }
                }

                Console.WriteLine(outputTotal + numberOfValues);
                Console.WriteLine(outputSmaller + smallerThan15);
                Console.WriteLine(outputBigger + biggerThan30);
            }
        }
    }
}
