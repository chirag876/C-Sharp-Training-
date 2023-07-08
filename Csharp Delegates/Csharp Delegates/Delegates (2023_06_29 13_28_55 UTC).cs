using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void MyDelegate(string msg);//Declaring delegate
public class Delegates
{
    public static void Method1(string message)//Function signature must match with delegate signature
    {
        Console.WriteLine("Called ClassA.Method1() with parameter: " + message);
    }

    public static void Method2(string message)
    {
        Console.WriteLine("Called ClassA.Method2() with parameter: " + message);
    }

    //A method can have a parameter of the delegate type
    public static void InvokeDelegate(MyDelegate del) // MyDelegate type parameter
    {
        del("Hello World");
    }
}

