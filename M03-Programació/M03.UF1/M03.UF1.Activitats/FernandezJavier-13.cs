namespace myWorkspace
{
    class mainClass
    {
        static void Main(string[] args)
        {
            // Constants.


            const string inputMessage = "Insert a value: ";
            const string outputMessage = "These are the numbers in the odd positions from the list: ";


            const int numbersToAskFor = 20;


            // Variables.


            int[] numberList = new int[numbersToAskFor];


            // Main code.




            for (int i = 0; i < numbersToAskFor; i++)
            {
                Console.Write(inputMessage);
                numberList[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write(outputMessage);


            for (int i = 0; i < numbersToAskFor; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    Console.Write(numberList[i] + " ");
                }
            }


        }
    }
}
