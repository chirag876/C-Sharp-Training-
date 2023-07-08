using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Throw3
    {
    public static void rethrowfunc2()
    {
        //If you re-throw an exception using exception parameter then it will not preserve the original exception and creates a new exception.
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
            throw ex;
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
