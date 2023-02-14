using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  public class Nestedifelsecondition
    {
    public void nestedifelsecon()
    {
        int i = 10, j = 20;

        if (i != j)
        {
            if (i < j)
            {
                Console.WriteLine("i is less than j");
            }
            else if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }
        }
        else
            Console.WriteLine("i is equal to j");
    }
}

