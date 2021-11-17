using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Creando una cola
        Stack <int> nombreStack = new Stack<int>();

        //agregando elementos a la cola
        foreach (int varBucle in new int[3] {5,10,15})
        {
            nombreStack.Push(varBucle);
        }

        //Recorriendo la cola
        System.Console.WriteLine("Valores de la cola");
        foreach (int varBucle in nombreStack)
        {
            System.Console.WriteLine(varBucle);
            
        }
        //eliminando elementos de la cola
        System.Console.WriteLine("Eliminando elementos");
        nombreStack.Pop();
        
        //Recorriendo la cola por segunda vez
        System.Console.WriteLine("Valores de la cola desp de borrar uno");
        foreach (int varBucle in nombreStack)
        {
            System.Console.WriteLine(varBucle);
            
        }
    }
}