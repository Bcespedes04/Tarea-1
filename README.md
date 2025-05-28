# Tarea 1

Los links donde se encontro la solucion son los siguientes:

1) https://andresledo.es/csharp/serie-fibonacci/

2) https://gist.github.com/UdaraAlwis/0c951827231470d8e2ede48152419986

3) https://gist.github.com/mikedugan/8249709

4) https://www.bytehide.com/blog/fibonacci-csharp

5) https://stackoverflow.com/questions/40966711/how-to-get-fibonacci-in-c-sharp

6) Chatgpt para terminar de arreglar el while ya que cuando se colocaba 1 la app no tiraba ningun msj y cuando ponia 3 me tiraba el msj de error mas el procedimiento por lo que se consulto con la IA para poder solucionar este problema adjunto promt y respuesta

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
            Console.Write("Escribe un numero entre 2 y 45: ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n) || n < 2 || n > 45) ;
            {
                Console.WriteLine("Ingreso incorrecto, por favor intente con un valor entre 2 y 45 nuevamente: ");
            }

            double phi = (1 + Math.Sqrt(5)) / 2;
            Console.WriteLine($"\nPhi ~ {phi}");

            int[] fib = new int[n + 1];
            fib[0] = 0;
            fib[1] = 1;

            for(int i = 2; i<= n; i++)
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

No me funciona correctamente el try ya que si coloco 1 no me tira el mensaje pero si pongo 3 me tira el msj y el calculo

Esta fue la respuesta de chatgpt:

Tienes un pequeño error en tu bloque while: la llave de apertura del bloque ({) está fuera del while y por eso el mensaje de error siempre se ejecuta una vez, incluso si el valor es correcto. Además, si el valor es incorrecto, el mensaje no aparece, ya que el ciclo no repite el mensaje dentro del while.

int n;
while (true)
{
    Console.Write("Escribe un numero entre 2 y 45: ");
    if (int.TryParse(Console.ReadLine(), out n) && n >= 2 && n <= 45)
    {
        break;
    }
    Console.WriteLine("Ingreso incorrecto, por favor intente con un valor entre 2 y 45 nuevamente.");
}


