using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //uso del delegado
        // OperacionesMatematicas operacion = new OperacionesMatematicas(Cuadrado);
        OperacionesMatematicas operacion = new OperacionesMatematicas(num=> num*num);// simplificación

        System.Console.WriteLine(operacion(4));

        //uso del delegado
        // OperacionesMatematicas2 operacion2 = new OperacionesMatematicas2(Suma);
        OperacionesMatematicas2 operacion2 = new OperacionesMatematicas2((numero1,numero2)=> numero1+numero2); // simplificación

        System.Console.WriteLine(operacion2(3,2));
    }
    public delegate int OperacionesMatematicas2(int numero1, int numero2);
    public delegate int OperacionesMatematicas(int numero);
    /* todo esto se simplifica usando el lambda
    public static int Cuadrado(int num)
    {
        return num * num;
    }*/

    public static int Suma(int num1, int num2)
    {
        return num1 + num2;
    }
}