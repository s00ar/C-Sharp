using System;

namespace programPotencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador=0, usuario, pwd;
            do
            {
                Console.Clear();
                Console.Write("Ingrese el número de usuario: ");
                usuario=Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese la contraseña en números: ");
                pwd=Convert.ToInt32(Console.ReadLine());
                if (usuario!=161910 || pwd!=1234)
                {
                    contador++;
                    Console.WriteLine("Contraseña o usuario incorrecto \n"+
                    "Presione una tecla para continuar");
                    Console.ReadLine();

                }
                if (usuario == 161910 && pwd == 1234)
                {
                    Console.WriteLine("Acceso concedido");
                } else
                {
                    if(contador==3)
                    {
                    Console.WriteLine("Intentos excedidos");
                    Environment.Exit(0);
                    }
                }
            } while (usuario!=161910 || pwd!=1234 && contador<=3);
        }
    }
}
