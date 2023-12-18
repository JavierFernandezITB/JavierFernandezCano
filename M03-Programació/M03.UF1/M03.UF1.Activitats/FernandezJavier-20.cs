// Author: Javier Fernández Cano
// Date: 6 Nov 2023

/*

Especifica un algorisme que demani a l’usuari que introdueixi els números d’una matriu de 7 files per 3 columnes (compresos entre 1 i 9 inclosos) per teclat. Una vegada la matriu estigui omplerta, cal que el vostre programa mostri la matriu trasposta (només els valors, sense els claudàtors).

*/


namespace myWorkspace
{
    class FernandezJaviCode
    {
        static void Main()
        {
            // Constants

            const string inputMessage = "Introduce un valor para añadir a la matriz (entre 1 y 9): ";
            const string inputErrorMessage = "El valor introducido no se encuentra dentro del rango, intentalo otra vez: ";
            const string outputMessage = "Este es tu resultado:";

            // Variables

            int[,] inputMatrix = new int[7, 3];
            int[,] outputMatrix = new int[3, 7];

            // Main code

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(inputMessage);
                    inputMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    while ( !(inputMatrix[i, j] >= 1 && inputMatrix[i, j] <= 9) ) 
                    {
                        Console.Write(inputErrorMessage);
                        inputMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine(outputMessage);
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    outputMatrix[i, j] = inputMatrix[j, i];
                    Console.Write(outputMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}