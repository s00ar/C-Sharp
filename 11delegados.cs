using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {//creación objeto delegado apuntando a objeto bienvenida
        ObjetoDelegado DelegadoEjemplo = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);
        //Utilización metodo delegado
        DelegadoEjemplo("Fernando");

        DelegadoEjemplo = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);
        DelegadoEjemplo("Tomate el palo");
    }

    delegate void ObjetoDelegado(string msg);
}

class MensajeBienvenida
{
    public static void SaludoBienvenida(string msg)
    {
        Console.WriteLine("Buenas, como va {0}?", msg);
    }
}

class MensajeDespedida
{
    public static void SaludoDespedida(string msg)
    {
        Console.WriteLine("Adios mi ciela,{0}", msg);
    }
}