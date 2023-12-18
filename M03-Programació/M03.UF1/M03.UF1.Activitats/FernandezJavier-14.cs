namespace myWorkspace
{
    class mainClass
    {
        static void Main(string[] args)
        {
            // Constants.


            const string inputMessage = "Insert a value: ";
            const string inputErrorNotInRange = "The value must be between 1 and 9. Insert a value: ";


            const int numbersToAskFor = 20;
            const int minArrayRange = 0;


            // Variables.


            int inputValue;


            int[] numberList = new int[numbersToAskFor];


            // Main code.




            for (int i = 0; i < numbersToAskFor; i++)
            {
                Console.Write(inputMessage);
                inputValue = Convert.ToInt32(Console.ReadLine());
                while (inputValue < 1 || inputValue > 9)
                {
                    Console.Write(inputErrorNotInRange);
                    inputValue = Convert.ToInt32(Console.ReadLine());
                }
                numberList[i] = inputValue;
            }


            for (int i = 0; i < numbersToAskFor; i++)
            {
                Console.Write(numberList[i] + " ");
            }


            Console.WriteLine();


            for (int i = numbersToAskFor - 1; i > minArrayRange - 1; i--)
            {
                Console.Write(numberList[i] + " ");
            }


        }
    }
}