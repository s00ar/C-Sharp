using System;
using static System.Math;
using static System.Console;

namespace AppCursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();
            double raiz = Sqrt(9);//raiz cuadrada de 9
            double potencia = Pow(3, 4); // 3 a la 4ta potencia

            WriteLine($"La raíz cuadrada de 3 es {raiz}");
            WriteLine($"3 a la 4 potencia es {potencia}");
        }
    }
}
