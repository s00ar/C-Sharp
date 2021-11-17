using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {   //Creando el diccionario
        Dictionary<string, int> nombreDiccionario = new Dictionary<string, int>();

        //Llenando el diccionario de dos maneras
        nombreDiccionario.Add("Juan", 18);
        nombreDiccionario.Add("Giselle", 35);

        nombreDiccionario["María"]=25;
        nombreDiccionario["Antonio"]=29;

        //Reccoriendo el diccionario
        foreach (KeyValuePair<string, int> varBucle in nombreDiccionario)
        {
            //Console.WriteLine("Nombre: "+ varBucle.Key + " Edad: " + varBucle.Value);
            Console.WriteLine("Nombre: {0} Edad: {1}", varBucle.Key, varBucle.Value);
            
        }
    }
}