using System;
using System.Collections.Generic;
using System.Linq;

class Kniha
{
	public string Nazev { get; set; }
	public string Autor { get; set; }
	public int RokVydani { get; set; }
}

class Program
{
	static void Main()
	{
		List<Kniha> knihy = new List<Kniha>
		{
			new Kniha { Nazev = "Kniha A", Autor = "Autor X", RokVydani = 1995 },
			new Kniha { Nazev = "Kniha B", Autor = "Autor Y", RokVydani = 2005 },
			new Kniha { Nazev = "Kniha C", Autor = "Autor X", RokVydani = 2010 },
			new Kniha { Nazev = "Kniha D", Autor = "Autor Z", RokVydani = 2018 }
		};

		// Filtrování knih po roce 2000, seřazení podle autora, transformace na názvy knih

		// Filtrování knih       
		var noveknihy = knihy.Where(k => k.RokVydani > 2000);
		// Seřazení podle autora
		var noveknihy123 = noveknihy.OrderBy(k => k.Autor);
		// Transformace na názvy knih
		var noveknihyjsousigma = noveknihy123.Select(k => k.Nazev);
		//výstup
		foreach (string slovo in noveknihyjsousigma)
		{
			Console.WriteLine(slovo);

		}
	}
}
