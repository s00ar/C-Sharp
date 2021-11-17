using System;
using static System.Console;
using System.Collections.Generic;

namespace prueba
{
    class Program 
    {
        static void Main(string[] args) 
        {
            //ARRAY IMPLICITO
            var valores = new[] { 15, 28, 34, 90, 80.2 };  //todo pasa a ser double

            //ARRAY DE OBJETOS cada objeto tiene dos valores
            Empleados[] arrayEmpleados= new Empleados[3];
            Empleados Ana=new Empleados("Ana", 27);
            arrayEmpleados[0]=new Empleados("Sara", 37);
            arrayEmpleados[1]=Ana;
            arrayEmpleados[2]=new Empleados("Pedro", 45);

            //ARRAY DE TIPOS O CLASES ANONIMAS
            var personas = new []
            {
                new{Nombre="Juan", Edad=19},
                new{Nombre="María", Edad=49},
                new{Nombre="Diana", Edad=35}
            };
            
            //RECORRIENDO ARRAY DE OBJETO
            for(int i=0; i<arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].getInfo());
            }
            foreach (Empleados datos in arrayEmpleados)
            {
                Console.WriteLine(datos.getInfo());
                //c# detecta que datos tiene los mismos valores que cualquier objeto de tipo Empleados
                
            }

            //RECORRIENDO ARRAY IMPLICITO
            foreach (double variable in valores)
            {
                Console.WriteLine(variable);
            }

            //RECORRIENDO ARRAY DE TIPOS O CLASES ANONIMAS
            foreach (var variable in personas)
            {
                Console.WriteLine(variable);
            }
        }
    }
    class Empleados
    {
        //CAMPO DE CLASES
        private String nombre;
        private int edad;

        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public String getInfo()
        {
            return "Nombre del empleado: " + nombre +  " Edad: " + edad;
        }
    }    
}