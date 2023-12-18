// Author: Javier Fernández Cano
// Date: 5 Dec 2023

/*

    Implementa un mètode per a utilitzar en un programa principal, o invocat per un altre mètode, que permeti validar si un nombre és més petit que un valor (introduït per teclat) o és dins d’un rang (està dins de dos valors introduïts per teclat). 
    Els missatges que es mostraran han de poder ser parametritzables.

*/

namespace myWorkspace
{
    public class myClass
    {
        public static void Main(string[] args)
        {
            const string inputMessage = "Introduce un valor: ";
            const string isInRangeMessage = "{0} se encuentra entre {1} y {2}.";
            const string isLowerThanMessage = "{0} es menor que {1}.";

            int inputValue;

            Console.Write(inputMessage);
            inputValue = Convert.ToInt32(Console.ReadLine());

            IsInRangeOrLower(inputValue, 5, 1, 10, isLowerThanMessage, isInRangeMessage);
        }

        public static bool IsInRangeOrLower(int value, int lowerthan, int minRange, int maxRange, string lowerThanMessage, string betweenRangeMessage)
        { 
            bool isInRange = value >= minRange && value <= maxRange;
            bool isLowerThan = value < lowerthan;

            if (isInRange)
            {
                Console.WriteLine(betweenRangeMessage, value, minRange, maxRange);
            }
            if (isLowerThan)
            {
                Console.WriteLine(lowerThanMessage, value, lowerthan);
            }

            return isInRange || isLowerThan; 
        }
    }
}