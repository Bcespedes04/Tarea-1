using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class Program
    {
        static void Main()
        {
            int n;
            while (true)
            {
                Console.Write("Escribe un numero entre 2 y 45: ");
                if (int.TryParse(Console.ReadLine(), out n) && n >= 2 && n <= 45)
                {
                    break;
                }
                Console.WriteLine("Ingreso incorrecto, por favor intente con un valor entre 2 y 45 nuevamente: ");
            }

            double phi = (1 + Math.Sqrt(5)) / 2;
            Console.WriteLine($"\nPhi ~ {phi}");

            int[] fib = new int[n + 1];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            for (int i = 2; i <= n; i++)
            {
                double division = (double)fib[i] / fib[i - 1];
                double diferencia = Math.Abs(division - phi);
                Console.WriteLine($"Fib({i}) / Fib({i - 1}) ~ {division} [+- {diferencia}]");
            }

            Console.WriteLine($"\nFib({n}) = {fib[n]}");
            Console.WriteLine($"Fib({n - 1}) = {fib[n - 1]}");
        }
    }
}
