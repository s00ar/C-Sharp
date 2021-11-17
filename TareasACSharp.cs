using System;
using System.Threading;

namespace proyectoTareasACSharp
{
    class Program
    {        
        static void Main(string[] args)
        {
			bool menuPrincipal = true;
            while(menuPrincipal==true)
            {
                try
                {
                    MenuPrincipal();
                }
                catch(Exception e)
                {
                    Console.WriteLine($"ERROR GENERAL\n"+e.Message+
                    "Presione cualquier tecla para continuar");
                    Console.ReadKey();
                }
            }
        }//fin metodo main
            
        static void MenuPrincipal()
        {
            int menuPrincOpc = 0;
		/*	bool ExitProgMenuPrinc = true;
			while (ExitProgMenuPrinc==true)
			{*/
				Console.Clear();
				Console.WriteLine("MENU PRINCIPAL \n"+
				"[1] EJERCICIOS DE CLASE 2 \n"+
				"[2] EJERCICIOS DE CLASE 3 \n"+
				"[3] EJERCICIOS DE CLASE 4 \n"+
				"[4] EJERCICIOS DE CLASE 7 \n"+
				"[5] SALIR");
				menuPrincOpc = int.Parse(Console.ReadLine());
				switch (menuPrincOpc)
				{
				case 1:
					FunctionEjerciciosClase2();
					break;
				case 2:
					FunctionEjerciciosClase3();
					break;
				case 3:
					FunctionEjerciciosClase4();
					break;
				case 4:
					FunctionEjerciciosClase7();
					break;
				case 5:
				    Environment.Exit(0);
					break;
				default:
					Console.WriteLine("Ingresó un valor invalido. Intentelo nuevamente.");
					Console.WriteLine("Presione una tecla para continuar.");
					Console.ReadLine();
					break;
				}
			//}
        }//fin metodo
        static void FunctionEjerciciosClase2()
        {
            bool menu1 = true;
            int menu1Opc;
                while (menu1)
                {
                    Console.Clear();
                    Console.WriteLine("EJERCICIOS CLASE 2 \n"+
					"[0] MENU PRINCIPAL \n"+
                    "[1] EJERCICIO 1: Producto, Suma y Media de 4 valores \n"+
                    "[2] EJERCICIO 2: Suma de 2 valores numericos \n"+
                    "[3] EJERCICIO 3: Volumen de un prisma \n"+
                    "[4] EJERCICIO 4: Valor de Masa Corporal \n"+
                    "[5] EJERCICIO 5: Desempeño de un automóvil \n");
                    menu1Opc = int.Parse(Console.ReadLine());
                    switch (menu1Opc)
                    {
                    case 0:
                        MenuPrincipal();
                        break;
                    case 1:
                        Console.WriteLine("Ingrese valor 1: ");
                        double valor1=double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese valor 2: ");
                        double valor2=double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese valor 3: ");
                        double valor3=double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese valor 4: ");
                        double valor4=double.Parse(Console.ReadLine());
                        double respProd = valor1 * valor2 * valor3 * valor4;
                        double respSuma = valor1 + valor2 + valor3 + valor4;
                        double respMedia = respSuma/4;
                        Console.WriteLine($"El resultado del producto de los valores ingresados es: {respProd}");
                        Thread.Sleep(1000);
                        Console.WriteLine($"El resultado de la suma de los valores ingresados es: {respSuma}");
                        Thread.Sleep(1000);
                        Console.WriteLine($"El resultado de la media de los valores ingresados es: {respMedia}");
                        Thread.Sleep(1000);
                        Console.WriteLine("Presione una tecla para continuar.");
                        Console.ReadLine();
                        break;
                    case 2:
                        double val1, val2, suma;
                        Console.WriteLine("Ingrese valor 1: ");
                        val1=double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese valor 2: ");
                        val2=double.Parse(Console.ReadLine());
                                       
                        suma = val1 + val2;

                        Console.WriteLine($"El resultado de la suma de los valores ingresados es: {suma}");
                        Console.WriteLine("Presione una tecla para continuar.");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese la base del prisma: ");
                        double basePrisma=Double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la altura del prisma: ");
                        double alturaPrisma=Double.Parse(Console.ReadLine());
                        double volumenPrisma=basePrisma*alturaPrisma;
                        Console.WriteLine($"El volumen del prisma ingresado es de {volumenPrisma}");
                        Console.WriteLine("Presione una tecla para continuar.");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Ingrese su altura en metros separado por punto: ");
                        double alt=double.Parse(Console.ReadLine());
                        Console.Write("Ingrese su peso en kilogramos: ");
                        double peso=double.Parse(Console.ReadLine());

                        double imc=peso/(Math.Pow(alt, 2));
                        //double imc = peso/(alt*alt);
                        Console.WriteLine($"Tu IMC es: {imc}");
                        Console.WriteLine("Presione una tecla para continuar.");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Write("Ingrese la cantidad de kilometros recorridos: ");
                        float km=float.Parse(Console.ReadLine());
                        Console.Write("Ingrese el precio de combustible: ");
                        float precio=float.Parse(Console.ReadLine());
                        Console.Write("Ingrese cuantos kilometros recorre el vehículo por litro de combustible: ");
                        float kml=float.Parse(Console.ReadLine());

                        float lConsumidos=km/kml;
                        Console.WriteLine($"La cantidad de litros consumidos es de {lConsumidos}");
                        float importe=lConsumidos*precio;
                        Console.WriteLine($"El importe económico es de ${importe}");
                        Console.WriteLine("Presione una tecla para continuar.");
                        Console.ReadLine();
                        break;      
                    default:
                        Console.WriteLine("Ingresó un valor invalido. Intentelo nuevamente.");
                        break;
					}
                }
        }
        static void FunctionEjerciciosClase3()
        {
            bool menu2 = true;
            int menu2Opc;
            while (menu2)
            {
                Console.Clear();
                Console.WriteLine("EJERCICIOS CLASE 3 \n"+
				"[0] MENU PRINCIPAL \n"+
                "[1] EJERCICIO 1 a 3: Sistema Electoral \n"+
                "[2] EJERCICIO 4: Valor numerico a letras \n"+
                "[3] EJERCICIO 5: Tablas de multiplicar \n");
                menu2Opc = int.Parse(Console.ReadLine());
                switch (menu2Opc)
                {
                    case 0:
                        MenuPrincipal();
                        break;
                    case 1:
                        Console.Write("Ingrese nombre y apellido:");
                        string nomApe=Console.ReadLine();
                        Console.Write("Ingrese su edad: ");
                        int edad=int.Parse(Console.ReadLine());

						if (edad>16 && edad<70){
							Console.WriteLine("Estas habilitado para Votar");
						} else {
							Console.WriteLine($"Hola {nomApe}. Tu edad es: {edad} y no estas habilitado para votar!");
						}
						Console.WriteLine("Presione una tecla para continuar.");
						Console.ReadLine();
						break;
					case 2:
						Console.WriteLine("Ingrese su valor entre 1 y 5: ");
						int num=int.Parse(Console.ReadLine());
						Console.Clear();
						if (num>0 && num<6)
						{
							switch (num)
							{
								case 1:
								Console.WriteLine("UNO");
								break;
								case 2:
								Console.WriteLine("DOS");
								break;
								case 3:
								Console.WriteLine("TRES");
								break;
								case 4:
								Console.WriteLine("CUATRO");
								break;
								case 5:
								Console.WriteLine("CINCO");
								break;
							}                     
						} else
						{
							Console.WriteLine("Dato erróneo");
						}
						Console.WriteLine("Presione una tecla para continuar.");
						Console.ReadLine();
						break;
					case 3:            
						int tabla=1;
						int resTabla=1;

						Console.WriteLine("Ingrese la tabla de multiplicar deseada");
						int valTabla=int.Parse(Console.ReadLine());
						Console.Clear();

						Console.WriteLine($"Tabla del {valTabla}");
						while (tabla<=10)
						{
							resTabla=tabla*valTabla;
							Console.WriteLine($"{tabla} x {valTabla} = {resTabla}");
							Thread.Sleep(1000);
							tabla++;
						}
						Console.WriteLine("Presione una tecla para continuar.");
						Console.ReadLine();
						break;      
					default:
						Console.WriteLine("Ingresó un valor invalido. Intentelo nuevamente.");
						break;
					}
				}
		}
		static void FunctionEjerciciosClase4()
		{
				bool menu3 = true;
				int menu3Opc;
					while (menu3)
					{
						Console.Clear();
						Console.WriteLine("EJERCICIOS CLASE 4 \n"+
						"[0] MENU PRINCIPAL \n"+
						"[1] EJERCICIO 1: Sistema de carga de articulo con precio y código de descuento \n"+
						"[2] EJERCICIO 2: Serie de números pares, impares y ceros \n"+
						"[3] EJERCICIO 3: Calculador de IMC mejorado \n"+
						"[4] EJERCICIO 4: Número positivo, negativo o cero \n"+
						"[5] EJERCICIO 5: Carga hombres y mujeres de Discoteca \n");
						menu3Opc = int.Parse(Console.ReadLine());
							switch (menu3Opc)
							{
								case 0:
									MenuPrincipal();
									break;
								case 1:
									Console.Write("Ingrese Nombre del artículo: ");
									string art=Console.ReadLine();
									Console.Write("Ingrese el Código del Artículo: ");
									double cod=double.Parse(Console.ReadLine());
									Console.Write("Ingrese el precio del Artículo: ");
									double precioArt=double.Parse(Console.ReadLine());

									double precioDesc=0;
									if (cod==1 || cod==2)
									{
										if (cod==1)
										{
											precioDesc=precioArt*0.90;
										}
										if (cod==2)
										{
											precioDesc=precioArt*0.80;
										}
										else
										{
											Console.WriteLine("Error de carga de artículo");
										}
									}

									Console.WriteLine($"El Artículo {art} || Código: 0{cod} || Precio Original: ${precioArt} || Precio con Descuento: ${precioDesc}");

									Console.WriteLine("Presione una tecla para continuar.");
									Console.ReadLine();
									break;
								case 2:
									double contadorCeros=0;
									double contadorPares=0;
									double contadorImpares=0;
									double numWhile=0;
									string valoresIng="";
									string comaEsp=", ";

									Console.Clear();
									while (numWhile>=0)
									{
										Console.Clear();
										Console.WriteLine("Ingrese valor: ");
										numWhile = double.Parse(Console.ReadLine());
											if (numWhile==0)
											{
												contadorCeros++;
											}
											if (0==(numWhile%2))
											{
												contadorPares++;
											}
											if (0!=(numWhile%2))
											{
												contadorImpares++;
											}
										Convert.ToString(numWhile);
										if (numWhile<0)
										{
											valoresIng=valoresIng + numWhile;
										}
										else
										{
											valoresIng=valoresIng + numWhile + comaEsp;
										}
									}
									Console.Clear();
									if (contadorCeros==0 ||contadorCeros==1)
									{
										if (contadorCeros==0)
										{
										Console.WriteLine("No se procesaron ceros durante la carga");
										}
										else {
											Console.WriteLine("Se proceso un solo cero durante la carga");
										}
									}
									else
									{
										Console.WriteLine($"Se procesaron {contadorCeros} ceros durante la carga");
									}
									Console.WriteLine($"Total de valores pares: {contadorPares} || Total de valores impares: {contadorImpares}");
									if (contadorImpares==0 || contadorPares==0)
									{
										Console.WriteLine("La serie no presenta alternancia!");
									} else
									{
										Console.WriteLine("La serie presenta alternancia!");
									}
									Console.WriteLine($"Estos son los valores ingresados: {valoresIng}");
									Console.WriteLine("Presione una tecla para continuar.");
									Console.ReadLine();
									break;
								case 3:
									Console.Write("Ingrese su altura en metros separado por punto: ");
									double alt=double.Parse(Console.ReadLine());
									Console.Write("Ingrese su peso en kilogramos: ");
									double peso=double.Parse(Console.ReadLine());

									double imc=peso/(Math.Pow(alt, 2));
									Console.WriteLine($"Tu IMC es: {imc}");
									if (imc>30)
									{
										Console.WriteLine("Paciente con obesidad");
									} else
									{
										if (imc>25 && imc<29.9)
										{
											Console.WriteLine("Paciente con sobrepeso");
										} else 
										{
											if (imc>18.5 && imc<24.9)
											{
												Console.WriteLine("Paciente dentro del peso normal");
											}
										}
									}
									Console.WriteLine("Presione una tecla para continuar.");
									Console.ReadLine();
									break;
								case 4:
									Console.Write("Ingrese un número: ");
									double num=double.Parse(Console.ReadLine());
									if (num>0)
									{
										Console.WriteLine("El número ingresado es positivo");
									} else 
									{
										if (num<0)
										{
											Console.WriteLine("El número ingresado es negativo");
										} else 
										{
											Console.WriteLine("El número ingresado es cero");
										}
									}
									Console.WriteLine("Presione una tecla para continuar.");
									Console.ReadLine();
									break;
								case 5:
									int may25=0;
									int edad=0;
									int hombres=0;
									int mujeres=0;
									string sexo;
									int nro = 0;

									for (int i = 0; i < 20; i++)
									{
										nro++;
										Console.WriteLine($"Jóven número {nro}");
										Console.Write("Ingresa tu edad:");
										edad = int.Parse(Console.ReadLine());
										if (edad>=25)
										{
											may25++;
										}
										Console.Write("Indica tu sexo: [F][M]");
										sexo = Console.ReadLine();
										if (sexo=="M")
										{
											hombres++;
										} else 
										{
											if (sexo=="F")
											{
												mujeres++;
											}
										}
									}
									Console.WriteLine($"De las 20 personas ingresadas, {mujeres} son mujeres; {hombres} son hombres y {may25}");
									Console.WriteLine("Presione una tecla para continuar.");
									Console.ReadLine();
									break;      
								default:
									Console.WriteLine("Ingresó un valor invalido. Intentelo nuevamente.");
									break;
							}
					}
		}
		static void FunctionEjerciciosClase7()
		{
				bool menu4 = true;
				int menu4Opc;
					while (menu4)
					{
						Console.Clear();
						Console.WriteLine("EJERCICIOS CLASE 7 \n"+
						"[0] MENU PRINCIPAL \n"+
						"[1] EJERCICIO 1: Valores numericos a letras \n"+
						"[2] EJERCICIO 2: Números a días de la semana \n"+
						"[3] EJERCICIO 3: Vocales minúscula a mayúscula \n"+
						"[4] EJERCICIO 4: Suma, Resta y Multiplicación de 2 valores \n"+
						"[5] EJERCICIO 5: Carga de Clientes con código y situación fiscal \n");
						menu4Opc = int.Parse(Console.ReadLine());
							switch (menu4Opc)
							{
								case 0:
									MenuPrincipal();
									break;
								case 1:
									Console.WriteLine("Ingrese su valor entre 1 y 5: ");
									int num=int.Parse(Console.ReadLine());
									Console.Clear();
									if (num>0 && num<6)
									{
										switch (num)
										{
											case 1:
											Console.WriteLine("UNO");
											break;
											case 2:
											Console.WriteLine("DOS");
											break;
											case 3:
											Console.WriteLine("TRES");
											break;
											case 4:
											Console.WriteLine("CUATRO");
											break;
											case 5:
											Console.WriteLine("CINCO");
											break;
										}                     
									} else
									{
										Console.WriteLine("Dato erróneo");
									}
									Console.WriteLine("Presione una tecla para continuar.");
									Console.ReadLine();
									break;
								case 2:
									char pregExit='n';
									bool progRun=true;
									int nroDia;
								
									while(progRun==true)//while (pregExit='s') || (pregExit='S')
									{
									Console.WriteLine("Ingrese un número del 1 al 7");
									nroDia = int.Parse(Console.ReadLine());
									switch (nroDia)
									{
										case 1:
										Console.WriteLine("El nro 1 se corresponde con el día LUNES /n");
										break;
										case 2:
										Console.WriteLine("El nro 2 se corresponde con el día MARTES /n");
										break;
										case 3:
										Console.WriteLine("El nro 3 se corresponde con el día MIERCOLES /n");
										break;
										case 4:
										Console.WriteLine("El nro 4 se corresponde con el día JUEVES /n");
										break;
										case 5:
										Console.WriteLine("El nro 5 se corresponde con el día VIERNES /n");
										break;
										case 6:
										Console.WriteLine("El nro 6 se corresponde con el día SÁBADO /n");
										break;
										case 7:
										Console.WriteLine("El nro 7 se corresponde con el día DOMINGO /n");
										break;
										default:
										Console.WriteLine("Valor incorrecto. Intentalo nuevamente.");
										break;
									}
									Console.Write("Deseas continuar? [S]][N]");
									pregExit = char.Parse(Console.ReadLine());
									switch(pregExit)
									{
										case 's':
											Console.WriteLine("Reiniciando programa. Presione cualquier tecla para continuar");
											Console.ReadKey();
											break;
										
										case 'S':
											Console.WriteLine("Reiniciando programa. Presione cualquier tecla para continuar");
											Console.ReadKey();
											break;
										
										case 'n':
											Console.WriteLine("Saliendo del programa. Presione cualquier tecla para continuar");
											Console.ReadKey();
											progRun=false;
											break;
										
										case 'N':
											Console.WriteLine("Saliendo del programa. Presione cualquier tecla para continuar");
											Console.ReadKey();
											progRun=false;
											break;
										default:
											Console.WriteLine("Valor incorrecto. Vuelva a intentarlo");
											break;
										}   
									}
									Console.WriteLine("Presione una tecla para continuar.");
									Console.ReadLine();
									break;
								case 3:
									char letra;

									Console.WriteLine("Ingrese una vocal: ");
									letra = char.Parse(Console.ReadLine());
									Console.Clear();
									if (letra=='A' || letra=='E' || letra=='I' || letra=='O' || letra=='U')
									{
										Console.WriteLine("Tu vocal ya está en mayuscula!");
									} else {

									switch (letra)
									{
										case 'a':
										Console.WriteLine("A");
										break;
										case 'e':
										Console.WriteLine("E");
										break;
										case 'i':
										Console.WriteLine("I");
										break;
										case 'o':
										Console.WriteLine("O");
										break;
										case 'u':
										Console.WriteLine("U");
										break;
										default:
										Console.WriteLine("Usted ingresó una consonante!");
										break;
										}
									}
									Console.WriteLine("Presione una tecla para continuar.");
									Console.ReadLine();
									break;
								case 4:
									double operacRes;

									Console.Clear();
									Console.WriteLine("Ingresa el primer valor de la operación: ");
									double valor1 = int.Parse(Console.ReadLine());
									
									Console.Clear();
									Console.WriteLine("Ingresa el segundo valor de la operación: ");
									double valor2 = int.Parse(Console.ReadLine());
									
									Console.Clear();
									Console.WriteLine("Seleccione la operación a realizar y digite el número corriespondiente a la misma: \n"+"1 - SUMA\n"+"2 - RESTA\n"+"3 - MULTIPLICACIÓN");
									double operacSel = int.Parse(Console.ReadLine());
									switch (operacSel)
									{
										case 1:                
										Console.Clear();
										operacRes = valor1 + valor2;
										Console.WriteLine($"La SUMA de los valores ingresados es {operacRes}");
										Console.WriteLine("\n Presione una tecla para continuar");
										Console.ReadLine();
										break;
										case 2:                
										Console.Clear();
										operacRes = valor1 - valor2;
										Console.WriteLine($"La RESTA de los valores ingresados es {operacRes}");
										Console.WriteLine("\n Presione una tecla para continuar");
										Console.ReadLine();
										break;
										case 3:                
										Console.Clear();
										operacRes = valor1 * valor2;
										Console.WriteLine($"La MULTIPLICACIÓN de los valores ingresados es {operacRes}");
										Console.WriteLine("\n Presione una tecla para continuar");
										Console.ReadLine();
										break;
										default:                
										Console.Clear();
										Console.WriteLine("Valor erróneo. Vuelva a intentarlo");
										Console.WriteLine("\n Presione una tecla para continuar");
										Console.ReadLine();
										break;
									}
									Console.WriteLine("Presione una tecla para continuar.");
									Console.ReadLine();
									break;
								case 5:
									double montoAli, montoFinal;
									string tipoIva;

									Console.Write("Ingrese el código de cliente: ");
									int codCliente = int.Parse(Console.ReadLine());
									Console.Write("Ingrese nombre del cliente o razón social: ");
									string nomCliente = Console.ReadLine();
									Console.Write("Seleccione la situación fiscal del cliente:\n"+
													"[1] ...RESPONSABLE INSCRIPTO \n"+
													"[2] RESPONSABLE NO INSCRIPTO \n"+
													"[3] ..................EXENTO \n"+
													"[4] ........CONSUMIDOR FINAL \n"+
													"Indique el número de opción seleccionada: ");
									int sitFiscal = int.Parse(Console.ReadLine());
									Console.Write("Ingrese monto de la compra: $");
									double montoOrig = double.Parse(Console.ReadLine());

									switch (sitFiscal)
									{
										case 1:
											montoAli = montoOrig * 0.14;
											montoFinal = montoOrig * 1.14;
											tipoIva = "RESPONSABLE INSCRIPTO";
											break;
										case 2:
											montoAli = montoOrig * 0.18;
											montoFinal = montoOrig * 1.18;
											tipoIva = "RESPONSABLE NO INSCRIPTO";
											break;
										case 3:
											montoAli = 0;
											montoFinal = montoOrig;
											tipoIva = "EXENTO";
											break;
										case 4:
											montoAli = montoOrig * 0.21;
											montoFinal = montoOrig * 1.21;
											tipoIva = "CONSUMIDOR FINAL";
											break;
										default:
											montoAli = montoOrig * 0.21;
											montoFinal = montoOrig * 1.21;
											tipoIva = "OTRO";
											break;
									}
									Console.WriteLine($"Código del cliente.........................{codCliente}");
									Console.WriteLine($"Nombre del cliente/razón social............{nomCliente}");
									Console.WriteLine($"Situación IVA..............................{tipoIva}");
									Console.WriteLine($"Monto de Alicuota IVA correspondiente......{montoAli}");
									Console.WriteLine($"Monto total de compra c/Alicuota incluida..{montoFinal}");
									Console.WriteLine("-------------------------------------------------------");
									Console.WriteLine("Presione una tecla para finalizar");
									Console.ReadLine();
									break;      
								default:
									Console.WriteLine("Ingresó un valor invalido. Intentelo nuevamente.");
									break;
							}//cierra switch ejercicios clase 7
					}//while functclase7
		}//metodo clase 7
    }//program class
}//namespace