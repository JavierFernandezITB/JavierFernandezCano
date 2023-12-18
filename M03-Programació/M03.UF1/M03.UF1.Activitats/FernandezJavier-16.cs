namespace myWorkspace
{
    class mainClass
    {
        static void Main(string[] args)
        {
            // Constants.

            const string outputMessage = "Insert a value: ";

            const int minusOne = -1;
            const int valuesToAsk = 10;

            // Variables.

            int[] savedValues = new int[valuesToAsk];

            // Main code.

            for (int i = 0; i < valuesToAsk; i++)
            {
                Console.Write(outputMessage);
                savedValues[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = valuesToAsk - 1; i > minusOne; i--)
            {
                Console.Write(savedValues[i] + " ");
            }
        }
    }
}