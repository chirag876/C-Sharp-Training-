using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//switch case using return statement
    public class SwitchCase4
    {
    public static void switchcase4con()
    {
        int x = 124;
        Console.Write(isOdd(x) ? "Even value" : "Odd value");
        static bool isOdd(int i)
        {
            int x = 124;
            switch (x % 2)
            {
                case 0:
                    return true;
                case 1:
                    return false;
                default:
                    return false;
            }

            //return false;
        }
    }
    }
