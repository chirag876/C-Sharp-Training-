using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class staticvar
    {
    public readonly int k = 10; //changed only in constructor
    public static int k2 = 0;// cannot be changed in constructor
    public staticvar()
    {
        k2 = 45;
        k = 34;
    }
    public void printfunc()
    {
        k2 = 50;
    }
    public static void printfunc1()
    {

        k2 = 70;

    }
    public void resultfunc()
    {
        Console.WriteLine(k2);
        Console.WriteLine(k);
    }
   
}

