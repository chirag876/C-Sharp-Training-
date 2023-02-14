using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class AccessingArrayElements
    {

    public void accessingarrayelements1()
    {
        /*Array elements can be accessed using an index. An index 
         * is a number associated with each array element, starting
         * with index 0 and ending with array size - 1.*/
        int[] evenNums = new int[5];
        evenNums[0] = 2;
        evenNums[1] = 4;
        evenNums[2] = 6;
        evenNums[3] = 8;
        evenNums[4] = 10;
        //evenNums[5] = 12; //Throws IndexOutOfRangeException

        foreach (int i in evenNums)
        {
            Console.WriteLine(i);
        }
    }
    public void accessingarrayelements2()
    {
        //Accessing array elements using for loop
        int[] evenNums = { 2, 4, 6, 8, 10 };

        for (int i = 0; i < evenNums.Length; i++)
            Console.WriteLine(evenNums[i]); // read values of array elements


        for (int i = 0; i < evenNums.Length; i++)
            evenNums[i] = evenNums[i] + 10; //increase the value of each element by 10

        Console.WriteLine("After setting values");

        for (int i = 0; i < evenNums.Length; i++)
            Console.WriteLine(evenNums[i]);
    }


}


