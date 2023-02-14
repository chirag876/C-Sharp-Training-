using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  public class Stack
    {
    public void stackfunc()
    {
        //Creating a simple stack
        Stack<int> numbers = new Stack<int>();
        numbers.Push(1);
        numbers.Push(2);
        numbers.Push(3);
        numbers.Push(4);
        Console.WriteLine("Output of stackfunc() method");
        foreach (var item in numbers)
            Console.Write(item + ",");//prints 4,3,2,1, 
            Console.WriteLine(" ");
    }

    public void stackfunc2()
    {
        //creating a stack using array
        int[] arr = new int[] { 3, 6, 9, 12 };
        Stack<int> myStack = new Stack<int>(arr);

        Console.WriteLine("Output of stackfunc2() method");
        foreach (var itm in myStack)
            Console.Write(itm + ",");
      
    }

    public static void stackpop()
    {
        //Access Stack using Pop()
        Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);

        //this loop will pop the elements one by one
        //while (myStack.Count > 0) 
        //{
        //    int top = myStack.Pop();
        //    Console.WriteLine("Popped element: " + top);
        //}


        Console.WriteLine("Total Number of elements in Stack: {0}", myStack.Count);

        while (myStack.Count > 0)
            Console.Write(myStack.Pop() + ",");

        Console.WriteLine();
        Console.WriteLine("Number of elements left in Stack: {0}", myStack.Count);

        //This while loop will access the specified element from the stack
        //int target = 2;
        //int temp;
        //while (myStack.Peek() != target)
        //{
        //    temp = myStack.Pop();
        //}
        //temp = myStack.Pop();
        //Console.WriteLine("Popped Element:" + temp + ",");
    }

    public static void stackpeek()
    {
        Stack<string> myStack = new Stack<string>();
        myStack.Push("Chirag Gupta");
        myStack.Push("Roshan Parmar");
        myStack.Push("Chhavi Bindal");
        myStack.Push("Sejal Singh");

        Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);

        if (myStack.Count > 0)
        {
            Console.WriteLine(myStack.Peek());
        }
                
        Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);        
    }

    public static void stackcontain()
    {
        Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);

        Console.WriteLine(myStack.Contains(2));
        Console.WriteLine(myStack.Contains(10));
    }
}

