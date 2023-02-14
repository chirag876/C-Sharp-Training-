using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class arraylinq
{
    public void linqfunc()
    {
        int[] nums = new int[5] { 10, 15, 16, 8, 6 };
        foreach (int i in nums)
        {
            Console.WriteLine(nums.Max());
            Console.WriteLine(nums.Min());
            Console.WriteLine(nums.Sum());
            Console.WriteLine(nums.Average());
        }
    }

    public void linqfunc2()
    {
        int[] nums = { 10, 15, 16, 8, 6 };

        Console.WriteLine("Original Array");

        foreach (var element in nums)
            Console.WriteLine(element);

        Array.Sort(nums);

        Console.WriteLine("Sorted Array");

        foreach (var element in nums)
            Console.WriteLine(element);

        Array.Reverse(nums);

        Console.WriteLine("Reversed Array");

        Array.ForEach<int>(nums, n => Console.WriteLine(n));

        Console.WriteLine(Array.BinarySearch(nums, 15));

    }
}

