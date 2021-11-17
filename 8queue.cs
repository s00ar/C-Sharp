using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Creando una cola
        Queue <int> nombreQueue = new Queue<int>();

        //agregando elementos a la cola
        foreach (int varBucle in new int[3] {5,10,15})
        {
            nombreQueue.Enqueue(varBucle);
        }

        //Recorriendo la cola
        System.Console.WriteLine("Valores de la cola");
        foreach (int varBucle in nombreQueue)
        {
            System.Console.WriteLine(varBucle);
            
        }
        //eliminando elementos de la cola
        System.Console.WriteLine("Eliminando elementos");
        nombreQueue.Dequeue();
        
        //Recorriendo la cola por segunda vez
        System.Console.WriteLine("Valores de la cola desp de borrar uno");
        foreach (int varBucle in nombreQueue)
        {
            System.Console.WriteLine(varBucle);
            
        }
    }
}