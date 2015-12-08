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

			//Събиране на числа
			a = 10;
			b = 5;
			sum = a + b;

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

			Console.WriteLine ("\nStandartno delene: " + ( 14/4 ). ToString());
			Console.WriteLine ("standartno delene: " + (14 % 4).ToString ());
		}
	}
}
