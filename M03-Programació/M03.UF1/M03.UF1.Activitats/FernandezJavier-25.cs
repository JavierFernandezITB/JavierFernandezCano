// Author: Javier Fernández Cano
// Date: 6 Nov 2023

/*

Implementa un programa que emmagatzemi una frase introduïda per teclat en la variable textOne. Demana un altre text i emmagatzema’l en la variable textTwo. Afegeix textTwo a textOne i mostra-la per pantalla. És correcte? Què pots observar a les variables textOne i textTwo?

*/


namespace myWorkspace
{
    class FernandezJaviCode
    {
        static void Main()
        {

            // Constants

            const string inputFirstMessage = "Introduce una frase: ";
            const string inputSecondMessage = "Introduce otra frase: ";

            // Variables

            string textOne;
            string textTwo;

            // Main code

            Console.Write(inputFirstMessage);
            textOne = Console.ReadLine();

            Console.Write(inputSecondMessage);
            textTwo = Console.ReadLine();

            textOne += textTwo;

            Console.WriteLine(textOne);
            Console.WriteLine(textTwo);

            // Funciona, pero estamos no estamos sobreescribiendo la variable.
        }
    }
}