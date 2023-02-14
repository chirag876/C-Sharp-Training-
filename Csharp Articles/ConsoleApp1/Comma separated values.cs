using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Commaseparatedvalues
    {
    public void commaseparatedfunc()
    {
        string[] animals = { "Cat", "Alligator", "Fox", "Donkey" };
        var str = String.Join(",", animals);

        int[] nums = { 1, 2, 3, 4 };
        var str1 = String.Join(",", nums);
    }
    }

