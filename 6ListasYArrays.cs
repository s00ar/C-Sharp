using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {//INTRODUCIR ELEMENTOS HASTA 0 EN UNA LISTA
        int numeroIngresado=1;
        List<int> nuevaList = new List<int>();
        System.Console.WriteLine("Introduce elementos en la colección (0 para salir)");
        while (numeroIngresado!=0)
        {
            numeroIngresado = Int32.Parse(Console.ReadLine());
            nuevaList.Add(numeroIngresado);
        }
        
        nuevaList.RemoveAt(nuevaList.Count-1);// remueve el 0

        System.Console.WriteLine("Los elementos ingresados son estos: ");
        foreach (int entero in nuevaList)
        {
            System.Console.WriteLine(entero);
        }
        /*INTRODUCIR ELEMENTOS HASTA 0 EN UNA LISTA II (Mi versión)
        int numeroIngresado;
        List<int> nuevaList = new List<int>();
        System.Console.WriteLine("Introduce elementos en la colección (0 para salir)");
        do
        {
            numeroIngresado = Convert.ToInt32(Console.ReadLine());
            if (numeroIngresado!=0)
            {   
            nuevaList.Add(numeroIngresado);
            }
        } while (numeroIngresado!=0);

        System.Console.WriteLine("Los numeros ingresados fueron los siguientes: \n");

        for (int i = 0; i < nuevaList.Count; i++)
        {
            System.Console.WriteLine(nuevaList[i]);
        }
        //INGRESAR Y ALMACENAR NUMEROS EN UNA LIST
        List<int> numeros = new List<int>();//Creación de la lista 
        System.Console.WriteLine("Cuantos numeros quieres introducir? ");
        int cantidadNumeros = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cantidadNumeros; i++)
        {
            numeros.Add(Convert.ToInt32(Console.ReadLine()));
        }
        
            System.Console.WriteLine("Los números ingresados fueron los siguientes:\n");
        for(int i = 0; i < cantidadNumeros; i++)
        {
            System.Console.WriteLine(numeros[i]);
        }

        /*  LISTA Y ARRAYS
        
        List<int> numeros = new List<int>();//Creación de la lista 

        int[] arrayListaNumeros = new int[] {3, 6, 9, 12, 15}; //array con numeros

        for (int i = 0; i < cantidadNumeros; i++)
        {
            numeros.Add(arrayListaNumeros[i]);//agregamos el array a la lista
        }
        numeros.Add(5);//agregando valores a la lista
        numeros.Add(15);
        numeros.Add(25);
        
        for(int i = 0; i < 8; i++)
        {
            System.Console.WriteLine(numeros[i]);//mostramo la lista con sus numeros y los del array sumados
        }*/
    }
}