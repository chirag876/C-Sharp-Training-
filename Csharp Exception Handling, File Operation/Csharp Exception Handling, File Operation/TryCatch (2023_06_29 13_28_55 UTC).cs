using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class TryCatch
    {
    public static void trycatchfunc()
    {
        //Exception handling using try-catch blocks
        try
        {
            Console.WriteLine("Enter a number: ");

            var num = int.Parse(Console.ReadLine());

            Console.WriteLine("Squre of {0} is {1}", num, num * num);
        }
        catch
        {
            Console.WriteLine("Error occurred.");
        }
        finally
        {
            Console.WriteLine("Re-try with a different number.");
        }
    }
}

