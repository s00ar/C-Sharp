using System;

namespace prueba
{
    class Program 
    { 
        static void Main(string[] args) 
        {
            /*
            Bonus Antonio = Bonus.extra;
            
            double bonusAntonio=(double)Antonio;

            double salarioAntonuio=1500+bonusAntonio;

            Console.Write(bonus.Antonio);*/
            Empleado Fernando = new Empleado(Bonus.extra, 1500);
            Console.WriteLine("El sueldo de Fernando es " + Fernando.getSalario());
        }
    }
    class Empleado
    {
        public Empleado(Bonus bonusEmpleado, double salario)
        {
            bonus=(double)bonusEmpleado;
            this.salario=salario;
        }
        public double getSalario()
        {
            return salario+bonus;
        }
        private double salario, bonus;
    }
        enum Bonus { bajo=500, normal=1000, bueno=1500, extra=2000 };
} 