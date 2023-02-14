using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class NullReferenceException
    {
    public void DisplayCities(IList<string> cities)
	{
		foreach (var city in cities)
		{
			Console.WriteLine(city);
		}
	}
    }
