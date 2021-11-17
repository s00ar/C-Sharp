using System;
using static System.Console;
using System.Collections.Generic;

namespace AppCursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu3 = true;
            while (menu3)
            {
                double contadorCeros=0, contadorPares=0, contadorImpares=0, numWhile=0;
                List<double> valoresIng = new List<double>();
                Clear();
                while (numWhile>=0)
                {
                    Clear();
                    WriteLine("Ingrese valor: ");
                    numWhile = double.Parse(ReadLine());
                        if (numWhile==0)
                        {
                            contadorCeros++;
                        }
                        if (0==(numWhile%2))
                        {
                            contadorPares++;
                        }
                        if (0!=(numWhile%2))
                        {
                            contadorImpares++;
                        }
/*TODO                                    Convert.ToString(numWhile);
                    if (numWhile<0)
                    {
                        valoresIng=valoresIng + numWhile;
                    }
                    else
                    {
                        valoresIng=valoresIng + numWhile + comaEsp;
                    }*/
                    valoresIng.Add(numWhile);
                    WriteLine($"{valoresIng}");
                    ReadLine();
            }
                Clear();
                if (contadorCeros==0 ||contadorCeros==1)
                {
                    if (contadorCeros==0)
                    {
                    WriteLine("No se procesaron ceros durante la carga");
                    }
                    else {
                        WriteLine("Se proceso un solo cero durante la carga");
                    }
                }
                else
                {
                    WriteLine($"Se procesaron {contadorCeros} ceros durante la carga");
                }
                WriteLine($"Total de valores pares: {contadorPares} || Total de valores impares: {contadorImpares}");
                if (contadorImpares==0 || contadorPares==0)
                {
                    WriteLine("La serie no presenta alternancia!");
                } else
                {
                    WriteLine("La serie presenta alternancia!");
                }
                WriteLine($"Estos son los valores ingresados: {valoresIng}");
                WriteLine("Presione una tecla para continuar.");
                ReadLine();
                }
        }
    }
}