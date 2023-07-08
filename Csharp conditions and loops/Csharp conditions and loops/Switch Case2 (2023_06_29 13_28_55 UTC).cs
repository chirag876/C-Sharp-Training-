using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class SwitchCase2
    {

    //switch statement can also include an expression whose result will be tested against each case at runtime.
    int x = 125;
    public void switchcase2con()
    {
        switch (x % 2)
        {
            case 0:
                Console.WriteLine($"{x} is an even value");
                break;
            case 1:
                Console.WriteLine($"{x} is an odd Value");
                break;
        }
    }
    }
