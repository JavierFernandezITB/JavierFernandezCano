// Author: Javier Fernández Cano
// Date: 6 Nov 2023

/*

Modifica el programa anterior de manera que mostri les notes introduïdes ordenades de manera ascendent i descendent (per separat).

*/


namespace myWorkspace
{
    class FernandezJaviCode
    {
        static void Main()
        {

            // Constants

            const int marksToInsert = 20;
            const int minMark = 0;
            const int maxMark = 10;

            const string inputMessage = "Introduce una nota (entre 0 y 10): ";
            const string inputErrorMessage = "Vaya, parece que has introducido un número fuera del rango. Inténtalo otra vez: ";
            const string queryMessage = "Que valor deseas buscar? ";
            const string queryNotFound = "El valor que buscas no ha sido introducido.";
            const string queryFound = "El valor que buscas ha sido introducido.";

            // Variables

            bool found = false;

            int query;
            int index = 0;
            int[] marksArray = new int[marksToInsert];

            // Main code

            for (int i = 0; i < marksArray.Length; i++)
            {
                Console.Write(inputMessage);
                marksArray[i] = Convert.ToInt32(Console.ReadLine());
                while (!(marksArray[i] >= minMark && marksArray[i] <= maxMark))
                {
                    Console.Write(inputErrorMessage);
                    marksArray[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write(queryMessage);
            query = Convert.ToInt32(Console.ReadLine());

            while ((index < marksArray.Length) && (!found))
            {
                if (query == marksArray[index])
                {
                    found = true;
                }
                index++;
            }

            Console.WriteLine(found ? queryFound : queryNotFound);

            for (int i = minMark; i < maxMark + 1; i++)
            {
                for (int j = 0; j < marksToInsert; j++)
                {
                    if (i == marksArray[j])
                    {
                        Console.Write(i + " ");
                    }
                }
            }

            Console.WriteLine();

            for (int i = maxMark + 1; i > minMark - 1; i--)
            {
                for (int j = 0; j < marksToInsert; j++)
                {
                    if (i == marksArray[j])
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}