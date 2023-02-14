using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class ArrayasArguments
    {
    public static void UpdateArray(int[] arr)

	{
        int[] number = { 1, 2, 3, 4, 5 };

        for (int i = 0; i < arr.Length; i++)
            arr[i] = arr[i] + 10;
    }
    }

