using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class SwitchCase3
    {
    //combined switch case
    public void switchcase3con()
    {
        int x = 5;

        switch (x)
        {
            case 1:
                Console.WriteLine("x = 1");
                break;
            case 2:
                Console.WriteLine("x = 2");
                break;
            case 4:
            case 5:
                Console.WriteLine("x = 4 or x = 5");
                break;
            default:
                Console.WriteLine("x > 5");
                break;
        }
    }
    }

