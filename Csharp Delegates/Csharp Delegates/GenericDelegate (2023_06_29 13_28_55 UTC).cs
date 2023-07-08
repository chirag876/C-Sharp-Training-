using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*A generic delegate can be defined the same way as a delegate but using generic type parameters or return type. The generic type must be specified when
you set a target method.*/

public delegate T add<T>(T param1, T param2); // generic delegate
public class GenericDelegate
    {
    public static int Sum(int val1, int val2)
    {
        return val1 + val2;
    }

    public static string Concat(string str1, string str2)
    {
        return str1 + str2;
    }
}

