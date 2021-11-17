using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int nroFib1=1, nroFib2=1, nroFib3; 

        System.Console.WriteLine("Cuantos digitos de la Sucesión de Fibonacci deseas ver: ");
        int digitosVar = Convert.ToInt32(Console.ReadLine());
        if (digitosVar<=0)
        {
            System.Console.WriteLine("No deseas ver la secuencia de Fibonacci");
            Environment.Exit(0);
        }
        if (digitosVar==1)
        {
            System.Console.WriteLine("Secuencua Fibonacci elegida:\n 1");
            Environment.Exit(0);
        }
        if (digitosVar==2)
        {
            System.Console.WriteLine("Secuencua Fibonacci elegida:\n1\n1");
            Environment.Exit(0); 
        }
            
        digitosVar = digitosVar-2;
        
        List <int> listFib = new List<int> {1,1};

            for (int i = 0; i < digitosVar; i++)
            {
                nroFib3 = nroFib1+nroFib2;
                listFib.Add(nroFib3);
                nroFib1=nroFib2;
                nroFib2=nroFib3;

            }
            System.Console.WriteLine("Secuencua Fibonacci elegida:");
            foreach (int num in listFib)
            {
                System.Console.WriteLine(num);
            }
    }
}