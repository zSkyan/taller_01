using System;
using System.Threading; // funciones o método de retardo de tiempo y similares
namespace taller
{
	class Program
	{
		public static void Main(string[] args) // método principal
		{
			// VARIABLES

			// DECLARACIONES

			// var independientes
			double X1, Y1, X2, Y2;
			
			// var dependientes
			double pendiente;
			
			// var auxiliares
			string titulo, autor;
			
			// expresiones condicionales
			bool condicion01;
			
			// mensajes
			string mensaje01, mensaje02, mensaje03, mensaje04, mensaje05, mensaje06, mensaje07, mensaje08, mensaje09;

			// DECLARACIÓN-DEFINICIÓN
			const int SEGUNDOS = 1000;
			
			// DEFINICIONES
			// explicitas constante
			mensaje01 = "Ingrese el valor de X1";
			mensaje02 = "Ingrese el valor de Y1";
			mensaje03 = "Ingrese el valor de X2";
			mensaje04 = "Ingrese el valor de Y2";

			titulo = "App que determina sí la pendiente de la recta es positiva o negativa";
			autor = "Por: Jean Pierre R.";

			// Presentación
			
			Console.WriteLine(titulo + Environment.NewLine + autor + Environment.NewLine);
			Thread.Sleep(2*SEGUNDOS);
			
			// Implícitas (lectura)
			
			Console.WriteLine(mensaje01);
			X1 = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine(mensaje02);
			Y1 = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine(mensaje03);
			X2 = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine(mensaje04);
			Y2 = Convert.ToDouble(Console.ReadLine());
			
			mensaje05 = "Usted ingreso los siguientes valores: " + "para X1: " + X1 + ", para Y1: " + Y1 + ", para X2: " + X2 + ", para Y2: " + Y2;
			Console.WriteLine(mensaje05);
			Thread.Sleep(2*SEGUNDOS);

			// Procedimiento
			
			pendiente = (Y1-Y2)/(X1-X2);
			mensaje06 = "La ecuación de la línea recta es y: ";
			Console.WriteLine(mensaje06);
			condicion01 = (pendiente!=0);
			
			if (condicion01) {
				Console.WriteLine(pendiente + " (X-"+ X1 +") + "+ Y1);
				mensaje09 = "La pendiente es: " + pendiente;
				Console.WriteLine(mensaje09);
				if ((pendiente>0)) {
					mensaje07 = "La pendiente de la recta es positiva";
					Console.WriteLine(mensaje07);
				} else {
					mensaje08 = "La pendiente de la recta es negativa";
					Console.WriteLine(mensaje08);
				}
			} else {
				Console.WriteLine(Y1);
			}

			// Sentencias para retener la consola
			Console.WriteLine(Environment.NewLine);
			Console.Write("Presione cualquier tecla para terminar . . . ");
			Console.ReadKey(true);
		}
	}
}