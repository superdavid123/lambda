using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
	static void Main()
	{
		List<int> cisla = new List<int> { 5, 15, 8, 22, 1, 11 };

		// Filtrujeme čísla větší než 10
		var Numbers = cisla.Where(x => x > 10);
		// Výstup: 15, 22, 11
		Console.WriteLine(Numbers);
	}
}
