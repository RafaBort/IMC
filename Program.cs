using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo do seu IMC...");
            
            Console.WriteLine("Coloque sua altura...");
            string altura = Console.ReadLine();

            Console.WriteLine("Digite seu peso...");
            string peso = Console.ReadLine();

            Double A1 = Convert.ToDouble(altura);
            Double P1 = Convert.ToDouble(peso);

            Double A2 = A1 * A1;

            Double IMC = P1 / A2;

            Console.WriteLine("Seu IMC é... " + IMC);



        }
    }
}
