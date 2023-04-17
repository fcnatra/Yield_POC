using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		var elements = new System.Collections.Generic.List<Element>();
		elements.Add(Element.New(1, "first"));
		elements.Add(Element.New(2, "second"));
		elements.Add(Element.New(3, "third"));
		elements.Add(Element.New(4, "fourtg"));
		elements.Add(Element.New(5, "fifth"));
		elements.Add(Element.New(6, "sixth"));
		elements.Add(Element.New(7, "septh"));
		
		var dict = elements.ToDictionary(x => x.Id, x => x);
		
		Console.WriteLine("Seventh element: " + dict[7].Value);
		
		Console.WriteLine();
		foreach(Element monthName in GetMonthNames("es"))
			Console.WriteLine(monthName.Value);
		
		Console.WriteLine();
		foreach(Element monthName in GetMonthNames("es").Where(m => m.Value.StartsWith("m")))
			Console.WriteLine(monthName.Value);

		Console.WriteLine("\nEND");
	}
	
	public static System.Collections.Generic.IEnumerable<Element> GetMonthNames(string culture)
	{
		for (int i = 0; i < 12; i++)
		{
			Console.WriteLine("Creating yield element " + i.ToString());
			yield return Element.New(i, new DateTime(2020, i + 1, 1)
				.ToString("MMMM", System.Globalization.CultureInfo.CreateSpecificCulture(culture)));
		}
	}
}

public class Element
{
	public int Id {get; set;}
	public string Value {get; set;}
	public static Element New(int id, string value)
	{
		return new Element {Id = id, Value = value};
	}
}
