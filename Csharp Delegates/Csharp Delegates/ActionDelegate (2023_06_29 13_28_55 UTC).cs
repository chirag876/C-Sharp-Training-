using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Action is a delegate type defined in the System namespace. An Action type delegate is the same as Func delegate except that 
 the Action delegate doesn't return a value. In other words, an Action delegate can be used with a method that has a void 
 return type.*/
public class ActionDelegate
{
    public static void ConsolePrint(int i)
    {
        Console.WriteLine(i);
    }
}

