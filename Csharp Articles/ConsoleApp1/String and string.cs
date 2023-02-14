using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Stringandstring
{
    public void stringfunc()
    {
        /*String " a.k.a "String" (capital "S") is a . NET framework data type while "string" is a C# data type. 
         In short "String" is an alias (the same thing called with different names) of "string". So technically both the 
         below code statements will give the same output.*/
        string str1 = "Hello";
        String str2 = "World!";

        Console.WriteLine(str1.GetType().FullName); // System.String
        Console.WriteLine(str2.GetType().FullName); // System.String
    }
}

