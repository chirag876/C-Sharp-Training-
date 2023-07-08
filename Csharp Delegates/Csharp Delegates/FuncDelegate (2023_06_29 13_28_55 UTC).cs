using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*C# includes built-in generic delegate types Func and Action, so that you don't need to define custom delegates manually
in most cases.*/
public class FuncDelegate
    {
    static Func<int, int, int> operation;


    public static int Sum(int x, int y)
    {
        return x + y;
    }

    //You can assign an anonymous method to the Func delegate by using the delegate keyword.

    public static Func<int> getRandomNumber = delegate ()
    {
        Random rnd = new Random();
        return rnd.Next(1000, 9999);
    };
}

