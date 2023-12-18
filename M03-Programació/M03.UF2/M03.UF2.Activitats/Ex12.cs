// Author: Javier Fernández Cano
// Date: 18 Dec 2023

/*

    Demanar per teclat el nombre de litres consumits aquest mes i calcular la factura d’aigua, tenint en compte les següents dades:
    La quota fixa és de 6€.
    Els primers 50 litres d’aigua són de franc.
    Entre 50 i 200 litres, el litre costa 0,1€
    A partir de 200 el litre costa 0,3€.

*/

namespace myWorkspace
{
    public class myClass
    {
        public static void Main(string[] args)
        {
            const string inputMonthUseMessage = "Introduce los litros consumidos este mes: ";
            const string outputBill = "Total a pagar: {0} EUR";
            const float fixedQuota = 6;

            int[] lowRange = { 0, 50 };
            int[] midRange = { 50, 200 };
            int[] highRange = { 200, 100000 };
            float usage;

            Console.WriteLine(inputMonthUseMessage);
            usage = Convert.ToInt32(Console.ReadLine());

            if (IsInRange(usage, lowRange))
                Console.WriteLine(outputBill, CalculateBill(fixedQuota, usage, 0));
            else if (IsInRange(usage, midRange))
                Console.WriteLine(outputBill, CalculateBill(fixedQuota, usage, 0.1f));
            else if (IsInRange(usage, highRange))
                Console.WriteLine(outputBill, CalculateBill(fixedQuota, usage, 0.3f));
        }

        public static float CalculateBill(float fixedQuota, float usage, float pricePerLiter)
        {
            return fixedQuota + (usage * pricePerLiter);
        }

        public static bool IsInRange(float value, int[] range)
        {
            return value >= range[0] && value <= range[1];
        }
    }
}