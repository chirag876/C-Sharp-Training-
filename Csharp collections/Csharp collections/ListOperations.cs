using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class ListOperations
    {
    public static void listoperationfunc()
    {
        // Insert elements into List
        Console.WriteLine("inserting 11 at 1st index: after 10.");
        var numbers = new List<int>() { 10, 20, 30, 40 };

        numbers.Insert(1, 11);// inserts 11 at 1st index: after 10.

        foreach (var num in numbers)
            Console.WriteLine(num);
        Console.WriteLine(" ");
    }

    public static void listoperationfunc2()
    {
        //Remove elements from List

        var numbers = new List<int>() { 10, 20, 30, 40, 10 };

        numbers.Remove(10); // removes 10 elements from a list

        numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)

        //numbers.RemoveAt(10); //removes the 3rd element (index starts from 0)

        foreach (var num in numbers)
            Console.WriteLine(num);
        Console.WriteLine(" ");
    }

    public static void listoperationfunc3()
    {
        var numbers = new List<int>() { 10, 20, 30, 40 };

        Console.WriteLine(numbers.Contains(10));
        Console.WriteLine(numbers.Contains(11));
        Console.WriteLine(numbers.Contains(20));
    }
}

