using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int> {1,2,3,4,5,6,7};
        List<int> numerosPares = numeros.FindAll(i=> i % 2 == 0);

        foreach (int pares in numerosPares)
        {
            System.Console.WriteLine(pares);
        }

        numerosPares.ForEach(numero => Console.WriteLine(numero));//recorre el array con los numeros pares

        numerosPares.ForEach(numero => {
            System.Console.WriteLine("El número par es: ");
            System.Console.WriteLine(numero); });
    }
}