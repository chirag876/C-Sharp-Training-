using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Indexoutofrange
    {
    public void range1()
    {
        int[] arr = new int[5] { 10, 30, 25, 45, 65 };
        Console.WriteLine(arr[0]);
        Console.WriteLine(arr[1]);
        Console.WriteLine(arr[2]);
        Console.WriteLine(arr[3]);
        Console.WriteLine(arr[4]);
        Console.WriteLine(arr[5]);
    }

    public void range2() //prevention of index out of range
    {
        int[] arr = new int[5] { 10, 30, 25, 45, 65 };

        Console.WriteLine(arr[0]);
        Console.WriteLine(arr[1]);
        Console.WriteLine(arr[2]);
        Console.WriteLine(arr[3]);
        Console.WriteLine(arr[4]);

        if (arr.Length >= 6)
            Console.WriteLine(arr[5]);
    }

}

