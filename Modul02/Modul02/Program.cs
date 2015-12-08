using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;
			string program_name = "Modul02 - Primeri";
			string program_version = "1.0";


			//Събиране на числа
			a = 10;
			b = 5;
			sum = a + b;

			//Za programata
			Console.WriteLine ( program_name );
			Console.WriteLine ( "Version: " + program_version + "\n\n");

			//Писане в конзола
			Console.Write (a);
			Console.Write (" plus ");
			Console.Write (b);
			Console.Write ( " ravno na ");
			Console.WriteLine (sum);

			//Допълнителни оператори
			Console.WriteLine ("\nIzpolzwane na +=");
			a += b; //a=12+6, a=a+b
			Console.WriteLine (a);

			Console.WriteLine ("\nIzpolzwane na -=");
			a -= b;
			Console.WriteLine (a);

			Console.WriteLine ("\nIzpolzwane na *=");
			a *= b;
			Console.WriteLine (a);
			a = 15; b = 10;
			Console.WriteLine ("\n Standartno delene: " + ( 14/4 ). ToString());
			Console.WriteLine ("\n Hvastane na ostatak: " + (14 % 4).ToString ());

			Console.WriteLine (a % b);		//pokazwa ostataka

			Console.WriteLine ( program_name );
		}
	}
}
