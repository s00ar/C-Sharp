// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class calculoimc {

		static void Main(string[] args) {
			double estatura;
			double peso;
			string resp;
			double resultado;
			bool salir;
			// REPETICIÓN PARA QUE TODO EL PROGRAMA SE EJECUTE HASTA LA ÓRDEN DE SALIR
			do {
				// PARA QUE SOLO SALGA CUANDO PASE A SER VERDADERO
				salir = false;
				// ENTRADA DE DATOS CON VALIDACIÓN
				Console.WriteLine("=========================================================================");
				Console.WriteLine("Bienvenido al sistema automatizado y revolucionario de medición de Indice de Masa Corporal de forrocorp");
				Console.WriteLine("");
				Console.WriteLine("=========================================================================");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine(">>>Presiona cualquier tecla para continuar...<<<");
				Console.ReadKey();
				Console.Clear();
				do {
					Console.Clear();
					Console.WriteLine("******************************************************");
					Console.WriteLine("* Ingrese su estatura en metros separados por punto: *");
					Console.WriteLine("******************************************************");
					estatura = Double.Parse(Console.ReadLine());
					if (estatura<0) {
						Console.WriteLine("dato erroneo");
						estatura = 0;
					} else {
						Console.WriteLine("dato aceptado");
					}
				} while (estatura<=0);
				do {
					Console.Clear();
					Console.WriteLine("***********************************");
					Console.WriteLine("*     Ingrese su peso en kg:      *");
					Console.WriteLine("***********************************");
					peso = Double.Parse(Console.ReadLine());
					if (peso<0) {
						Console.WriteLine("dato erroneo");
						peso = 0;
					} else {
						Console.WriteLine("dato aceptado");
					}
				} while (peso<=0);
				// CALCULO Y DEVOLUCIÓN A USUARIO
				Console.Clear();
				resultado = peso/(estatura*estatura);
				if (resultado>24.9) {
					Console.WriteLine("***********************************");
					Console.WriteLine("*         Tienes sobrepeso        *");
					Console.WriteLine("***********************************");
				}
				if (resultado<24.9 && resultado>18.4) {
					Console.WriteLine("***********************************");
					Console.WriteLine("*      Estas en tu peso ideal     *");
					Console.WriteLine("***********************************");
				}
				if (resultado<18.4) {
					Console.WriteLine("***********************************");
					Console.WriteLine("*Estas por debajo de tu peso ideal*");
					Console.WriteLine("***********************************");
				}
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine(">>>Presiona cualquier tecla para continuar...<<<");
				Console.ReadKey();
				Console.Clear();
				Console.WriteLine("***********************************");
				Console.WriteLine("      Tu IMC es:"+resultado);
				Console.WriteLine("***********************************");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine(">>>Presiona cualquier tecla para continuar...<<<");
				Console.ReadKey();
				Console.Clear();
				// SALIDA CONDICIONAL DEL PROGRAMA
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("***********************************");
				Console.WriteLine("*      Deseas salir [S][N]?       *");
				Console.WriteLine("***********************************");
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

