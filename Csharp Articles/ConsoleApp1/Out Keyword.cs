using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class OutKeyword
    {
    //The out parameters can be used when you want to return more than one values from the method.
    public static void OutParamExample(out int x)
    {
        x = 100;
    }

    public static void GetMultipleRandomValue(out int x, out int y)
    {
        var random = new Random();
        x = random.Next();
        y = random.Next();
    }
}
