// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class ejercicio4valorapalabra {

		static void Main(string[] args) {
			int num;
			string resp;
			bool salir;
			// INPUT
			do {
				// BOOLEANO DE SALIDA
				salir = false;
				// SECUENCIA SEGÚN, PROCESO Y RESPUESTA
				Console.Write("Ingrese un valor de 1 a 5 en números enteros:");
				num = int.Parse(Console.ReadLine());
				switch (num) {
				case 1:
					Console.WriteLine("Tipeaste el número uno!");
					break;
				case 2:
					Console.WriteLine("Tipeaste el número dos!");
					break;
				case 3:
					Console.WriteLine("Tipeaste el número tres!");
					break;
				case 4:
					Console.WriteLine("Tipeaste el número cuatros!");
					break;
				case 5:
					Console.WriteLine("Tipeaste el número cinco!");
					break;
				default:
					Console.WriteLine("Ingresaste un número invalido. Copaté y ponele onda ;)");
				}
				// MENÚ DE SALIDA
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

