using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Throw2
    {
    public static void rethrowfunc()
    {
        //Re-throwing an Exception
        //You can also re-throw an exception from the catch block to pass on to the caller and let the caller handle it the way they want.
        try
        {
            Method1();
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
        }
    }

    public static void Method1()
    {
        try
        {
            Method2();
        }
        catch (NullReferenceException ex)
        {
            throw;
        }
    }

    public static void Method2()
    {
        string str = null;
        try
        {
            Console.Write(str[0]);
        }
        catch (NullReferenceException ex)
        {
            throw;
        }
    }
}