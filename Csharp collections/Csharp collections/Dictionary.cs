﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public  class Dictionary
    {
    public static void dictionaryfunc()
    {
        //Creating a dictionary and adding the elements to it
        IDictionary<int, string> numberNames = new Dictionary<int, string>();
        numberNames.Add(1, "One"); //adding key/value using the Add() method
        numberNames.Add(3, "Three");
        numberNames.Add(2, "Two");

        foreach (KeyValuePair<int, string> kvp in numberNames)
        Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

        //creating a dictionary using collection-initializer syntax
        var cities = new Dictionary<string, string>(){
            {"UK","London, Manchester, Birmingham"},
            {"USA","Chicago, New York, Washington"},
            {"India","Mumbai, New Delhi, Pune"}
        };

        foreach (var kvp in cities)
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
    }

    public static void dictionaryaccess()
    {
        var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

        Console.WriteLine(cities["UK"]); //prints value of UK key
        Console.WriteLine(cities["USA"]);//prints value of USA key
       //Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

        Console.WriteLine("---access elements using for loop---");
        //use ElementAt() to retrieve key-value pair using index
        for (int i = 0; i < cities.Count; i++)
        {
            Console.WriteLine("Key: {0}, Value: {1}", cities.ElementAt(i).Key, cities.ElementAt(i).Value);
        }

        //use ContainsKey() to check for an unknown key
        if (cities.ContainsKey("France"))
        {
            Console.WriteLine(cities["France"]);
        }

        //use TryGetValue() to get a value of unknown key
        string result;

        if (cities.TryGetValue("France", out result))
        {
            Console.WriteLine(result);
        }
    }
    public static void dictionaryupdate()
    {
        var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };
        cities["UK"] = "Liverpool, Bristol"; // update value of UK key
        cities["USA"] = "Los Angeles, Boston"; // update value of USA key
       //cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException
        if (cities.ContainsKey("France"))
        {
            cities["France"] = "Paris";
        }
        foreach (var kvp in cities)
        Console.WriteLine("Key: {0}, Value:{1}", kvp.Key, kvp.Value);
    }


    public static void dictionaryremove()
    {
        var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

        Console.WriteLine("Total Elements: {0}", cities.Count);

        cities.Remove("UK"); // removes UK 
       //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

        if (cities.ContainsKey("France"))
        { // check key before removing it
            cities.Remove("France");
        }
        Console.WriteLine("Total Elements: {0}", cities.Count);
        cities.Clear(); //deletes all elements
        Console.WriteLine("Total Elements after Clear(): {0}", cities.Count);
    }
    }
