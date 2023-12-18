// Author: Javier Fernández Cano
// Date: 5 Dec 2023

/*

    Implementa un programa que generi una llista de 10 valors aleatoris entre el 0 i el 200, demani un valor per teclat i informi per pantalla si aquest valor indicat es troba a la llista.

*/

namespace myWorkspace
{
    public class myClass
    {
        public static void Main(string[] args)
        {

            const int arrLength = 10;
            const int minRange = 0;
            const int maxRange = 201;
            const string inputMessage = "Introduce un número: ";
            const string queryFoundMessage = "El número se encuentra entre los aleatorios.";
            const string queryNotFoundMessage = "El número NO se encuentra entre los aleatorios.";

            int query;
            int[] randomArray = GenerateRandomArray(arrLength, minRange, maxRange);
            
            Console.Write(inputMessage);
            query = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SearchInArray(query, randomArray) ? queryFoundMessage : queryNotFoundMessage);
        }

        public static int[] GenerateRandomArray(int length, int minRange, int maxRange)
        {
            Random rnd = new Random();
            int[] numArray = new int[length];
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = rnd.Next(minRange, maxRange);
            }
            return numArray;
        }

        public static bool SearchInArray(int query, int[] array)
        {
            bool stopSearching = false;
            int idx = 0;
            while (idx< array.Length && !stopSearching)
            {
                if (array[idx] == query)
                {
                    stopSearching = !stopSearching;
                }
                else
                {
                    idx++;
                }
            }
            return stopSearching;
        }
    }
}