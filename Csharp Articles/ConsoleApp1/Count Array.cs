using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
    public class CountArray
    {
    public void countfunc()
    {
        //displays the total number of elements in the array
        string[] empty = new string[5];
        var totalElements = empty.Count(); //5

        string[] animals = { "Cat", "Alligator", "fox", "donkey", "Cat", "alligator" };
        totalElements = animals.Count(); //6

        int[] nums = { 1, 2, 3, 4, 3, 55, 23, 2, 5, 6, 2, 2 };
        totalElements = nums.Count(); //12



        //The following example shows how to count the specific elements based on some condition.
        var totalCats = animals.Count(s => s == "Cat");
        var animalsStartsWithA = animals.Count(s => s.StartsWith("a", StringComparison.CurrentCultureIgnoreCase));
        var totalEvenNums = nums.Count(n => n % 2 == 0);



        //Regex with the Count() method
        var animalsWithCapitalLetter = animals.Count(s =>
        {
            return Regex.IsMatch(s, "^[A-Z]");
        });
    }
    }