using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты линейного уравнения 0=kx+b ");
            Console.Write("Коэффициент k= ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Коэффициент b= ");
            int b = Convert.ToInt32(Console.ReadLine());
            LinearFunction okx_b = new LinearFunction{ k = k, b = b };
            double x = okx_b.Root();
            Console.WriteLine("В уравнении 0={0}x+{1}, х = {2}", k, b, x);

            Console.ReadKey();

        }
        struct LinearFunction
        {
            public int k;
            public int b;
            public double Root()
            {
                double r = 0;
                if (k == 0)
                {
                    Console.WriteLine("Решения нет, х может быть любым числом");
                }
                else
                {
                    r = -(double)b / k;
                }
                return r;
            }
        }

    }
}
