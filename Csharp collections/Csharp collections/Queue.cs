using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Queue
{
    public static void queuefunc()
    {
        Console.WriteLine("Create and Add Elements in the Queue");
        Queue<int> callerIds = new Queue<int>();
        callerIds.Enqueue(1);
        callerIds.Enqueue(2);
        callerIds.Enqueue(3);
        callerIds.Enqueue(4);

        foreach (var id in callerIds)
            Console.WriteLine(id);
        Console.WriteLine(" ");
    }

    public static void queuefunc2()
    {
        /*The Dequeue() and the Peek() method is used to retrieve the first element in a queue collection. The Dequeue() 
         removes and returns the first element from a queue because the queue stores elements in FIFO order. Calling the
         Dequeue() method on an empty queue will throw the InvalidOperation exception. So, always check that the total 
         count of a queue is greater than zero before calling it.*/

        Console.WriteLine("Reading Queue");
        Queue<string> strQ = new Queue<string>();
        strQ.Enqueue("H");
        strQ.Enqueue("e");
        strQ.Enqueue("l");
        strQ.Enqueue("l");
        strQ.Enqueue("o");

        Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5
        Console.WriteLine(" ");

        while (strQ.Count > 0)
            Console.WriteLine(strQ.Dequeue()); //prints Hello
        Console.WriteLine(" ");

        Console.WriteLine("Total elements: {0}", strQ.Count); //prints 0
        Console.WriteLine(" ");
    }

    public static void queuefunc3()
    {
        /*The Peek() method always returns the first item from a queue collection without removing it from the queue. 
         Calling the Peek() method on an empty queue will throw a run-time exception InvalidOperationException.*/
        Console.WriteLine("Using Peek() method");
        Queue<string> strQ = new Queue<string>();
        strQ.Enqueue("H");
        strQ.Enqueue("e");
        strQ.Enqueue("l");
        strQ.Enqueue("l");
        strQ.Enqueue("o");

        Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5
        Console.WriteLine(" ");

        if (strQ.Count > 0)
        {
            Console.WriteLine(strQ.Peek()); //prints H
            Console.WriteLine(" ");
        }
    }

    public static void queuefunc4()
    {
        /*The Contains() method checks whether an item exists in a queue or not. It returns true if the specified item exists,
         otherwise returns false.*/

        //Contains() Signature: bool Contains(object obj);

        Console.WriteLine("Using Contains() method");
        Queue<int> callerIds = new Queue<int>();
        callerIds.Enqueue(1);
        callerIds.Enqueue(2);
        callerIds.Enqueue(3);
        callerIds.Enqueue(4);

        Console.WriteLine(callerIds.Contains(2)); //true
        Console.WriteLine(callerIds.Contains(10)); //false
    }
}

