using System;
using static System.Console;
using System.Collections.Generic;

namespace prueba
{
    class Program 
    {
        static void Main(string[] args) 
        {
            int [] arrayElementos = LeerDatos();

            System.Console.WriteLine("Imprimiendo desde el main");

            foreach (int i in arrayElementos)
            {
                System.Console.WriteLine(i);
            }
        }
        static int[] LeerDatos()
        {
            System.Console.WriteLine("Cuantos elementos quieres que tenga el array: ");
            string respuesta=Console.ReadLine();
            int numElementos=int.Parse(respuesta);//CREAMOS NUMELEMENTOS QUE DETERMINA EL LARGO DEL ARRAY POSTERIOR
            int[] datos=new int[numElementos];//CREANDO EL ARRAY DATOS CON EL LARGO DE NUMELEMENTOS

            for(int i=0;i<numElementos;i++)
            {
                System.Console.WriteLine($"Introduce el dato para la posición {i}");
                respuesta = Console.ReadLine();
                int datosElementos=int.Parse(respuesta);
                datos[i] = datosElementos;
            }

            return datos;
        }
    }    
}

/* 
            int [] numeros = new int[4];
            numeros[0]=7;
            numeros[1]=9;
            numeros[2]=15;
            numeros[3]=3;

            ProcesaDatos(numeros);

            foreach(int i in numeros)
            {
                Console.WriteLine(i);
            }
        }
//metodo que devuelve array
        static void ProcesaDatos(int [] datos)
        {
            foreach (  int i in datos)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < 4; i++)
            {
                datos[i] += 10;
            } */