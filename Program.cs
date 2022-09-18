using System;

namespace FloatPointNumbers
{
	class Program
	{
		static void Main(string[]args)
		{
			float number1, number2, product;

			Console.Write("Enter a first number: ");
			number1 = Convert.ToSingle(Console.ReadLine());
			
			Console.Write("Enter a second number: ");
			number2 = Convert.ToSingle(Console.ReadLine());

			product = number1 * number2;

            Console.WriteLine("{0} * {1} = {2}", number1, number2, product);

            Console.ReadKey();
		}
	}
}