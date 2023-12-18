using System;

namespace myWorkspace
{
    class mainClass
    {
        static void Main(string[] args)
        {
            // Constants.

            const string inputMessage = "How much values do you want to insert? ";
            const string inputSecondMessage = "Specify a value: ";
            const string outputMessage = "The sum of the values is: ";

            // Variables.

            int sumOfValues = 0;
            int valuesSpecified;

            // Main code.

            do
            {
                Console.Write(inputMessage);
                valuesSpecified = Convert.ToInt32(Console.ReadLine());
            } while (valuesSpecified <= 0);

            int[] valueList = new int[valuesSpecified];

            for (int i = 0; i < valuesSpecified; i++)
            {
                Console.Write(inputSecondMessage);
                valueList[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < valuesSpecified; i++)
            {
                sumOfValues += valueList[i];
            }

            Console.Write(outputMessage);
            Console.WriteLine(sumOfValues);
        }
    }
}