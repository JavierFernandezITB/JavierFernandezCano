/* Javier Fernández Cano
 *  Email:      javier.fernandez.7e7@itb.cat
 *  Date:       9/10/2023
 *  Version:    1.0.0
*/


/* Notes:
 *  Input:
 *      None
 *  Output:
 *      all numbers between 2000 & 3000 (included) divisible by 7 & not mult of 5
*/


// Dependencies.

namespace mainWorkspace
{
    public class mainProgram
    {
        static void Main(string[] args)
        {

            // Constants.



            // Variables

            string separator = "";

            int minRange = 2000;
            int maxRange = 3000;


            // Main code.

            for (int i = minRange; i < maxRange + 1; i++)
            {
                if ((i % 7) == 0 && (i % 5) != 0)
                {
                    Console.Write(separator + i);
                    separator = ", ";
                }
            }
        }
    }
}