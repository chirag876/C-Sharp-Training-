using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Foreachloop

{
    public void loop() //for each on array
    {
        string[] Names = { "Chirag Gupta", "Ashutosh Singh", "Devansh Sharma", "Chaavi Bindal" };

        foreach (string Name in Names)
        {
            Console.WriteLine("{0}", Name);
        }
    }
    public void loop2() //for each loop on list
    {
        List<int> oddNumbers = new List<int>() { 1, 3, 5, 7, 9 };

        foreach (int num in oddNumbers)
        {
            Console.Write(num);
        }
        Console.WriteLine("Using ForEach() Extension Method:");
        oddNumbers.ForEach(num => Console.Write(num));
    }

    public void loop3() //for each loop on dictionary
    {
        var citiesOfCountry = new Dictionary<string, string>()
{{"UK", "London, Manchester, Birmingham"},{"USA", "Chicago, New York, Washington"},{"India", "Mumbai, New Delhi, Pune"}};
        foreach (var city in citiesOfCountry)
        {
            Console.WriteLine("{0}, {1}", city.Key, city.Value);
        }
    }
}
  