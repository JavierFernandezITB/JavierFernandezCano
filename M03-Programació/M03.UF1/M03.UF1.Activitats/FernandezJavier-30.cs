// Author: Javier Fernández Cano
// Date: 6 Nov 2023

/*

    ABBA va ser un grup suec de música pop que es va crear a Estocolm l'any 1972, però la fama li va arribar l'any 1974 en guanyar el Festival de la Cançó d'Eurovisió d'aquell any amb la seva cançó Waterloo. Van aprofitar aquell moment per encadenar un èxit darrere un altre fins a convertir-se en la banda amb més vendes de la dècada dels setanta.

    El grup va destacar també pel seu atrevit vestuari, extravagant i molt colorit. El nom del grup tampoc deixava indiferent, ja que estava compost per les inicials dels quatre membres del grup: Agneta, Björn, Benny i Anni-Frid.

    Entrada
    Cada cas conté la llista de membres d'un grup musical. Un grup musical té un mínim de dos membres i un màxim de quinze (si fossin més no tocarien a res a l'hora de repartir-se els guanys...) La llista es compon pel nom de cadascú dels membres separats per comes a excepció de l'últim membre, que en comptes d'una coma té la conjunció "i".

    Sortida
    Per a cada cas cal indicar la primera lletra del nom de cadascun dels membres en majúscules, sense accents.

    Exemple d'Entrada
    Agneta, Björn, Benny i Anni-Frid
    Pau, Antoni, Carles, Òscar, Mari Carmen, Ernesto i Ramon
    Josep Maria, Octavi, Ester i Lluís

    Exemple de Sortida
    ABBA
    PACOMER
    JOEL

*/


namespace myWorkspace
{
    class FernandezJaviCode
    {
        static void Main()
        {

            // Constants

            const string inputMessage = "Introduce los nombres de los miembros: ";

            // Variables

            string inputValue;

            // Main code

            Console.Write(inputMessage);
            inputValue = Console.ReadLine();

            string[] splittedString = inputValue.Split(", ");

            for (int i = 0; i < splittedString.Length; i++)
            {
                Console.Write(splittedString[i].Substring(0, 1));
                string[] reSplittedString = splittedString[i].Split(" i ");
                if (reSplittedString.Length > 1)
                {
                    Console.Write(reSplittedString[1].Substring(0, 1));
                }
            }
        }
    }
}