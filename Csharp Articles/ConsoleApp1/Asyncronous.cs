using System;

class Asyncronous { 

    public void LongProcess()
    {
        Console.WriteLine("LongProcess Started");

        //some code that takes long execution time 
        System.Threading.Thread.Sleep(4000); // hold execution for 4 seconds

        Console.WriteLine("LongProcess Completed");
    }

    public void ShortProcess()
    {
        Console.WriteLine("ShortProcess Started");
        //do something here
        Console.WriteLine("ShortProcess Completed");
    }
}