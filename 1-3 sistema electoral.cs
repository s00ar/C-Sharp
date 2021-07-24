// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;
using System.Threading;

namespace PSeInt {
	class sistelectoral {

		static void Main(string[] args) {
			int edad;
			string nom;
			string pregunta;
			string resp;
			bool salir;
			do {
				// DEFINO EL VALOR DEL BOOLEANO COMO FALSO
				salir = false;
				// PRESENTACIÓN
				Console.Clear();
				Console.WriteLine("Bienvenido al sistema de control electoral");
				Thread.Sleep(1*1000);
				// ENTRADAS
				Console.Write("Ingrese por favor sus nombres y apellido completo: ");
				nom = Console.ReadLine();
				Console.Clear();
				Console.WriteLine("Bienvenido al sistema de control electoral");
				Console.Write("Por favor ingrese su edad: ");
				edad = int.Parse(Console.ReadLine());
				Console.Clear();
				Console.WriteLine("Bienvenido al sistema de control electoral");
				// PROCESO Y DEVOLUCIÓN
				if (edad<16 || edad>70) {
					Console.WriteLine("Hola "+nom+", tu edad es "+edad+" y NO estas habilitado para votar!");
				} else {
					Console.WriteLine("Felicitaciones! "+nom+" Estas habilitado para votar! Hacelo con responsabilidad. No seas bolud@");
				}
				Console.WriteLine("Presione cualquier tecla para continuar");
				Console.ReadKey();
				Console.Clear();
				Console.WriteLine("Bienvenido al sistema de control electoral");
				// SALIDA CONDICIONAL DEL PROGRAMA
				Console.WriteLine("Deseas salir [S][N]?");
				resp = Console.ReadLine();
				if (resp.Equals("S") || resp.Equals("s")) {
					salir = true;
					if (resp.Equals("N") || resp.Equals("n")) {
						Console.Clear();
						Console.WriteLine("reiniciando programa electoral");
						Thread.Sleep(1*1000);
						salir = false;
					}
				} else {
					Console.Clear();
					Console.WriteLine("Ojo que metiste el dedo en cualquier lado");
					Console.WriteLine("Deseas salir [S][N]?");
					resp = Console.ReadLine();
					if (resp.Equals("S") || resp.Equals("s")) {
						salir = true;
						if (resp.Equals("N") || resp.Equals("n")) {
							Console.Clear();
							Console.WriteLine("reiniciando programa electoral");
							Thread.Sleep(1*1000);
							salir = false;
						}
					}
					Thread.Sleep(3*1000);
					salir = false;
				}
			} while (salir!=true);
		}

	}

}

