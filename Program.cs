using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__2__exc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b, h, p, a, d;

            Console.WriteLine("Digite o valor da base do retângulo: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite o valor da altura: ");
            h = double.Parse(Console.ReadLine());

            p = 2 * (b + h);
            a = b * h;
            d = (double)Math.Sqrt((double)Math.Pow(b,2)+(double)Math.Pow(h,2));

            Console.WriteLine("O perímetro do retângulo é: "+ p);
            Console.WriteLine("A área do retângulo é: "+ a);
            Console.WriteLine("A diagonal do retângulo é :"+ d);
            Console.ReadKey();


        }
    }
}
