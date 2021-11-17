using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string frase = "Mi nombre es Juan";

        string patron = "[J]";//para buscar nros de telefonos en secuencia @"\d{3}-\d{3}-\d{4}

        Regex miRegex = new Regex(patron);

        MatchCollection elMatch = miRegex.Matches(frase);

        if(elMatch.Count>0) Console.WriteLine("Se ha encontrado una J");
        else Console.WriteLine("No se ha encontrado J");
    }
}