using System;

namespace prueba
{
    class Program 
    { 
        static void Main(string[] args) 
        {
            System.Console.WriteLine("Probando el avión");

            Avion miAvion = new Avion();

            miAvion.ArrancarMotor("Broooom");

            miAvion.Despegar();

            miAvion.Conducir();

            miAvion.Aterrizar();

            miAvion.PararMotor("Swishhh");

            System.Console.WriteLine("Probando el coche");

            Coche miChoche = new Coche();

            miCoche.ArrancaMotor("Room room");

            miCoche.Acelerar();

            miCoche.Conducir();

            miCoche.Frenar();

            miCoche.PararMotor("Kriiiick");

            System.Console.WriteLine("Polimorfismo en acción");

        }
    }
    
    class Vehiculo
    {
        public void ArrancarMotor(string sonidoAlArrancar)
        {
            System.Console.WriteLine($"Arranca el motor - {sonidoAlArrancar}");
        }
        public void PararMotor(string sonidoAlParar)
        {
            System.Console.WriteLine($"Parando el motor - {sonidoAlParar}");
        }
        public virtual void Conducir()
        {
            System.Console.WriteLine("Este es el código generico para el método conducir");
        }
    }
    
    class Avion : Vehiculo
    {
        public void Aterrizar()
        {
            System.Console.WriteLine("Aterrizando");
        }
        public void Despegar()
        {
            System.Console.WriteLine("Despegando");
        }
        public override void Conducir()
        {
            //base.Conducir();
            System.Console.WriteLine("Surcando los cielos");
        }
        
    }
    
    class Coche : Vehiculo
    {
        public void Acelerar()
        {
            System.Console.WriteLine("Acelerando");
        }
        public void Frenar()
        {
            System.Console.WriteLine("Frenando");
        }
        public override void Conducir()
        {
            //base.Conducir();
            System.Console.WriteLine("Recorriendo rutas");
        }
    }
} 