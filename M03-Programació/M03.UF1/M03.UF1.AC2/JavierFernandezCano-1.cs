/* 
 * Author: Raquel Alamán
 * Modified: Javier Fernández Cano
 * M03. Programació UF1
 * v1. 09/10/2023
 * Exercici 1. Especifica un algorisme per a validar si un nombre natural introduït 
 * per teclar és múltiple per un segon nombre natural també introduït per teclat.
 * 
 */

using System;
namespace DataTypes
{
    class MyDataTypes
    {
        static void Main()
        {
            const string MsgFirstNum = "Introdueix un nombre natural";
            const string MsgSecondNum = "Introdueix un segon nombre natural";
            const string MsgRetry = "El nombre introduit no es natural, torna a intentar-ho";
            const string MsgOK = "El primer valor és múltiple del segon valor";
            const string MsgKO = "El primer valor no és múltiple del segon valor";
            const string MsgExit = "Pulsa qualsevol tecla per sortir";

            int firstNum, secondNum;

            Console.WriteLine(MsgFirstNum);
            firstNum = Convert.ToInt16(Console.ReadLine());

            while (firstNum < 1) {
                Console.WriteLine(MsgRetry);
                firstNum = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine(MsgSecondNum);
            secondNum = Convert.ToInt16(Console.ReadLine());

            while (secondNum < 1)
            {
                Console.WriteLine(MsgRetry);
                secondNum = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine(firstNum % secondNum == 0 ? MsgOK : MsgKO);
            Console.WriteLine(MsgExit);
            Console.ReadKey();
        }
    }
}