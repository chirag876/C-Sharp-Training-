using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public class ArrayListOperations
    {
    public static void arraylistaccessfunc()
    {
        //Accessing an arraylist element
        var arlist = new ArrayList() { 1, "Bill",300,4.5f};

        //Access individual item using indexer
        int firstElement = (int)arlist[0]; //returns 1
        Console.WriteLine(firstElement);
        string secondElement = (string)arlist[1]; //returns "Bill"
        Console.WriteLine(secondElement);//int secondElement = (int) arlist[1]; //Error: cannot cover string to int

        //using var keyword without explicit casting
        var first = arlist[0]; //returns 1
        var second = arlist[1]; //returns "Bill"
                                //var fifthElement = arlist[5]; //Error: Index out of range

        //update elements
        arlist[0] = "Steve";
        arlist[1] = 100;
        //arlist[5] = 500; //Error: Index out of range
    }

    public static void arraylistaccessfunc2()
    {
        //Iterate arraylist element
        ArrayList arlist = new ArrayList()
                        {
                            1,
                            "Bill",
                            300,
                            4.5F
                        };

        Console.WriteLine("foreach loop");
        foreach (var item in arlist)
            Console.Write(item + ", "); //output: 1, Bill, 300, 4.5, 

        Console.WriteLine("");
        Console.WriteLine("for loop");

        for (int i = 0; i < arlist.Count; i++)
            Console.Write(arlist[i] + ", "); //output: 1, Bill, 300, 4.5, 
    }

}

