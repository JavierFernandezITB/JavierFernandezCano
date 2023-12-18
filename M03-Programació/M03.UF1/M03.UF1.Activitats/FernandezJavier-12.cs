namespace myWorkspace
{
    class mainClass
    {
        static void Main(string[] args)
        {
            // Constants.


            const string inputMessage = "Insert a value: ";
            const string outputEven = "Even numbers: ";
            const string outputOdd = "Odd numbers: ";


            const int numbersToAskFor = 20;


            // Variables.


            int[] oddNumbers = new int[numbersToAskFor];
            int[] evenNumbers = new int[numbersToAskFor];




            int evenInserted = 0;
            int oddInserted = 0;
            int temporaryNumber;


            // Main code.


            for (int i = 0; i < numbersToAskFor; i++)
            {
                Console.Write(inputMessage);
                temporaryNumber = Convert.ToInt16(Console.ReadLine());
                if (temporaryNumber % 2 == 0)
                {
                   
                    evenNumbers[evenInserted] = temporaryNumber;
                    evenInserted += 1;
                }
                else {
                    oddNumbers[oddInserted] = temporaryNumber;
                    oddInserted += 1;
                }
            }


            Console.Write(outputEven);


            for (int i = 0; i < evenInserted; i++)
            {
                Console.Write(oddNumbers[i] != 0 ? evenNumbers[i] + " " : "");
            }


            Console.WriteLine();


            Console.Write(outputOdd);
            for (int i = 0; i < oddInserted; i++)
            {
                Console.Write(oddNumbers[i] != 0 ? oddNumbers[i] + " " : "");
            }
        }
    }
}
