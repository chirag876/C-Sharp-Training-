using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class HashTable
    {
    public static void hashtablefunc()
    {
        //The following example demonstrates creating a Hashtable and adding elements.
        Hashtable numberNames = new Hashtable();
        Console.WriteLine("Adding a key/value using the Add() method");
        Console.WriteLine(" ");
        numberNames.Add(1, "One"); //adding a key/value using the Add() method
        numberNames.Add(2, "Two");
        numberNames.Add(3, "Three");
        //numberNames.Add(3, "Three");//run-time exception: key already added.

        foreach (DictionaryEntry kvp in numberNames)
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        Console.WriteLine(" ");


        //creating a dictionary using collection-initializer syntax
        Console.WriteLine("Creating a dictionary using collection-initializer syntax");
        Console.WriteLine(" ");
        var cities = new Hashtable(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

        foreach (DictionaryEntry kvp in cities)
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

    }
}
