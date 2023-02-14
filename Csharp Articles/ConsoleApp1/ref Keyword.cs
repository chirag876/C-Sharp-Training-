using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

    public class refKeyword
    {
    public static void ProcessNumber(int num)

    {
        //Passing Value Type Variable
        num = 100;
    }

    public static void ProcessString(ref int num)
    {
        //Passing Value Type by Reference
        num = 100;
    }

    public static void ProcessNumber(ref int num)
    {
        num = num + 100;
    }
}
