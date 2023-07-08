using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   public class Ternaryoperator
    {
    public void ternary()
    {
        int x = 20, y = 10, z = 15; 

        var result = x > y ? "x is greater than y" : "x is less than y";
        Console.WriteLine(result);


        //Nested Ternary operator
        string result1 = x > y ? "x is greater than y" :
                    x < y ? "x is less than y" :
                        x == y ? "x is equal to y" : "No result";
         Console.WriteLine(result1);

        //Right associativity of ternary operator
        int result2 = x * 3 > y ? x : y > z ? y : z;
        Console.WriteLine(result2);
    }
    }

