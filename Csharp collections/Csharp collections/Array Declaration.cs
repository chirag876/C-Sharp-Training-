using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

    public class ArrayDeclaration
    {
    public void arrayfunc1()
    {
        int[] evenNums = new int[5] { 2, 4, 6, 8, 10 };
        string[] cities = new string[3] { "Mumbai", "London", "New York" };
        foreach (int i in evenNums)
        {
            Console.WriteLine(i);
        }

        foreach(string str in cities) { 
            Console.WriteLine(str + " ");
        }

        
    }

    public void arrayfunc2()
    {
        //Arrays type variables can be declared using var without square brackets.
        var evenNums1 = new int[] { 2, 4, 6, 8, 10 };
        var cities1 = new string[] { "Mumbai", "London", "New York" };

        foreach (int i in evenNums1)
        {
            Console.WriteLine(i);
        }
        foreach (string str in cities1)
        {
                Console.WriteLine(str + " ");
        }
    }

    public void arrayfunc3()
    {
        /*If you are adding array elements at the time of declaration, then size is optional. The compiler will infer
        its size based on the number of elements inside curly braces,*/
        int[] evenNums2 = { 2, 4, 6, 8, 10 };
        string[] cities2 = { "Mumbai", "London", "New York" };

        foreach(int i in evenNums2)
        {
            Console.WriteLine(i);
        }

        foreach(string str in cities2)
        {
            Console.WriteLine(str + " ");
        }
    }

    public void arrayfunc4()
    {
        /*It is not necessary to declare and initialize an array in a single statement.You can first declare an array 
            then initialize it later on using the new operator.*/

        //This is known as Late Initialization
        int[] evenNum;
        evenNum = new int[5];
        //OR
        evenNum = new int[] { 2, 4, 6, 8, 10 };

        foreach(int i in evenNum)
        {
            Console.WriteLine(i);
        }
    }
}


////The following example demonstrate invalid array declarations.
////must specify the size 
////int[] evenNums4 = new int[];

////number of elements must be equal to the specified size 
////int[] evenNum4s = new int[5] { 2, 4 };

////cannot use var with array initializer
////var evenNums4 = { 2, 4, 6, 8, 10 };