using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tuple2
{
    //A method can have a tuple as a parameter.
    public static void DisplayTuple(Tuple<int, string, string> person)
    {
        Console.WriteLine($"Id = {person.Item1}");
        Console.WriteLine($"First Name = {person.Item2}");
        Console.WriteLine($"Last Name = {person.Item3}");
    }

    //A Tuple can be return from a method.
    public static Tuple<int, string, string> GetPerson()
    {
        return System.Tuple.Create(1, "Chirag", "Gupta");
    }
}