using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Tuple
    {
    public static void tuplefunc()
    {
        //creating and accessing the tuple 
        var book = new Tuple<string, string, double>("C# in Depth", "Jon Skeet", 100.50);  
            Console.WriteLine("-----------------Book's Record---------------------");  
            Console.WriteLine("Title  "  + book.Item1);  
            Console.WriteLine("Author " + book.Item2);  
            Console.WriteLine("Price  "  + book.Item3);

        var person = new Tuple<int, string, string>(1, "Steve", "Jobs");
        Console.WriteLine(person.Item1); // returns 1
        Console.WriteLine(person.Item2); // returns "Steve"
        Console.WriteLine(person.Item3); // returns "Jobs"


        var numbers = new Tuple<string, int, int, string, int, string, int>("One", 2, 3, "Four", 5, "Six", 7);
        Console.WriteLine(numbers.Item1); // returns "One"
        Console.WriteLine(numbers.Item2); // returns 2
        Console.WriteLine(numbers.Item3); // returns 3
        Console.WriteLine(numbers.Item4); // returns "Four"
        Console.WriteLine(numbers.Item5); // returns 5
        Console.WriteLine(numbers.Item6); // returns "Six"
        Console.WriteLine(numbers.Item7); // returns 7      

    }

    public static void tuplefunc2()
    {
        /*In C#, an 8-tuple is a tuple that contains eight elements and it is also known as Octuple. You can create an 
         8-tuple using two different ways:*/

        /*If you will this constructor, then you can also create a tuple that contains eight or more than eight elements by 
         using the rest parameter to create n-nested tuples and each tuple contains from one to seven components.*/

        /*rest: It is any generic Tuple object which contains the values of the tuple’s remaining components.
            Exception: This will give ArgumentException if the rest is not a generic Tuple object.*/

        // Creating tuple with eight elements
        // Using Tuple<T1, T2, T3, T4, T5, T6,T7, TRest>(T1, T2, T3, T4, T5, T6,T7, TRest) constructor
        Tuple<int, int, int, int, int, int, int, Tuple<int>> My_Tuple = new Tuple<int, int, int, int, int, int, int, 
                                                               Tuple<int>>(22, 33, 44, 545, 55,88, 66, new Tuple<int>(77));

        Console.WriteLine("Element 1: " + My_Tuple.Item1);
        Console.WriteLine("Element 2: " + My_Tuple.Item2);
        Console.WriteLine("Element 3: " + My_Tuple.Item3);
        Console.WriteLine("Element 4: " + My_Tuple.Item4);
        Console.WriteLine("Element 5: " + My_Tuple.Item5);
        Console.WriteLine("Element 6: " + My_Tuple.Item6);
        Console.WriteLine("Element 7: " + My_Tuple.Item7);
        Console.WriteLine("Element 8: " + My_Tuple.Rest.Item1);
    }

    public static void tuplefunc3()
    {
        //Using the Create method
        /*You can also create 8-tuple with the help of Create method. When you use this method then there is no need to 
         specify the type of the elements stored in the tuple.*/

        //Return Type: This method returns 8-tuple whose value is item1, item2, item3, item4, item5, item6, item7, and item8.
        // Creating tuple with eight 
        // elements Using Create method

       /*Here we have a naming conflict: If you have another class or namespace in your code with the same name as the Tuple
         class, the compiler may be confused and not able to find the correct class. In this case, you can use the fully 
         qualified name System.Tuple to specify which class you want to use.*/

        var My_Tuple = System.Tuple.Create("C", "C++", "Ruby",
             "Java", "Perl", "PHP", "Python", "Scala");

        Console.WriteLine("Element 1: " + My_Tuple.Item1);
        Console.WriteLine("Element 2: " + My_Tuple.Item2);
        Console.WriteLine("Element 3: " + My_Tuple.Item3);
        Console.WriteLine("Element 4: " + My_Tuple.Item4);
        Console.WriteLine("Element 5: " + My_Tuple.Item5);
        Console.WriteLine("Element 6: " + My_Tuple.Item6);
        Console.WriteLine("Element 7: " + My_Tuple.Item7);
        Console.WriteLine("Element 8: " + My_Tuple.Rest);
    }
}
