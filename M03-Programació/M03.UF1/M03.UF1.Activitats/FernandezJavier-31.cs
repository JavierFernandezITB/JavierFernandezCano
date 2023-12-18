// Author: Javier Fernández Cano
// Date: 7 Nov 2023

/*

El següent tipus de dades emmagatzema les quantitats mitjanes de pluja per cada mes de l’any:

    float[] arrayPluges = {15.5f, 10f, 3.2f, 1.25f, 1.75f, 12f, 5.15f, 6.75f, 15f, 9.25f, 10.75f, 20.75f};

Implementa un programa perquè faci el següent:

    Mostri tot el contingut de l'array, mostrant les mitjanes de cada mes de manera descendent. Un exemple de sortida seria aquest:

        *inserte captura aquí*

    Compti quants mesos han tingut pluges entre 5 i 18 litres de mitjana (inclosos),  torni a mostrar el llistat de valors, la mitjana i el recompte calculat. Una possible sortida del programa seria aquesta:

        *inserte captura aquí*

    Demani per teclat un valor i cerqui aquest dins l’array. Si el troba, ho ha d’indicar (aturant-se en trobar-lo, no s’ha de recórrer tot l’array). Si no l’ha trobat, informar que el valor no està dins l’array. Important! No cal validar el valor introduït per teclat.

        *inserte captura aquí*
*/


namespace myWorkspace
{
    class FernandezJaviCode
    {
        static void Main()
        {

            // Constants

            const string monthTemplate = "Mes {0}: {1}";
            const string avrgTemplate = "\nLa mediana és {0}";
            const string sumTemplate = "Hay {0} meses con medianas entre 5 y 18 litros de lluvia.";
            const string inputMessage = "Introduce un valor a buscar: ";
            const string outputQueryFound = "El valor se encuentra dentro de la lista.";
            const string outputQueryNotFound = "El valor no se encuentra dentro de la lista.";

            const float minRange = 5.0f;
            const float maxRange = 18.0f;

            float[] arrayPluges = { 15.5f, 10f, 3.2f, 1.25f, 1.75f, 12f, 5.15f, 6.75f, 15f, 9.25f, 10.75f, 20.75f };

            // Variables

            bool queryFound = false;

            int numberInRange = 0;
            int index = 0;

            float query;
            float sumOfValues = 0.0f;

            // Main code

            for (int i = 0; i < arrayPluges.Length; i++)
            {
                for (int j = i; j < arrayPluges.Length; j++)
                {
                    if (arrayPluges[i] < arrayPluges[j])
                    {
                        float temporaryValue = arrayPluges[j];
                        arrayPluges[j] = arrayPluges[i];
                        arrayPluges[i] = temporaryValue;
                    }
                }
            }

            for (int i = 0; i < arrayPluges.Length; i++)
            {
                Console.WriteLine(monthTemplate, i + 1, arrayPluges[i]);
                sumOfValues += arrayPluges[i];
                if (arrayPluges[i] >= minRange && arrayPluges[i] <= maxRange)
                {
                    numberInRange += 1;
                }
            }

            Console.WriteLine(avrgTemplate, sumOfValues / arrayPluges.Length);
            Console.WriteLine(sumTemplate, numberInRange);
            Console.Write(inputMessage);
            query = Convert.ToSingle(Console.ReadLine());

            while ((index < arrayPluges.Length) && (!queryFound))
            {
                if (arrayPluges[index] == query)
                { 
                    queryFound = true;
                }
                index++;
            }

            Console.WriteLine(queryFound ? outputQueryFound : outputQueryNotFound );
        }
    }
}