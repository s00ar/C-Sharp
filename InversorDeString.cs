using System;

class Program
{
    static string ReverseString(string stringAInvertir)
    {
        char[] arrayAInvertir = stringAInvertir.ToCharArray();
        //crea el array para invertir a partir del string convertido a caracteres
        Array.Reverse(arrayAInvertir);
        //invierte el array creado
        return new string(arrayAInvertir);
        //convierte el array invertido nuevamente a string
    }
    
    static void Main()
    {
        string nombreInput;

        System.Console.WriteLine("Ingrese un nombre: ");
        nombreInput = Console.ReadLine();
        Console.WriteLine(ReverseString(nombreInput));
    }
}