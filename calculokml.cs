// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class gastocombustible {

		static void Main(string[] args) {
			double importeecocomb;
			double km;
			double kml;
			double litrosconsumidos;
			double pr;
			string resp;
			bool salir;
			// REPETICIÓN PARA QUE TODO EL PROGRAMA SE EJECUTE HASTA LA ÓRDEN DE SALIR
			do {
				// PARA QUE SOLO SALGA CUANDO PASE A SER VERDADERO
				salir = false;
				// ENTRADA DE DATOS CON VALIDACIÓN  
				do {
					Console.Clear();
					Console.Write("Ingrese la cantidad de kilometros recorridos:");
					km = Double.Parse(Console.ReadLine());
				} while (km<=0);
				// PARA QUE SOLO SALGA CUANDO PASE A SER VERDADERO
				salir = false;
				// ENTRADA DE DATOS CON VALIDACIÓN  
				do {
					Console.Clear();
					Console.Write("Cuantos kilometros recorres su vehículo con 1 (un) litro de combustible:");
					kml = Double.Parse(Console.ReadLine());
				} while (kml<=0);
				do {
					Console.Clear();
					Console.Write("Cual es el precio del combustible por litro:");
					pr = Double.Parse(Console.ReadLine());
				} while (pr<=0);
				// CALUCLOS Y DEVOLUCIÓN A USUARIO
				litrosconsumidos = km/kml;
				importeecocomb = litrosconsumidos*pr;
				Console.Clear();
				Console.WriteLine("Se consumieron en total "+litrosconsumidos+" litros de combustible y el importe económico gastado fue de $");
				// SALIDA CONDICIONAL DEL PROGRAMA
				Console.WriteLine("Deseas salir [S][N]?");
				resp = Console.ReadLine();
				if (resp.Equals("S") || resp.Equals("s")) {
					salir = true;
				} else {
					salir = false;
				}
			} while (salir!=true);
		}

	}

}

