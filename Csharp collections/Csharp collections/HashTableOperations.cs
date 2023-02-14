using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public class HashTableOperations
    {
    public static void hashtabledictionary()
    {
        //Add Dictionary in Hashtable
        Dictionary<int, string> dict = new Dictionary<int, string>();

        dict.Add(1, "one");
        dict.Add(2, "two");
        dict.Add(3, "three");

        Hashtable ht = new Hashtable(dict);

        Console.WriteLine("Total elements added from dictionary to hashtable are: {0}", ht.Count);
        Console.WriteLine(" ");
    }

    public static void hashtableupdate()
    {
        var cities = new Hashtable(){{"UK", "London, Manchester, Birmingham"},{"USA", "Chicago, New York, Washington"}};
        /*You can retrieve the value of an existing key from the Hashtable by passing a key in indexer. The Hashtable is a non-generic
        collection, so you must type cast values while retrieving it.*/

        string citiesOfUK = (string)cities["UK"]; //cast to string
        string citiesOfUSA = (string)cities["USA"]; //cast to string

        Console.WriteLine("---Before updating values---");
        foreach (DictionaryEntry de in cities)
            Console.WriteLine("key: {0}, Value: {1}", de.Key, de.Value);
        Console.WriteLine(" ");

        cities["UK"] = "Liverpool, Bristol"; // update value of UK key
        cities["USA"] = "Los Angeles, Boston"; // update value of USA key

        //if (!cities.ContainsKey("France"))
        //{
        //    cities["France"] = "Paris";
        //}

        Console.WriteLine("---After updating values---");

        foreach (DictionaryEntry de in cities)
            Console.WriteLine("key: {0}, Value: {1}", de.Key, de.Value);
        Console.WriteLine(" ");
    }

    public static void hashtableremove()
    {
        //Remove Elements from Hashtable
        /*The Remove() method removes the key-value that match with the specified in the Hashtable. It throws the KeyNotfoundException if 
         the specified key not found in the Hashtable, so check for an existing key using the ContainsKey() method before removing.*/

        //Use the Clear() method to remove all the elements in one shot.

        var cities = new Hashtable(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

        Console.WriteLine("Total Elements before removing: {0}", cities.Count);
        cities.Remove("UK"); // removes UK 
       //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

        Console.WriteLine("Total Elements after removing: {0}", cities.Count);

        if (cities.ContainsKey("France"))
        { // check key before removing it
            cities.Remove("France");
        }

        cities.Clear(); //removes all elements
        Console.WriteLine("Total Elements after Clear(): {0}", cities.Count);
    }
}
