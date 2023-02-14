using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DuplicateArrays
{
    public void duplicatearrays()
    {
        //combine two arrays without duplicate values in C# using the Union() method
        string[] animals = { "Cat", "Alligator", "Fox", "Donkey", "Cat" };
        string[] birds = { "Sparrow", "Peacock", "Dove", "Crow" };
        var all = animals.Union(birds).ToArray();

        /*ToArray() Copies the elements of the ArrayList to a new Object array. ToArray(Type) Copies the elements of 
         the ArrayList to a new array of the specified element type.*/

        int[] num1 = { 1, 2, 3, 4, 3, 55, 23, 2 };
        int[] num2 = { 55, 23, 45, 50, 80 };
        var all1 = num1.Union(num2).ToArray();
    }
}