using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    public class Forloop2
    {
    public void forloop2()
    {
        int i = 0;

        for (; ; )
        {
            if (i < 10)
            {
                Console.WriteLine("Value of i: {0}", i);
                i++;
            }
            else
                break;
        }
    }
    }

