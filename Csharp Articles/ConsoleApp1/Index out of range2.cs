using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Indexoutofrange2
    {
    public void arrayrange()
    {
        try
        {
            int[] arr = new int[5] { 1, 3, 5, 4, 6 };
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr[3]);
            Console.WriteLine(arr[4]);
            Console.WriteLine(arr[5]); // throws IndexOutOfRange exception
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: {0}", ex.Message);
        }
    }
}
