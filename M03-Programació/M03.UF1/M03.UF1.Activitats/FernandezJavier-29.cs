// Author: Javier Fernández Cano
// Date: 6 Nov 2023

/*

Fent servir la interpolació, implementa un programa que mostri el contingut del jagged array

*/


namespace myWorkspace
{
    class FernandezJaviCode
    {
        static void Main()
        {

            // Constants

            int[][] jaggedArr = new int[4][];
            jaggedArr[0] = new int[] { 1, 2, 3, 4 };
            jaggedArr[1] = new int[] { 11, 34, 67 };
            jaggedArr[2] = new int[] { 89, 23 };
            jaggedArr[3] = new int[] { 0, 45, 78, 53, 99 };

            // Variables

            string modString = "";

            // Main code

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                modString = "";
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    modString += jaggedArr[i][j] + " ";
                }
                Console.WriteLine($"Fila: {i} {modString}");
            }

        }
    }
}