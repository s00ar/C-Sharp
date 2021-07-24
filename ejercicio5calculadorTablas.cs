// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class ejercicio4tablasdemultiplicación {

		static void Main(string[] args) {
			int max;
			int num;
			string resp;
			int respuesta;
			bool salir;
			int tabla;
			// INPUT
			do {
				// BOOLEANO DE SALIDA
				salir = false;
				// SECUENCIA SEGÚN, PROCESO Y RESPUESTA
				Console.Write("Ingrese el número entero del que desea saber la tabla:");
				num = int.Parse(Console.ReadLine());
				max = 10;
				for (tabla=1;tabla<=max;tabla++) {
					respuesta = num*tabla;
					Console.WriteLine(num+" x "+tabla+" = "+respuesta);
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

