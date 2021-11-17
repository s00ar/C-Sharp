using System;

namespace prueba
{
    class Program 
    { 
        static void Main(string[] args) 
        {
            int[] myArray = {1,2,1,3,3,1,2,1,5,1};

            int valorMax=myArray[0];
            
            for (int i = 0; i < myArray.Length; i++)
            {
                if (valorMax<myArray[i])
                {
                    valorMax=myArray[i];
                }
            }
            System.Console.WriteLine(valorMax);
        }
    }
} 