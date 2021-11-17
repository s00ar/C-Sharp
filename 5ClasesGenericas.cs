using System;
using System.IO;

namespace prueba
{
    class Program 
    { 
        static void Main(string[] args) 
        {
            AlmacenObjetos<String> archivos = new AlmacenObjetos<String>(4);

            archivos.agregar("Juan");
            archivos.agregar("Antonio");
            archivos.agregar("Eleonora");
            archivos.agregar("Sandra");
            
            String nombrePersona = (String)archivos.getElement(2);

            Console.WriteLine(nombrePersona);
            /*

            archivos.agregar(new Empleado(1500));
            archivos.agregar(new Empleado(2500));
            archivos.agregar(new Empleado(3500));
            archivos.agregar(new Empleado(4500));
            
            Empleado salarioEmpleado = archivos.getElement(2);
            Console.WriteLine(salarioEmpleado.getSalario());*/
        }
    }
    class AlmacenObjetos<T> //clase generica con esto le decimos que esta clase va a utilizar cualquier cosa
    {
        public AlmacenObjetos(int z)
        {
            datosElemento=new T[z]; //determinamos que z es el largo del array
        }

        public void agregar(T obj) // T como tipo de objeto
        {
            datosElemento[i] = obj;
            i++;
        }

        public T getElement(int i)//T como tipo de retorno
        {
            return datosElemento[i];
        }

        private T[] datosElemento; //Usamos T en la declaración del array podemos guardar cualquier tipo de objeto en el array
        private int i = 0;
    }
    /* class Empleado
    {
        public Empleado(double salario)
        {
            this.salario=salario;
        }
        public double getSalario()
        {
            return salario;
        }
    }*/
} 