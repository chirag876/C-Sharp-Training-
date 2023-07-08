using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*The delegate can point to multiple methods. A delegate that points multiple methods is called a multicast delegate. The "+" or "+="
operator adds a function to the invocation list, and the "-" and "-=" operator removes it.*/

public delegate void MyDelegate2(string message);
public class MulticastDelegate
    {
    public static void MethodA(string message)
    {
        Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
    }

    public static void MethodB(string message)
    {
        Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
    }

    //If a delegate returns a value, then the last assigned target method's value will be return when a multicast delegate called.

}
