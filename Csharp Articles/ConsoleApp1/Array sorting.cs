using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Arraysorting
    {
    public void sortfunc()
    {
        string[] animals = { "Cat", "Alligator", "Fox", "Donkey", "Bear", "Elephant", "Goat" };
        Array.Sort(animals);//Sorts array in ascending order
        Array.Sort(animals, 0, 3);//Sorts first 3 elements in an array

        //The following example sorts two different arrays where one array contains keys, and another contains values.
        int[] numbers = { 2, 1, 4, 3 };
        String[] numberNames = { "two", "one", "four", "three" };
        Array.Sort(numbers, numberNames);
        Array.ForEach<int>(numbers, n => Console.WriteLine(n));//[1,2,3,4]
        Array.ForEach<string>(numberNames, s => Console.WriteLine(s));//["one", "two", "three", "four"]



    }
    }
