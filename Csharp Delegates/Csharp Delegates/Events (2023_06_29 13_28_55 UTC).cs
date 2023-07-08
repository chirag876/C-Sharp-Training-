using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Event has no return type and is always void
//all events are based on delegates
class AddTwoNumbers //This is Publisher Class who will raise an event
{
    public delegate void dg_OddNumber(); //Declared Delegate   //1  
    public event dg_OddNumber ev_OddNumber; //Declared Events  //2

    public void Add() //function to add two numbers in this an event is raised 
    {
        int result;
        result = 5 + 4;
        Console.WriteLine(result.ToString()); //Output 9
        //Check if result is odd number then raise event
        if ((result % 2 != 0) && (ev_OddNumber != null))
        {
            ev_OddNumber(); //Raised Event if the odd number is found //3 
        }
    }
}

