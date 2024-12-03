using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static void Main()
	{
		List<string> slova = new List<string> { "jablko", "banán", "kiwi", "pomeranč", "hruška" };

		// Seřadíme seznam podle délky řetězce
		var slovicka = slova.OrderBy(s => s.Length).ToList();
		// Výstup: kiwi, hruška, banán, jablko, pomeranč
		foreach (string slovo in slovicka)
		{
			Console.WriteLine(slovo);
		}
	}
}
