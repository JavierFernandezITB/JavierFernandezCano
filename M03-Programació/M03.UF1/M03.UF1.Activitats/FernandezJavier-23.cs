// Author: Javier Fernández Cano
// Date: 6 Nov 2023

/*

Implementa un programa en el que s’introdueixin 20 notes per terminal (valors entre el 0 i el 10 inclosos). Un cop emmagatzemats, cal demanar a l’usuari si vol mostrar els valors ordenats de manera ascendent o descendent i mostrar-ho per pantalla.

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
            const string askOutputType = "Quieres ver los resultados de manera ascendente o descendente? ";
            const string outputTypeError = "Ups, parece que te has equivocado. Prueba con ascendente/descendente: ";
            const string ascendente = "ascendente";
            const string descendente = "descendente";

            // Variables

            string outputType;

            int[] marksArray = new int[marksToInsert];


            // Main code

            for (int i = 0; i < marksToInsert; i++)
            {
                Console.Write(inputMessage);
                marksArray[i] = Convert.ToInt32(Console.ReadLine());
                while (!(marksArray[i] >= minMark && marksArray[i] <= maxMark))
                {
                    Console.Write(inputErrorMessage);
                    marksArray[i] = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.Write(askOutputType);
            outputType = Console.ReadLine();
            while (!(outputType.ToLower() == ascendente) && !(outputType.ToLower() == descendente))
            {
                Console.Write(outputTypeError);
                outputType = Console.ReadLine();
            }

            if (outputType.ToLower() == ascendente)
            {
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

            } 
            else if (outputType.ToLower() == descendente.ToLower()) 
            {
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
}