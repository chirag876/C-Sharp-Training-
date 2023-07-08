using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class ExeceptionHandling
    {
    public static void exceptionfunc()
    {
        //Simple exception handling
        Console.WriteLine("Enter a number: "); // enter non-numeric value to see the exception

        var num = int.Parse(Console.ReadLine());

        Console.WriteLine("Squre of {0} is {1}", num, num * num);
    }

    
}

