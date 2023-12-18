// Author: Javier Fernández Cano
// Date: 18 Dec 2023

/*

    Implementa un algorisme que demani 20 nombres enters per teclat i retorni els valors de  les posicions senars.

*/

namespace myWorkspace
{
    public class myClass
    {
        public static void Main(string[] args)
        {
            const string inputMessage = "Introduce un valor: ";
            const string listMessage = "Lista de numeros impares.";

            int[] numArray = new int[20];

            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(inputMessage);
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(listMessage);
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] % 2 == 1)
                    Console.WriteLine("{0}: {1}", i, numArray[i]);
            }
        }
    }
}