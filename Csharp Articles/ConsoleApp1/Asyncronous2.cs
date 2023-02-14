using System;

class Asyncronous2
{
    public async void LongProcess2()
    {
        Console.WriteLine("LongProcess2 Started");
        await Task.Delay(4000); // hold execution for 4 seconds
        Console.WriteLine("LongProcess2 Completed");
    }

    public void ShortProcess2()
    {
        Console.WriteLine("ShortProcess2 Started");
        //do something here
        Console.WriteLine("ShortProcess2 Completed");
    }
}