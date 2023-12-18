// Author: Javier Fernández Cano
// Date: 6 Nov 2023

/*

Implementa un programa en el que s’introdueixin 20 notes per terminal (valors entre el 0 i el 10 inclosos). Un cop emmagatzemats, cal demanar a l’usuari quin valor vol cercar i el programa retornarà si aquest valor es troba entre els introduïts o no.

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
        }
    }
}