// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;
using System.Threading;

namespace PSeInt {
	class reloj {

		static void Main(string[] args) {
			int horas;
			int minutos;
			int segundos;
			horas = 0;
			minutos = 0;
			segundos = 0;
			do {
				Console.Write("Escribe la hora exacta en formato de 24hs: ");
				horas = int.Parse(Console.ReadLine());
				if (horas>23 || horas<0) {
					Console.WriteLine("Formato de horario incorrecto");
					horas = 0;
					Thread.Sleep(1*1000);
					Console.Clear();
				}
				Console.Write("Ingresar los minutos: ");
				minutos = int.Parse(Console.ReadLine());
				if (minutos>59 || minutos<0) {
					Console.WriteLine("Formato de horario incorrecto");
					minutos = 0;
					Thread.Sleep(1*1000);
					Console.Clear();
				}
			} while (horas<=0);
			while (true) {
				Console.Clear();
				Console.WriteLine("RELOJ EN VIVO");
				if (horas<10) {
					Console.Write("0");
				}
				Console.Write(horas+":");
				if (minutos<10) {
					Console.Write("0");
				}
				Console.Write(minutos+":");
				if (segundos<10) {
					Console.Write("0");
				}
				Console.WriteLine(segundos);
				// aumentar en un segundo
				segundos = segundos+1;
				if (segundos==60) {
					minutos = minutos+1;
					segundos = 0;
					if (minutos==60) {
						horas = horas+1;
						minutos = 0;
						if (horas==24) {
							horas = 0;
						}
					}
				}
				Thread.Sleep(1*1000);
			}
		}

	}

}

