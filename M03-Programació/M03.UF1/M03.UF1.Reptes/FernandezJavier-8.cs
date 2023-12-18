// Author: Javier Fernández Cano
// Date: 8 Nov 2023

/*

L’algoritme de Luhn, també conegut com a algorisme de mòdul 10 o mod 10, és una fórmula simple de comprovació que s’utilitza per validar una varietat de números d’identificació, com ara números de targeta de crèdit, números IMEI, números d’assegurança social canadenc. La fórmula LUHN va ser creada a finals dels anys seixanta per un grup de matemàtics. Poc després, les empreses de targetes de crèdit el van adoptar. Com que l'algoritme es troba en un domini públic, pot utilitzar-lo tothom. 
La majoria de les targetes de crèdit i molts números d’identificació del govern utilitzen l’algoritme com a mètode senzill per distingir els números vàlids de xifres errònies o d’alguna manera incorrecta. 
Va ser dissenyat per protegir contra errors accidentals, no atacs maliciosos.

Passos implicats en l'algoritme de Luhn

Entenem l’algorisme amb un exemple:
    Considereu l'exemple d'un número de compte "79927398713".
    Pas 1: a partir del dígit més dret multiplica per 2 el valor de cada segon dígit,

    Pas 2: si el doble d’un nombre resulta en un nombre de dos dígits, és a dir, superior a 9 (per exemple, 6 × 2 = 12), llavors afegiu els dígits del producte (per exemple, 12: 1 + 2 = 3, 15: 1 + 5 = 6), per obtenir un número amb un sol dígit.

    Pas 3: agafeu la suma de tots els dígits.

    Pas 4: si el mòdul total 10 és igual a 0 (si el total acaba en zero), el nombre és vàlid segons la fórmula de Luhn; altrament no és vàlid.

    Com que la suma és 70, que és un múltiple de 10, per tant el número introduït és vàlid.

*/


namespace myWorkspace
{
    class FernandezJaviCode
    {
        static void Main()
        {

            // Constants

            const string inputMessage = "Introduzca el número a validar: ";
            const string outputValid = "El número introducido es válido.";
            const string outputNotValid = "El número introducido es inválido.";

            // Variables

            int suma = 0;

            bool segundoDigito = false;

            string inputValue;


            // Main code

            Console.Write(inputMessage);
            inputValue = Console.ReadLine();

            for (int i = inputValue.Length - 1; i >= 0; i--)
            {

                int doble = inputValue[i] - '0';

                if (segundoDigito)
                {
                    doble *= 2;
                }
                segundoDigito = !segundoDigito;

                suma += doble / 10;
                suma += doble % 10;
            }

            if (suma % 10 == 0)
            {
                Console.WriteLine(outputValid);
            }
            else 
            {
                Console.WriteLine(outputNotValid);
            }

        }
    }
}