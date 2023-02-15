using System;

namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois numeros: ");
            int x = int.Parse (Console.ReadLine());
            int y = int.Parse (Console.ReadLine());

            int soma = x + y;
            Console.WriteLine("Soma = " + soma);
        }
    }
}
