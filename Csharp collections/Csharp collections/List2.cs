using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class List2
    {
    public static void listarrayfunc()
    {
        string[] cities = new string[3] { "Mumbai", "London", "New York" };

        var popularCities = new List<string>();

        // adding an array in a List
        /*Use the AddRange() method to add all the elements from an array or another collection to List.*/
        popularCities.AddRange(cities);

        var favouriteCities = new List<string>();

        // adding a List 
        favouriteCities.AddRange(popularCities);

        Console.WriteLine(popularCities.Count);
        Console.WriteLine(favouriteCities.Count);

    }

    public static void listaccessfunc()
    {
        List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };
        Console.WriteLine("Accessing list in simple way");
        Console.WriteLine(numbers[0]); 
        Console.WriteLine(numbers[1]); 
        Console.WriteLine(numbers[2]); 
        Console.WriteLine(numbers[3]);
        Console.WriteLine(numbers[4]);
        Console.WriteLine(" ");



        // using foreach LINQ method
        Console.WriteLine("Accessing list using foreach LINQ method");
        numbers.ForEach(el => Console.WriteLine(el));
        Console.WriteLine(" ");

        Console.WriteLine("Accessing list using foreach loop");
        foreach (var el in numbers)
            Console.WriteLine(el);
        Console.WriteLine(" ");


        // using for loop
        Console.WriteLine("Accessing list using for loop");
        for (int i = 0; i < numbers.Count; i++)
            Console.WriteLine(numbers[i]);
        Console.WriteLine(" ");

    }
}
