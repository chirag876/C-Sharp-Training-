using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 public class Arraylist
    {
    public static void PrintArrayList(ArrayList list)
    {
        foreach (int num in list)
        {
            Console.WriteLine(num);
        }
    }

    public static void PrintArrayList2()
    {
        //Adding Elements in ArrayList
        var arlist1 = new ArrayList();
        arlist1.Add(1);
        arlist1.Add("Bill");
        arlist1.Add(" ");
        arlist1.Add(true);
        arlist1.Add(4.5);
        arlist1.Add(null);

        // adding elements using object initializer syntax
        var arlist2 = new ArrayList()
                    {
                        2, "Steve", true, 4.5, null
                    };
        Console.WriteLine("ArrayList 1 Elements");
        for (int i = 0; i < arlist1.Count; i++)
            Console.WriteLine(arlist1[i]);

        Console.WriteLine("ArrayList 2 Elements");

        for (int i = 0; i < arlist2.Count; i++)
            Console.WriteLine(arlist2[i]);
    }

    public static void  PrintArrayList3()
    {
        //Adding Entire Array/ArrayList into ArrayList
        var arlist1 = new ArrayList();

        var arlist2 = new ArrayList()
                            {
                                1, "Bill", " ", true, 4.5, null
                            };

        int[] arr = { 100, 200, 300, 400 };

        Queue<string> myQ = new Queue<string>();
        myQ.Enqueue("Hello");
        myQ.Enqueue("World!");

        arlist1.AddRange(arlist2); //adding arraylist in arraylist 
        arlist1.AddRange(arr); //adding array in arraylist 
        arlist1.AddRange(myQ); //adding Queue in arraylist 

        Console.WriteLine("ArrayList Elements");

        for (int i = 0; i < arlist1.Count; i++)
            Console.WriteLine(arlist1[i]);
    }
}