using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AnonymousMethod;

/*an anonymous method is a method without a name. Anonymous methods in C# can be defined using the delegate keyword and can be 
assigned to a variable of delegate type.*/

public class AnonymousMethod
{
    public delegate void Print(int value);
}



//Anonymous methods can also be passed to a method that accepts the delegate as a parameter.
public delegate void Print2(int value2);

public class sampleProgram
{
    public static void PrintHelperMethod(Print2 printDel, int val)
    {
        val += 10;
        printDel(val);
    }
}