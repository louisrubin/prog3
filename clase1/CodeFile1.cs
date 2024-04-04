using System;

// Declaración del espacio de nombres
namespace MiProyecto
{
    // Declaración de la clase
    public class WWER
    {
        public int tablaMult(int num, int mult = 1)
        {
            //int mult = num2;
            if (mult == 11)
            {
                return mult;
            }
            Console.WriteLine($"{num}x{mult} = {num * mult}");

            return tablaMult(num, mult + 1);
        }
    }

    class Program()
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese numero: ");
            int numIngr = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------");

            WWER wWER = new WWER();
            wWER.tablaMult(numIngr);
        }
    }
}
;
