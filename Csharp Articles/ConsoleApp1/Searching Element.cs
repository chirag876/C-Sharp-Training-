using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class SearchingElement
    {
    public void searchfunc()
    {
        //following example finds the first element that matches with string "Bill".
        string[] names = { "Steve", "Bill", "Bill Gates", "Ravi", "Mohan", "Salman", "Boski" };
        var stringToFind = "Bill";
        var result = Array.Find(names, element => element == stringToFind); // returns "Bill"

        //The following example returns the first element that starts with "B".
        var result1 = Array.Find(names, element => element.StartsWith("B")); // returns Bill

        //The following example returns the first element, whose length is five or more.
        var result2 = Array.Find(names, element => element.Length >= 5); // returns Steve

        //the Array.Find() method only returns the first occurrence and not all matching
    }

    public void searchfunc2()
    {
        //The following example finds all elements that match with "Bill" or "bill".
        string[] names = { "Steve", "Bill", "bill", "James", "Mohan", "Salman", "Boski" };
        var stringToFind = "bill";
        string[] result = Array.FindAll(names, element => element.ToLower() == stringToFind); // return Bill, bill

        //The following example finds all elements that start with B.
        string[] result1 = Array.FindAll(names, element => element.StartsWith("B")); // return Bill, Boski

        //The following example finds all elements whose length is five or more.
        string[] result2 = Array.FindAll(names, element => element.Length >= 5); // returns Steve, James, Mohan, Salman, Boski 
    }

    public  void searchfunc3()
    {
        //The following example finds all elements that match with "Bill" or "bill".
        string[] names = { "Steve", "Bill", "bill", "James", "Mohan", "Salman", "Boski" };
        var stringToFind = "bill";
        var result = Array.FindLast(names, element => element.Contains(stringToFind)); // returns "Boski"

        //The following example finds all elements that start with B.
        var result1 = Array.FindLast(names, element => element.StartsWith("B")); // returns Boski

        //The following example finds all elements whose length is five or more.
        result = Array.FindLast(names, element => element.Length >= 5); // returns Boski 
    }
}



